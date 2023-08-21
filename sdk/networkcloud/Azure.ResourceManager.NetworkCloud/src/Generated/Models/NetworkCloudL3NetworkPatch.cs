// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> L3NetworkPatchParameters represents the body of the request to patch the cloud services network. </summary>
    public partial class NetworkCloudL3NetworkPatch
    {
        /// <summary> Initializes a new instance of NetworkCloudL3NetworkPatch. </summary>
        public NetworkCloudL3NetworkPatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
