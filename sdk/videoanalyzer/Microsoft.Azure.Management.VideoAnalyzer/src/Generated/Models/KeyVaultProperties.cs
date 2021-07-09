// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details for accessing the encryption keys in Key Vault.
    /// </summary>
    public partial class KeyVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultProperties class.
        /// </summary>
        public KeyVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultProperties class.
        /// </summary>
        /// <param name="keyIdentifier">The URL of the Key Vault key used to
        /// encrypt the account. The key may either be versioned (for example
        /// https://vault/keys/mykey/version1) or reference a key without a
        /// version (for example https://vault/keys/mykey).</param>
        /// <param name="currentKeyIdentifier">The current key used to encrypt
        /// Video Analyzer account, including the key version.</param>
        public KeyVaultProperties(string keyIdentifier, string currentKeyIdentifier = default(string))
        {
            KeyIdentifier = keyIdentifier;
            CurrentKeyIdentifier = currentKeyIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the Key Vault key used to encrypt the
        /// account. The key may either be versioned (for example
        /// https://vault/keys/mykey/version1) or reference a key without a
        /// version (for example https://vault/keys/mykey).
        /// </summary>
        [JsonProperty(PropertyName = "keyIdentifier")]
        public string KeyIdentifier { get; set; }

        /// <summary>
        /// Gets the current key used to encrypt Video Analyzer account,
        /// including the key version.
        /// </summary>
        [JsonProperty(PropertyName = "currentKeyIdentifier")]
        public string CurrentKeyIdentifier { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyIdentifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyIdentifier");
            }
        }
    }
}
