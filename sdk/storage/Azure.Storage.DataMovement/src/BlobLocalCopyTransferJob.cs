﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.DataMovement.Models;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// TODO; descriptions and comments for this entire class
    /// TODO: Add possible options bag for copy transfer
    /// </summary>
    internal class BlobLocalCopyTransferJob : StorageTransferJob
    {
        internal BlobBaseClient _destinationBlobClient;

        public BlobBaseClient destinationBlobClient => _destinationBlobClient;

        private BlobBaseClient _sourceBlobClient;

        public BlobBaseClient sourceBlobClient => _sourceBlobClient;

        /// <summary>
        /// The <see cref="BlobSyncCopyOptions"/>.
        /// </summary>
        internal BlobSyncCopyOptions _copyOptions;
        /// <summary>
        /// Gets the <see cref="BlobSyncCopyOptions"/>.
        /// </summary>
        public BlobSyncCopyOptions copyOptions => _copyOptions;

        /// <summary>
        /// Creates Single Copy Transfer Job
        ///
        /// TODO: better description and param descriptions.
        /// </summary>
        /// <param name="sourceClient"></param>
        /// <param name="destinationClient"></param>
        /// <param name="copyOptions"></param>
        /// <param name="cancellationToken"></param>
        public BlobLocalCopyTransferJob(
            BlobBaseClient sourceClient,
            BlobBaseClient destinationClient,
            BlobSyncCopyOptions copyOptions,
            CancellationToken cancellationToken)
        {
            _sourceBlobClient = sourceClient;
            _destinationBlobClient = destinationClient;
            _copyOptions = copyOptions;
            CancellationToken = cancellationToken;
        }

        /// <summary>
        /// Create next TransferItem/Task to be processed.
        /// </summary>
        /// <returns>The Task to perform the Upload operation.</returns>
        public override Task CreateTransferTaskAsync()
        {
            // TODO: implement download the blob and store it and upload to the destination.
            return Task.CompletedTask;
        }
    }
}
