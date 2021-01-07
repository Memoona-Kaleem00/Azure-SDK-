// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Properties of a share. </summary>
    public partial class SharePropertiesInternal
    {
        /// <summary> Initializes a new instance of SharePropertiesInternal. </summary>
        /// <param name="lastModified"> . </param>
        /// <param name="etag"> . </param>
        /// <param name="quota"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="etag"/> is null. </exception>
        internal SharePropertiesInternal(DateTimeOffset lastModified, string etag, int quota)
        {
            if (etag == null)
            {
                throw new ArgumentNullException(nameof(etag));
            }

            LastModified = lastModified;
            Etag = etag;
            Quota = quota;
        }

        /// <summary> Initializes a new instance of SharePropertiesInternal. </summary>
        /// <param name="lastModified"> . </param>
        /// <param name="etag"> . </param>
        /// <param name="quota"> . </param>
        /// <param name="provisionedIops"> . </param>
        /// <param name="provisionedIngressMBps"> . </param>
        /// <param name="provisionedEgressMBps"> . </param>
        /// <param name="nextAllowedQuotaDowngradeTime"> . </param>
        /// <param name="deletedTime"> . </param>
        /// <param name="remainingRetentionDays"> . </param>
        /// <param name="accessTier"> . </param>
        /// <param name="accessTierChangeTime"> . </param>
        /// <param name="accessTierTransitionState"> . </param>
        /// <param name="leaseStatus"> The current lease status of the share. </param>
        /// <param name="leaseState"> Lease state of the share. </param>
        /// <param name="leaseDuration"> When a share is leased, specifies whether the lease is of infinite or fixed duration. </param>
        /// <param name="enabledProtocols"> . </param>
        /// <param name="rootSquash"> . </param>
        internal SharePropertiesInternal(DateTimeOffset lastModified, string etag, int quota, int? provisionedIops, int? provisionedIngressMBps, int? provisionedEgressMBps, DateTimeOffset? nextAllowedQuotaDowngradeTime, DateTimeOffset? deletedTime, int? remainingRetentionDays, string accessTier, DateTimeOffset? accessTierChangeTime, string accessTierTransitionState, LeaseStatusType? leaseStatus, LeaseStateType? leaseState, LeaseDurationType? leaseDuration, string enabledProtocols, ShareRootSquash? rootSquash)
        {
            LastModified = lastModified;
            Etag = etag;
            Quota = quota;
            ProvisionedIops = provisionedIops;
            ProvisionedIngressMBps = provisionedIngressMBps;
            ProvisionedEgressMBps = provisionedEgressMBps;
            NextAllowedQuotaDowngradeTime = nextAllowedQuotaDowngradeTime;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            AccessTier = accessTier;
            AccessTierChangeTime = accessTierChangeTime;
            AccessTierTransitionState = accessTierTransitionState;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            EnabledProtocols = enabledProtocols;
            RootSquash = rootSquash;
        }

        public DateTimeOffset LastModified { get; }
        public string Etag { get; }
        public int Quota { get; }
        public int? ProvisionedIops { get; }
        public int? ProvisionedIngressMBps { get; }
        public int? ProvisionedEgressMBps { get; }
        public DateTimeOffset? NextAllowedQuotaDowngradeTime { get; }
        public DateTimeOffset? DeletedTime { get; }
        public int? RemainingRetentionDays { get; }
        public string AccessTier { get; }
        public DateTimeOffset? AccessTierChangeTime { get; }
        public string AccessTierTransitionState { get; }
        /// <summary> The current lease status of the share. </summary>
        public LeaseStatusType? LeaseStatus { get; }
        /// <summary> Lease state of the share. </summary>
        public LeaseStateType? LeaseState { get; }
        /// <summary> When a share is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public LeaseDurationType? LeaseDuration { get; }
        public string EnabledProtocols { get; }
        public ShareRootSquash? RootSquash { get; }
    }
}
