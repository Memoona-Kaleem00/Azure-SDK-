// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Value for the specified parameter. Can be either &apos;value&apos; or &apos;reference&apos; but not both. </summary>
    public partial class ParameterValue
    {
        /// <summary> Initializes a new instance of ParameterValue. </summary>
        public ParameterValue()
        {
        }

        /// <summary> Initializes a new instance of ParameterValue. </summary>
        /// <param name="value"> Parameter value. Any valid JSON value is allowed including objects, arrays, strings, numbers and booleans. </param>
        /// <param name="reference"> Parameter value as reference type. </param>
        internal ParameterValue(BinaryData value, SecretValueReference reference)
        {
            Value = value;
            Reference = reference;
        }

        /// <summary>
        /// Parameter value. Any valid JSON value is allowed including objects, arrays, strings, numbers and booleans.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Value { get; set; }
        /// <summary> Parameter value as reference type. </summary>
        public SecretValueReference Reference { get; set; }
    }
}
