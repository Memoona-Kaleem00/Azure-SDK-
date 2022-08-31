// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB MongoDB collection index options. </summary>
    public partial class MongoDBIndexConfig
    {
        /// <summary> Initializes a new instance of MongoDBIndexConfig. </summary>
        public MongoDBIndexConfig()
        {
        }

        /// <summary> Initializes a new instance of MongoDBIndexConfig. </summary>
        /// <param name="expireAfterSeconds"> Expire after seconds. </param>
        /// <param name="isUnique"> Is unique or not. </param>
        internal MongoDBIndexConfig(int? expireAfterSeconds, bool? isUnique)
        {
            ExpireAfterSeconds = expireAfterSeconds;
            IsUnique = isUnique;
        }

        /// <summary> Expire after seconds. </summary>
        public int? ExpireAfterSeconds { get; set; }
        /// <summary> Is unique or not. </summary>
        public bool? IsUnique { get; set; }
    }
}
