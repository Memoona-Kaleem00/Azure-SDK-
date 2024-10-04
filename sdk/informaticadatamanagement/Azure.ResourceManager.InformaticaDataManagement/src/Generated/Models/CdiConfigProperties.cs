// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> The CdiConfigProperties. </summary>
    public partial class CdiConfigProperties
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

        /// <summary> Initializes a new instance of <see cref="CdiConfigProperties"/>. </summary>
        /// <param name="engineName"></param>
        /// <param name="engineVersion"></param>
        /// <param name="applicationConfigs"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="engineName"/>, <paramref name="engineVersion"/> or <paramref name="applicationConfigs"/> is null. </exception>
        public CdiConfigProperties(string engineName, string engineVersion, IEnumerable<InformaticaApplicationConfigs> applicationConfigs)
        {
            Argument.AssertNotNull(engineName, nameof(engineName));
            Argument.AssertNotNull(engineVersion, nameof(engineVersion));
            Argument.AssertNotNull(applicationConfigs, nameof(applicationConfigs));

            EngineName = engineName;
            EngineVersion = engineVersion;
            ApplicationConfigs = applicationConfigs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CdiConfigProperties"/>. </summary>
        /// <param name="engineName"></param>
        /// <param name="engineVersion"></param>
        /// <param name="applicationConfigs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdiConfigProperties(string engineName, string engineVersion, IList<InformaticaApplicationConfigs> applicationConfigs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EngineName = engineName;
            EngineVersion = engineVersion;
            ApplicationConfigs = applicationConfigs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CdiConfigProperties"/> for deserialization. </summary>
        internal CdiConfigProperties()
        {
        }

        /// <summary> Gets or sets the engine name. </summary>
        public string EngineName { get; set; }
        /// <summary> Gets or sets the engine version. </summary>
        public string EngineVersion { get; set; }
        /// <summary> Gets the application configs. </summary>
        public IList<InformaticaApplicationConfigs> ApplicationConfigs { get; }
    }
}
