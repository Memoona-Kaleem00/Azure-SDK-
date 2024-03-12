// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The group by expression to be used in the query. </summary>
    public partial class QueryGrouping
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

        /// <summary> Initializes a new instance of <see cref="QueryGrouping"/>. </summary>
        /// <param name="columnType"> Has type of the column to group. </param>
        /// <param name="name"> The name of the column to group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public QueryGrouping(QueryColumnType columnType, string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ColumnType = columnType;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="QueryGrouping"/>. </summary>
        /// <param name="columnType"> Has type of the column to group. </param>
        /// <param name="name"> The name of the column to group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryGrouping(QueryColumnType columnType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ColumnType = columnType;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryGrouping"/> for deserialization. </summary>
        internal QueryGrouping()
        {
        }

        /// <summary> Has type of the column to group. </summary>
        public QueryColumnType ColumnType { get; }
        /// <summary> The name of the column to group. </summary>
        public string Name { get; }
    }
}
