// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StorageSshPublicKey. </summary>
    public partial class StorageSshPublicKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSshPublicKey"/>. </summary>
        public StorageSshPublicKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSshPublicKey"/>. </summary>
        /// <param name="description"> Optional. It is used to store the function/usage of the key. </param>
        /// <param name="key"> Ssh public key base64 encoded. The format should be: '&lt;keyType&gt; &lt;keyData&gt;', e.g. ssh-rsa AAAABBBB. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSshPublicKey(string description, string key, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            Key = key;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Optional. It is used to store the function/usage of the key. </summary>
        public string Description { get; set; }
        /// <summary> Ssh public key base64 encoded. The format should be: '&lt;keyType&gt; &lt;keyData&gt;', e.g. ssh-rsa AAAABBBB. </summary>
        public string Key { get; set; }
    }
}
