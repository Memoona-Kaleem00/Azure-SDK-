// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Properties to configure Encryption. </summary>
    public partial class Encryption
    {
        /// <summary> Initializes a new instance of Encryption. </summary>
        public Encryption()
        {
            KeyVaultProperties = new ChangeTrackingList<KeyVaultProperties>();
            KeySource = "Microsoft.KeyVault";
        }

        /// <summary> Initializes a new instance of Encryption. </summary>
        /// <param name="keyVaultProperties"> Properties of KeyVault. </param>
        /// <param name="keySource"> Enumerates the possible value of keySource for Encryption. </param>
        /// <param name="requireInfrastructureEncryption"> Enable Infrastructure Encryption (Double Encryption). </param>
        internal Encryption(IList<KeyVaultProperties> keyVaultProperties, string keySource, bool? requireInfrastructureEncryption)
        {
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
        }

        /// <summary> Properties of KeyVault. </summary>
        public IList<KeyVaultProperties> KeyVaultProperties { get; }
        /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
        public string KeySource { get; set; }
        /// <summary> Enable Infrastructure Encryption (Double Encryption). </summary>
        public bool? RequireInfrastructureEncryption { get; set; }
    }
}
