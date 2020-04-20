﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Storage.Shared
{
    /// <summary>
    /// Functions like a readable <see cref="MemoryStream"/> but uses an ArrayPool to supply the backing memory.
    /// This stream support buffering long sizes.
    /// </summary>
    internal class PooledMemoryStream : Stream
    {
        private class BufferPartition
        {
            /// <summary>
            /// The buffer for this partition.
            /// </summary>
            public byte[] Buffer { get; set; }

            /// <summary>
            /// Offset at which known data stops and garbage bytes begin.
            /// </summary>
            public int GarbageOffset { get; set; }
        }

        /// <summary>
        /// Boundary at which point we start requesting multiple arrays for our buffer.
        /// </summary>
        public int MaxArraySize { get; }

        /// <summary>
        /// The backing array pool.
        /// </summary>
        public ArrayPool<byte> ArrayPool { get; }

        /// <summary>
        /// Absolute position of this stream in the larger stream it was chunked from.
        /// </summary>
        public long AbsolutePosition { get; }

        /// <summary>
        /// List of arrays making up the overall buffer. Since ArrayPool may give us a larger array than needed,
        /// each array is paired with a count of the space actually used in the array. This <b>should</b> only
        /// be important for the final buffer.
        /// </summary>
        private List<BufferPartition> BufferSet { get; } = new List<BufferPartition>();

        private PooledMemoryStream(ArrayPool<byte> arrayPool, long absolutePosition, int maxArraySize)
        {
            AbsolutePosition = absolutePosition;
            ArrayPool = arrayPool;
            MaxArraySize = maxArraySize;
        }

        /// <summary>
        /// Buffers a portion of the given stream, returning the buffered stream partition.
        /// </summary>
        /// <param name="stream">Stream to buffer from.</param>
        /// <param name="minCount">Minimum number of bytes to buffer. This method will not return until at least this many bytes have been read from <paramref name="stream"/> or the stream completes.</param>
        /// <param name="maxCount">Maximum number of bytes to buffer.</param>
        /// <param name="absolutePosition">Current position of the stream, since <see cref="Stream.Position"/> throws if not seekable.</param>
        /// <param name="arrayPool">Pool to rent buffer space from.</param>
        /// <param name="maxArrayPoolRentalSize">Max size we can request from the array pool.</param>
        /// <param name="async">Whether to perform this operation asynchronously</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The buffered stream partition with memory backed by an array pool.</returns>
        internal static async Task<(PooledMemoryStream Partition, bool StreamFinished)> BufferStreamPartitionInternal(Stream stream, long minCount, long maxCount, long absolutePosition, ArrayPool<byte> arrayPool, int maxArrayPoolRentalSize, bool async, CancellationToken cancellationToken)
        {
            int totalRead = 0;
            bool streamFinished = false;
            var streamPartition = new PooledMemoryStream(arrayPool, absolutePosition, maxArrayPoolRentalSize);

            int maxCountIndividualBuffer;
            int minCountIndividualBuffer;
            int readIndividualBuffer;
            do
            {
                byte[] buffer;
                int offset;
                BufferPartition latestBuffer;
                if (((latestBuffer = streamPartition.BufferSet.LastOrDefault())?.GarbageOffset ?? 0) < (latestBuffer?.Buffer.Length ?? 0))
                {
                    buffer = latestBuffer.Buffer;
                    offset = latestBuffer.GarbageOffset;
                }
                else
                {
                    buffer = arrayPool.Rent((int)Math.Min(maxCount - totalRead, streamPartition.MaxArraySize));
                    offset = 0;
                }

                // limit max and min count for this buffer by buffer length
                maxCountIndividualBuffer = (int)Math.Min(maxCount - totalRead, buffer.Length - offset);
                minCountIndividualBuffer = (int)Math.Min(minCount - totalRead, maxCountIndividualBuffer);

                (readIndividualBuffer, streamFinished) = await ReadLoopInternal(
                    stream,
                    buffer,
                    offset: offset,
                    minCountIndividualBuffer,
                    maxCountIndividualBuffer,
                    async,
                    cancellationToken).ConfigureAwait(false);
                if (readIndividualBuffer == 0) // stream fininished and didn't put anything in the array
                {
                    arrayPool.Return(buffer);
                    break;
                }

                if (latestBuffer == default)
                {
                    streamPartition.BufferSet.Add(new BufferPartition
                    {
                        Buffer = buffer,
                        GarbageOffset = readIndividualBuffer
                    });
                }
                else
                {
                    latestBuffer.GarbageOffset += readIndividualBuffer;
                }

                totalRead += readIndividualBuffer;

            /* If we read the max size of this buffer then quitting on min count is pointless. The point of quitting
             * on min count is when the source stream doesn't have available bytes and we've reached an amount worth
             * sending instead of blocking on. If we filled the available array, we don't actually know whether more
             * data is available yet, as we limited our read for reasons outside the stream state. We should therefore
             * try at least one more read regardless of whether we hit min count.
             */
            } while (totalRead < minCount && readIndividualBuffer == maxCountIndividualBuffer);

            return (streamPartition, streamFinished);
        }

        /// <summary>
        /// Loops Read() calls into buffer until minCount is reached or stream returns 0.
        /// </summary>
        /// <returns>Bytes read and whether we reached end of stream.</returns>
        private static async Task<(int Read, bool StreamFinished)> ReadLoopInternal(Stream stream, byte[] buffer, int offset, int minCount, int maxCount, bool async, CancellationToken cancellationToken)
        {
            int totalRead = 0;
            bool endOfStream = false;
            do
            {
                int read = async
                    ? await stream.ReadAsync(buffer, offset + totalRead, maxCount - totalRead, cancellationToken).ConfigureAwait(false)
                    : stream.Read(buffer, offset + totalRead, maxCount - totalRead);
                if (read == 0)
                {
                    endOfStream = true;
                    break;
                }
                totalRead += read;
            } while (totalRead < minCount);

            return (totalRead, endOfStream);
        }

        public override bool CanRead => true;

        public override bool CanSeek => true;

        public override bool CanWrite => false;

        public override long Length => BufferSet.Sum(tuple => tuple.GarbageOffset);

        public override long Position { get; set; }

        public override void Flush()
        {
            // no-op, just like MemoryStream
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (Position >= Length)
            {
                return 0;
            }

            int read = 0;
            while (read < count && Position < Length)
            {
                (byte[] currentBuffer, int bufferCount, long offsetOfBuffer) = GetBufferFromPosition();

                int toCopy = (int)Math.Min(Math.Min(Length - Position, bufferCount), count);
                Array.Copy(currentBuffer, Position - offsetOfBuffer, buffer, read, toCopy);
                read += toCopy;
                Position += toCopy;
            }

            return read;
        }

        private (byte[] currentBuffer, int bufferCount, long offsetOfBuffer) GetBufferFromPosition()
        {
            AssertPositionInBounds();

            long countingPosition = 0;
            foreach (var tuple in BufferSet)
            {
                if (countingPosition + tuple.GarbageOffset <= Position)
                {
                    countingPosition += tuple.GarbageOffset;
                }
                else
                {
                    return (tuple.Buffer, tuple.GarbageOffset, countingPosition);
                }
            }

            /* this.Length is defined as the sum of all counts.
             * We already throw if this.Position >= this.Length.
             * We can only get here if this.Position is >= the sum of all counts.
             * We will never get here. */
            throw new InvalidOperationException("Incorrect stream partition length.");
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    Position = offset;
                    break;
                case SeekOrigin.Current:
                    Position += offset;
                    break;
                case SeekOrigin.End:
                    Position = Length + offset;
                    break;
            }

            return Position;
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        protected override void Dispose(bool disposing)
        {
            foreach (var buffer in BufferSet)
            {
                ArrayPool.Return(buffer.Buffer);
            }
            BufferSet.Clear();
        }

        private void AssertPositionInBounds()
        {
            if (Position >= Length || Position < 0)
            {
                throw new InvalidOperationException("Cannot read outside the bounds of this stream.");
            }
        }
    }
}
