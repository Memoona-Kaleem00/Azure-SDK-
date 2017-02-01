// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a reference to Key Vault Secret
    /// </summary>
    public partial class KeyVaultSecretReference
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultSecretReference class.
        /// </summary>
        public KeyVaultSecretReference() { }

        /// <summary>
        /// Initializes a new instance of the KeyVaultSecretReference class.
        /// </summary>
        /// <param name="secretUrl">The URL referencing a secret in a Key
        /// Vault.</param>
        /// <param name="sourceVault">The relative URL of the Key Vault
        /// containing the secret.</param>
        public KeyVaultSecretReference(string secretUrl, Microsoft.Azure.Management.Resource.Fluent.SubResource sourceVault)
        {
            SecretUrl = secretUrl;
            SourceVault = sourceVault;
        }

        /// <summary>
        /// Gets or sets the URL referencing a secret in a Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "secretUrl")]
        public string SecretUrl { get; set; }

        /// <summary>
        /// Gets or sets the relative URL of the Key Vault containing the
        /// secret.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVault")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource SourceVault { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SecretUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretUrl");
            }
            if (SourceVault == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceVault");
            }
        }
    }
}

