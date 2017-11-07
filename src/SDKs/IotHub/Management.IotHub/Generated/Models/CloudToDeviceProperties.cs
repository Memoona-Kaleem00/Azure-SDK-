// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The IoT hub cloud-to-device messaging properties.
    /// </summary>
    public partial class CloudToDeviceProperties
    {
        /// <summary>
        /// Initializes a new instance of the CloudToDeviceProperties class.
        /// </summary>
        public CloudToDeviceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudToDeviceProperties class.
        /// </summary>
        /// <param name="maxDeliveryCount">The max delivery count for
        /// cloud-to-device messages in the device queue. See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.</param>
        /// <param name="defaultTtlAsIso8601">The default time to live for
        /// cloud-to-device messages in the device queue. See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.</param>
        public CloudToDeviceProperties(int? maxDeliveryCount = default(int?), System.TimeSpan? defaultTtlAsIso8601 = default(System.TimeSpan?), FeedbackProperties feedback = default(FeedbackProperties))
        {
            MaxDeliveryCount = maxDeliveryCount;
            DefaultTtlAsIso8601 = defaultTtlAsIso8601;
            Feedback = feedback;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the max delivery count for cloud-to-device messages in
        /// the device queue. See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
        /// </summary>
        [JsonProperty(PropertyName = "maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// Gets or sets the default time to live for cloud-to-device messages
        /// in the device queue. See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
        /// </summary>
        [JsonProperty(PropertyName = "defaultTtlAsIso8601")]
        public System.TimeSpan? DefaultTtlAsIso8601 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedback")]
        public FeedbackProperties Feedback { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxDeliveryCount > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxDeliveryCount", 100);
            }
            if (MaxDeliveryCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDeliveryCount", 1);
            }
            if (Feedback != null)
            {
                Feedback.Validate();
            }
        }
    }
}
