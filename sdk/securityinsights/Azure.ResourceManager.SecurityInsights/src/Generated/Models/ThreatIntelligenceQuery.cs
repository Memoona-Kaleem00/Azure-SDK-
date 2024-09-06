// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a query to run on the TI objects in the workspace. </summary>
    public partial class ThreatIntelligenceQuery
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

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceQuery"/>. </summary>
        public ThreatIntelligenceQuery()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceQuery"/>. </summary>
        /// <param name="condition"> Represents a condition used to query for TI objects. </param>
        /// <param name="sortBy"> Specifies how to sort the query results. </param>
        /// <param name="maxPageSize"> Represents the maximum size of the page that will be returned from the query API. </param>
        /// <param name="minPageSize"> Represents the minimum size of the page that will be returned from the query API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceQuery(QueryCondition condition, QuerySortBy sortBy, int? maxPageSize, int? minPageSize, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Condition = condition;
            SortBy = sortBy;
            MaxPageSize = maxPageSize;
            MinPageSize = minPageSize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Represents a condition used to query for TI objects. </summary>
        [WirePath("condition")]
        public QueryCondition Condition { get; set; }
        /// <summary> Specifies how to sort the query results. </summary>
        [WirePath("sortBy")]
        public QuerySortBy SortBy { get; set; }
        /// <summary> Represents the maximum size of the page that will be returned from the query API. </summary>
        [WirePath("maxPageSize")]
        public int? MaxPageSize { get; set; }
        /// <summary> Represents the minimum size of the page that will be returned from the query API. </summary>
        [WirePath("minPageSize")]
        public int? MinPageSize { get; set; }
    }
}
