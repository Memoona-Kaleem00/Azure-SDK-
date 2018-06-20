// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the retry policy for an event subscription
    /// </summary>
    public partial class RetryPolicy
    {
        /// <summary>
        /// Initializes a new instance of the RetryPolicy class.
        /// </summary>
        public RetryPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetryPolicy class.
        /// </summary>
        /// <param name="maxDeliveryAttempts">Maximum number of delivery retry
        /// attempts for events.</param>
        /// <param name="eventTimeToLiveInMinutes">Time To Live (in minutes)
        /// for events.</param>
        public RetryPolicy(int? maxDeliveryAttempts = default(int?), int? eventTimeToLiveInMinutes = default(int?))
        {
            MaxDeliveryAttempts = maxDeliveryAttempts;
            EventTimeToLiveInMinutes = eventTimeToLiveInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets maximum number of delivery retry attempts for events.
        /// </summary>
        [JsonProperty(PropertyName = "maxDeliveryAttempts")]
        public int? MaxDeliveryAttempts { get; set; }

        /// <summary>
        /// Gets or sets time To Live (in minutes) for events.
        /// </summary>
        [JsonProperty(PropertyName = "eventTimeToLiveInMinutes")]
        public int? EventTimeToLiveInMinutes { get; set; }

    }
}
