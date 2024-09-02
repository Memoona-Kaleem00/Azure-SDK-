// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ServiceManagedResourcesSettings. </summary>
    internal partial class ServiceManagedResourcesSettings
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

        /// <summary> Initializes a new instance of <see cref="ServiceManagedResourcesSettings"/>. </summary>
        public ServiceManagedResourcesSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceManagedResourcesSettings"/>. </summary>
        /// <param name="cosmosDb"> The settings for the service managed cosmosdb account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceManagedResourcesSettings(CosmosDbSettings cosmosDb, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CosmosDb = cosmosDb;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The settings for the service managed cosmosdb account. </summary>
        internal CosmosDbSettings CosmosDb { get; set; }
        /// <summary> The throughput of the collections in cosmosdb database. </summary>
        public int? CosmosDbCollectionsThroughput
        {
            get => CosmosDb is null ? default : CosmosDb.CollectionsThroughput;
            set
            {
                if (CosmosDb is null)
                    CosmosDb = new CosmosDbSettings();
                CosmosDb.CollectionsThroughput = value;
            }
        }
    }
}
