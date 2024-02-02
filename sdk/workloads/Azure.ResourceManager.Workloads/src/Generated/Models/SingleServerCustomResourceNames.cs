// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// The resource-names input to specify custom names for underlying azure resources that are part of a single server SAP system.
    /// Please note <see cref="SingleServerCustomResourceNames"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SingleServerFullResourceNames"/>.
    /// </summary>
    public abstract partial class SingleServerCustomResourceNames
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SingleServerCustomResourceNames"/>. </summary>
        protected SingleServerCustomResourceNames()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SingleServerCustomResourceNames"/>. </summary>
        /// <param name="namingPatternType"> The pattern type to be used for resource naming. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SingleServerCustomResourceNames(SapNamingPatternType namingPatternType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NamingPatternType = namingPatternType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The pattern type to be used for resource naming. </summary>
        internal SapNamingPatternType NamingPatternType { get; set; }
    }
}
