// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Save Tenant Configuration Contract details. </summary>
    public partial class ConfigurationSaveContent
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

        /// <summary> Initializes a new instance of <see cref="ConfigurationSaveContent"/>. </summary>
        public ConfigurationSaveContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationSaveContent"/>. </summary>
        /// <param name="branch"> The name of the Git branch in which to commit the current configuration snapshot. </param>
        /// <param name="forceUpdate"> The value if true, the current configuration database is committed to the Git repository, even if the Git repository has newer changes that would be overwritten. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationSaveContent(string branch, bool? forceUpdate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Branch = branch;
            ForceUpdate = forceUpdate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the Git branch in which to commit the current configuration snapshot. </summary>
        [WirePath("properties.branch")]
        public string Branch { get; set; }
        /// <summary> The value if true, the current configuration database is committed to the Git repository, even if the Git repository has newer changes that would be overwritten. </summary>
        [WirePath("properties.force")]
        public bool? ForceUpdate { get; set; }
    }
}
