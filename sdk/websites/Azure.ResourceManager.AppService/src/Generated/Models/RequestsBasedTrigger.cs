// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Trigger based on total requests.
    /// Serialized Name: RequestsBasedTrigger
    /// </summary>
    public partial class RequestsBasedTrigger
    {
        /// <summary> Initializes a new instance of RequestsBasedTrigger. </summary>
        public RequestsBasedTrigger()
        {
        }

        /// <summary> Initializes a new instance of RequestsBasedTrigger. </summary>
        /// <param name="count">
        /// Request Count.
        /// Serialized Name: RequestsBasedTrigger.count
        /// </param>
        /// <param name="timeInterval">
        /// Time interval.
        /// Serialized Name: RequestsBasedTrigger.timeInterval
        /// </param>
        internal RequestsBasedTrigger(int? count, string timeInterval)
        {
            Count = count;
            TimeInterval = timeInterval;
        }

        /// <summary>
        /// Request Count.
        /// Serialized Name: RequestsBasedTrigger.count
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Time interval.
        /// Serialized Name: RequestsBasedTrigger.timeInterval
        /// </summary>
        public string TimeInterval { get; set; }
    }
}
