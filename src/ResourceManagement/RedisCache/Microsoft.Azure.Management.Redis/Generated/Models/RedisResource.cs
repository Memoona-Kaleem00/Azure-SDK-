// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System;		
    using System.Linq;
    using System.Collections.Generic;		
    using Newtonsoft.Json;		
    using Rest;		
    using Rest.Serialization;		
    using Rest.Azure;		

    /// <summary>
    /// A single redis item in List or Get Operation.
    /// </summary>
    [JsonTransformation]
    public partial class RedisResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RedisResource class.
        /// </summary>
        public RedisResource() { }

        /// <summary>
        /// Initializes a new instance of the RedisResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="sku">What sku of redis cache to deploy.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="redisVersion">Redis Version.</param>
        /// <param name="provisioningState">Redis instance provisioning
        /// status</param>
        /// <param name="hostName">Redis host name</param>
        /// <param name="port">Redis non-ssl port</param>
        /// <param name="sslPort">Redis ssl port</param>
        /// <param name="redisConfiguration">All Redis Settings. Few possible
        /// keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.</param>
        /// <param name="enableNonSslPort">If the value is true, then the
        /// non-ssl redis server port (6379) will be enabled.</param>
        /// <param name="tenantSettings">tenantSettings</param>
        /// <param name="shardCount">The number of shards to be created on a
        /// Premium Cluster Cache.</param>
        /// <param name="subnetId">The full resource ID of a subnet in a
        /// virtual network to deploy the redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1</param>
        /// <param name="staticIP">Required when deploying a redis cache
        /// inside an existing Azure Virtual Network.</param>
        public RedisResource(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string redisVersion = default(string), string provisioningState = default(string), string hostName = default(string), int? port = default(int?), int? sslPort = default(int?), IDictionary<string, string> redisConfiguration = default(IDictionary<string, string>), bool? enableNonSslPort = default(bool?), IDictionary<string, string> tenantSettings = default(IDictionary<string, string>), int? shardCount = default(int?), string subnetId = default(string), string staticIP = default(string))
            : base(location, id, name, type, tags)
        {
            RedisVersion = redisVersion;
            ProvisioningState = provisioningState;
            HostName = hostName;
            Port = port;
            SslPort = sslPort;
            RedisConfiguration = redisConfiguration;
            EnableNonSslPort = enableNonSslPort;
            TenantSettings = tenantSettings;
            ShardCount = shardCount;
            SubnetId = subnetId;
            StaticIP = staticIP;
            Sku = sku;
        }

        /// <summary>
        /// Gets redis Version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.redisVersion")]
        public string RedisVersion { get; private set; }

        /// <summary>
        /// Gets redis instance provisioning status
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets redis host name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets redis non-ssl port
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; private set; }

        /// <summary>
        /// Gets redis ssl port
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sslPort")]
        public int? SslPort { get; private set; }

        /// <summary>
        /// Gets or sets all Redis Settings. Few possible keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.redisConfiguration")]
        public IDictionary<string, string> RedisConfiguration { get; set; }

        /// <summary>
        /// Gets or sets if the value is true, then the non-ssl redis server
        /// port (6379) will be enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableNonSslPort")]
        public bool? EnableNonSslPort { get; set; }

        /// <summary>
        /// Gets or sets tenantSettings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tenantSettings")]
        public IDictionary<string, string> TenantSettings { get; set; }

        /// <summary>
        /// Gets or sets the number of shards to be created on a Premium
        /// Cluster Cache.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shardCount")]
        public int? ShardCount { get; set; }

        /// <summary>
        /// Gets or sets the full resource ID of a subnet in a virtual network
        /// to deploy the redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets required when deploying a redis cache inside an
        /// existing Azure Virtual Network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.staticIP")]
        public string StaticIP { get; set; }

        /// <summary>
        /// Gets or sets what sku of redis cache to deploy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (SubnetId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SubnetId, "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "SubnetId", "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$");
                }
            }
            if (StaticIP != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(StaticIP, "^\\d+\\.\\d+\\.\\d+\\.\\d+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "StaticIP", "^\\d+\\.\\d+\\.\\d+\\.\\d+$");
                }
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
