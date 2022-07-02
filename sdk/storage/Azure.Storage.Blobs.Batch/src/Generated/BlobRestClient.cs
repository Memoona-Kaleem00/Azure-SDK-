// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Blobs.Batch.Models;

namespace Azure.Storage.Blobs.Batch
{
    internal partial class BlobRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _snapshot;
        private readonly string _versionId;
        private readonly string _version;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of BlobRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, container, or blob that is the targe of the desired operation. </param>
        /// <param name="snapshot"> The snapshot parameter is an opaque DateTime value that, when present, specifies the blob snapshot to retrieve. For more information on working with blob snapshots, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/creating-a-snapshot-of-a-blob&quot;&gt;Creating a Snapshot of a Blob.&lt;/a&gt;. </param>
        /// <param name="versionId"> The version id parameter is an opaque DateTime value that, when present, specifies the version of the blob to operate on. It&apos;s for service version 2019-10-10 and newer. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public BlobRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string snapshot = null, string versionId = null, string version = "2020-06-12")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _snapshot = snapshot;
            _versionId = versionId;
            _version = version ?? throw new ArgumentNullException(nameof(version));
        }

        internal HttpMessage CreateSetAccessTierRequest(string containerName, string blob, BatchAccessTier tier, int? timeout, BatchRehydratePriority? rehydratePriority, string leaseId, string ifTags)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(containerName, false);
            uri.AppendPath("/", false);
            uri.AppendPath(blob, false);
            uri.AppendQuery("comp", "tier", true);
            if (_snapshot != null)
            {
                uri.AppendQuery("snapshot", _snapshot, true);
            }
            if (_versionId != null)
            {
                uri.AppendQuery("versionid", _versionId, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-access-tier", tier.ToString());
            if (rehydratePriority != null)
            {
                request.Headers.Add("x-ms-rehydrate-priority", rehydratePriority.Value.ToString());
            }
            request.Headers.Add("x-ms-version", _version);
            if (leaseId != null)
            {
                request.Headers.Add("x-ms-lease-id", leaseId);
            }
            if (ifTags != null)
            {
                request.Headers.Add("x-ms-if-tags", ifTags);
            }
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The Set Tier operation sets the tier on a blob. The operation is allowed on a page blob in a premium storage account and on a block blob in a blob storage account (locally redundant storage only). A premium page blob&apos;s tier determines the allowed size, IOPS, and bandwidth of the blob. A block blob&apos;s tier determines Hot/Cool/Archive storage type. This operation does not update the blob&apos;s ETag. </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="blob"> The blob name. </param>
        /// <param name="tier"> Indicates the tier to be set on the blob. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations&quot;&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="rehydratePriority"> Optional: Indicates the priority with which to rehydrate an archived blob. </param>
        /// <param name="leaseId"> If specified, the operation only succeeds if the resource&apos;s lease is active and matches this ID. </param>
        /// <param name="ifTags"> Specify a SQL where clause on blob tags to operate only on blobs with a matching value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blob"/> is null. </exception>
        public async Task<ResponseWithHeaders<BlobSetAccessTierHeaders>> SetAccessTierAsync(string containerName, string blob, BatchAccessTier tier, int? timeout = null, BatchRehydratePriority? rehydratePriority = null, string leaseId = null, string ifTags = null, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            using var message = CreateSetAccessTierRequest(containerName, blob, tier, timeout, rehydratePriority, leaseId, ifTags);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new BlobSetAccessTierHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The Set Tier operation sets the tier on a blob. The operation is allowed on a page blob in a premium storage account and on a block blob in a blob storage account (locally redundant storage only). A premium page blob&apos;s tier determines the allowed size, IOPS, and bandwidth of the blob. A block blob&apos;s tier determines Hot/Cool/Archive storage type. This operation does not update the blob&apos;s ETag. </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="blob"> The blob name. </param>
        /// <param name="tier"> Indicates the tier to be set on the blob. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations&quot;&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="rehydratePriority"> Optional: Indicates the priority with which to rehydrate an archived blob. </param>
        /// <param name="leaseId"> If specified, the operation only succeeds if the resource&apos;s lease is active and matches this ID. </param>
        /// <param name="ifTags"> Specify a SQL where clause on blob tags to operate only on blobs with a matching value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blob"/> is null. </exception>
        public ResponseWithHeaders<BlobSetAccessTierHeaders> SetAccessTier(string containerName, string blob, BatchAccessTier tier, int? timeout = null, BatchRehydratePriority? rehydratePriority = null, string leaseId = null, string ifTags = null, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            using var message = CreateSetAccessTierRequest(containerName, blob, tier, timeout, rehydratePriority, leaseId, ifTags);
            _pipeline.Send(message, cancellationToken);
            var headers = new BlobSetAccessTierHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string containerName, string blob, int? timeout, string leaseId, DeleteSnapshotsOptionType? deleteSnapshots, DateTimeOffset? ifModifiedSince, DateTimeOffset? ifUnmodifiedSince, string ifMatch, string ifNoneMatch, string ifTags, BlobDeleteType? blobDeleteType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(containerName, false);
            uri.AppendPath("/", false);
            uri.AppendPath(blob, false);
            if (_snapshot != null)
            {
                uri.AppendQuery("snapshot", _snapshot, true);
            }
            if (_versionId != null)
            {
                uri.AppendQuery("versionid", _versionId, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            if (blobDeleteType != null)
            {
                uri.AppendQuery("deletetype", blobDeleteType.Value.ToSerialString(), true);
            }
            request.Uri = uri;
            if (leaseId != null)
            {
                request.Headers.Add("x-ms-lease-id", leaseId);
            }
            if (deleteSnapshots != null)
            {
                request.Headers.Add("x-ms-delete-snapshots", deleteSnapshots.Value.ToSerialString());
            }
            if (ifModifiedSince != null)
            {
                request.Headers.Add("If-Modified-Since", ifModifiedSince.Value, "R");
            }
            if (ifUnmodifiedSince != null)
            {
                request.Headers.Add("If-Unmodified-Since", ifUnmodifiedSince.Value, "R");
            }
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            if (ifTags != null)
            {
                request.Headers.Add("x-ms-if-tags", ifTags);
            }
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> If the storage account&apos;s soft delete feature is disabled then, when a blob is deleted, it is permanently removed from the storage account. If the storage account&apos;s soft delete feature is enabled, then, when a blob is deleted, it is marked for deletion and becomes inaccessible immediately. However, the blob service retains the blob or snapshot for the number of days specified by the DeleteRetentionPolicy section of [Storage service properties] (Set-Blob-Service-Properties.md). After the specified number of days has passed, the blob&apos;s data is permanently removed from the storage account. Note that you continue to be charged for the soft-deleted blob&apos;s storage until it is permanently removed. Use the List Blobs API and specify the &quot;include=deleted&quot; query parameter to discover which blobs and snapshots have been soft deleted. You can then use the Undelete Blob API to restore a soft-deleted blob. All other operations on a soft-deleted blob or snapshot causes the service to return an HTTP status code of 404 (ResourceNotFound). </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="blob"> The blob name. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations&quot;&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="leaseId"> If specified, the operation only succeeds if the resource&apos;s lease is active and matches this ID. </param>
        /// <param name="deleteSnapshots"> Required if the blob has associated snapshots. Specify one of the following two options: include: Delete the base blob and all of its snapshots. only: Delete only the blob&apos;s snapshots and not the blob itself. </param>
        /// <param name="ifModifiedSince"> Specify this header value to operate only on a blob if it has been modified since the specified date/time. </param>
        /// <param name="ifUnmodifiedSince"> Specify this header value to operate only on a blob if it has not been modified since the specified date/time. </param>
        /// <param name="ifMatch"> Specify an ETag value to operate only on blobs with a matching value. </param>
        /// <param name="ifNoneMatch"> Specify an ETag value to operate only on blobs without a matching value. </param>
        /// <param name="ifTags"> Specify a SQL where clause on blob tags to operate only on blobs with a matching value. </param>
        /// <param name="blobDeleteType"> Optional.  Only possible value is &apos;permanent&apos;, which specifies to permanently delete a blob if blob soft delete is enabled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blob"/> is null. </exception>
        public async Task<ResponseWithHeaders<BlobDeleteHeaders>> DeleteAsync(string containerName, string blob, int? timeout = null, string leaseId = null, DeleteSnapshotsOptionType? deleteSnapshots = null, DateTimeOffset? ifModifiedSince = null, DateTimeOffset? ifUnmodifiedSince = null, string ifMatch = null, string ifNoneMatch = null, string ifTags = null, BlobDeleteType? blobDeleteType = null, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            using var message = CreateDeleteRequest(containerName, blob, timeout, leaseId, deleteSnapshots, ifModifiedSince, ifUnmodifiedSince, ifMatch, ifNoneMatch, ifTags, blobDeleteType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new BlobDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> If the storage account&apos;s soft delete feature is disabled then, when a blob is deleted, it is permanently removed from the storage account. If the storage account&apos;s soft delete feature is enabled, then, when a blob is deleted, it is marked for deletion and becomes inaccessible immediately. However, the blob service retains the blob or snapshot for the number of days specified by the DeleteRetentionPolicy section of [Storage service properties] (Set-Blob-Service-Properties.md). After the specified number of days has passed, the blob&apos;s data is permanently removed from the storage account. Note that you continue to be charged for the soft-deleted blob&apos;s storage until it is permanently removed. Use the List Blobs API and specify the &quot;include=deleted&quot; query parameter to discover which blobs and snapshots have been soft deleted. You can then use the Undelete Blob API to restore a soft-deleted blob. All other operations on a soft-deleted blob or snapshot causes the service to return an HTTP status code of 404 (ResourceNotFound). </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="blob"> The blob name. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations&quot;&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="leaseId"> If specified, the operation only succeeds if the resource&apos;s lease is active and matches this ID. </param>
        /// <param name="deleteSnapshots"> Required if the blob has associated snapshots. Specify one of the following two options: include: Delete the base blob and all of its snapshots. only: Delete only the blob&apos;s snapshots and not the blob itself. </param>
        /// <param name="ifModifiedSince"> Specify this header value to operate only on a blob if it has been modified since the specified date/time. </param>
        /// <param name="ifUnmodifiedSince"> Specify this header value to operate only on a blob if it has not been modified since the specified date/time. </param>
        /// <param name="ifMatch"> Specify an ETag value to operate only on blobs with a matching value. </param>
        /// <param name="ifNoneMatch"> Specify an ETag value to operate only on blobs without a matching value. </param>
        /// <param name="ifTags"> Specify a SQL where clause on blob tags to operate only on blobs with a matching value. </param>
        /// <param name="blobDeleteType"> Optional.  Only possible value is &apos;permanent&apos;, which specifies to permanently delete a blob if blob soft delete is enabled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blob"/> is null. </exception>
        public ResponseWithHeaders<BlobDeleteHeaders> Delete(string containerName, string blob, int? timeout = null, string leaseId = null, DeleteSnapshotsOptionType? deleteSnapshots = null, DateTimeOffset? ifModifiedSince = null, DateTimeOffset? ifUnmodifiedSince = null, string ifMatch = null, string ifNoneMatch = null, string ifTags = null, BlobDeleteType? blobDeleteType = null, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            using var message = CreateDeleteRequest(containerName, blob, timeout, leaseId, deleteSnapshots, ifModifiedSince, ifUnmodifiedSince, ifMatch, ifNoneMatch, ifTags, blobDeleteType);
            _pipeline.Send(message, cancellationToken);
            var headers = new BlobDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
