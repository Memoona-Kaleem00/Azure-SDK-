// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> A CosmosDB Cassandra API data source/sink. </summary>
    public partial class CosmosCassandraDataTransferDataSourceSink : DataTransferDataSourceSink
    {
        /// <summary> Initializes a new instance of <see cref="CosmosCassandraDataTransferDataSourceSink"/>. </summary>
        /// <param name="keyspaceName"></param>
        /// <param name="tableName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> or <paramref name="tableName"/> is null. </exception>
        public CosmosCassandraDataTransferDataSourceSink(string keyspaceName, string tableName)
        {
            if (keyspaceName == null)
            {
                throw new ArgumentNullException(nameof(keyspaceName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            KeyspaceName = keyspaceName;
            TableName = tableName;
            Component = DataTransferComponent.CosmosDBCassandra;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosCassandraDataTransferDataSourceSink"/>. </summary>
        /// <param name="component"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="keyspaceName"></param>
        /// <param name="tableName"></param>
        /// <param name="remoteAccountName"></param>
        internal CosmosCassandraDataTransferDataSourceSink(DataTransferComponent component, IDictionary<string, BinaryData> serializedAdditionalRawData, string keyspaceName, string tableName, string remoteAccountName) : base(component, serializedAdditionalRawData)
        {
            KeyspaceName = keyspaceName;
            TableName = tableName;
            RemoteAccountName = remoteAccountName;
            Component = component;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosCassandraDataTransferDataSourceSink"/> for deserialization. </summary>
        internal CosmosCassandraDataTransferDataSourceSink()
        {
        }

        /// <summary> Gets or sets the keyspace name. </summary>
        [WirePath("keyspaceName")]
        public string KeyspaceName { get; set; }
        /// <summary> Gets or sets the table name. </summary>
        [WirePath("tableName")]
        public string TableName { get; set; }
        /// <summary> Gets or sets the remote account name. </summary>
        [WirePath("remoteAccountName")]
        public string RemoteAccountName { get; set; }
    }
}
