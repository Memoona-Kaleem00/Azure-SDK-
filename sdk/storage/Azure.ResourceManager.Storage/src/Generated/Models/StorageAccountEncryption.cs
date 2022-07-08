// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The encryption settings on the storage account. </summary>
    public partial class StorageAccountEncryption
    {
        /// <summary> Initializes a new instance of StorageAccountEncryption. </summary>
        public StorageAccountEncryption()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountEncryption. </summary>
        /// <param name="services"> List of services which support encryption. </param>
        /// <param name="keySource"> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </param>
        /// <param name="requireInfrastructureEncryption"> A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest. </param>
        /// <param name="keyVaultProperties"> Properties provided by key vault. </param>
        /// <param name="encryptionIdentity"> The identity to be used with service-side encryption at rest. </param>
        internal StorageAccountEncryption(StorageAccountEncryptionServices services, StorageAccountKeySource? keySource, bool? requireInfrastructureEncryption, StorageAccountKeyVaultProperties keyVaultProperties, StorageAccountEncryptionIdentity encryptionIdentity)
        {
            Services = services;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
            KeyVaultProperties = keyVaultProperties;
            EncryptionIdentity = encryptionIdentity;
        }

        /// <summary> List of services which support encryption. </summary>
        public StorageAccountEncryptionServices Services { get; set; }
        /// <summary> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </summary>
        public StorageAccountKeySource? KeySource { get; set; }
        /// <summary> A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest. </summary>
        public bool? RequireInfrastructureEncryption { get; set; }
        /// <summary> Properties provided by key vault. </summary>
        public StorageAccountKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The identity to be used with service-side encryption at rest. </summary>
        public StorageAccountEncryptionIdentity EncryptionIdentity { get; set; }
    }
}
