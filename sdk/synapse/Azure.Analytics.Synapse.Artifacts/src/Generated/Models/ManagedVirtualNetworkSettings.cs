// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Managed Virtual Network Settings. </summary>
    public partial class ManagedVirtualNetworkSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkSettings"/>. </summary>
        public ManagedVirtualNetworkSettings()
        {
            AllowedAadTenantIdsForLinking = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkSettings"/>. </summary>
        /// <param name="preventDataExfiltration"> Prevent Data Exfiltration. </param>
        /// <param name="linkedAccessCheckOnTargetResource"> Linked Access Check On Target Resource. </param>
        /// <param name="allowedAadTenantIdsForLinking"> Allowed Aad Tenant Ids For Linking. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedVirtualNetworkSettings(bool? preventDataExfiltration, bool? linkedAccessCheckOnTargetResource, IList<string> allowedAadTenantIdsForLinking, Dictionary<string, BinaryData> rawData)
        {
            PreventDataExfiltration = preventDataExfiltration;
            LinkedAccessCheckOnTargetResource = linkedAccessCheckOnTargetResource;
            AllowedAadTenantIdsForLinking = allowedAadTenantIdsForLinking;
            _rawData = rawData;
        }

        /// <summary> Prevent Data Exfiltration. </summary>
        public bool? PreventDataExfiltration { get; set; }
        /// <summary> Linked Access Check On Target Resource. </summary>
        public bool? LinkedAccessCheckOnTargetResource { get; set; }
        /// <summary> Allowed Aad Tenant Ids For Linking. </summary>
        public IList<string> AllowedAadTenantIdsForLinking { get; }
    }
}
