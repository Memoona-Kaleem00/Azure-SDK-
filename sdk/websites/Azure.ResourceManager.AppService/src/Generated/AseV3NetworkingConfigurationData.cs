// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the AseV3NetworkingConfiguration data model. </summary>
    public partial class AseV3NetworkingConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationData. </summary>
        public AseV3NetworkingConfigurationData()
        {
            WindowsOutboundIPAddresses = new ChangeTrackingList<string>();
            LinuxOutboundIPAddresses = new ChangeTrackingList<string>();
            ExternalInboundIPAddresses = new ChangeTrackingList<string>();
            InternalInboundIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="windowsOutboundIPAddresses"> Serialized Name: AseV3NetworkingConfiguration.properties.windowsOutboundIpAddresses. </param>
        /// <param name="linuxOutboundIPAddresses"> Serialized Name: AseV3NetworkingConfiguration.properties.linuxOutboundIpAddresses. </param>
        /// <param name="externalInboundIPAddresses"> Serialized Name: AseV3NetworkingConfiguration.properties.externalInboundIpAddresses. </param>
        /// <param name="internalInboundIPAddresses"> Serialized Name: AseV3NetworkingConfiguration.properties.internalInboundIpAddresses. </param>
        /// <param name="allowNewPrivateEndpointConnections">
        /// Property to enable and disable new private endpoint connection creation on ASE
        /// Serialized Name: AseV3NetworkingConfiguration.properties.allowNewPrivateEndpointConnections
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal AseV3NetworkingConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<string> windowsOutboundIPAddresses, IReadOnlyList<string> linuxOutboundIPAddresses, IReadOnlyList<string> externalInboundIPAddresses, IReadOnlyList<string> internalInboundIPAddresses, bool? allowNewPrivateEndpointConnections, string kind) : base(id, name, resourceType, systemData)
        {
            WindowsOutboundIPAddresses = windowsOutboundIPAddresses;
            LinuxOutboundIPAddresses = linuxOutboundIPAddresses;
            ExternalInboundIPAddresses = externalInboundIPAddresses;
            InternalInboundIPAddresses = internalInboundIPAddresses;
            AllowNewPrivateEndpointConnections = allowNewPrivateEndpointConnections;
            Kind = kind;
        }

        /// <summary> Serialized Name: AseV3NetworkingConfiguration.properties.windowsOutboundIpAddresses. </summary>
        public IReadOnlyList<string> WindowsOutboundIPAddresses { get; }
        /// <summary> Serialized Name: AseV3NetworkingConfiguration.properties.linuxOutboundIpAddresses. </summary>
        public IReadOnlyList<string> LinuxOutboundIPAddresses { get; }
        /// <summary> Serialized Name: AseV3NetworkingConfiguration.properties.externalInboundIpAddresses. </summary>
        public IReadOnlyList<string> ExternalInboundIPAddresses { get; }
        /// <summary> Serialized Name: AseV3NetworkingConfiguration.properties.internalInboundIpAddresses. </summary>
        public IReadOnlyList<string> InternalInboundIPAddresses { get; }
        /// <summary>
        /// Property to enable and disable new private endpoint connection creation on ASE
        /// Serialized Name: AseV3NetworkingConfiguration.properties.allowNewPrivateEndpointConnections
        /// </summary>
        public bool? AllowNewPrivateEndpointConnections { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
