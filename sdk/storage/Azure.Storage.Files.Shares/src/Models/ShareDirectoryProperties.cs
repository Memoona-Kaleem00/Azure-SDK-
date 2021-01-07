﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable SA1402  // File may only contain a single type

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary>
    /// Properites for a directory.
    /// </summary>
    public class ShareDirectoryProperties
    {
        /// <summary>
        /// A set of name-value pairs that contain metadata for the directory.
        /// </summary>
        public IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// The ETag contains a value that you can use to perform operations conditionally, in quotes.
        /// </summary>
        public ETag ETag { get; internal set; }

        /// <summary>
        /// Returns DateTimeOffest the directory was last modified. Operations on files within the directory
        /// do not affect the last modified time of the directory.
        /// </summary>
        public DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// Set to true if the directory metadata is completely encrypted using the specified algorithm.
        /// Otherwise, the value is set to false.
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// The SMB properties for the directory.
        /// </summary>
        public FileSmbProperties SmbProperties { get; set; }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new StorageDirectoryProperties instance for mocking.
        /// </summary>
        public static ShareDirectoryProperties StorageDirectoryProperties(
                IDictionary<string, string> metadata,
                ETag eTag,
                DateTimeOffset lastModified,
                bool isServerEncrypted,
                string fileAttributes,
                DateTimeOffset fileCreationTime,
                DateTimeOffset fileLastWriteTime,
                DateTimeOffset fileChangeTime,
                string filePermissionKey,
                string fileId,
                string fileParentId
            )
            => new ShareDirectoryProperties(new RawStorageDirectoryProperties()
            {
                Metadata = metadata,
                ETag = eTag,
                LastModified = lastModified,
                IsServerEncrypted = isServerEncrypted,
                FileAttributes = fileAttributes,
                FileCreationTime = fileCreationTime,
                FileLastWriteTime = fileLastWriteTime,
                FileChangeTime = fileChangeTime,
                FilePermissionKey = filePermissionKey,
                FileId = fileId,
                FileParentId = fileParentId
            });
    }
}
