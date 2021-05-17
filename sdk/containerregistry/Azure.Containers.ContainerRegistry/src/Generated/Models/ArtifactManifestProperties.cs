// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest attributes details. </summary>
    public partial class ArtifactManifestProperties
    {
        /// <summary> Initializes a new instance of ArtifactManifestProperties. </summary>
        /// <param name="digest"> Manifest. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="digest"/> is null. </exception>
        internal ArtifactManifestProperties(string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn)
        {
            if (digest == null)
            {
                throw new ArgumentNullException(nameof(digest));
            }

            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ManifestReferences = new ChangeTrackingList<ArtifactManifestReference>();
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ArtifactManifestProperties. </summary>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="digest"> Manifest. </param>
        /// <param name="size"> Image size. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        /// <param name="manifestReferences"> List of manifests referenced by this manifest list.  List will be empty if this manifest is not a manifest list. </param>
        /// <param name="tags"> List of tags. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <param name="quarantineState"> Quarantine state. </param>
        /// <param name="quarantineDetails"> Quarantine details. </param>
        internal ArtifactManifestProperties(string repositoryName, string digest, long? size, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, ArtifactArchitecture? architecture, ArtifactOperatingSystem? operatingSystem, IReadOnlyList<ArtifactManifestReference> manifestReferences, IReadOnlyList<string> tags, bool? canDelete, bool? canWrite, bool? canList, bool? canRead, string quarantineState, string quarantineDetails)
        {
            RepositoryName = repositoryName;
            Digest = digest;
            Size = size;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Architecture = architecture;
            OperatingSystem = operatingSystem;
            ManifestReferences = manifestReferences;
            Tags = tags;
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
            QuarantineState = quarantineState;
            QuarantineDetails = quarantineDetails;
        }

        /// <summary> Repository name. </summary>
        public string RepositoryName { get; }
        /// <summary> Manifest. </summary>
        public string Digest { get; }
        /// <summary> Image size. </summary>
        public long? Size { get; }
        /// <summary> Created time. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Last update time. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> CPU architecture. </summary>
        public ArtifactArchitecture? Architecture { get; }
        /// <summary> Operating system. </summary>
        public ArtifactOperatingSystem? OperatingSystem { get; }
        /// <summary> List of manifests referenced by this manifest list.  List will be empty if this manifest is not a manifest list. </summary>
        public IReadOnlyList<ArtifactManifestReference> ManifestReferences { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
    }
}
