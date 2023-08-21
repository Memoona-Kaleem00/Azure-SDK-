// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters for VirtualNetworkGatewayPolicyGroup. </summary>
    public partial class VirtualNetworkGatewayPolicyGroup : NetworkResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayPolicyGroup. </summary>
        public VirtualNetworkGatewayPolicyGroup()
        {
            PolicyMembers = new Core.ChangeTrackingList<VirtualNetworkGatewayPolicyGroupMember>();
            VngClientConnectionConfigurations = new Core.ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayPolicyGroup. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="isDefault"> Shows if this is a Default VirtualNetworkGatewayPolicyGroup or not. </param>
        /// <param name="priority"> Priority for VirtualNetworkGatewayPolicyGroup. </param>
        /// <param name="policyMembers"> Multiple PolicyMembers for VirtualNetworkGatewayPolicyGroup. </param>
        /// <param name="vngClientConnectionConfigurations"> List of references to vngClientConnectionConfigurations. </param>
        /// <param name="provisioningState"> The provisioning state of the VirtualNetworkGatewayPolicyGroup resource. </param>
        internal VirtualNetworkGatewayPolicyGroup(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, bool? isDefault, int? priority, IList<VirtualNetworkGatewayPolicyGroupMember> policyMembers, IReadOnlyList<WritableSubResource> vngClientConnectionConfigurations, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            IsDefault = isDefault;
            Priority = priority;
            PolicyMembers = policyMembers;
            VngClientConnectionConfigurations = vngClientConnectionConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Shows if this is a Default VirtualNetworkGatewayPolicyGroup or not. </summary>
        public bool? IsDefault { get; set; }
        /// <summary> Priority for VirtualNetworkGatewayPolicyGroup. </summary>
        public int? Priority { get; set; }
        /// <summary> Multiple PolicyMembers for VirtualNetworkGatewayPolicyGroup. </summary>
        public IList<VirtualNetworkGatewayPolicyGroupMember> PolicyMembers { get; }
        /// <summary> List of references to vngClientConnectionConfigurations. </summary>
        public IReadOnlyList<WritableSubResource> VngClientConnectionConfigurations { get; }
        /// <summary> The provisioning state of the VirtualNetworkGatewayPolicyGroup resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
