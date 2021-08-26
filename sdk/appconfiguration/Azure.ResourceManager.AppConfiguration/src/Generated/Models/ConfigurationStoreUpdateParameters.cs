// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The parameters for updating a configuration store. </summary>
    public partial class ConfigurationStoreUpdateParameters
    {
        /// <summary> Initializes a new instance of ConfigurationStoreUpdateParameters. </summary>
        public ConfigurationStoreUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The managed identity information for the configuration store. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> The SKU of the configuration store. </summary>
        public Sku Sku { get; set; }
        /// <summary> The ARM resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The encryption settings of the configuration store. </summary>
        public EncryptionProperties Encryption { get; set; }
        /// <summary> Disables all authentication methods other than AAD authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
