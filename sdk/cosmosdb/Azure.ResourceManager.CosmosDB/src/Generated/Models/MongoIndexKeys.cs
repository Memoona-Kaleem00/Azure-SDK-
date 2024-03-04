// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB MongoDB collection resource object. </summary>
    internal partial class MongoIndexKeys
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

        /// <summary> Initializes a new instance of <see cref="MongoIndexKeys"/>. </summary>
        public MongoIndexKeys()
        {
            Keys = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoIndexKeys"/>. </summary>
        /// <param name="keys"> List of keys for each MongoDB collection in the Azure Cosmos DB service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoIndexKeys(IList<string> keys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Keys = keys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of keys for each MongoDB collection in the Azure Cosmos DB service. </summary>
        [WirePath("keys")]
        public IList<string> Keys { get; }
    }
}
