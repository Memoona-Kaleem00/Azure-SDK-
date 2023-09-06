// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Capability a resource SKU has. </summary>
    public partial class StoragePoolSkuCapability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuCapability"/>. </summary>
        internal StoragePoolSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuCapability"/>. </summary>
        /// <param name="name"> Capability name. </param>
        /// <param name="value"> Capability value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePoolSkuCapability(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Capability name. </summary>
        public string Name { get; }
        /// <summary> Capability value. </summary>
        public string Value { get; }
    }
}
