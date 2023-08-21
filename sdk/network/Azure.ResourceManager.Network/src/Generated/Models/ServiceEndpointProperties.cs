// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The service endpoint properties. </summary>
    public partial class ServiceEndpointProperties
    {
        /// <summary> Initializes a new instance of ServiceEndpointProperties. </summary>
        public ServiceEndpointProperties()
        {
            Locations = new Core.ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of ServiceEndpointProperties. </summary>
        /// <param name="service"> The type of the endpoint service. </param>
        /// <param name="locations"> A list of locations. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint resource. </param>
        internal ServiceEndpointProperties(string service, IList<AzureLocation> locations, NetworkProvisioningState? provisioningState)
        {
            Service = service;
            Locations = locations;
            ProvisioningState = provisioningState;
        }

        /// <summary> The type of the endpoint service. </summary>
        public string Service { get; set; }
        /// <summary> A list of locations. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> The provisioning state of the service endpoint resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
