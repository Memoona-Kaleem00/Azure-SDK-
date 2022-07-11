// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the VnetInfoResource data model. </summary>
    public partial class VnetInfoResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of VnetInfoResourceData. </summary>
        public VnetInfoResourceData()
        {
            Routes = new ChangeTrackingList<VnetRoute>();
        }

        /// <summary> Initializes a new instance of VnetInfoResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetResourceId">
        /// The Virtual Network&apos;s resource ID.
        /// Serialized Name: VnetInfoResource.properties.vnetResourceId
        /// </param>
        /// <param name="certThumbprint">
        /// The client certificate thumbprint.
        /// Serialized Name: VnetInfoResource.properties.certThumbprint
        /// </param>
        /// <param name="certBlob">
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
        /// Point-To-Site VPN connection.
        /// Serialized Name: VnetInfoResource.properties.certBlob
        /// </param>
        /// <param name="routes">
        /// The routes that this Virtual Network connection uses.
        /// Serialized Name: VnetInfoResource.properties.routes
        /// </param>
        /// <param name="isResyncRequired">
        /// &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: VnetInfoResource.properties.resyncRequired
        /// </param>
        /// <param name="dnsServers">
        /// DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses.
        /// Serialized Name: VnetInfoResource.properties.dnsServers
        /// </param>
        /// <param name="isSwift">
        /// Flag that is used to denote if this is VNET injection
        /// Serialized Name: VnetInfoResource.properties.isSwift
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal VnetInfoResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string vnetResourceId, string certThumbprint, string certBlob, IReadOnlyList<VnetRoute> routes, bool? isResyncRequired, string dnsServers, bool? isSwift, string kind) : base(id, name, resourceType, systemData)
        {
            VnetResourceId = vnetResourceId;
            CertThumbprint = certThumbprint;
            CertBlob = certBlob;
            Routes = routes;
            IsResyncRequired = isResyncRequired;
            DnsServers = dnsServers;
            IsSwift = isSwift;
            Kind = kind;
        }

        /// <summary>
        /// The Virtual Network&apos;s resource ID.
        /// Serialized Name: VnetInfoResource.properties.vnetResourceId
        /// </summary>
        public string VnetResourceId { get; set; }
        /// <summary>
        /// The client certificate thumbprint.
        /// Serialized Name: VnetInfoResource.properties.certThumbprint
        /// </summary>
        public string CertThumbprint { get; }
        /// <summary>
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
        /// Point-To-Site VPN connection.
        /// Serialized Name: VnetInfoResource.properties.certBlob
        /// </summary>
        public string CertBlob { get; set; }
        /// <summary>
        /// The routes that this Virtual Network connection uses.
        /// Serialized Name: VnetInfoResource.properties.routes
        /// </summary>
        public IReadOnlyList<VnetRoute> Routes { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: VnetInfoResource.properties.resyncRequired
        /// </summary>
        public bool? IsResyncRequired { get; }
        /// <summary>
        /// DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses.
        /// Serialized Name: VnetInfoResource.properties.dnsServers
        /// </summary>
        public string DnsServers { get; set; }
        /// <summary>
        /// Flag that is used to denote if this is VNET injection
        /// Serialized Name: VnetInfoResource.properties.isSwift
        /// </summary>
        public bool? IsSwift { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
