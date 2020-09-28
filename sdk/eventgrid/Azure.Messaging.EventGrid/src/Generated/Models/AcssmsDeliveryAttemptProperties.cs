// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema for details of a delivery attempt. </summary>
    public partial class AcssmsDeliveryAttemptProperties
    {
        /// <summary> Initializes a new instance of AcssmsDeliveryAttemptProperties. </summary>
        internal AcssmsDeliveryAttemptProperties()
        {
        }

        /// <summary> Initializes a new instance of AcssmsDeliveryAttemptProperties. </summary>
        /// <param name="timestamp"> TimeStamp when delivery was attempted. </param>
        /// <param name="segmentsSucceeded"> Number of segments that were successfully delivered. </param>
        /// <param name="segmentsFailed"> Number of segments whose delivery failed. </param>
        internal AcssmsDeliveryAttemptProperties(DateTimeOffset? timestamp, int? segmentsSucceeded, int? segmentsFailed)
        {
            Timestamp = timestamp;
            SegmentsSucceeded = segmentsSucceeded;
            SegmentsFailed = segmentsFailed;
        }

        /// <summary> TimeStamp when delivery was attempted. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Number of segments that were successfully delivered. </summary>
        public int? SegmentsSucceeded { get; }
        /// <summary> Number of segments whose delivery failed. </summary>
        public int? SegmentsFailed { get; }
    }
}
