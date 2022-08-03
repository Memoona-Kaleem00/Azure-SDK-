// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary>
    /// A reference to a related private endpoint connection.
    /// Serialized Name: PrivateEndpointConnectionReference
    /// </summary>
    public partial class PrivateEndpointConnectionReference : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionReference. </summary>
        internal PrivateEndpointConnectionReference()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionReference. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState">
        /// The provisioning status of the private endpoint connection.
        /// Serialized Name: PrivateEndpointConnectionReference.properties.provisioningState
        /// </param>
        /// <param name="privateEndpoint">
        /// The resource of private endpoint.
        /// Serialized Name: PrivateEndpointConnectionReference.properties.privateEndpoint
        /// </param>
        /// <param name="connectionState">
        /// A collection of information about the state of the connection between service consumer and provider.
        /// Serialized Name: PrivateEndpointConnectionReference.properties.privateLinkServiceConnectionState
        /// </param>
        internal PrivateEndpointConnectionReference(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProvisioningState? provisioningState, WritableSubResource privateEndpoint, AppConfigurationPrivateLinkServiceConnectionState connectionState) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
        }

        /// <summary>
        /// The provisioning status of the private endpoint connection.
        /// Serialized Name: PrivateEndpointConnectionReference.properties.provisioningState
        /// </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// The resource of private endpoint.
        /// Serialized Name: PrivateEndpointConnectionReference.properties.privateEndpoint
        /// </summary>
        internal WritableSubResource PrivateEndpoint { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// Serialized Name: PrivateEndpointConnectionReference.properties.privateLinkServiceConnectionState
        /// </summary>
        public AppConfigurationPrivateLinkServiceConnectionState ConnectionState { get; }
    }
}
