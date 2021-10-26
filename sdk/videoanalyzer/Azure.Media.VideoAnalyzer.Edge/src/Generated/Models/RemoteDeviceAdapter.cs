// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The Video Analyzer edge module can act as a transparent gateway for video, enabling IoT devices to send video to the cloud from behind a firewall. A remote device adapter should be created for each such IoT device. Communication between the cloud and IoT device would then flow via the Video Analyzer edge module. </summary>
    public partial class RemoteDeviceAdapter
    {
        /// <summary> Initializes a new instance of RemoteDeviceAdapter. </summary>
        /// <param name="name"> The unique identifier for the remote device adapter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RemoteDeviceAdapter(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of RemoteDeviceAdapter. </summary>
        /// <param name="name"> The unique identifier for the remote device adapter. </param>
        /// <param name="systemData"> Read-only system metadata associated with this object. </param>
        /// <param name="properties"> Properties of the remote device adapter. </param>
        internal RemoteDeviceAdapter(string name, SystemData systemData, RemoteDeviceAdapterProperties properties)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
        }

        /// <summary> The unique identifier for the remote device adapter. </summary>
        public string Name { get; set; }
        /// <summary> Read-only system metadata associated with this object. </summary>
        public SystemData SystemData { get; set; }
        /// <summary> Properties of the remote device adapter. </summary>
        public RemoteDeviceAdapterProperties Properties { get; set; }
    }
}
