﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Files.Shares;

namespace Azure.Storage.DataMovement.Files.Shares
{
    internal class ShareDirectoryStorageResourceContainer : StorageResourceContainer
    {
        internal ShareFileStorageResourceOptions ResourceOptions { get; set; }
        internal PathScanner PathScanner { get; set; }

        internal ShareDirectoryClient ShareDirectoryClient { get; }

        public override Uri Uri => ShareDirectoryClient.Uri;

        internal ShareDirectoryStorageResourceContainer(ShareDirectoryClient shareDirectoryClient, ShareFileStorageResourceOptions options)
        {
            ShareDirectoryClient = shareDirectoryClient;
            ResourceOptions = options;
        }

        protected override StorageResourceItem GetStorageResourceReference(string path)
        {
            List<string> pathSegments = path.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToList();
            ShareDirectoryClient dir = ShareDirectoryClient;
            foreach (string pathSegment in pathSegments.Take(pathSegments.Count - 1))
            {
                dir = dir.GetSubdirectoryClient(pathSegment);
            }
            ShareFileClient file = dir.GetFileClient(pathSegments.Last());
            return new ShareFileStorageResourceItem(file, ResourceOptions);
        }

        protected override async IAsyncEnumerable<StorageResource> GetStorageResourcesAsync(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (ShareFileClient client in PathScanner.ScanFilesAsync(
                ShareDirectoryClient, cancellationToken).ConfigureAwait(false))
            {
                yield return new ShareFileStorageResourceItem(client, ResourceOptions);
            }
        }

        #region Protected Hooks
        // Internal func to access protected member for testing.
        internal async IAsyncEnumerable<StorageResource> GetStorageResourcesInternal(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (StorageResource resource in GetStorageResourcesAsync(cancellationToken).ConfigureAwait(false))
            {
                yield return resource;
            }
        }

        internal StorageResourceItem GetStorageResourceReferenceInternal(string path)
            => GetStorageResourceReference(path);
        #endregion
    }
}
