// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Private endpoint connection properties. </summary>
    public partial class PrivateEndpointConnectionProperties
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionProperties. </summary>
        public PrivateEndpointConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProperties. </summary>
        /// <param name="provisioningState"> Indicates whether there is an ongoing operation on the private endpoint. </param>
        /// <param name="privateEndpoint"> ARM id for the private endpoint resource corresponding to the connection. </param>
        /// <param name="connectionState"> State of the private endpoint connection. </param>
        internal PrivateEndpointConnectionProperties(PrivateEndpointConnectionPropertiesProvisioningState? provisioningState, SubResource privateEndpoint, MigratePrivateLinkServiceConnectionState connectionState)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
        }

        /// <summary> Indicates whether there is an ongoing operation on the private endpoint. </summary>
        public PrivateEndpointConnectionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> ARM id for the private endpoint resource corresponding to the connection. </summary>
        internal SubResource PrivateEndpoint { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> State of the private endpoint connection. </summary>
        public MigratePrivateLinkServiceConnectionState ConnectionState { get; set; }
    }
}
