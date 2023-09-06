// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Details of the customer managed key associated with the workspace. </summary>
    public partial class SynapseWorkspaceKeyDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceKeyDetails"/>. </summary>
        public SynapseWorkspaceKeyDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceKeyDetails"/>. </summary>
        /// <param name="name"> Workspace Key sub-resource name. </param>
        /// <param name="keyVaultUri"> Workspace Key sub-resource key vault url. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseWorkspaceKeyDetails(string name, Uri keyVaultUri, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            KeyVaultUri = keyVaultUri;
            _rawData = rawData;
        }

        /// <summary> Workspace Key sub-resource name. </summary>
        public string Name { get; set; }
        /// <summary> Workspace Key sub-resource key vault url. </summary>
        public Uri KeyVaultUri { get; set; }
    }
}
