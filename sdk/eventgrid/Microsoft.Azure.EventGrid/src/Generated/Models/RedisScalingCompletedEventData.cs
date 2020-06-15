// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for an
    /// Microsoft.Cache.ScalingCompleted event.
    /// </summary>
    public partial class RedisScalingCompletedEventData
    {
        /// <summary>
        /// Initializes a new instance of the RedisScalingCompletedEventData
        /// class.
        /// </summary>
        public RedisScalingCompletedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisScalingCompletedEventData
        /// class.
        /// </summary>
        /// <param name="timestamp">The time at which the event
        /// occurred.</param>
        /// <param name="name">The name of this event.</param>
        /// <param name="status">The status of this event. Failed or  succeeded
        /// </param>
        public RedisScalingCompletedEventData(System.DateTime? timestamp = default(System.DateTime?), string name = default(string), string status = default(string))
        {
            Timestamp = timestamp;
            Name = name;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time at which the event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the name of this event.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the status of this event. Failed or  succeeded
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
