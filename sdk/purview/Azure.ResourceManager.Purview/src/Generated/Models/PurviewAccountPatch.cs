// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The account update properties. </summary>
    public partial class PurviewAccountPatch
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

        /// <summary> Initializes a new instance of <see cref="PurviewAccountPatch"/>. </summary>
        public PurviewAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountPatch"/>. </summary>
        /// <param name="identity"> The Managed Identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="properties"> The account properties. </param>
        /// <param name="tags"> Tags on the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewAccountPatch(ManagedServiceIdentity identity, PurviewAccountProperties properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Properties = properties;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Managed Identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The account properties. </summary>
        public PurviewAccountProperties Properties { get; set; }
        /// <summary> Tags on the azure resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
