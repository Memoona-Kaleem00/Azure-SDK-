// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB Mongo DB Resource. </summary>
    public partial class MongoDBPrivilegeResourceInfo
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBPrivilegeResourceInfo"/>. </summary>
        public MongoDBPrivilegeResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBPrivilegeResourceInfo"/>. </summary>
        /// <param name="dbName"> The database name the role is applied. </param>
        /// <param name="collection"> The collection name the role is applied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBPrivilegeResourceInfo(string dbName, string collection, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DBName = dbName;
            Collection = collection;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The database name the role is applied. </summary>
        [WirePath("db")]
        public string DBName { get; set; }
        /// <summary> The collection name the role is applied. </summary>
        [WirePath("collection")]
        public string Collection { get; set; }
    }
}
