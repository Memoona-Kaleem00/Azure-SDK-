// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Server endpoint cloud tiering status object. </summary>
    public partial class ServerEndpointCloudTieringStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServerEndpointCloudTieringStatus"/>. </summary>
        internal ServerEndpointCloudTieringStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServerEndpointCloudTieringStatus"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="health"> Cloud tiering health state. </param>
        /// <param name="healthLastUpdatedOn"> The last updated timestamp of health state. </param>
        /// <param name="lastCloudTieringResult"> Last cloud tiering result (HResult). </param>
        /// <param name="lastSuccessTimestamp"> Last cloud tiering success timestamp. </param>
        /// <param name="spaceSavings"> Information regarding how much local space cloud tiering is saving. </param>
        /// <param name="cachePerformance"> Information regarding how well the local cache on the server is performing. </param>
        /// <param name="filesNotTiering"> Information regarding files that failed to be tiered. </param>
        /// <param name="volumeFreeSpacePolicyStatus"> Status of the volume free space policy. </param>
        /// <param name="datePolicyStatus"> Status of the date policy. </param>
        /// <param name="lowDiskMode"> Information regarding the low disk mode state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerEndpointCloudTieringStatus(DateTimeOffset? lastUpdatedOn, ServerEndpointHealthState? health, DateTimeOffset? healthLastUpdatedOn, int? lastCloudTieringResult, DateTimeOffset? lastSuccessTimestamp, CloudTieringSpaceSavings spaceSavings, CloudTieringCachePerformance cachePerformance, CloudTieringFilesNotTiering filesNotTiering, CloudTieringVolumeFreeSpacePolicyStatus volumeFreeSpacePolicyStatus, CloudTieringDatePolicyStatus datePolicyStatus, CloudTieringLowDiskMode lowDiskMode, Dictionary<string, BinaryData> rawData)
        {
            LastUpdatedOn = lastUpdatedOn;
            Health = health;
            HealthLastUpdatedOn = healthLastUpdatedOn;
            LastCloudTieringResult = lastCloudTieringResult;
            LastSuccessTimestamp = lastSuccessTimestamp;
            SpaceSavings = spaceSavings;
            CachePerformance = cachePerformance;
            FilesNotTiering = filesNotTiering;
            VolumeFreeSpacePolicyStatus = volumeFreeSpacePolicyStatus;
            DatePolicyStatus = datePolicyStatus;
            LowDiskMode = lowDiskMode;
            _rawData = rawData;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Cloud tiering health state. </summary>
        public ServerEndpointHealthState? Health { get; }
        /// <summary> The last updated timestamp of health state. </summary>
        public DateTimeOffset? HealthLastUpdatedOn { get; }
        /// <summary> Last cloud tiering result (HResult). </summary>
        public int? LastCloudTieringResult { get; }
        /// <summary> Last cloud tiering success timestamp. </summary>
        public DateTimeOffset? LastSuccessTimestamp { get; }
        /// <summary> Information regarding how much local space cloud tiering is saving. </summary>
        public CloudTieringSpaceSavings SpaceSavings { get; }
        /// <summary> Information regarding how well the local cache on the server is performing. </summary>
        public CloudTieringCachePerformance CachePerformance { get; }
        /// <summary> Information regarding files that failed to be tiered. </summary>
        public CloudTieringFilesNotTiering FilesNotTiering { get; }
        /// <summary> Status of the volume free space policy. </summary>
        public CloudTieringVolumeFreeSpacePolicyStatus VolumeFreeSpacePolicyStatus { get; }
        /// <summary> Status of the date policy. </summary>
        public CloudTieringDatePolicyStatus DatePolicyStatus { get; }
        /// <summary> Information regarding the low disk mode state. </summary>
        public CloudTieringLowDiskMode LowDiskMode { get; }
    }
}
