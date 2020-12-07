// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple8000Series.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The additional device details regarding the end point count and volume
    /// container count.
    /// </summary>
    public partial class DeviceDetails
    {
        /// <summary>
        /// Initializes a new instance of the DeviceDetails class.
        /// </summary>
        public DeviceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceDetails class.
        /// </summary>
        /// <param name="endpointCount">The total number of endpoints that are
        /// currently on the device ( i.e. number of volumes).</param>
        /// <param name="volumeContainerCount">The total number of volume
        /// containers on the device.</param>
        public DeviceDetails(int? endpointCount = default(int?), int? volumeContainerCount = default(int?))
        {
            EndpointCount = endpointCount;
            VolumeContainerCount = volumeContainerCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total number of endpoints that are currently on
        /// the device ( i.e. number of volumes).
        /// </summary>
        [JsonProperty(PropertyName = "endpointCount")]
        public int? EndpointCount { get; set; }

        /// <summary>
        /// Gets or sets the total number of volume containers on the device.
        /// </summary>
        [JsonProperty(PropertyName = "volumeContainerCount")]
        public int? VolumeContainerCount { get; set; }

    }
}
