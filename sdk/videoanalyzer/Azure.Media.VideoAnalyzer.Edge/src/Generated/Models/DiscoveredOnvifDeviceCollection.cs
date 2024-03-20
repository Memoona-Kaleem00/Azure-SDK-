// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> A list of ONVIF devices that were discovered in the same subnet as the IoT Edge device. </summary>
    public partial class DiscoveredOnvifDeviceCollection
    {
        /// <summary> Initializes a new instance of <see cref="DiscoveredOnvifDeviceCollection"/>. </summary>
        public DiscoveredOnvifDeviceCollection()
        {
            Value = new ChangeTrackingList<DiscoveredOnvifDevice>();
        }

        /// <summary> Initializes a new instance of <see cref="DiscoveredOnvifDeviceCollection"/>. </summary>
        /// <param name="value"> An array of ONVIF devices that have been discovered in the same subnet as the IoT Edge device. </param>
        internal DiscoveredOnvifDeviceCollection(IList<DiscoveredOnvifDevice> value)
        {
            Value = value;
        }

        /// <summary> An array of ONVIF devices that have been discovered in the same subnet as the IoT Edge device. </summary>
        public IList<DiscoveredOnvifDevice> Value { get; }
    }
}
