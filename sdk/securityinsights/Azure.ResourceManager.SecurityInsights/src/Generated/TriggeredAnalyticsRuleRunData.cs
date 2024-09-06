// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the TriggeredAnalyticsRuleRun data model.
    /// The triggered analytics rule run
    /// </summary>
    public partial class TriggeredAnalyticsRuleRunData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="TriggeredAnalyticsRuleRunData"/>. </summary>
        /// <param name="executeOn"></param>
        /// <param name="ruleId"></param>
        /// <param name="triggeredAnalyticsRuleRunId"></param>
        /// <param name="provisioningState"> The triggered analytics rule run provisioning state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="triggeredAnalyticsRuleRunId"/> is null. </exception>
        public TriggeredAnalyticsRuleRunData(DateTimeOffset executeOn, string ruleId, string triggeredAnalyticsRuleRunId, ProvisioningState provisioningState)
        {
            Argument.AssertNotNull(ruleId, nameof(ruleId));
            Argument.AssertNotNull(triggeredAnalyticsRuleRunId, nameof(triggeredAnalyticsRuleRunId));

            ExecuteOn = executeOn;
            RuleId = ruleId;
            TriggeredAnalyticsRuleRunId = triggeredAnalyticsRuleRunId;
            ProvisioningState = provisioningState;
            RuleRunAdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="TriggeredAnalyticsRuleRunData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="executeOn"></param>
        /// <param name="ruleId"></param>
        /// <param name="triggeredAnalyticsRuleRunId"></param>
        /// <param name="provisioningState"> The triggered analytics rule run provisioning state. </param>
        /// <param name="ruleRunAdditionalData"> Dictionary of &lt;any&gt;. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggeredAnalyticsRuleRunData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset executeOn, string ruleId, string triggeredAnalyticsRuleRunId, ProvisioningState provisioningState, IDictionary<string, BinaryData> ruleRunAdditionalData, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ExecuteOn = executeOn;
            RuleId = ruleId;
            TriggeredAnalyticsRuleRunId = triggeredAnalyticsRuleRunId;
            ProvisioningState = provisioningState;
            RuleRunAdditionalData = ruleRunAdditionalData;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TriggeredAnalyticsRuleRunData"/> for deserialization. </summary>
        internal TriggeredAnalyticsRuleRunData()
        {
        }

        /// <summary> Gets or sets the execute on. </summary>
        [WirePath("properties.executionTimeUtc")]
        public DateTimeOffset ExecuteOn { get; set; }
        /// <summary> Gets or sets the rule id. </summary>
        [WirePath("properties.ruleId")]
        public string RuleId { get; set; }
        /// <summary> Gets or sets the triggered analytics rule run id. </summary>
        [WirePath("properties.triggeredAnalyticsRuleRunId")]
        public string TriggeredAnalyticsRuleRunId { get; set; }
        /// <summary> The triggered analytics rule run provisioning state. </summary>
        [WirePath("properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; set; }
        /// <summary>
        /// Dictionary of &lt;any&gt;
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
        [WirePath("properties.ruleRunAdditionalData")]
        public IDictionary<string, BinaryData> RuleRunAdditionalData { get; }
        /// <summary> Etag of the azure resource. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; set; }
    }
}
