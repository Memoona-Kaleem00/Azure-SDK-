// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Variable values. </summary>
    public partial class VariableValues
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

        /// <summary> Initializes a new instance of <see cref="VariableValues"/>. </summary>
        /// <param name="variable"> Variable name of the last detection request. </param>
        /// <param name="timestamps"> Time stamps of the last detection request. </param>
        /// <param name="values"> Values of variables. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="variable"/>, <paramref name="timestamps"/> or <paramref name="values"/> is null. </exception>
        public VariableValues(string variable, IEnumerable<string> timestamps, IEnumerable<float> values)
        {
            Argument.AssertNotNull(variable, nameof(variable));
            Argument.AssertNotNull(timestamps, nameof(timestamps));
            Argument.AssertNotNull(values, nameof(values));

            Variable = variable;
            Timestamps = timestamps.ToList();
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VariableValues"/>. </summary>
        /// <param name="variable"> Variable name of the last detection request. </param>
        /// <param name="timestamps"> Time stamps of the last detection request. </param>
        /// <param name="values"> Values of variables. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VariableValues(string variable, IList<string> timestamps, IList<float> values, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Variable = variable;
            Timestamps = timestamps;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VariableValues"/> for deserialization. </summary>
        internal VariableValues()
        {
        }

        /// <summary> Variable name of the last detection request. </summary>
        public string Variable { get; }
        /// <summary> Time stamps of the last detection request. </summary>
        public IList<string> Timestamps { get; }
        /// <summary> Values of variables. </summary>
        public IList<float> Values { get; }
    }
}
