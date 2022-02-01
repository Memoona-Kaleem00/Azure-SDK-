// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the Secret data model. </summary>
    public partial class SecretData : KeyVaultResource
    {
        /// <summary> Initializes a new instance of SecretData. </summary>
        /// <param name="properties"> Properties of the secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SecretData(SecretProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of SecretData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <param name="properties"> Properties of the secret. </param>
        internal SecretData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, IReadOnlyDictionary<string, string> tags, SecretProperties properties) : base(id, name, type, systemData, location, tags)
        {
            Properties = properties;
        }

        /// <summary> Properties of the secret. </summary>
        public SecretProperties Properties { get; set; }
    }
}
