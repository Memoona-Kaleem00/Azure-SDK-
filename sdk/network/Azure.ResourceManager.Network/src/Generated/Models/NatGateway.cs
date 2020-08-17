// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Nat Gateway resource. </summary>
    public partial class NatGateway : Resource
    {
        /// <summary> Initializes a new instance of NatGateway. </summary>
        public NatGateway()
        {
            Zones = new ChangeTrackingList<string>();
            PublicIpAddresses = new ChangeTrackingList<SubResource>();
            PublicIpPrefixes = new ChangeTrackingList<SubResource>();
            Subnets = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of NatGateway. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The nat gateway SKU. </param>
        /// <param name="zones"> A list of availability zones denoting the zone in which Nat Gateway should be deployed. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the nat gateway. </param>
        /// <param name="publicIpAddresses"> An array of public ip addresses associated with the nat gateway resource. </param>
        /// <param name="publicIpPrefixes"> An array of public ip prefixes associated with the nat gateway resource. </param>
        /// <param name="subnets"> An array of references to the subnets using this nat gateway resource. </param>
        /// <param name="resourceGuid"> The resource GUID property of the NAT gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the NAT gateway resource. </param>
        internal NatGateway(string id, string name, string type, string location, IDictionary<string, string> tags, NatGatewaySku sku, IList<string> zones, string etag, int? idleTimeoutInMinutes, IList<SubResource> publicIpAddresses, IList<SubResource> publicIpPrefixes, IReadOnlyList<SubResource> subnets, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Sku = sku;
            Zones = zones;
            Etag = etag;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            PublicIpAddresses = publicIpAddresses;
            PublicIpPrefixes = publicIpPrefixes;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> The nat gateway SKU. </summary>
        public NatGatewaySku Sku { get; set; }
        /// <summary> A list of availability zones denoting the zone in which Nat Gateway should be deployed. </summary>
        public IList<string> Zones { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The idle timeout of the nat gateway. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> An array of public ip addresses associated with the nat gateway resource. </summary>
        public IList<SubResource> PublicIpAddresses { get; }
        /// <summary> An array of public ip prefixes associated with the nat gateway resource. </summary>
        public IList<SubResource> PublicIpPrefixes { get; }
        /// <summary> An array of references to the subnets using this nat gateway resource. </summary>
        public IReadOnlyList<SubResource> Subnets { get; }
        /// <summary> The resource GUID property of the NAT gateway resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the NAT gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
