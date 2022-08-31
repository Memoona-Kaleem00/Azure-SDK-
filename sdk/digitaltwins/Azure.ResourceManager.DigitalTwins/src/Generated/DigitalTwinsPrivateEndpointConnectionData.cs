// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary> A class representing the DigitalTwinsPrivateEndpointConnection data model. </summary>
    public partial class DigitalTwinsPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of DigitalTwinsPrivateEndpointConnectionData. </summary>
        /// <param name="properties"> The connection properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DigitalTwinsPrivateEndpointConnectionData(ConnectionProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DigitalTwinsPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The connection properties. </param>
        internal DigitalTwinsPrivateEndpointConnectionData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, ConnectionProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> The connection properties. </summary>
        public ConnectionProperties Properties { get; set; }
    }
}
