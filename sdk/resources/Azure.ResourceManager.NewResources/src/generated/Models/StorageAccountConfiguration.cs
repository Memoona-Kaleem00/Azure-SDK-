// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Settings to use an existing storage account. Valid storage account kinds are: Storage, StorageV2 and FileStorage. </summary>
    public partial class StorageAccountConfiguration
    {
        /// <summary> Initializes a new instance of StorageAccountConfiguration. </summary>
        public StorageAccountConfiguration()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountConfiguration. </summary>
        /// <param name="storageAccountName"> The storage account name. </param>
        /// <param name="storageAccountKey"> The storage account access key. </param>
        internal StorageAccountConfiguration(string storageAccountName, string storageAccountKey)
        {
            StorageAccountName = storageAccountName;
            StorageAccountKey = storageAccountKey;
        }

        /// <summary> The storage account name. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> The storage account access key. </summary>
        public string StorageAccountKey { get; set; }
    }
}
