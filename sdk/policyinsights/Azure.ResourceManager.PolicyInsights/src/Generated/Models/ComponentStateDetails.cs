// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Component state details. </summary>
    public partial class ComponentStateDetails : ResourceData
    {
        /// <summary> Initializes a new instance of ComponentStateDetails. </summary>
        internal ComponentStateDetails()
        {
            AdditionalProperties = new Core.ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ComponentStateDetails. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timestamp"> Component compliance evaluation timestamp. </param>
        /// <param name="complianceState"> Component compliance state. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ComponentStateDetails(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? timestamp, string complianceState, IReadOnlyDictionary<string, BinaryData> additionalProperties) : base(id, name, resourceType, systemData)
        {
            Timestamp = timestamp;
            ComplianceState = complianceState;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Component compliance evaluation timestamp. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Component compliance state. </summary>
        public string ComplianceState { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
