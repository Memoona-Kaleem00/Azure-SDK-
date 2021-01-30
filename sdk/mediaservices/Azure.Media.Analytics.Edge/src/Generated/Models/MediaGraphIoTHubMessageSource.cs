// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Enables a media graph to receive messages via routes declared in the IoT Edge deployment manifest. </summary>
    public partial class MediaGraphIoTHubMessageSource : MediaGraphSource
    {
        /// <summary> Initializes a new instance of MediaGraphIoTHubMessageSource. </summary>
        /// <param name="name"> The name to be used for this source node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MediaGraphIoTHubMessageSource(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Type = "#Microsoft.Media.MediaGraphIoTHubMessageSource";
        }

        /// <summary> Initializes a new instance of MediaGraphIoTHubMessageSource. </summary>
        /// <param name="type"> The type of the source node. The discriminator for derived types. </param>
        /// <param name="name"> The name to be used for this source node. </param>
        /// <param name="hubInputName"> Name of the input path where messages can be routed to (via routes declared in the IoT Edge deployment manifest). </param>
        internal MediaGraphIoTHubMessageSource(string type, string name, string hubInputName) : base(type, name)
        {
            HubInputName = hubInputName;
            Type = type ?? "#Microsoft.Media.MediaGraphIoTHubMessageSource";
        }

        /// <summary> Name of the input path where messages can be routed to (via routes declared in the IoT Edge deployment manifest). </summary>
        public string HubInputName { get; set; }
    }
}
