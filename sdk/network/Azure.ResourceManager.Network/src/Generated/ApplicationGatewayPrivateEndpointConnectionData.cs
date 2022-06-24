// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ApplicationGatewayPrivateEndpointConnection data model. </summary>
    public partial class ApplicationGatewayPrivateEndpointConnectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayPrivateEndpointConnectionData. </summary>
        public ApplicationGatewayPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayPrivateEndpointConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the application gateway private endpoint connection resource. </param>
        /// <param name="linkIdentifier"> The consumer link id. </param>
        internal ApplicationGatewayPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, PrivateEndpointData privateEndpoint, NetworkPrivateLinkServiceConnectionState connectionState, NetworkProvisioningState? provisioningState, string linkIdentifier) : base(id, name, resourceType)
        {
            ETag = eTag;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            LinkIdentifier = linkIdentifier;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The resource of private end point. </summary>
        public PrivateEndpointData PrivateEndpoint { get; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public NetworkPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the application gateway private endpoint connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The consumer link id. </summary>
        public string LinkIdentifier { get; }
    }
}
