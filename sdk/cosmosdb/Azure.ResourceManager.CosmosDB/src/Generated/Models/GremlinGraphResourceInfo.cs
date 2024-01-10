// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Gremlin graph resource object. </summary>
    public partial class GremlinGraphResourceInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GremlinGraphResourceInfo"/>. </summary>
        /// <param name="graphName"> Name of the Cosmos DB Gremlin graph. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public GremlinGraphResourceInfo(string graphName)
        {
            Argument.AssertNotNull(graphName, nameof(graphName));

            GraphName = graphName;
        }

        /// <summary> Initializes a new instance of <see cref="GremlinGraphResourceInfo"/>. </summary>
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
        internal GremlinGraphResourceInfo(string graphName, CosmosDBIndexingPolicy indexingPolicy, CosmosDBContainerPartitionKey partitionKey, int? defaultTtl, CosmosDBUniqueKeyPolicy uniqueKeyPolicy, ConflictResolutionPolicy conflictResolutionPolicy, long? analyticalStorageTtl, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GraphName = graphName;
            IndexingPolicy = indexingPolicy;
            PartitionKey = partitionKey;
            DefaultTtl = defaultTtl;
            UniqueKeyPolicy = uniqueKeyPolicy;
            ConflictResolutionPolicy = conflictResolutionPolicy;
            AnalyticalStorageTtl = analyticalStorageTtl;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GremlinGraphResourceInfo"/> for deserialization. </summary>
        internal GremlinGraphResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB Gremlin graph. </summary>
        public string GraphName { get; set; }
        /// <summary> The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the graph. </summary>
        public CosmosDBIndexingPolicy IndexingPolicy { get; set; }
        /// <summary> The configuration of the partition key to be used for partitioning data into multiple partitions. </summary>
        public CosmosDBContainerPartitionKey PartitionKey { get; set; }
        /// <summary> Default time to live. </summary>
        public int? DefaultTtl { get; set; }
        /// <summary> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </summary>
        internal CosmosDBUniqueKeyPolicy UniqueKeyPolicy { get; set; }
        /// <summary> List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </summary>
        public IList<CosmosDBUniqueKey> UniqueKeys
        {
            get
            {
                if (UniqueKeyPolicy is null)
                    UniqueKeyPolicy = new CosmosDBUniqueKeyPolicy();
                return UniqueKeyPolicy.UniqueKeys;
            }
        }

        /// <summary> The conflict resolution policy for the graph. </summary>
        public ConflictResolutionPolicy ConflictResolutionPolicy { get; set; }
        /// <summary> Analytical TTL. </summary>
        public long? AnalyticalStorageTtl { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public ResourceRestoreParameters RestoreParameters { get; set; }
        /// <summary> Enum to indicate the mode of resource creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
    }
}
