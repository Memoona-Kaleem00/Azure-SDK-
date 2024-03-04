// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedMongoDBCollectionResourceInfo. </summary>
    public partial class ExtendedMongoDBCollectionResourceInfo : MongoDBCollectionResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedMongoDBCollectionResourceInfo"/>. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public ExtendedMongoDBCollectionResourceInfo(string collectionName) : base(collectionName)
        {
            if (collectionName == null)
            {
                throw new ArgumentNullException(nameof(collectionName));
            }
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedMongoDBCollectionResourceInfo"/>. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <param name="shardKey"> A key-value pair of shard keys to be applied for the request. </param>
        /// <param name="indexes"> List of index keys. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedMongoDBCollectionResourceInfo(string collectionName, IDictionary<string, string> shardKey, IList<MongoDBIndex> indexes, int? analyticalStorageTtl, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, IDictionary<string, BinaryData> serializedAdditionalRawData, string rid, float? timestamp, ETag? etag) : base(collectionName, shardKey, indexes, analyticalStorageTtl, restoreParameters, createMode, serializedAdditionalRawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedMongoDBCollectionResourceInfo"/> for deserialization. </summary>
        internal ExtendedMongoDBCollectionResourceInfo()
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
