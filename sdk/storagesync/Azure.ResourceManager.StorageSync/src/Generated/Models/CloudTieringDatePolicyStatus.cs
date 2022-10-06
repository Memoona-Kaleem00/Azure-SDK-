// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Status of the date policy. </summary>
    public partial class CloudTieringDatePolicyStatus
    {
        /// <summary> Initializes a new instance of CloudTieringDatePolicyStatus. </summary>
        internal CloudTieringDatePolicyStatus()
        {
        }

        /// <summary> Initializes a new instance of CloudTieringDatePolicyStatus. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="tieredFilesMostRecentAccessTimestamp"> Most recent access time of tiered files. </param>
        internal CloudTieringDatePolicyStatus(DateTimeOffset? lastUpdatedOn, DateTimeOffset? tieredFilesMostRecentAccessTimestamp)
        {
            LastUpdatedOn = lastUpdatedOn;
            TieredFilesMostRecentAccessTimestamp = tieredFilesMostRecentAccessTimestamp;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Most recent access time of tiered files. </summary>
        public DateTimeOffset? TieredFilesMostRecentAccessTimestamp { get; }
    }
}
