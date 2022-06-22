// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> An option to store secret value in secure place. </summary>
    internal partial class SecretStore
    {
        /// <summary> Initializes a new instance of SecretStore. </summary>
        public SecretStore()
        {
        }

        /// <summary> Initializes a new instance of SecretStore. </summary>
        /// <param name="keyVaultId"> The key vault id to store secret. </param>
        internal SecretStore(ResourceIdentifier keyVaultId)
        {
            KeyVaultId = keyVaultId;
        }

        /// <summary> The key vault id to store secret. </summary>
        public ResourceIdentifier KeyVaultId { get; set; }
    }
}
