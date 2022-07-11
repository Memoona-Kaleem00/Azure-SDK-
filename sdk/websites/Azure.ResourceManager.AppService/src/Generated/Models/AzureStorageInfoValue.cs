// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Azure Files or Blob Storage access information value for dictionary storage.
    /// Serialized Name: AzureStorageInfoValue
    /// </summary>
    public partial class AzureStorageInfoValue
    {
        /// <summary> Initializes a new instance of AzureStorageInfoValue. </summary>
        public AzureStorageInfoValue()
        {
        }

        /// <summary> Initializes a new instance of AzureStorageInfoValue. </summary>
        /// <param name="storageType">
        /// Type of storage.
        /// Serialized Name: AzureStorageInfoValue.type
        /// </param>
        /// <param name="accountName">
        /// Name of the storage account.
        /// Serialized Name: AzureStorageInfoValue.accountName
        /// </param>
        /// <param name="shareName">
        /// Name of the file share (container name, for Blob storage).
        /// Serialized Name: AzureStorageInfoValue.shareName
        /// </param>
        /// <param name="accessKey">
        /// Access key for the storage account.
        /// Serialized Name: AzureStorageInfoValue.accessKey
        /// </param>
        /// <param name="mountPath">
        /// Path to mount the storage within the site&apos;s runtime environment.
        /// Serialized Name: AzureStorageInfoValue.mountPath
        /// </param>
        /// <param name="state">
        /// State of the storage account.
        /// Serialized Name: AzureStorageInfoValue.state
        /// </param>
        internal AzureStorageInfoValue(AzureStorageType? storageType, string accountName, string shareName, string accessKey, string mountPath, AzureStorageState? state)
        {
            StorageType = storageType;
            AccountName = accountName;
            ShareName = shareName;
            AccessKey = accessKey;
            MountPath = mountPath;
            State = state;
        }

        /// <summary>
        /// Type of storage.
        /// Serialized Name: AzureStorageInfoValue.type
        /// </summary>
        public AzureStorageType? StorageType { get; set; }
        /// <summary>
        /// Name of the storage account.
        /// Serialized Name: AzureStorageInfoValue.accountName
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// Name of the file share (container name, for Blob storage).
        /// Serialized Name: AzureStorageInfoValue.shareName
        /// </summary>
        public string ShareName { get; set; }
        /// <summary>
        /// Access key for the storage account.
        /// Serialized Name: AzureStorageInfoValue.accessKey
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// Path to mount the storage within the site&apos;s runtime environment.
        /// Serialized Name: AzureStorageInfoValue.mountPath
        /// </summary>
        public string MountPath { get; set; }
        /// <summary>
        /// State of the storage account.
        /// Serialized Name: AzureStorageInfoValue.state
        /// </summary>
        public AzureStorageState? State { get; }
    }
}
