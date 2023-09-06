// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> A service that allows server-side encryption to be used. </summary>
    public partial class StorageEncryptionService
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageEncryptionService"/>. </summary>
        public StorageEncryptionService()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageEncryptionService"/>. </summary>
        /// <param name="isEnabled"> A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is enabled by default today and cannot be disabled. </param>
        /// <param name="lastEnabledOn"> Gets a rough estimate of the date/time when the encryption was last enabled by the user. Data is encrypted at rest by default today and cannot be disabled. </param>
        /// <param name="keyType"> Encryption key type to be used for the encryption service. 'Account' key type implies that an account-scoped encryption key will be used. 'Service' key type implies that a default service key is used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageEncryptionService(bool? isEnabled, DateTimeOffset? lastEnabledOn, StorageEncryptionKeyType? keyType, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            LastEnabledOn = lastEnabledOn;
            KeyType = keyType;
            _rawData = rawData;
        }

        /// <summary> A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is enabled by default today and cannot be disabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Gets a rough estimate of the date/time when the encryption was last enabled by the user. Data is encrypted at rest by default today and cannot be disabled. </summary>
        public DateTimeOffset? LastEnabledOn { get; }
        /// <summary> Encryption key type to be used for the encryption service. 'Account' key type implies that an account-scoped encryption key will be used. 'Service' key type implies that a default service key is used. </summary>
        public StorageEncryptionKeyType? KeyType { get; set; }
    }
}
