// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the IPAllocation data model. </summary>
    public partial class IPAllocationData : Resource
    {
        /// <summary> Initializes a new instance of IPAllocationData. </summary>
        public IPAllocationData()
        {
            AllocationTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of IPAllocationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="subnet"> The Subnet that using the prefix of this IpAllocation resource. </param>
        /// <param name="virtualNetwork"> The VirtualNetwork that using the prefix of this IpAllocation resource. </param>
        /// <param name="typePropertiesType"> The type for the IpAllocation. </param>
        /// <param name="prefix"> The address prefix for the IpAllocation. </param>
        /// <param name="prefixLength"> The address prefix length for the IpAllocation. </param>
        /// <param name="prefixType"> The address prefix Type for the IpAllocation. </param>
        /// <param name="ipamAllocationId"> The IPAM allocation ID. </param>
        /// <param name="allocationTags"> IpAllocation tags. </param>
        internal IPAllocationData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, WritableSubResource subnet, WritableSubResource virtualNetwork, IPAllocationType? typePropertiesType, string prefix, int? prefixLength, IPVersion? prefixType, string ipamAllocationId, IDictionary<string, string> allocationTags) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Subnet = subnet;
            VirtualNetwork = virtualNetwork;
            TypePropertiesType = typePropertiesType;
            Prefix = prefix;
            PrefixLength = prefixLength;
            PrefixType = prefixType;
            IpamAllocationId = ipamAllocationId;
            AllocationTags = allocationTags;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The Subnet that using the prefix of this IpAllocation resource. </summary>
        internal WritableSubResource Subnet { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet.Id;
            set => Subnet.Id = value;
        }

        /// <summary> The VirtualNetwork that using the prefix of this IpAllocation resource. </summary>
        internal WritableSubResource VirtualNetwork { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkId
        {
            get => VirtualNetwork.Id;
            set => VirtualNetwork.Id = value;
        }

        /// <summary> The type for the IpAllocation. </summary>
        public IPAllocationType? TypePropertiesType { get; set; }
        /// <summary> The address prefix for the IpAllocation. </summary>
        public string Prefix { get; set; }
        /// <summary> The address prefix length for the IpAllocation. </summary>
        public int? PrefixLength { get; set; }
        /// <summary> The address prefix Type for the IpAllocation. </summary>
        public IPVersion? PrefixType { get; set; }
        /// <summary> The IPAM allocation ID. </summary>
        public string IpamAllocationId { get; set; }
        /// <summary> IpAllocation tags. </summary>
        public IDictionary<string, string> AllocationTags { get; }
    }
}
