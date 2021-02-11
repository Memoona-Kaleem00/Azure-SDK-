﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using Azure.Storage.Blobs.Models;
using Tags = System.Collections.Generic.IDictionary<string, string>;
using Azure.Core;
using System.IO;
using System.Globalization;

namespace Azure.Storage.Blobs
{
    internal static partial class BlobExtensions
    {
        #region Tags
        internal static IDictionary<string, string> ToTagDictionary(this BlobTags blobTags)
        {
            if (blobTags?.BlobTagSet == null)
            {
                return null;
            }
            Dictionary<string, string> tags = new Dictionary<string, string>();
            foreach (BlobTag blobTag in blobTags.BlobTagSet)
            {
                tags[blobTag.Key] = blobTag.Value;
            }

            return tags;
        }

        internal static BlobTags ToBlobTags(this Tags tags)
        {
            if (tags == null)
            {
                return null;
            }
            IEnumerable<BlobTag> blobTags = tags.Select(tag => new BlobTag(tag.Key, tag.Value));
            return new BlobTags(blobTags);
        }

        internal static string ToTagsString(this Tags tags)
        {
            if (tags == null)
            {
                return null;
            }

            List<string> encodedTags = new List<string>();
            foreach (KeyValuePair<string, string> tag in tags)
            {
                encodedTags.Add($"{WebUtility.UrlEncode(tag.Key)}={WebUtility.UrlEncode(tag.Value)}");
            }
            return string.Join("&", encodedTags);
        }

        internal static TaggedBlobItem ToBlobTagItem(this FilterBlobItem filterBlobItem)
        {
            if (filterBlobItem == null)
            {
                return null;
            }

            return new TaggedBlobItem
            {
                BlobName = filterBlobItem.Name,
                BlobContainerName = filterBlobItem.ContainerName,
                Tags = filterBlobItem.Tags.ToTagDictionary()
            };
        }

        internal static List<TaggedBlobItem> ToBlobTagItems(this IEnumerable<FilterBlobItem> filterBlobItems)
        {
            if (filterBlobItems == null)
            {
                return null;
            }

            List<TaggedBlobItem> list = new List<TaggedBlobItem>();

            foreach (FilterBlobItem filterBlobItem in filterBlobItems)
            {
                list.Add(filterBlobItem.ToBlobTagItem());
            }

            return list;
        }
        #endregion

        #region ORS
        /// <summary>
        /// Internal. Parses Object Replication Policy ID from Rule ID and sets the Policy ID for source blobs.
        /// </summary>
        /// <param name="OrIds">
        /// Unparsed Object Replication headers.
        /// For source blobs, the dictionary will contain keys that contain the policy id and rule id separated
        /// by a underscore (e.g. policyId_ruleId). The value of these keys will be the replication status (e.g. Complete, Failed).
        /// For destination blobs, the dictionary will contain one entry where the key will be "policy-id"
        /// and the value will be the destination policy id. No parsing will be required for this.
        /// </param>
        /// <returns>
        /// If the blob has object replication policy(s) applied and is the source blob, this method will return a
        /// List of <see cref="ObjectReplicationPolicy"/>, which contains the Policy ID and the respective
        /// rule(s) and replication status(s) for each policy.
        /// If the blob has object replication policy applied and is the destination blob,
        /// this method will return default as the policy id should be set in ObjectReplicationDestinationPolicyId
        /// (e.g. <see cref="BlobProperties.ObjectReplicationDestinationPolicyId"/>,<see cref="BlobDownloadDetails.ObjectReplicationDestinationPolicyId"/>).
        /// </returns>
        internal static IList<ObjectReplicationPolicy> ParseObjectReplicationIds(this IDictionary<string, string> OrIds)
        {
            try
            {
                // If the dictionary contains a key with policy id, we are not required to do any parsing since
                // the policy id should already be stored in the ObjectReplicationDestinationPolicyId.
                KeyValuePair<string, string> destPolicy = OrIds.Single(id => (id.Key == "policy-id"));
                return default;
            }
            catch (Exception)
            {
                // If an exception is thrown by Single then we have confirmed that there's not a policy id already
                // stored in the ObjectReplicationDestinationPolicyId and that we have the unparsed
                // Object Replication headers from the source blob.
            }
            List<ObjectReplicationPolicy> OrProperties = new List<ObjectReplicationPolicy>();
            foreach (KeyValuePair<string, string> status in OrIds)
            {
                string[] parsedIds = status.Key.Split('_');
                int policyIndex = OrProperties.FindIndex(policy => policy.PolicyId == parsedIds[0]);
                if (policyIndex > -1)
                {
                    OrProperties[policyIndex].Rules.Add(new ObjectReplicationRule()
                    {
                        RuleId = parsedIds[1],
                        ReplicationStatus = (ObjectReplicationStatus)Enum.Parse(typeof(ObjectReplicationStatus), status.Value, true)
                    });
                }
                else
                {
                    IList<ObjectReplicationRule> NewRuleStatus = new List<ObjectReplicationRule>();
                    NewRuleStatus.Add(new ObjectReplicationRule()
                    {
                        RuleId = parsedIds[1],
                        ReplicationStatus = (ObjectReplicationStatus)Enum.Parse(typeof(ObjectReplicationStatus), status.Value, true)
                    });
                    OrProperties.Add(new ObjectReplicationPolicy()
                    {
                        PolicyId = parsedIds[0],
                        Rules = NewRuleStatus
                    });
                }
            }
            return OrProperties;
        }

        /// <summary>
        /// Internal. Parses Object Replication Policy ID from Rule ID and sets the Policy ID for source blobs.
        /// </summary>
        /// <param name="OrMetadata">
        /// Unparsed Object Replication headers.
        /// For source blobs, the dictionary will contain keys that are prefixed with "or-" and followed by the
        /// policy id and rule id separated by a underscore (e.g. or-policyId_ruleId).
        /// The value of this metadata key will be the replication status (e.g. Complete, Failed).
        /// </param>
        /// <returns>
        /// If the blob has object replication policy(s) applied and is the source blob, this method will return a
        /// List of <see cref="ObjectReplicationPolicy"/>, which contains the Policy ID and the respective
        /// rule(s) and replication status(s) for each policy.
        /// </returns>
        internal static IList<ObjectReplicationPolicy> ParseObjectReplicationMetadata(this IReadOnlyDictionary<string, string> OrMetadata)
        {
            List<ObjectReplicationPolicy> OrProperties = new List<ObjectReplicationPolicy>();
            foreach (KeyValuePair<string, string> status in OrMetadata)
            {
                string[] parsedIds = status.Key.Split('_');
                if (parsedIds[0].StartsWith("or-", System.StringComparison.InvariantCulture))
                {
                    parsedIds[0] = parsedIds[0].Substring("or-".Length);
                }
                int policyIndex = OrProperties.FindIndex(policy => policy.PolicyId == parsedIds[0]);
                if (policyIndex > -1)
                {
                    OrProperties[policyIndex].Rules.Add(new ObjectReplicationRule()
                    {
                        RuleId = parsedIds[1],
                        ReplicationStatus = (ObjectReplicationStatus)Enum.Parse(typeof(ObjectReplicationStatus), status.Value, true)
                    });
                }
                else
                {
                    IList<ObjectReplicationRule> NewRuleStatus = new List<ObjectReplicationRule>();
                    NewRuleStatus.Add(new ObjectReplicationRule()
                    {
                        RuleId = parsedIds[1],
                        ReplicationStatus = (ObjectReplicationStatus)Enum.Parse(typeof(ObjectReplicationStatus), status.Value, true)
                    });
                    OrProperties.Add(new ObjectReplicationPolicy()
                    {
                        PolicyId = parsedIds[0],
                        Rules = NewRuleStatus
                    });
                }
            }
            return OrProperties;
        }
        #endregion

        #region ToRehydratePriority
        internal static RehydratePriority? ToRehydratePriority(this string rehydratePriority)
        {
            if (rehydratePriority == null)
            {
                return null;
            }

            if (rehydratePriority == RehydratePriority.High.ToString())
            {
                return RehydratePriority.High;
            }
            else
            {
                return RehydratePriority.Standard;
            }
        }
        #endregion

        #region ToAccountInfo
        internal static AccountInfo ToAccountInfo(this ResponseWithHeaders<ServiceGetAccountInfoHeaders> response)
        {
            if (response == null)
            {
                return null;
            }
            return new AccountInfo
            {
                SkuName = response.Headers.SkuName.GetValueOrDefault(),
                AccountKind = response.Headers.AccountKind.GetValueOrDefault(),
                IsHierarchicalNamespaceEnabled = response.Headers.IsHierarchicalNamespaceEnabled.GetValueOrDefault()
            };
        }
        #endregion

        #region ToBlobContainerInfo
        // TODO
        internal static BlobContainerInfo ToBlobContainerInfo(this ResponseWithHeaders<ContainerCreateHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobContainerAccessPolicy
        internal static BlobContainerAccessPolicy ToBlobContainerAccessPolicy(
            this ResponseWithHeaders<IReadOnlyList<BlobSignedIdentifier>, ContainerGetAccessPolicyHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobContainerAccessPolicy
            {
                BlobPublicAccess = response.Headers.BlobPublicAccess.GetValueOrDefault(),
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                SignedIdentifiers = response.Value.ToList()
            };
        }
        #endregion

        #region ToBlobContainerInfo
        internal static BlobContainerInfo ToBlobContainerInfo(this ResponseWithHeaders<ContainerSetAccessPolicyHeaders> response)
        {
            if (response == null)
            {
                return null;
            }
            return new BlobContainerInfo
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
            };
        }

        internal static BlobContainerInfo ToBlobContainerInfo(this ResponseWithHeaders<ContainerSetMetadataHeaders> response)
        {
            if (response == null)
            {
                return null;
            }
            return new BlobContainerInfo
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
            };
        }
        #endregion

        #region ToBlobContentInfo
        internal static BlobContentInfo ToBlobContentInfo(this ResponseWithHeaders<AppendBlobCreateHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobContentInfo
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                ContentHash = response.Headers.ContentMD5,
                VersionId = response.Headers.VersionId,
                EncryptionKeySha256 = response.Headers.EncryptionKeySha256,
                EncryptionScope = response.Headers.EncryptionScope,
                //BlobSequenceNumber is not returned by Append Blobs.
            };
        }

        internal static BlobContentInfo ToBlobContentInfo(this ResponseWithHeaders<PageBlobCreateHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobContentInfo
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                ContentHash = response.Headers.ContentMD5,
                VersionId = response.Headers.VersionId,
                EncryptionKeySha256 = response.Headers.EncryptionKeySha256,
                EncryptionScope = response.Headers.EncryptionScope,
                // TODO
                //BlobSequenceNumber = response.Headers.Blob
            };
        }
        #endregion

        #region ToBlobAppendInfo
        // TODO
        internal static BlobAppendInfo ToBlobAppendInfo(this ResponseWithHeaders<AppendBlobAppendBlockHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobAppendInfo
        // TODO
        internal static BlobAppendInfo ToBlobAppendInfo(this ResponseWithHeaders<AppendBlobAppendBlockFromUrlHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobInfo
        // TODO
        internal static BlobInfo ToBlobInfo(this ResponseWithHeaders<AppendBlobSealHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToPageInfo
        // TODO
        internal static PageInfo ToPageInfo(this ResponseWithHeaders<PageBlobUploadPagesHeaders> response)
        {
            return null;
        }

        // TODO
        internal static PageInfo ToPageInfo(this ResponseWithHeaders<PageBlobClearPagesHeaders> response)
        {
            return null;
        }

        // TODO
        internal static PageInfo ToPageInfo(this ResponseWithHeaders<PageBlobUploadPagesFromURLHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToPageRangesInfo
        // TODO
        internal static PageRangesInfo ToPageRangesInfo(this ResponseWithHeaders<PageList, PageBlobGetPageRangesHeaders> response)
        {
            return null;
        }

        // TODO
        internal static PageRangesInfo ToPageRangesInfo(this ResponseWithHeaders<PageList, PageBlobGetPageRangesDiffHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToPageBlobInfo
        // TODO
        internal static PageBlobInfo ToPageBlobInfo(this ResponseWithHeaders<PageBlobResizeHeaders> response)
        {
            return null;
        }

        // TODO
        internal static PageBlobInfo ToPageBlobInfo(this ResponseWithHeaders<PageBlobUpdateSequenceNumberHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlockInfo
        // TODO
        internal static BlockInfo ToBlockInfo(this ResponseWithHeaders<BlockBlobStageBlockHeaders> response)
        {
            return null;
        }

        // TODO
        internal static BlockInfo ToBlockInfo(this ResponseWithHeaders<BlockBlobStageBlockFromURLHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobContentInfo
        // TODO
        internal static BlobContentInfo ToBlobContentInfo(this ResponseWithHeaders<BlockBlobCommitBlockListHeaders> response)
        {
            return null;
        }

        // TODO
        internal static BlobContentInfo ToBlobContentInfo(this ResponseWithHeaders<BlockBlobPutBlobFromUrlHeaders> response)
        {
            return null;
        }

        // TODO
        internal static BlobContentInfo ToBlobContentInfo(this ResponseWithHeaders<BlockBlobUploadHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlockList
        // TODO
        internal static BlockList ToBlockList(this ResponseWithHeaders<BlockList, BlockBlobGetBlockListHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobDownloadInfo
        // TODO
#pragma warning disable CA1801 // Review unused parameters
        internal static BlobDownloadInfo ToBlobDownloadInfo(ResponseWithHeaders<Stream, BlobQueryHeaders> response, Stream stream)
#pragma warning restore CA1801 // Review unused parameters
        {
            return null;
        }
        #endregion

        #region ToBlobSnapshotInfo
        internal static BlobSnapshotInfo ToBlobSnapshotInfo(this ResponseWithHeaders<BlobCreateSnapshotHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobSnapshotInfo
            {
                Snapshot = response.Headers.Snapshot,
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                VersionId = response.Headers.VersionId,
                IsServerEncrypted = response.Headers.IsServerEncrypted.GetValueOrDefault()
            };
        }
        #endregion

        #region ToBlobInfo
        internal static BlobInfo ToBlobInfo(this ResponseWithHeaders<BlobSetMetadataHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobInfo
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                // TODO
                //BlobSequenceNumber = response.Headers
                VersionId = response.Headers.VersionId
            };
        }

        internal static BlobInfo ToBlobInfo(this ResponseWithHeaders<BlobSetHttpHeadersHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobInfo
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                // TODO
                //BlobSequenceNumber = response.Headers
                //VersionId = response.Headers.VersionId
            };
        }
        #endregion

        #region ToBlobProperties
        // TODO
        internal static BlobProperties ToBlobProperties(this ResponseWithHeaders<BlobGetPropertiesHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobProperties
            {
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                CreatedOn = response.Headers.CreationTime.GetValueOrDefault(),
                Metadata = response.Headers.Metadata,
                ObjectReplicationDestinationPolicyId = response.Headers.ObjectReplicationPolicyId,
                ObjectReplicationSourceProperties =
                    response.Headers.ObjectReplicationRules?.Count > 0
                    ? BlobExtensions.ParseObjectReplicationIds(response.Headers.ObjectReplicationRules)
                    : null,
                BlobType = response.Headers.BlobType.GetValueOrDefault(),
                CopyCompletedOn = response.Headers.CopyCompletionTime.GetValueOrDefault(),
                CopyStatusDescription = response.Headers.CopyStatusDescription,
                CopyId = response.Headers.CopyId,
                CopyProgress = response.Headers.CopyProgress,
                CopySource = response.Headers.CopySource == null ? null : new Uri(response.Headers.CopySource),
                CopyStatus = response.Headers.CopyStatus.GetValueOrDefault(),
                IsIncrementalCopy = response.Headers.IsIncrementalCopy.GetValueOrDefault(),
                DestinationSnapshot = response.Headers.DestinationSnapshot,
                LeaseDuration = response.Headers.LeaseDuration.GetValueOrDefault(),
                LeaseState = response.Headers.LeaseState.GetValueOrDefault(),
                LeaseStatus = response.Headers.LeaseStatus.GetValueOrDefault(),
                ContentLength = response.Headers.ContentLength.GetValueOrDefault(),
                ContentType = response.Headers.ContentType,
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                ContentHash = response.Headers.ContentMD5,
                ContentEncoding = response.Headers.ContentEncoding,
                ContentDisposition = response.Headers.ContentDisposition,
                ContentLanguage = response.Headers.ContentLanguage,
                CacheControl = response.Headers.CacheControl,
                BlobSequenceNumber = response.Headers.BlobSequenceNumber.GetValueOrDefault(),
                AcceptRanges = response.Headers.AcceptRanges,
                BlobCommittedBlockCount = response.Headers.BlobCommittedBlockCount.GetValueOrDefault(),
                IsServerEncrypted = response.Headers.IsServerEncrypted.GetValueOrDefault(),
                EncryptionKeySha256 = response.Headers.EncryptionKeySha256,
                EncryptionScope = response.Headers.EncryptionScope,
                AccessTier = response.Headers.AccessTier,
                AccessTierInferred = response.Headers.AccessTierInferred.GetValueOrDefault(),
                ArchiveStatus = response.Headers.ArchiveStatus,
                AccessTierChangedOn = response.Headers.AccessTierChangeTime.GetValueOrDefault(),
                VersionId = response.Headers.VersionId,
                TagCount = response.Headers.TagCount.GetValueOrDefault(),
                ExpiresOn = response.Headers.ExpiresOn.GetValueOrDefault(),
                IsSealed = response.Headers.IsSealed.GetValueOrDefault(),
                RehydratePriority = response.Headers.RehydratePriority,
                LastAccessed = response.Headers.LastAccessed.GetValueOrDefault()
            };
        }
        #endregion

        #region ToBlobCopyInfo
        // TODO
        internal static BlobCopyInfo ToBlobCopyInfo(this ResponseWithHeaders<BlobCopyFromURLHeaders> response)
        {
            return null;
        }

        // TODO
        internal static BlobCopyInfo ToBlobCopyInfo(this ResponseWithHeaders<BlobStartCopyFromURLHeaders> response)
        {
            return null;
        }

        // TODO
        internal static BlobCopyInfo ToBlobCopyInfo(this ResponseWithHeaders<PageBlobCopyIncrementalHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobDownloadInfo
        // TODO
#pragma warning disable CA1801 // Review unused parameters
        internal static BlobDownloadInfo ToBlobDownloadInfo(ResponseWithHeaders<Stream, BlobDownloadHeaders> response, Stream stream)
#pragma warning restore CA1801 // Review unused parameters
        {
            return null;
        }

        // TODO
        internal static BlobDownloadInfo ToBlobDownloadInfo(this ResponseWithHeaders<Stream, BlobDownloadHeaders> response)
        {
            return null;
        }
        #endregion

        #region ToBlobLease
        internal static BlobLease ToBlobLease(this ResponseWithHeaders<BlobAcquireLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseId = response.Headers.LeaseId,
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<ContainerAcquireLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseId = response.Headers.LeaseId,
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<BlobRenewLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseId = response.Headers.LeaseId,
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<ContainerRenewLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseId = response.Headers.LeaseId,
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<BlobChangeLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseId = response.Headers.LeaseId,
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<ContainerChangeLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseId = response.Headers.LeaseId,
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<BlobBreakLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                // LeaseId is not returned on a broken lease.
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static BlobLease ToBlobLease(this ResponseWithHeaders<ContainerBreakLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobLease
            {
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                // LeaseId is not returned on a broken lease.
                LeaseTime = response.GetRawResponse().Headers.ExtractLeaseTime()
            };
        }

        internal static int? ExtractLeaseTime(this ResponseHeaders responseHeaders)
        {
            int? leaseTime = null;

            if (responseHeaders.TryGetValue(Constants.HeaderNames.LeaseTime, out string leaseTimeString))
            {
                leaseTime = int.Parse(leaseTimeString, CultureInfo.InvariantCulture);
            }

            return leaseTime;
        }
        #endregion

        #region ToReleasedObjectInfo
        internal static ReleasedObjectInfo ToReleasedObjectInfo(this ResponseWithHeaders<BlobReleaseLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new ReleasedObjectInfo(
                eTag: response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                lastModified: response.Headers.LastModified.GetValueOrDefault());
        }

        internal static ReleasedObjectInfo ToReleasedObjectInfo(this ResponseWithHeaders<ContainerReleaseLeaseHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new ReleasedObjectInfo(
                eTag: response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                lastModified: response.Headers.LastModified.GetValueOrDefault());
        }
        #endregion

        #region ToBlobItem
        internal static BlobItem[] ToBlobItems(this IReadOnlyList<BlobItemInternal> blobItemInternals)
        {
            if (blobItemInternals == null)
            {
                return null;
            }

            return blobItemInternals.Select(r => r.ToBlobItem()).ToArray();
        }

        internal static BlobItem ToBlobItem(this BlobItemInternal blobItemInternal)
        {
            if (blobItemInternal == null)
            {
                return null;
            }

            return new BlobItem
            {
                Name = blobItemInternal.Name,
                Deleted = blobItemInternal.Deleted,
                Snapshot = blobItemInternal.Snapshot,
                VersionId = blobItemInternal.VersionId,
                IsLatestVersion = blobItemInternal.IsCurrentVersion,
                Properties = blobItemInternal.Properties.ToBlobItemProperties(),
                Metadata = blobItemInternal.Metadata?.Count > 0
                    ? blobItemInternal.Metadata.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                    : new Dictionary<string, string>(),
                Tags = blobItemInternal.BlobTags.ToTagDictionary(),
                ObjectReplicationSourceProperties = blobItemInternal.ObjectReplicationMetadata?.Count > 0
                    ? ParseObjectReplicationMetadata(blobItemInternal.ObjectReplicationMetadata)
                    : null
            };
        }

        internal static BlobItemProperties ToBlobItemProperties(this BlobPropertiesInternal blobPropertiesInternal)
        {
            if (blobPropertiesInternal == null)
            {
                return null;
            }

            return new BlobItemProperties
            {
                LastModified = blobPropertiesInternal.LastModified,
                ContentLength = blobPropertiesInternal.ContentLength,
                ContentType = blobPropertiesInternal.ContentType,
                ContentEncoding = blobPropertiesInternal.ContentEncoding,
                ContentLanguage = blobPropertiesInternal.ContentLanguage,
                ContentHash = blobPropertiesInternal.ContentMD5,
                ContentDisposition = blobPropertiesInternal.ContentDisposition,
                CacheControl = blobPropertiesInternal.CacheControl,
                BlobSequenceNumber = blobPropertiesInternal.BlobSequenceNumber,
                BlobType = blobPropertiesInternal.BlobType,
                LeaseStatus = blobPropertiesInternal.LeaseStatus,
                LeaseState = blobPropertiesInternal.LeaseState,
                LeaseDuration = blobPropertiesInternal.LeaseDuration,
                CopyId = blobPropertiesInternal.CopyId,
                CopyStatus = blobPropertiesInternal.CopyStatus,
                CopySource = blobPropertiesInternal.CopySource == null ? null : new Uri(blobPropertiesInternal.CopySource),
                CopyProgress = blobPropertiesInternal.CopyProgress,
                CopyStatusDescription = blobPropertiesInternal.CopyStatusDescription,
                ServerEncrypted = blobPropertiesInternal.ServerEncrypted,
                DestinationSnapshot = blobPropertiesInternal.DestinationSnapshot,
                RemainingRetentionDays = blobPropertiesInternal.RemainingRetentionDays,
                AccessTier = blobPropertiesInternal.AccessTier,
                AccessTierInferred = blobPropertiesInternal.AccessTierInferred.GetValueOrDefault(),
                ArchiveStatus = blobPropertiesInternal.ArchiveStatus,
                CustomerProvidedKeySha256 = blobPropertiesInternal.CustomerProvidedKeySha256,
                EncryptionScope = blobPropertiesInternal.EncryptionScope,
                TagCount = blobPropertiesInternal.TagCount,
                ExpiresOn = blobPropertiesInternal.ExpiresOn,
                IsSealed = blobPropertiesInternal.IsSealed,
                RehydratePriority = blobPropertiesInternal.RehydratePriority,
                LastAccessedOn = blobPropertiesInternal.LastAccessedOn,
                // TODO fix this in autorest.md
                ETag = new ETag(blobPropertiesInternal.Etag),
                CreatedOn = blobPropertiesInternal.CreationTime,
                CopyCompletedOn = blobPropertiesInternal.CopyCompletionTime,
                DeletedOn = blobPropertiesInternal.DeletedTime,
                AccessTierChangedOn = blobPropertiesInternal.AccessTierChangeTime
            };
        }

        #endregion

        #region ToBlobContainerItem
        internal static BlobContainerItem[] ToBlobContainerItems(this IReadOnlyList<ContainerItemInternal> containerItemInternals)
        {
            if (containerItemInternals == null)
            {
                return null;
            }

            return containerItemInternals.Select(r => r.ToBlobContainerItem()).ToArray();
        }

        internal static BlobContainerItem ToBlobContainerItem(this ContainerItemInternal containerItemInternal)
        {
            if (containerItemInternal == null)
            {
                return null;
            }

            return new BlobContainerItem
            {
                Name = containerItemInternal.Name,
                IsDeleted = containerItemInternal.Deleted,
                VersionId = containerItemInternal.Version,
                Properties = BlobExtensions.ToBlobContainerProperties(containerItemInternal.Properties, containerItemInternal.Metadata)
            };
        }
        #endregion

        #region ToBlobContainerProperties
        internal static BlobContainerProperties ToBlobContainerProperties(
            ContainerPropertiesInternal containerPropertiesInternal,
            IReadOnlyDictionary<string, string> metadata)
        {
            if (containerPropertiesInternal == null)
            {
                return null;
            }

            return new BlobContainerProperties
            {
                LastModified = containerPropertiesInternal.LastModified,
                LeaseStatus = containerPropertiesInternal.LeaseStatus,
                LeaseState = containerPropertiesInternal.LeaseState,
                LeaseDuration = containerPropertiesInternal.LeaseDuration,
                PublicAccess = containerPropertiesInternal.PublicAccess,
                HasImmutabilityPolicy = containerPropertiesInternal.HasImmutabilityPolicy,
                HasLegalHold = containerPropertiesInternal.HasLegalHold,
                DefaultEncryptionScope = containerPropertiesInternal.DefaultEncryptionScope,
                PreventEncryptionScopeOverride = containerPropertiesInternal.PreventEncryptionScopeOverride,
                DeletedOn = containerPropertiesInternal.DeletedTime,
                RemainingRetentionDays = containerPropertiesInternal.RemainingRetentionDays,
                ETag = new ETag(containerPropertiesInternal.Etag),
                Metadata = metadata?.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
            };
        }

        // TODO
        internal static BlobContainerProperties ToBlobContainerProperties(this ResponseWithHeaders<ContainerGetPropertiesHeaders> response)
        {
            if (response == null)
            {
                return null;
            }

            return new BlobContainerProperties
            {
                LastModified = response.Headers.LastModified.GetValueOrDefault(),
                LeaseStatus = response.Headers.LeaseStatus,
                LeaseState = response.Headers.LeaseState,
                LeaseDuration = response.Headers.LeaseDuration ?? LeaseDurationType.Infinite,
                PublicAccess = response.Headers.BlobPublicAccess,
                HasImmutabilityPolicy = response.Headers.HasImmutabilityPolicy,
                HasLegalHold = response.Headers.HasLegalHold,
                DefaultEncryptionScope = response.Headers.DefaultEncryptionScope,
                PreventEncryptionScopeOverride = response.Headers.DenyEncryptionScopeOverride,
                // TODO
                //DeletedOn =
                //RemainingRetentionDays =
                ETag = response.GetRawResponse().Headers.ETag.GetValueOrDefault(),
                Metadata = response.Headers.Metadata
            };
        }
        #endregion
    }
}
