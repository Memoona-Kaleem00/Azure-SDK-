// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Tags object for patch operations. </summary>
    public partial class FrontDoorWebApplicationFirewallPolicyPatch
    {
        /// <summary> Initializes a new instance of FrontDoorWebApplicationFirewallPolicyPatch. </summary>
        public FrontDoorWebApplicationFirewallPolicyPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
