// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of Vaults in the Vault. </summary>
        /// <returns> An object representing collection of Vaults and their operations over a Vault. </returns>
        public virtual VaultCollection GetVaults()
        {
            return new VaultCollection(Client, Id);
        }

        /// <summary> Gets a collection of ManagedHsms in the ManagedHsm. </summary>
        /// <returns> An object representing collection of ManagedHsms and their operations over a ManagedHsm. </returns>
        public virtual ManagedHsmCollection GetManagedHsms()
        {
            return new ManagedHsmCollection(Client, Id);
        }
    }
}
