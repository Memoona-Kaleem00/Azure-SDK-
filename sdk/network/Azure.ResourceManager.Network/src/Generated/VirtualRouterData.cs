// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualRouter data model.
    /// VirtualRouter Resource.
    /// </summary>
    public partial class VirtualRouterData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualRouterData. </summary>
        public VirtualRouterData()
        {
            VirtualRouterIPs = new Core.ChangeTrackingList<string>();
            Peerings = new Core.ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of VirtualRouterData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualRouterAsn"> VirtualRouter ASN. </param>
        /// <param name="virtualRouterIPs"> VirtualRouter IPs. </param>
        /// <param name="hostedSubnet"> The Subnet on which VirtualRouter is hosted. </param>
        /// <param name="hostedGateway"> The Gateway on which VirtualRouter is hosted. </param>
        /// <param name="peerings"> List of references to VirtualRouterPeerings. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal VirtualRouterData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, long? virtualRouterAsn, IList<string> virtualRouterIPs, WritableSubResource hostedSubnet, WritableSubResource hostedGateway, IReadOnlyList<WritableSubResource> peerings, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            VirtualRouterAsn = virtualRouterAsn;
            VirtualRouterIPs = virtualRouterIPs;
            HostedSubnet = hostedSubnet;
            HostedGateway = hostedGateway;
            Peerings = peerings;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> VirtualRouter ASN. </summary>
        public long? VirtualRouterAsn { get; set; }
        /// <summary> VirtualRouter IPs. </summary>
        public IList<string> VirtualRouterIPs { get; }
        /// <summary> The Subnet on which VirtualRouter is hosted. </summary>
        internal WritableSubResource HostedSubnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HostedSubnetId
        {
            get => HostedSubnet is null ? default : HostedSubnet.Id;
            set
            {
                if (HostedSubnet is null)
                    HostedSubnet = new WritableSubResource();
                HostedSubnet.Id = value;
            }
        }

        /// <summary> The Gateway on which VirtualRouter is hosted. </summary>
        internal WritableSubResource HostedGateway { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HostedGatewayId
        {
            get => HostedGateway is null ? default : HostedGateway.Id;
            set
            {
                if (HostedGateway is null)
                    HostedGateway = new WritableSubResource();
                HostedGateway.Id = value;
            }
        }

        /// <summary> List of references to VirtualRouterPeerings. </summary>
        public IReadOnlyList<WritableSubResource> Peerings { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
