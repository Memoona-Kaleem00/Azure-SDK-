// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB location metadata. </summary>
    public partial class CosmosDBLocationProperties
    {
        /// <summary> Initializes a new instance of CosmosDBLocationProperties. </summary>
        public CosmosDBLocationProperties()
        {
            BackupStorageRedundancies = new ChangeTrackingList<BackupStorageRedundancy>();
        }

        /// <summary> Initializes a new instance of CosmosDBLocationProperties. </summary>
        /// <param name="doesSupportsAvailabilityZone"> Flag indicating whether the location supports availability zones or not. </param>
        /// <param name="isResidencyRestricted"> Flag indicating whether the location is residency sensitive. </param>
        /// <param name="backupStorageRedundancies"> The properties of available backup storage redundancies. </param>
        internal CosmosDBLocationProperties(bool? doesSupportsAvailabilityZone, bool? isResidencyRestricted, IReadOnlyList<BackupStorageRedundancy> backupStorageRedundancies)
        {
            DoesSupportsAvailabilityZone = doesSupportsAvailabilityZone;
            IsResidencyRestricted = isResidencyRestricted;
            BackupStorageRedundancies = backupStorageRedundancies;
        }

        /// <summary> Flag indicating whether the location supports availability zones or not. </summary>
        public bool? DoesSupportsAvailabilityZone { get; }
        /// <summary> Flag indicating whether the location is residency sensitive. </summary>
        public bool? IsResidencyRestricted { get; }
        /// <summary> The properties of available backup storage redundancies. </summary>
        public IReadOnlyList<BackupStorageRedundancy> BackupStorageRedundancies { get; }
    }
}
