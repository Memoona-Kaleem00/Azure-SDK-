// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> An Azure Storage blob. </summary>
    internal partial class BlobItemInternal
    {
        /// <summary> Initializes a new instance of BlobItemInternal. </summary>
        /// <param name="name"></param>
        /// <param name="deleted"></param>
        /// <param name="snapshot"></param>
        /// <param name="properties"> Properties of a blob. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="snapshot"/> or <paramref name="properties"/> is null. </exception>
        internal BlobItemInternal(BlobName name, bool deleted, string snapshot, BlobPropertiesInternal properties)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Name = name;
            Deleted = deleted;
            Snapshot = snapshot;
            Properties = properties;
            Metadata = new ChangeTrackingDictionary<string, string>();
            OrMetadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of BlobItemInternal. </summary>
        /// <param name="name"></param>
        /// <param name="deleted"></param>
        /// <param name="snapshot"></param>
        /// <param name="versionId"></param>
        /// <param name="isCurrentVersion"></param>
        /// <param name="properties"> Properties of a blob. </param>
        /// <param name="metadata"> Dictionary of &lt;string&gt;. </param>
        /// <param name="blobTags"> Blob tags. </param>
        /// <param name="hasVersionsOnly"></param>
        /// <param name="orMetadata"> Dictionary of &lt;string&gt;. </param>
        internal BlobItemInternal(BlobName name, bool deleted, string snapshot, string versionId, bool? isCurrentVersion, BlobPropertiesInternal properties, IReadOnlyDictionary<string, string> metadata, BlobTags blobTags, bool? hasVersionsOnly, IReadOnlyDictionary<string, string> orMetadata)
        {
            Name = name;
            Deleted = deleted;
            Snapshot = snapshot;
            VersionId = versionId;
            IsCurrentVersion = isCurrentVersion;
            Properties = properties;
            Metadata = metadata;
            BlobTags = blobTags;
            HasVersionsOnly = hasVersionsOnly;
            OrMetadata = orMetadata;
        }

        /// <summary> Gets the name. </summary>
        public BlobName Name { get; }
        /// <summary> Gets the deleted. </summary>
        public bool Deleted { get; }
        /// <summary> Gets the snapshot. </summary>
        public string Snapshot { get; }
        /// <summary> Gets the version id. </summary>
        public string VersionId { get; }
        /// <summary> Gets the is current version. </summary>
        public bool? IsCurrentVersion { get; }
        /// <summary> Properties of a blob. </summary>
        public BlobPropertiesInternal Properties { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
        /// <summary> Blob tags. </summary>
        public BlobTags BlobTags { get; }
        /// <summary> Gets the has versions only. </summary>
        public bool? HasVersionsOnly { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> OrMetadata { get; }
    }
}
