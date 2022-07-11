// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Key Vault container ARM resource for a certificate that is purchased through Azure.
    /// Serialized Name: AppServiceCertificatePatchResource
    /// </summary>
    public partial class AppServiceCertificateResourcePatch : ResourceData
    {
        /// <summary> Initializes a new instance of AppServiceCertificateResourcePatch. </summary>
        public AppServiceCertificateResourcePatch()
        {
        }

        /// <summary> Initializes a new instance of AppServiceCertificateResourcePatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="keyVaultId">
        /// Key Vault resource Id.
        /// Serialized Name: AppServiceCertificatePatchResource.properties.keyVaultId
        /// </param>
        /// <param name="keyVaultSecretName">
        /// Key Vault secret name.
        /// Serialized Name: AppServiceCertificatePatchResource.properties.keyVaultSecretName
        /// </param>
        /// <param name="provisioningState">
        /// Status of the Key Vault secret.
        /// Serialized Name: AppServiceCertificatePatchResource.properties.provisioningState
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal AppServiceCertificateResourcePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? provisioningState, string kind) : base(id, name, resourceType, systemData)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary>
        /// Key Vault resource Id.
        /// Serialized Name: AppServiceCertificatePatchResource.properties.keyVaultId
        /// </summary>
        public string KeyVaultId { get; set; }
        /// <summary>
        /// Key Vault secret name.
        /// Serialized Name: AppServiceCertificatePatchResource.properties.keyVaultSecretName
        /// </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary>
        /// Status of the Key Vault secret.
        /// Serialized Name: AppServiceCertificatePatchResource.properties.provisioningState
        /// </summary>
        public KeyVaultSecretStatus? ProvisioningState { get; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
