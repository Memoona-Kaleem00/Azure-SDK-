// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the BackupItem data model. </summary>
    public partial class BackupItemData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of BackupItemData. </summary>
        public BackupItemData()
        {
            Databases = new ChangeTrackingList<DatabaseBackupSetting>();
        }

        /// <summary> Initializes a new instance of BackupItemData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="backupId"> Id of the backup. </param>
        /// <param name="storageAccountUrl"> SAS URL for the storage account container which contains this backup. </param>
        /// <param name="blobName"> Name of the blob which contains data for this backup. </param>
        /// <param name="namePropertiesName"> Name of this backup. </param>
        /// <param name="status"> Backup status. </param>
        /// <param name="sizeInBytes"> Size of the backup in bytes. </param>
        /// <param name="created"> Timestamp of the backup creation. </param>
        /// <param name="log"> Details regarding this backup. Might contain an error message. </param>
        /// <param name="databases"> List of databases included in the backup. </param>
        /// <param name="scheduled"> True if this backup has been created due to a schedule being triggered. </param>
        /// <param name="lastRestoreTimeStamp"> Timestamp of a last restore operation which used this backup. </param>
        /// <param name="finishedTimeStamp"> Timestamp when this backup finished. </param>
        /// <param name="correlationId"> Unique correlation identifier. Please use this along with the timestamp while communicating with Azure support. </param>
        /// <param name="websiteSizeInBytes"> Size of the original web app which has been backed up. </param>
        internal BackupItemData(ResourceIdentifier id, string name, ResourceType type, string kind, int? backupId, string storageAccountUrl, string blobName, string namePropertiesName, BackupItemStatus? status, long? sizeInBytes, DateTimeOffset? created, string log, IReadOnlyList<DatabaseBackupSetting> databases, bool? scheduled, DateTimeOffset? lastRestoreTimeStamp, DateTimeOffset? finishedTimeStamp, string correlationId, long? websiteSizeInBytes) : base(id, name, type, kind)
        {
            BackupId = backupId;
            StorageAccountUrl = storageAccountUrl;
            BlobName = blobName;
            NamePropertiesName = namePropertiesName;
            Status = status;
            SizeInBytes = sizeInBytes;
            Created = created;
            Log = log;
            Databases = databases;
            Scheduled = scheduled;
            LastRestoreTimeStamp = lastRestoreTimeStamp;
            FinishedTimeStamp = finishedTimeStamp;
            CorrelationId = correlationId;
            WebsiteSizeInBytes = websiteSizeInBytes;
        }

        /// <summary> Id of the backup. </summary>
        public int? BackupId { get; }
        /// <summary> SAS URL for the storage account container which contains this backup. </summary>
        public string StorageAccountUrl { get; }
        /// <summary> Name of the blob which contains data for this backup. </summary>
        public string BlobName { get; }
        /// <summary> Name of this backup. </summary>
        public string NamePropertiesName { get; }
        /// <summary> Backup status. </summary>
        public BackupItemStatus? Status { get; }
        /// <summary> Size of the backup in bytes. </summary>
        public long? SizeInBytes { get; }
        /// <summary> Timestamp of the backup creation. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> Details regarding this backup. Might contain an error message. </summary>
        public string Log { get; }
        /// <summary> List of databases included in the backup. </summary>
        public IReadOnlyList<DatabaseBackupSetting> Databases { get; }
        /// <summary> True if this backup has been created due to a schedule being triggered. </summary>
        public bool? Scheduled { get; }
        /// <summary> Timestamp of a last restore operation which used this backup. </summary>
        public DateTimeOffset? LastRestoreTimeStamp { get; }
        /// <summary> Timestamp when this backup finished. </summary>
        public DateTimeOffset? FinishedTimeStamp { get; }
        /// <summary> Unique correlation identifier. Please use this along with the timestamp while communicating with Azure support. </summary>
        public string CorrelationId { get; }
        /// <summary> Size of the original web app which has been backed up. </summary>
        public long? WebsiteSizeInBytes { get; }
    }
}
