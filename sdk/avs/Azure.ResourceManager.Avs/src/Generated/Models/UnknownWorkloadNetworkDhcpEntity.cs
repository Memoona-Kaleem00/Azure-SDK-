// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The UnknownWorkloadNetworkDhcpEntity. </summary>
    internal partial class UnknownWorkloadNetworkDhcpEntity : WorkloadNetworkDhcpEntity
    {
        /// <summary> Initializes a new instance of UnknownWorkloadNetworkDhcpEntity. </summary>
        /// <param name="dhcpType"> Type of DHCP: SERVER or RELAY. </param>
        /// <param name="displayName"> Display name of the DHCP entity. </param>
        /// <param name="segments"> NSX Segments consuming DHCP. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        internal UnknownWorkloadNetworkDhcpEntity(DhcpTypeEnum dhcpType, string displayName, IReadOnlyList<string> segments, WorkloadNetworkDhcpProvisioningState? provisioningState, long? revision) : base(dhcpType, displayName, segments, provisioningState, revision)
        {
            DhcpType = dhcpType;
        }
    }
}
