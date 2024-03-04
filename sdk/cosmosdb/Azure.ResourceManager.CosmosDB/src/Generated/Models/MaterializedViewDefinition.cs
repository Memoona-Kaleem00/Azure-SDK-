// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Materialized View definition for the container. </summary>
    public partial class MaterializedViewDefinition
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

        /// <summary> Initializes a new instance of <see cref="MaterializedViewDefinition"/>. </summary>
        /// <param name="sourceCollectionId"> The name of the source container on which the Materialized View will be created. </param>
        /// <param name="definition"> The definition should be an SQL query which would be used to fetch data from the source container to populate into the Materialized View container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceCollectionId"/> or <paramref name="definition"/> is null. </exception>
        public MaterializedViewDefinition(string sourceCollectionId, string definition)
        {
            if (sourceCollectionId == null)
            {
                throw new ArgumentNullException(nameof(sourceCollectionId));
            }
            if (definition == null)
            {
                throw new ArgumentNullException(nameof(definition));
            }

            SourceCollectionId = sourceCollectionId;
            Definition = definition;
        }

        /// <summary> Initializes a new instance of <see cref="MaterializedViewDefinition"/>. </summary>
        /// <param name="sourceCollectionRid"> An unique identifier for the source collection. This is a system generated property. </param>
        /// <param name="sourceCollectionId"> The name of the source container on which the Materialized View will be created. </param>
        /// <param name="definition"> The definition should be an SQL query which would be used to fetch data from the source container to populate into the Materialized View container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaterializedViewDefinition(string sourceCollectionRid, string sourceCollectionId, string definition, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceCollectionRid = sourceCollectionRid;
            SourceCollectionId = sourceCollectionId;
            Definition = definition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MaterializedViewDefinition"/> for deserialization. </summary>
        internal MaterializedViewDefinition()
        {
        }

        /// <summary> An unique identifier for the source collection. This is a system generated property. </summary>
        [WirePath("sourceCollectionRid")]
        public string SourceCollectionRid { get; }
        /// <summary> The name of the source container on which the Materialized View will be created. </summary>
        [WirePath("sourceCollectionId")]
        public string SourceCollectionId { get; set; }
        /// <summary> The definition should be an SQL query which would be used to fetch data from the source container to populate into the Materialized View container. </summary>
        [WirePath("definition")]
        public string Definition { get; set; }
    }
}
