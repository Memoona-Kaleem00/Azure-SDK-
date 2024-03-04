// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedGremlinGraphResourceInfo. </summary>
    public partial class ExtendedGremlinGraphResourceInfo : GremlinGraphResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedGremlinGraphResourceInfo"/>. </summary>
        /// <param name="graphName"> Name of the Cosmos DB Gremlin graph. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public ExtendedGremlinGraphResourceInfo(string graphName) : base(graphName)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedGremlinGraphResourceInfo"/>. </summary>
        /// <param name="graphName"> Name of the Cosmos DB Gremlin graph. </param>
        /// <param name="indexingPolicy"> The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the graph. </param>
        /// <param name="partitionKey"> The configuration of the partition key to be used for partitioning data into multiple partitions. </param>
        /// <param name="defaultTtl"> Default time to live. </param>
        /// <param name="uniqueKeyPolicy"> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </param>
        /// <param name="conflictResolutionPolicy"> The conflict resolution policy for the graph. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedGremlinGraphResourceInfo(string graphName, CosmosDBIndexingPolicy indexingPolicy, CosmosDBContainerPartitionKey partitionKey, int? defaultTtl, CosmosDBUniqueKeyPolicy uniqueKeyPolicy, ConflictResolutionPolicy conflictResolutionPolicy, long? analyticalStorageTtl, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, IDictionary<string, BinaryData> serializedAdditionalRawData, string rid, float? timestamp, ETag? etag) : base(graphName, indexingPolicy, partitionKey, defaultTtl, uniqueKeyPolicy, conflictResolutionPolicy, analyticalStorageTtl, restoreParameters, createMode, serializedAdditionalRawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedGremlinGraphResourceInfo"/> for deserialization. </summary>
        internal ExtendedGremlinGraphResourceInfo()
        {
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        [WirePath("_rid")]
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        [WirePath("_ts")]
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        [WirePath("_etag")]
        public ETag? ETag { get; }
    }
}
