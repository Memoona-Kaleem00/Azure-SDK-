// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> KeyPolicy assigned to the storage account. </summary>
    internal partial class StorageAccountKeyPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyPolicy"/>. </summary>
        /// <param name="keyExpirationPeriodInDays"> The key expiration period in days. </param>
        public StorageAccountKeyPolicy(int keyExpirationPeriodInDays)
        {
            KeyExpirationPeriodInDays = keyExpirationPeriodInDays;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyPolicy"/>. </summary>
        /// <param name="keyExpirationPeriodInDays"> The key expiration period in days. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountKeyPolicy(int keyExpirationPeriodInDays, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyExpirationPeriodInDays = keyExpirationPeriodInDays;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyPolicy"/> for deserialization. </summary>
        internal StorageAccountKeyPolicy()
        {
        }

        /// <summary> The key expiration period in days. </summary>
        public int KeyExpirationPeriodInDays { get; set; }
    }
}
