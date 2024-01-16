// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VpnServerConfigurationPolicyGroup data model.
    /// VpnServerConfigurationPolicyGroup Resource.
    /// </summary>
    public partial class VpnServerConfigurationPolicyGroupData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VpnServerConfigurationPolicyGroupData"/>. </summary>
        public VpnServerConfigurationPolicyGroupData()
        {
            PolicyMembers = new ChangeTrackingList<VpnServerConfigurationPolicyGroupMember>();
            P2SConnectionConfigurations = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnServerConfigurationPolicyGroupData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="isDefault"> Shows if this is a Default VpnServerConfigurationPolicyGroup or not. </param>
        /// <param name="priority"> Priority for VpnServerConfigurationPolicyGroup. </param>
        /// <param name="policyMembers"> Multiple PolicyMembers for VpnServerConfigurationPolicyGroup. </param>
        /// <param name="p2sConnectionConfigurations"> List of references to P2SConnectionConfigurations. </param>
        /// <param name="provisioningState"> The provisioning state of the VpnServerConfigurationPolicyGroup resource. </param>
        internal VpnServerConfigurationPolicyGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, bool? isDefault, int? priority, IList<VpnServerConfigurationPolicyGroupMember> policyMembers, IReadOnlyList<WritableSubResource> p2sConnectionConfigurations, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            IsDefault = isDefault;
            Priority = priority;
            PolicyMembers = policyMembers;
            P2SConnectionConfigurations = p2sConnectionConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Shows if this is a Default VpnServerConfigurationPolicyGroup or not. </summary>
        public bool? IsDefault { get; set; }
        /// <summary> Priority for VpnServerConfigurationPolicyGroup. </summary>
        public int? Priority { get; set; }
        /// <summary> Multiple PolicyMembers for VpnServerConfigurationPolicyGroup. </summary>
        public IList<VpnServerConfigurationPolicyGroupMember> PolicyMembers { get; }
        /// <summary> List of references to P2SConnectionConfigurations. </summary>
        public IReadOnlyList<WritableSubResource> P2SConnectionConfigurations { get; }
        /// <summary> The provisioning state of the VpnServerConfigurationPolicyGroup resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
