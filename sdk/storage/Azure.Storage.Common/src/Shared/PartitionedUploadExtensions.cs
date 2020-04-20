﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Azure.Storage.Shared
{
    internal static class PartitionedUploadExtensions
    {
        /// <summary>
        /// Some streams will throw if you try to access their length so we wrap
        /// the check in a TryGet helper.
        /// </summary>
        internal static bool TryGetLength(Stream content, out long length)
        {
            length = 0;
            if (content == null)
            {
                return true;
            }
            try
            {
                if (content.CanSeek)
                {
                    length = content.Length;
                    return true;
                }
            }
            catch (NotSupportedException)
            {
            }
            return false;
        }

        //internal static async IAsyncEnumerable<PartitionViewStream> GetStreamedBlocksAsync(Stream stream,
        //    long blockSize,
        //    bool async,
        //    ArrayPool<byte> arrayPool,
        //    [EnumeratorCancellation]CancellationToken cancellationToken)
        //{

        //}

        /// <summary>
        /// Partition a stream into a series of blocks buffered as needed by an array pool.
        /// </summary>
        internal static async IAsyncEnumerable<PooledMemoryStream> GetBufferedBlocksAsync(
            Stream stream,
            long blockSize,
            bool async,
            ArrayPool<byte> arrayPool,
            [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            long read = 0;
            long absolutePosition = 0;

            // The minimum amount of data we'll accept from a stream before
            // splitting another block.
            long acceptableBlockSize = blockSize / 2;

            // if we know the data length, assert boundaries before spending resources uploading beyond service capabilities
            if (stream.CanSeek)
            {
                long minRequiredBlockSize = (long)Math.Ceiling((double)stream.Length / Constants.Blob.Block.MaxBlocks);
                if (blockSize < minRequiredBlockSize)
                {
                    throw new ArgumentException($"Max block size {blockSize} not large enough for Storage to hold {stream.Length}.");
                }
                // bring min up to our min required by the service
                acceptableBlockSize = Math.Max(acceptableBlockSize, minRequiredBlockSize);
            }

            // Read the next block
            bool streamFinished = false;
            do
            {
                try
                {
                    //int offset = 0;
                    //do
                    //{
                    //    // You can ask a stream to read however many bytes, but
                    //    // it's only going to read as much as it wants.  We're
                    //    // trying to saturate the network so we can live with
                    //    // sending more, smaller blocks rather than fewer
                    //    // perfectly sized blocks that are bound by local I/O.
                    //    if (async)
                    //    {
                    //        read = await stream.ReadAsync(
                    //            bytes,
                    //            offset,
                    //            blockSize - offset,
                    //            cancellationToken)
                    //            .ConfigureAwait(false);
                    //    }
                    //    else
                    //    {
                    //        cancellationToken.ThrowIfCancellationRequested();
                    //        read = stream.Read(bytes, offset, blockSize - offset);
                    //    }
                    //    offset += read;
                    //    absolutePosition += read;

                    //    // Keep reading until we've got enough to fill a block or
                    //    // until we can't read any more
                    //} while (offset < minimumBlockSize && read != 0);

                    PooledMemoryStream partition;
                    (partition, streamFinished) = await PooledMemoryStream.BufferStreamPartitionInternal(
                        stream,
                        acceptableBlockSize,
                        blockSize,
                        absolutePosition,
                        arrayPool,
                        100 * Constants.MB,
                        async,
                        cancellationToken).ConfigureAwait(false);
                    read = partition.Length;
                    absolutePosition += read;

                    // If we read anything, turn it into a StreamPartition and
                    // return it for staging
                    if (partition.Length != 0)
                    {
                        // The StreamParitition is disposable and it'll be the
                        // user's responsibility to return the bytes used to our
                        // ArrayPool
                        yield return partition;// new ChunkedStream(absolutePosition, bytes, offset, arrayPool);

                        // Clear the bytes reference so we don't return any
                        // memory that we've handed off to users in our finally
                        // block below
                        //bytes = null;
                    }
                }
                finally
                {
                    //// If we have memory that wasn't returned as a block, give
                    //// it back to the ArrayPool
                    //if (bytes != null)
                    //{
                    //    arrayPool.Return(bytes);
                    //}
                }

                // Continue reading blocks until we've exhausted the stream
            } while (!streamFinished);
        }
    }
}
