// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Maintenance;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Tag filter information for the VM. </summary>
    public partial class VmTagSettings
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

        /// <summary> Initializes a new instance of <see cref="VmTagSettings"/>. </summary>
        public VmTagSettings()
        {
            Tags = new ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> Initializes a new instance of <see cref="VmTagSettings"/>. </summary>
        /// <param name="tags"> Dictionary of tags with its list of values. </param>
        /// <param name="filterOperator"> Filter VMs by Any or All specified tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VmTagSettings(IDictionary<string, IList<string>> tags, VmTagOperator? filterOperator, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            FilterOperator = filterOperator;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Dictionary of tags with its list of values. </summary>
        public IDictionary<string, IList<string>> Tags { get; }
        /// <summary> Filter VMs by Any or All specified tags. </summary>
        public VmTagOperator? FilterOperator { get; set; }
    }
}
