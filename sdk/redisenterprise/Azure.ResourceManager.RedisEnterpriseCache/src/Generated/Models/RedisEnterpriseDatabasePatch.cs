// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    /// <summary> A partial update to the RedisEnterprise database. </summary>
    public partial class RedisEnterpriseDatabasePatch
    {
        /// <summary> Initializes a new instance of RedisEnterpriseDatabasePatch. </summary>
        public RedisEnterpriseDatabasePatch()
        {
            Modules = new ChangeTrackingList<RedisEnterpriseModule>();
        }

        /// <summary> Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted. </summary>
        public RedisEnterpriseClientProtocol? ClientProtocol { get; set; }
        /// <summary> TCP port of the database endpoint. Specified at create time. Defaults to an available port. </summary>
        public int? Port { get; set; }
        /// <summary> Current provisioning status of the database. </summary>
        public RedisEnterpriseProvisioningStatus? ProvisioningState { get; }
        /// <summary> Current resource status of the database. </summary>
        public RedisEnterpriseClusterResourceState? ResourceState { get; }
        /// <summary> Clustering policy - default is OSSCluster. Specified at create time. </summary>
        public RedisEnterpriseClusteringPolicy? ClusteringPolicy { get; set; }
        /// <summary> Redis eviction policy - default is VolatileLRU. </summary>
        public RedisEnterpriseEvictionPolicy? EvictionPolicy { get; set; }
        /// <summary> Persistence settings. </summary>
        public RedisPersistenceSettings Persistence { get; set; }
        /// <summary> Optional set of redis modules to enable in this database - modules can only be added at creation time. </summary>
        public IList<RedisEnterpriseModule> Modules { get; }
        /// <summary> Optional set of properties to configure geo replication for this database. </summary>
        public RedisEnterpriseDatabaseGeoReplication GeoReplication { get; set; }
    }
}
