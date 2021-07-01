// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Resource information with extended details. </summary>
    public partial class ManagedHsm : ManagedHsmResource
    {
        /// <summary> Initializes a new instance of ManagedHsm. </summary>
        public ManagedHsm()
        {
        }

        /// <summary> Initializes a new instance of ManagedHsm. </summary>
        /// <param name="id"> The Azure Resource Manager resource ID for the managed HSM Pool. </param>
        /// <param name="name"> The name of the managed HSM Pool. </param>
        /// <param name="type"> The resource type of the managed HSM Pool. </param>
        /// <param name="location"> The supported Azure location where the managed HSM Pool should be created. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the key vault resource. </param>
        /// <param name="properties"> Properties of the managed HSM. </param>
        internal ManagedHsm(string id, string name, string type, string location, ManagedHsmSku sku, IDictionary<string, string> tags, SystemData systemData, ManagedHsmProperties properties) : base(id, name, type, location, sku, tags, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the managed HSM. </summary>
        public ManagedHsmProperties Properties { get; set; }
    }
}
