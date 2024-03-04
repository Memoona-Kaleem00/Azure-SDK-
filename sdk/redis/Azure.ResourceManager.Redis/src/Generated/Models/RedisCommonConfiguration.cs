// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc. </summary>
    public partial class RedisCommonConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="RedisCommonConfiguration"/>. </summary>
        public RedisCommonConfiguration()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisCommonConfiguration"/>. </summary>
        /// <param name="isRdbBackupEnabled"> Specifies whether the rdb backup is enabled. </param>
        /// <param name="rdbBackupFrequency"> Specifies the frequency for creating rdb backup in minutes. Valid values: (15, 30, 60, 360, 720, 1440). </param>
        /// <param name="rdbBackupMaxSnapshotCount"> Specifies the maximum number of snapshots for rdb backup. </param>
        /// <param name="rdbStorageConnectionString"> The storage account connection string for storing rdb file. </param>
        /// <param name="isAofBackupEnabled"> Specifies whether the aof backup is enabled. </param>
        /// <param name="aofStorageConnectionString0"> First storage account connection string. </param>
        /// <param name="aofStorageConnectionString1"> Second storage account connection string. </param>
        /// <param name="maxFragmentationMemoryReserved"> Value in megabytes reserved for fragmentation per shard. </param>
        /// <param name="maxMemoryPolicy"> The eviction strategy used when your data won't fit within its memory limit. </param>
        /// <param name="maxMemoryReserved"> Value in megabytes reserved for non-cache usage per shard e.g. failover. </param>
        /// <param name="maxMemoryDelta"> Value in megabytes reserved for non-cache usage per shard e.g. failover. </param>
        /// <param name="maxClients"> The max clients config. </param>
        /// <param name="preferredDataArchiveAuthMethod"> Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS. </param>
        /// <param name="preferredDataPersistenceAuthMethod"> Preferred auth method to communicate to storage account used for data persistence, specify SAS or ManagedIdentity, default value is SAS. </param>
        /// <param name="zonalConfiguration"> Zonal Configuration. </param>
        /// <param name="authNotRequired"> Specifies whether the authentication is disabled. Setting this property is highly discouraged from security point of view. </param>
        /// <param name="storageSubscriptionId"> SubscriptionId of the storage account for persistence (aof/rdb) using ManagedIdentity. </param>
        /// <param name="isAadEnabled"> Specifies whether AAD based authentication has been enabled or disabled for the cache. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal RedisCommonConfiguration(bool? isRdbBackupEnabled, string rdbBackupFrequency, int? rdbBackupMaxSnapshotCount, string rdbStorageConnectionString, bool? isAofBackupEnabled, string aofStorageConnectionString0, string aofStorageConnectionString1, string maxFragmentationMemoryReserved, string maxMemoryPolicy, string maxMemoryReserved, string maxMemoryDelta, string maxClients, string preferredDataArchiveAuthMethod, string preferredDataPersistenceAuthMethod, string zonalConfiguration, string authNotRequired, string storageSubscriptionId, string isAadEnabled, IDictionary<string, BinaryData> additionalProperties)
        {
            IsRdbBackupEnabled = isRdbBackupEnabled;
            RdbBackupFrequency = rdbBackupFrequency;
            RdbBackupMaxSnapshotCount = rdbBackupMaxSnapshotCount;
            RdbStorageConnectionString = rdbStorageConnectionString;
            IsAofBackupEnabled = isAofBackupEnabled;
            AofStorageConnectionString0 = aofStorageConnectionString0;
            AofStorageConnectionString1 = aofStorageConnectionString1;
            MaxFragmentationMemoryReserved = maxFragmentationMemoryReserved;
            MaxMemoryPolicy = maxMemoryPolicy;
            MaxMemoryReserved = maxMemoryReserved;
            MaxMemoryDelta = maxMemoryDelta;
            MaxClients = maxClients;
            PreferredDataArchiveAuthMethod = preferredDataArchiveAuthMethod;
            PreferredDataPersistenceAuthMethod = preferredDataPersistenceAuthMethod;
            ZonalConfiguration = zonalConfiguration;
            AuthNotRequired = authNotRequired;
            StorageSubscriptionId = storageSubscriptionId;
            IsAadEnabled = isAadEnabled;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Specifies whether the rdb backup is enabled. </summary>
        [WirePath("rdb-backup-enabled")]
        public bool? IsRdbBackupEnabled { get; set; }
        /// <summary> Specifies the frequency for creating rdb backup in minutes. Valid values: (15, 30, 60, 360, 720, 1440). </summary>
        [WirePath("rdb-backup-frequency")]
        public string RdbBackupFrequency { get; set; }
        /// <summary> Specifies the maximum number of snapshots for rdb backup. </summary>
        [WirePath("rdb-backup-max-snapshot-count")]
        public int? RdbBackupMaxSnapshotCount { get; set; }
        /// <summary> The storage account connection string for storing rdb file. </summary>
        [WirePath("rdb-storage-connection-string")]
        public string RdbStorageConnectionString { get; set; }
        /// <summary> Specifies whether the aof backup is enabled. </summary>
        [WirePath("aof-backup-enabled")]
        public bool? IsAofBackupEnabled { get; set; }
        /// <summary> First storage account connection string. </summary>
        [WirePath("aof-storage-connection-string-0")]
        public string AofStorageConnectionString0 { get; set; }
        /// <summary> Second storage account connection string. </summary>
        [WirePath("aof-storage-connection-string-1")]
        public string AofStorageConnectionString1 { get; set; }
        /// <summary> Value in megabytes reserved for fragmentation per shard. </summary>
        [WirePath("maxfragmentationmemory-reserved")]
        public string MaxFragmentationMemoryReserved { get; set; }
        /// <summary> The eviction strategy used when your data won't fit within its memory limit. </summary>
        [WirePath("maxmemory-policy")]
        public string MaxMemoryPolicy { get; set; }
        /// <summary> Value in megabytes reserved for non-cache usage per shard e.g. failover. </summary>
        [WirePath("maxmemory-reserved")]
        public string MaxMemoryReserved { get; set; }
        /// <summary> Value in megabytes reserved for non-cache usage per shard e.g. failover. </summary>
        [WirePath("maxmemory-delta")]
        public string MaxMemoryDelta { get; set; }
        /// <summary> The max clients config. </summary>
        [WirePath("maxclients")]
        public string MaxClients { get; }
        /// <summary> Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS. </summary>
        [WirePath("preferred-data-archive-auth-method")]
        public string PreferredDataArchiveAuthMethod { get; }
        /// <summary> Preferred auth method to communicate to storage account used for data persistence, specify SAS or ManagedIdentity, default value is SAS. </summary>
        [WirePath("preferred-data-persistence-auth-method")]
        public string PreferredDataPersistenceAuthMethod { get; set; }
        /// <summary> Zonal Configuration. </summary>
        [WirePath("zonal-configuration")]
        public string ZonalConfiguration { get; }
        /// <summary> Specifies whether the authentication is disabled. Setting this property is highly discouraged from security point of view. </summary>
        [WirePath("authnotrequired")]
        public string AuthNotRequired { get; set; }
        /// <summary> SubscriptionId of the storage account for persistence (aof/rdb) using ManagedIdentity. </summary>
        [WirePath("storage-subscription-id")]
        public string StorageSubscriptionId { get; set; }
        /// <summary> Specifies whether AAD based authentication has been enabled or disabled for the cache. </summary>
        [WirePath("aad-enabled")]
        public string IsAadEnabled { get; set; }
        /// <summary>
        /// Additional Properties
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
        [WirePath("AdditionalProperties")]
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
