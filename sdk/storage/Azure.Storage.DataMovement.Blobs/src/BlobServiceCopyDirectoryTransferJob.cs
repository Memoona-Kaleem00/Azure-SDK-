﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.DataMovement.Models;
using Azure.Storage.DataMovement.Blobs.Models;
using Azure.Storage.Blobs;
using Azure.Core.Pipeline;

namespace Azure.Storage.DataMovement.Blobs
{
    /// <summary>
    /// TODO; descriptions and comments for this entire class
    /// TODO: Add possible options bag for copy transfer
    /// </summary>
    internal class BlobServiceCopyDirectoryTransferJob : BlobTransferJobInternal
    {
        private Uri _sourceDirectoryUri;

        /// <summary>
        /// Source Directory Uri jobs.
        /// </summary>
        public Uri SourceDirectoryUri => _sourceDirectoryUri;

        internal BlobVirtualDirectoryClient _destinationDirectoryClient;

        /// <summary>
        /// Destination directory for the finished copies
        /// </summary>
        public BlobVirtualDirectoryClient DestinationBlobDirectoryClient => _destinationDirectoryClient;

        /// <summary>
        /// Copy method to choose between StartCopyFromUri or SyncCopyFromUri
        /// </summary>
        internal readonly BlobServiceCopyMethod CopyMethod;

        /// <summary>
        /// The <see cref="BlobDirectoryCopyFromUriOptions"/>.
        /// </summary>
        internal BlobDirectoryCopyFromUriOptions _copyFromUriOptions;

        /// <summary>
        /// Gets the <see cref="BlobDirectoryCopyFromUriOptions"/>.
        /// </summary>
        public BlobDirectoryCopyFromUriOptions CopyFromUriOptions => _copyFromUriOptions;

        /// <summary>
        /// Creates Service Copy Directory Transfer Job
        ///
        /// TODO; better descriptions and update parameter descriptions
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="sourceDirectoryUri"></param>
        /// <param name="destinationClient"></param>
        /// <param name="copyMethod"></param>
        /// <param name="copyFromUriOptions"></param>
        public BlobServiceCopyDirectoryTransferJob(
            string jobId,
            Uri sourceDirectoryUri,
            BlobVirtualDirectoryClient destinationClient,
            BlobServiceCopyMethod copyMethod,
            BlobDirectoryCopyFromUriOptions copyFromUriOptions)
            : base(jobId)
        {
            _sourceDirectoryUri = sourceDirectoryUri;
            _destinationDirectoryClient = destinationClient;
            CopyMethod = copyMethod;
            _copyFromUriOptions = copyFromUriOptions;
        }

        /// <summary>
        /// Gets sing copy job for the job scheduler
        /// </summary>
        /// <param name="blobName"></param>
        /// <returns></returns>
        internal async Task<CopyFromUriOperation> GetSingleAsyncCopyTaskAsync(string blobName)
        {
            //TODO: check if the listing operation gives the full blob path name or just everything but the prefix
            BlobUriBuilder sourceUriBuilder = new BlobUriBuilder(SourceDirectoryUri);
            sourceUriBuilder.BlobName += $"/{blobName}";

            BlockBlobClient blockBlobClient = DestinationBlobDirectoryClient.GetBlockBlobClient(blobName);

            BlobCopyFromUriOptions blobCopyFromUriOptions = new BlobCopyFromUriOptions()
            {
                AccessTier = CopyFromUriOptions.AccessTier,
                RehydratePriority = CopyFromUriOptions.RehydratePriority,
                DestinationImmutabilityPolicy = CopyFromUriOptions.DestinationImmutabilityPolicy,
                LegalHold = CopyFromUriOptions.LegalHold,
                SourceAuthentication = CopyFromUriOptions.SourceAuthentication,
            };

            return await blockBlobClient.StartCopyFromUriAsync(SourceDirectoryUri, blobCopyFromUriOptions).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets sing copy job for the job scheduler
        /// </summary>
        /// <param name="blobName"></param>
        /// <returns></returns>
        internal async Task<Response<BlobCopyInfo>> GetSingleSyncCopyTaskAsync(string blobName)
        {
            //TODO: check if the listing operation gives the full blob path name or just everything but the prefix
            BlobUriBuilder sourceUriBuilder = new BlobUriBuilder(SourceDirectoryUri);
            sourceUriBuilder.BlobName += $"/{blobName}";

            BlockBlobClient blockBlobClient = DestinationBlobDirectoryClient.GetBlockBlobClient(blobName);

            BlobCopyFromUriOptions blobCopyFromUriOptions = new BlobCopyFromUriOptions()
            {
                AccessTier = CopyFromUriOptions.AccessTier,
                RehydratePriority = CopyFromUriOptions.RehydratePriority,
                DestinationImmutabilityPolicy = CopyFromUriOptions.DestinationImmutabilityPolicy,
                LegalHold = CopyFromUriOptions.LegalHold,
                SourceAuthentication = CopyFromUriOptions.SourceAuthentication,
            };

            return await blockBlobClient.SyncCopyFromUriAsync(SourceDirectoryUri, blobCopyFromUriOptions).ConfigureAwait(false);
        }

        /// <summary>
        /// Create next TransferItem/Task to be processed.
        /// </summary>
        /// <param name="blobName">Blob Name in the Source that is to be copied</param>
        /// <param name="async">Defines whether the oepration should be async</param>
        /// <returns>The Task to perform the Upload operation.</returns>
        public Action ProcessSingleCopyTransfer(string blobName, bool async = true)
        {
            return () =>
            {
                BlobUriBuilder sourceUriBuilder = new BlobUriBuilder(SourceDirectoryUri);
                sourceUriBuilder.BlobName += $"/{blobName}";
                Uri sourceBlobUri = sourceUriBuilder.ToUri();

                BlobClient destinationBlobClient = DestinationBlobDirectoryClient.GetBlobClient(blobName);

                // TODO: make logging messages similar to the errors class where we only take in params
                // so we dont have magic strings hanging out here
                Logger.LogAsync(DataMovementLogLevel.Information,
                    $"Processing Single Copy Transfer source: {sourceBlobUri.AbsoluteUri}; destination: {destinationBlobClient.Uri.AbsoluteUri}", async).EnsureCompleted();
                // Do only blockblob upload for now for now
                try
                {
                    BlobCopyFromUriOptions blobCopyFromUriOptions = new BlobCopyFromUriOptions()
                    {
                        AccessTier = CopyFromUriOptions.AccessTier,
                        RehydratePriority = CopyFromUriOptions.RehydratePriority,
                        DestinationImmutabilityPolicy = CopyFromUriOptions.DestinationImmutabilityPolicy,
                        LegalHold = CopyFromUriOptions.LegalHold,
                        SourceAuthentication = CopyFromUriOptions.SourceAuthentication,
                    };

                    if (CopyMethod == BlobServiceCopyMethod.ServiceSideAsyncCopy)
                    {
                        CopyFromUriOperation copyOperation = destinationBlobClient.StartCopyFromUri(sourceBlobUri, blobCopyFromUriOptions);
                        // TODO: Might want to figure out an appropriate delay to poll the wait for completion
                        // TODO: Also might want to cancel this if it takes too long to prevent any threads to be hung up on this operation.
                        copyOperation.WaitForCompletion(CancellationTokenSource.Token);

                        if (copyOperation.HasCompleted && copyOperation.HasValue)
                        {
                            Logger.LogAsync(DataMovementLogLevel.Information, $"Copy Transfer succeeded on from source:{sourceBlobUri.AbsoluteUri} to destination:{destinationBlobClient.Uri.AbsoluteUri}", async).EnsureCompleted();
                        }
                        else
                        {
                            Logger.LogAsync(DataMovementLogLevel.Error, $"Copy Transfer Failed due to unknown reasons. Upload Transfer returned null results", async).EnsureCompleted();
                        }
                    }
                    else //if(CopyMethod == BlobServiceCopyMethod.ServiceSideSyncCopy)
                    {
                        Response<BlobCopyInfo> response = destinationBlobClient.SyncCopyFromUri(sourceBlobUri, blobCopyFromUriOptions);
                        if (response != null && response.Value != null)
                        {
                            Logger.LogAsync(DataMovementLogLevel.Information, $"Copy Transfer succeeded on from source:{sourceBlobUri.AbsoluteUri} to destination:{destinationBlobClient.Uri.AbsoluteUri}", async).EnsureCompleted();
                        }
                        else
                        {
                            Logger.LogAsync(DataMovementLogLevel.Error, $"Copy Transfer Failed due to unknown reasons. Upload Transfer returned null results", async).EnsureCompleted();
                        }
                    }
                }
                //TODO: catch other type of exceptions and handle gracefully
                catch (RequestFailedException ex)
                {
                    Logger.LogAsync(DataMovementLogLevel.Error, $"Upload Transfer Failed due to the following: {ex.ErrorCode}: {ex.Message}", async).EnsureCompleted();
                    // Progress Handling is already done by the upload call
                }
                catch (Exception ex)
                {
                    Logger.LogAsync(DataMovementLogLevel.Error, $"Upload Transfer Failed due to the following: {ex.Message}", async).EnsureCompleted();
                    // Progress Handling is already done by the upload call
                }
            };
        }

        /// <summary>
        /// Translates job details
        /// </summary>
        public override BlobTransferJobProperties GetJobDetails()
        {
            return this.ToBlobTransferJobDetails();
        }
    }
}
