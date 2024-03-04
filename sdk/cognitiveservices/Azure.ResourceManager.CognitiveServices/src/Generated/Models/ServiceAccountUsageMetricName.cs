// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A metric name. </summary>
    public partial class ServiceAccountUsageMetricName
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

        /// <summary> Initializes a new instance of <see cref="ServiceAccountUsageMetricName"/>. </summary>
        internal ServiceAccountUsageMetricName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAccountUsageMetricName"/>. </summary>
        /// <param name="value"> The name of the metric. </param>
        /// <param name="localizedValue"> The friendly name of the metric. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAccountUsageMetricName(string value, string localizedValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            LocalizedValue = localizedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the metric. </summary>
        [WirePath("value")]
        public string Value { get; }
        /// <summary> The friendly name of the metric. </summary>
        [WirePath("localizedValue")]
        public string LocalizedValue { get; }
    }
}
