// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Confluent;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> The response of a list operation. </summary>
    internal partial class ConfluentOrganizationListResult
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

        /// <summary> Initializes a new instance of <see cref="ConfluentOrganizationListResult"/>. </summary>
        internal ConfluentOrganizationListResult()
        {
            Value = new ChangeTrackingList<ConfluentOrganizationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentOrganizationListResult"/>. </summary>
        /// <param name="value"> Result of a list operation. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfluentOrganizationListResult(IReadOnlyList<ConfluentOrganizationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result of a list operation. </summary>
        public IReadOnlyList<ConfluentOrganizationData> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
