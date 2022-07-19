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
        /// <summary> Initializes a new instance of ExtendedMongoDBCollectionResourceInfo. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public ExtendedMongoDBCollectionResourceInfo(string collectionName) : base(collectionName)
        {
            if (collectionName == null)
            {
                throw new ArgumentNullException(nameof(collectionName));
            }
        }

        /// <summary> Initializes a new instance of ExtendedMongoDBCollectionResourceInfo. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <param name="shardKey"> A key-value pair of shard keys to be applied for the request. </param>
        /// <param name="indexes"> List of index keys. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedMongoDBCollectionResourceInfo(string collectionName, IDictionary<string, string> shardKey, IList<MongoDBIndex> indexes, int? analyticalStorageTtl, string rid, float? timestamp, ETag? etag) : base(collectionName, shardKey, indexes, analyticalStorageTtl)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
