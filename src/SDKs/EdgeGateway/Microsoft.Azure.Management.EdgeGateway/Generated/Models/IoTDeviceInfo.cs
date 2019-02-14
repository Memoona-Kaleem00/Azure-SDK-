// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metadata of IoT device/IoT edge device to be configured.
    /// </summary>
    public partial class IoTDeviceInfo
    {
        /// <summary>
        /// Initializes a new instance of the IoTDeviceInfo class.
        /// </summary>
        public IoTDeviceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTDeviceInfo class.
        /// </summary>
        /// <param name="deviceId">Id of the IoT device/edge device.</param>
        /// <param name="ioTHostHub">Host name for IoT hub which is associated
        /// to the device.</param>
        /// <param name="authentication">IoT device authentication
        /// info.</param>
        public IoTDeviceInfo(string deviceId, string ioTHostHub, Authentication authentication = default(Authentication))
        {
            DeviceId = deviceId;
            IoTHostHub = ioTHostHub;
            Authentication = authentication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the IoT device/edge device.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets host name for IoT hub which is associated to the
        /// device.
        /// </summary>
        [JsonProperty(PropertyName = "ioTHostHub")]
        public string IoTHostHub { get; set; }

        /// <summary>
        /// Gets or sets ioT device authentication info.
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public Authentication Authentication { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeviceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceId");
            }
            if (IoTHostHub == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IoTHostHub");
            }
            if (Authentication != null)
            {
                Authentication.Validate();
            }
        }
    }
}
