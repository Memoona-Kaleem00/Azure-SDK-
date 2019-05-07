﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using Azure.Messaging.EventHubs.Core;

namespace Azure.Messaging.EventHubs
{
    /// <summary>
    ///   The position of events in an Event Hub partition, typically used in the creation of
    ///   an <see cref="EventSender" />.
    /// </summary>
    ///
    public class EventPosition
    {
        /// <summary>The token that represents the beginning event in the stream of a partition.</summary>
        protected const string StartOfStreamOffset = "-1";

        /// <summary>The token that represents the last event in the stream of a partition.</summary>
        protected const string EndOfStreamOffset = "@latest";

        /// <summary>
        ///   The offset of the eventidentified by this position.
        /// </summary>
        ///
        /// <value>Excpected to be <c>null</c> if the event position represents a sequence number or enqueue time.</value>
        ///
        internal string Offset { get; set; }

        /// <summary>
        ///   Indicates if the specified offset is inclusive of the event which it identifies.  This
        ///   information is only relevent if the event position was identified by an offset or sequence number.
        /// </summary>
        ///
        /// <value><c>true</c> if the offset is inclusive; otherwise, <c>false</c>.</value>
        ///
        internal bool IsInclusive { get; set; }

        /// <summary>
        ///   The enqueue time of the event identified by this position.
        /// </summary>
        ///
        /// <value>Excpected to be <c>null</c> if the event position represents an offset or sequence number.</value>
        ///
        internal DateTime? EnqueuedTimeUtc { get; set; }

        /// <summary>
        ///   The sequence number of the event identified by this poistion;
        /// </summary>
        ///
        /// <value>Excpected to be <c>null</c> if the event position represents an offset or enqueue time.</value>
        ///
        internal long? SequenceNumber { get; set; }

        /// <summary>
        ///   Corresponds to the location of the the first event present in the partition.  Use
        ///   this position to begin receiving from the first available event in the partition.
        /// </summary>
        ///
        public static EventPosition FirstAvailable => FromOffset(StartOfStreamOffset, true);

        /// <summary>
        ///   Corresponds to the end of the partition, where no more events are currently enqueued.  Use this
        ///   position to begin receiving from the next event to be enqueued in the partion after an <see cref="EventSender"/>
        ///   is created with this position.
        /// </summary>
        ///
        public static EventPosition EndOfStream => FromOffset(EndOfStreamOffset, false);

        /// <summary>
        ///   Initializes a new instance of the <see cref="EventPosition"/> class.
        /// </summary>
        ///
        /// <remarks>
        ///   Limit construction to only derrived classes, as the rules for legal value combinations
        ///   would be intimidating for consumers; the factory methods provide a more intuitive means of
        ///   creation.
        /// </remarks>
        ///
        protected EventPosition()
        {
        }

        /// <summary>
        ///   Corresponds to the event in the partition at the provided offset, inclusive of that event.
        /// </summary>
        ///
        /// <param name="offset">The offset of an event with respect to its relative position in the partition.</param>
        ///
        /// <returns>The position of the specified event.</returns>
        ///
        public static EventPosition FromOffset(int  offset) => FromOffset(offset.ToString(), true);

        /// <summary>
        ///   Corresponds to the event in the partition having a specified sequence number associated with it.
        /// </summary>
        ///
        /// <param name="sequenceNumber">The sequence number assigned to an event when it was enqueued in the partition.</param>
        /// <param name="isInclusive">If true, the event with the <paramref name="sequenceNumber"/> is included; otherwise the next event in sequence will be received.</param>
        ///
        /// <returns>The position of the specified event.</returns>
        ///
        public static EventPosition FromSequenceNumber(long sequenceNumber,
                                                       bool isInclusive = false)
        {
            return new EventPosition
            {
                SequenceNumber = sequenceNumber,
                IsInclusive = isInclusive
            };
        }

        /// <summary>
        ///   Corresponds to a specific date and time within the partition to begin seeking an event; the event enqueued after the
        ///   requested <paramref name="enqueuedTimeUtc" /> will become the current position.
        /// </summary>
        ///
        /// <param name="enqueuedTimeUtc">The date and time, in UTC, from which the next available event should be chosen.</param>
        ///
        /// <returns>The position of the specified event.</returns>
        ///
        public static EventPosition FromEnqueuedTime(DateTime enqueuedTimeUtc)
        {
            return new EventPosition
            {
                EnqueuedTimeUtc = enqueuedTimeUtc
            };
        }

        /// <summary>
        ///   Corresponds to the event in the partition at the provided offset.
        /// </summary>
        ///
        /// <param name="offset">The offset of an event with respect to its relative position in the partition.</param>
        /// <param name="isInclusive">If true, the event at the <paramref name="offset"/> is included; otherwise the next event in sequence will be received.</param>
        ///
        /// <returns>The position of the specified event.</returns>
        ///
        private static EventPosition FromOffset(string offset,
                                                bool   isInclusive = false)
        {
            Guard.ArgumentNotNullOrWhitespace(nameof(offset), offset);

            return new EventPosition
            {
                Offset = offset,
                IsInclusive = isInclusive
            };
        }

        /// <summary>
        ///   Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        ///
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        ///
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        ///   Returns a hash code for this instance.
        /// </summary>
        ///
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        ///   Converts the instance to string representation.
        /// </summary>
        ///
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }

    //TODO: Implement the AMQP-specific methods from track 1 to a new abstraction. (They were not brought forward)
}
