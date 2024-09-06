// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a condition used to query for TI objects. </summary>
    public partial class QueryCondition
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

        /// <summary> Initializes a new instance of <see cref="QueryCondition"/>. </summary>
        /// <param name="clauses"> The list of clauses to be evaluated in disjunction or conjunction base on the specified top level connective operator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clauses"/> is null. </exception>
        public QueryCondition(IEnumerable<ConditionClause> clauses)
        {
            Argument.AssertNotNull(clauses, nameof(clauses));

            Clauses = clauses.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="QueryCondition"/>. </summary>
        /// <param name="stixObjectType"> The STIX type for the objects returned by this query. </param>
        /// <param name="clauses"> The list of clauses to be evaluated in disjunction or conjunction base on the specified top level connective operator. </param>
        /// <param name="conditionConnective"> The top level connective operator for this condition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryCondition(string stixObjectType, IList<ConditionClause> clauses, ClauseConnective? conditionConnective, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StixObjectType = stixObjectType;
            Clauses = clauses;
            ConditionConnective = conditionConnective;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryCondition"/> for deserialization. </summary>
        internal QueryCondition()
        {
        }

        /// <summary> The STIX type for the objects returned by this query. </summary>
        [WirePath("stixObjectType")]
        public string StixObjectType { get; set; }
        /// <summary> The list of clauses to be evaluated in disjunction or conjunction base on the specified top level connective operator. </summary>
        [WirePath("clauses")]
        public IList<ConditionClause> Clauses { get; }
        /// <summary> The top level connective operator for this condition. </summary>
        [WirePath("conditionConnective")]
        public ClauseConnective? ConditionConnective { get; set; }
    }
}
