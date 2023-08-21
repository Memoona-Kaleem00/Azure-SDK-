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
    /// A class representing the FrontendIPConfiguration data model.
    /// Frontend IP address of the load balancer.
    /// </summary>
    public partial class FrontendIPConfigurationData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of FrontendIPConfigurationData. </summary>
        public FrontendIPConfigurationData()
        {
            Zones = new Core.ChangeTrackingList<string>();
            InboundNatRules = new Core.ChangeTrackingList<WritableSubResource>();
            InboundNatPools = new Core.ChangeTrackingList<WritableSubResource>();
            OutboundRules = new Core.ChangeTrackingList<WritableSubResource>();
            LoadBalancingRules = new Core.ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of FrontendIPConfigurationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="inboundNatRules"> An array of references to inbound rules that use this frontend IP. </param>
        /// <param name="inboundNatPools"> An array of references to inbound pools that use this frontend IP. </param>
        /// <param name="outboundRules"> An array of references to outbound rules that use this frontend IP. </param>
        /// <param name="loadBalancingRules"> An array of references to load balancing rules that use this frontend IP. </param>
        /// <param name="privateIPAddress"> The private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The Private IP allocation method. </param>
        /// <param name="privateIPAddressVersion"> Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. </param>
        /// <param name="subnet"> The reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference to the Public IP resource. </param>
        /// <param name="publicIPPrefix"> The reference to the Public IP Prefix resource. </param>
        /// <param name="gatewayLoadBalancer"> The reference to gateway load balancer frontend IP. </param>
        /// <param name="provisioningState"> The provisioning state of the frontend IP configuration resource. </param>
        internal FrontendIPConfigurationData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IList<string> zones, IReadOnlyList<WritableSubResource> inboundNatRules, IReadOnlyList<WritableSubResource> inboundNatPools, IReadOnlyList<WritableSubResource> outboundRules, IReadOnlyList<WritableSubResource> loadBalancingRules, string privateIPAddress, NetworkIPAllocationMethod? privateIPAllocationMethod, NetworkIPVersion? privateIPAddressVersion, SubnetData subnet, PublicIPAddressData publicIPAddress, WritableSubResource publicIPPrefix, WritableSubResource gatewayLoadBalancer, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            Zones = zones;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundRules = outboundRules;
            LoadBalancingRules = loadBalancingRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            PrivateIPAddressVersion = privateIPAddressVersion;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PublicIPPrefix = publicIPPrefix;
            GatewayLoadBalancer = gatewayLoadBalancer;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> An array of references to inbound rules that use this frontend IP. </summary>
        public IReadOnlyList<WritableSubResource> InboundNatRules { get; }
        /// <summary> An array of references to inbound pools that use this frontend IP. </summary>
        public IReadOnlyList<WritableSubResource> InboundNatPools { get; }
        /// <summary> An array of references to outbound rules that use this frontend IP. </summary>
        public IReadOnlyList<WritableSubResource> OutboundRules { get; }
        /// <summary> An array of references to load balancing rules that use this frontend IP. </summary>
        public IReadOnlyList<WritableSubResource> LoadBalancingRules { get; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The Private IP allocation method. </summary>
        public NetworkIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. </summary>
        public NetworkIPVersion? PrivateIPAddressVersion { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> The reference to the Public IP resource. </summary>
        public PublicIPAddressData PublicIPAddress { get; set; }
        /// <summary> The reference to the Public IP Prefix resource. </summary>
        internal WritableSubResource PublicIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPPrefixId
        {
            get => PublicIPPrefix is null ? default : PublicIPPrefix.Id;
            set
            {
                if (PublicIPPrefix is null)
                    PublicIPPrefix = new WritableSubResource();
                PublicIPPrefix.Id = value;
            }
        }

        /// <summary> The reference to gateway load balancer frontend IP. </summary>
        internal WritableSubResource GatewayLoadBalancer { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier GatewayLoadBalancerId
        {
            get => GatewayLoadBalancer is null ? default : GatewayLoadBalancer.Id;
            set
            {
                if (GatewayLoadBalancer is null)
                    GatewayLoadBalancer = new WritableSubResource();
                GatewayLoadBalancer.Id = value;
            }
        }

        /// <summary> The provisioning state of the frontend IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
