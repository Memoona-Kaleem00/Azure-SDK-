// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing the NetAppBackupPolicy data model.
    /// Backup policy information
    /// </summary>
    public partial class NetAppBackupPolicyData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetAppBackupPolicyData. </summary>
        /// <param name="location"> The location. </param>
        public NetAppBackupPolicyData(AzureLocation location) : base(location)
        {
            VolumeBackups = new Core.ChangeTrackingList<NetAppVolumeBackupDetail>();
        }

        /// <summary> Initializes a new instance of NetAppBackupPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="backupPolicyId"> Backup Policy Resource ID. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="dailyBackupsToKeep"> Daily backups count to keep. </param>
        /// <param name="weeklyBackupsToKeep"> Weekly backups count to keep. </param>
        /// <param name="monthlyBackupsToKeep"> Monthly backups count to keep. </param>
        /// <param name="volumesAssigned"> Volumes using current backup policy. </param>
        /// <param name="isEnabled"> The property to decide policy is enabled or not. </param>
        /// <param name="volumeBackups"> A list of volumes assigned to this policy. </param>
        internal NetAppBackupPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, ResourceIdentifier backupPolicyId, string provisioningState, int? dailyBackupsToKeep, int? weeklyBackupsToKeep, int? monthlyBackupsToKeep, int? volumesAssigned, bool? isEnabled, IReadOnlyList<NetAppVolumeBackupDetail> volumeBackups) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            BackupPolicyId = backupPolicyId;
            ProvisioningState = provisioningState;
            DailyBackupsToKeep = dailyBackupsToKeep;
            WeeklyBackupsToKeep = weeklyBackupsToKeep;
            MonthlyBackupsToKeep = monthlyBackupsToKeep;
            VolumesAssigned = volumesAssigned;
            IsEnabled = isEnabled;
            VolumeBackups = volumeBackups;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Backup Policy Resource ID. </summary>
        public ResourceIdentifier BackupPolicyId { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Daily backups count to keep. </summary>
        public int? DailyBackupsToKeep { get; set; }
        /// <summary> Weekly backups count to keep. </summary>
        public int? WeeklyBackupsToKeep { get; set; }
        /// <summary> Monthly backups count to keep. </summary>
        public int? MonthlyBackupsToKeep { get; set; }
        /// <summary> Volumes using current backup policy. </summary>
        public int? VolumesAssigned { get; }
        /// <summary> The property to decide policy is enabled or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> A list of volumes assigned to this policy. </summary>
        public IReadOnlyList<NetAppVolumeBackupDetail> VolumeBackups { get; }
    }
}
