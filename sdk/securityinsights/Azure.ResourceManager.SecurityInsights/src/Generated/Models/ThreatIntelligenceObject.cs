// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents a threat intelligence object in Azure Security Insights.
    /// Please note <see cref="ThreatIntelligenceObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ThreatIntelligenceAttackPattern"/>, <see cref="ThreatIntelligenceIdentity"/>, <see cref="ThreatIntelligenceIndicator"/>, <see cref="ThreatIntelligenceRelationship"/> and <see cref="ThreatIntelligenceThreatActor"/>.
    /// </summary>
    public abstract partial class ThreatIntelligenceObject : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceObject"/>. </summary>
        protected ThreatIntelligenceObject()
        {
            Data = new ChangeTrackingDictionary<string, BinaryData>();
            RelationshipHints = new ChangeTrackingList<RelationshipHint>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceObject"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the TI object. </param>
        /// <param name="data"> The core STIX object that this TI object represents. </param>
        /// <param name="createdBy"> The UserInfo of the user/entity which originally created this TI object. </param>
        /// <param name="source"> The source name for this TI object. </param>
        /// <param name="firstIngestedOn"> The timestamp for the first time this object was ingested. </param>
        /// <param name="lastIngestedOn"> The timestamp for the last time this object was ingested. </param>
        /// <param name="ingestionRulesVersion"> The ID of the rules version that was active when this TI object was last ingested. </param>
        /// <param name="lastUpdateMethod"> The name of the method/application that initiated the last write to this TI object. </param>
        /// <param name="lastModifiedBy"> The UserInfo of the user/entity which last modified this TI object. </param>
        /// <param name="lastUpdatedOn"> The timestamp for the last time this TI object was updated. </param>
        /// <param name="relationshipHints"> A dictionary used to help follow relationships from this object to other STIX objects. The keys are field names from the STIX object (in the 'data' field), and the values are lists of sources that can be prepended to the object ID in order to efficiently locate the target TI object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceObject(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TIObjectKind kind, IReadOnlyDictionary<string, BinaryData> data, ThreatIntelligenceUserInfo createdBy, string source, DateTimeOffset? firstIngestedOn, DateTimeOffset? lastIngestedOn, Guid? ingestionRulesVersion, string lastUpdateMethod, ThreatIntelligenceUserInfo lastModifiedBy, DateTimeOffset? lastUpdatedOn, IReadOnlyList<RelationshipHint> relationshipHints, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Data = data;
            CreatedBy = createdBy;
            Source = source;
            FirstIngestedOn = firstIngestedOn;
            LastIngestedOn = lastIngestedOn;
            IngestionRulesVersion = ingestionRulesVersion;
            LastUpdateMethod = lastUpdateMethod;
            LastModifiedBy = lastModifiedBy;
            LastUpdatedOn = lastUpdatedOn;
            RelationshipHints = relationshipHints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The kind of the TI object. </summary>
        internal TIObjectKind Kind { get; set; }
        /// <summary>
        /// The core STIX object that this TI object represents.
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
        [WirePath("properties.data")]
        public IReadOnlyDictionary<string, BinaryData> Data { get; }
        /// <summary> The UserInfo of the user/entity which originally created this TI object. </summary>
        [WirePath("properties.createdBy")]
        public ThreatIntelligenceUserInfo CreatedBy { get; }
        /// <summary> The source name for this TI object. </summary>
        [WirePath("properties.source")]
        public string Source { get; }
        /// <summary> The timestamp for the first time this object was ingested. </summary>
        [WirePath("properties.firstIngestedTimeUtc")]
        public DateTimeOffset? FirstIngestedOn { get; }
        /// <summary> The timestamp for the last time this object was ingested. </summary>
        [WirePath("properties.lastIngestedTimeUtc")]
        public DateTimeOffset? LastIngestedOn { get; }
        /// <summary> The ID of the rules version that was active when this TI object was last ingested. </summary>
        [WirePath("properties.ingestionRulesVersion")]
        public Guid? IngestionRulesVersion { get; }
        /// <summary> The name of the method/application that initiated the last write to this TI object. </summary>
        [WirePath("properties.lastUpdateMethod")]
        public string LastUpdateMethod { get; }
        /// <summary> The UserInfo of the user/entity which last modified this TI object. </summary>
        [WirePath("properties.lastModifiedBy")]
        public ThreatIntelligenceUserInfo LastModifiedBy { get; }
        /// <summary> The timestamp for the last time this TI object was updated. </summary>
        [WirePath("properties.lastUpdatedDateTimeUtc")]
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> A dictionary used to help follow relationships from this object to other STIX objects. The keys are field names from the STIX object (in the 'data' field), and the values are lists of sources that can be prepended to the object ID in order to efficiently locate the target TI object. </summary>
        [WirePath("properties.relationshipHints")]
        public IReadOnlyList<RelationshipHint> RelationshipHints { get; }
    }
}
