// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the basic gallery artifact publishing profile. </summary>
    public partial class GalleryArtifactPublishingProfileBase
    {
        /// <summary> Initializes a new instance of GalleryArtifactPublishingProfileBase. </summary>
        public GalleryArtifactPublishingProfileBase()
        {
            TargetRegions = new ChangeTrackingList<TargetRegion>();
        }

        /// <summary> Initializes a new instance of GalleryArtifactPublishingProfileBase. </summary>
        /// <param name="targetRegions"> The target regions where the Image Version is going to be replicated to. This property is updatable. </param>
        /// <param name="replicaCount"> The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable. </param>
        /// <param name="excludeFromLatest"> If set to true, Virtual Machines deployed from the latest version of the Image Definition won&apos;t use this Image Version. </param>
        /// <param name="publishedDate"> The timestamp for when the gallery image version is published. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to store the image. This property is not updatable. </param>
        /// <param name="replicationMode"> Optional parameter which specifies the mode to be used for replication. This property is not updatable. </param>
        internal GalleryArtifactPublishingProfileBase(IList<TargetRegion> targetRegions, int? replicaCount, bool? excludeFromLatest, DateTimeOffset? publishedDate, DateTimeOffset? endOfLifeDate, StorageAccountType? storageAccountType, ReplicationMode? replicationMode)
        {
            TargetRegions = targetRegions;
            ReplicaCount = replicaCount;
            ExcludeFromLatest = excludeFromLatest;
            PublishedDate = publishedDate;
            EndOfLifeDate = endOfLifeDate;
            StorageAccountType = storageAccountType;
            ReplicationMode = replicationMode;
        }

        /// <summary> The target regions where the Image Version is going to be replicated to. This property is updatable. </summary>
        public IList<TargetRegion> TargetRegions { get; }
        /// <summary> The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable. </summary>
        public int? ReplicaCount { get; set; }
        /// <summary> If set to true, Virtual Machines deployed from the latest version of the Image Definition won&apos;t use this Image Version. </summary>
        public bool? ExcludeFromLatest { get; set; }
        /// <summary> The timestamp for when the gallery image version is published. </summary>
        public DateTimeOffset? PublishedDate { get; }
        /// <summary> The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; set; }
        /// <summary> Specifies the storage account type to be used to store the image. This property is not updatable. </summary>
        public StorageAccountType? StorageAccountType { get; set; }
        /// <summary> Optional parameter which specifies the mode to be used for replication. This property is not updatable. </summary>
        public ReplicationMode? ReplicationMode { get; set; }
    }
}
