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
    /// <summary> Represents a security alert entity. </summary>
    public partial class SecurityInsightsAlert : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of SecurityInsightsAlert. </summary>
        public SecurityInsightsAlert()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            ConfidenceReasons = new ChangeTrackingList<SecurityInsightsAlertConfidenceReason>();
            RemediationSteps = new ChangeTrackingList<string>();
            Tactics = new ChangeTrackingList<SecurityInsightsAttackTactic>();
            ResourceIdentifiers = new ChangeTrackingList<BinaryData>();
            Kind = SecurityInsightsEntityKind.SecurityAlert;
        }

        /// <summary> Initializes a new instance of SecurityInsightsAlert. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="alertDisplayName"> The display name of the alert. </param>
        /// <param name="alertType"> The type name of the alert. </param>
        /// <param name="compromisedEntity"> Display name of the main entity being reported on. </param>
        /// <param name="confidenceLevel"> The confidence level of this alert. </param>
        /// <param name="confidenceReasons"> The confidence reasons. </param>
        /// <param name="confidenceScore"> The confidence score of the alert. </param>
        /// <param name="confidenceScoreStatus"> The confidence score calculation status, i.e. indicating if score calculation is pending for this alert, not applicable or final. </param>
        /// <param name="description"> Alert description. </param>
        /// <param name="endOn"> The impact end time of the alert (the time of the last event contributing to the alert). </param>
        /// <param name="intent"> Holds the alert intent stage(s) mapping for this alert. </param>
        /// <param name="providerAlertId"> The identifier of the alert inside the product which generated the alert. </param>
        /// <param name="processingEndOn"> The time the alert was made available for consumption. </param>
        /// <param name="productComponentName"> The name of a component inside the product which generated the alert. </param>
        /// <param name="productName"> The name of the product which published this alert. </param>
        /// <param name="productVersion"> The version of the product generating the alert. </param>
        /// <param name="remediationSteps"> Manual action items to take to remediate the alert. </param>
        /// <param name="severity"> The severity of the alert. </param>
        /// <param name="startOn"> The impact start time of the alert (the time of the first event contributing to the alert). </param>
        /// <param name="status"> The lifecycle status of the alert. </param>
        /// <param name="systemAlertId"> Holds the product identifier of the alert for the product. </param>
        /// <param name="tactics"> The tactics of the alert. </param>
        /// <param name="alertGeneratedOn"> The time the alert was generated. </param>
        /// <param name="vendorName"> The name of the vendor that raise the alert. </param>
        /// <param name="alertLink"> The uri link of the alert. </param>
        /// <param name="resourceIdentifiers"> The list of resource identifiers of the alert. </param>
        internal SecurityInsightsAlert(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string alertDisplayName, string alertType, string compromisedEntity, SecurityInsightsAlertConfidenceLevel? confidenceLevel, IReadOnlyList<SecurityInsightsAlertConfidenceReason> confidenceReasons, double? confidenceScore, SecurityInsightsAlertConfidenceScoreStatus? confidenceScoreStatus, string description, DateTimeOffset? endOn, SecurityInsightsKillChainIntent? intent, string providerAlertId, DateTimeOffset? processingEndOn, string productComponentName, string productName, string productVersion, IReadOnlyList<string> remediationSteps, SecurityInsightsAlertSeverity? severity, DateTimeOffset? startOn, SecurityInsightsAlertStatus? status, string systemAlertId, IReadOnlyList<SecurityInsightsAttackTactic> tactics, DateTimeOffset? alertGeneratedOn, string vendorName, string alertLink, IReadOnlyList<BinaryData> resourceIdentifiers) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AlertDisplayName = alertDisplayName;
            AlertType = alertType;
            CompromisedEntity = compromisedEntity;
            ConfidenceLevel = confidenceLevel;
            ConfidenceReasons = confidenceReasons;
            ConfidenceScore = confidenceScore;
            ConfidenceScoreStatus = confidenceScoreStatus;
            Description = description;
            EndOn = endOn;
            Intent = intent;
            ProviderAlertId = providerAlertId;
            ProcessingEndOn = processingEndOn;
            ProductComponentName = productComponentName;
            ProductName = productName;
            ProductVersion = productVersion;
            RemediationSteps = remediationSteps;
            Severity = severity;
            StartOn = startOn;
            Status = status;
            SystemAlertId = systemAlertId;
            Tactics = tactics;
            AlertGeneratedOn = alertGeneratedOn;
            VendorName = vendorName;
            AlertLink = alertLink;
            ResourceIdentifiers = resourceIdentifiers;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The display name of the alert. </summary>
        public string AlertDisplayName { get; }
        /// <summary> The type name of the alert. </summary>
        public string AlertType { get; }
        /// <summary> Display name of the main entity being reported on. </summary>
        public string CompromisedEntity { get; }
        /// <summary> The confidence level of this alert. </summary>
        public SecurityInsightsAlertConfidenceLevel? ConfidenceLevel { get; }
        /// <summary> The confidence reasons. </summary>
        public IReadOnlyList<SecurityInsightsAlertConfidenceReason> ConfidenceReasons { get; }
        /// <summary> The confidence score of the alert. </summary>
        public double? ConfidenceScore { get; }
        /// <summary> The confidence score calculation status, i.e. indicating if score calculation is pending for this alert, not applicable or final. </summary>
        public SecurityInsightsAlertConfidenceScoreStatus? ConfidenceScoreStatus { get; }
        /// <summary> Alert description. </summary>
        public string Description { get; }
        /// <summary> The impact end time of the alert (the time of the last event contributing to the alert). </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Holds the alert intent stage(s) mapping for this alert. </summary>
        public SecurityInsightsKillChainIntent? Intent { get; }
        /// <summary> The identifier of the alert inside the product which generated the alert. </summary>
        public string ProviderAlertId { get; }
        /// <summary> The time the alert was made available for consumption. </summary>
        public DateTimeOffset? ProcessingEndOn { get; }
        /// <summary> The name of a component inside the product which generated the alert. </summary>
        public string ProductComponentName { get; }
        /// <summary> The name of the product which published this alert. </summary>
        public string ProductName { get; }
        /// <summary> The version of the product generating the alert. </summary>
        public string ProductVersion { get; }
        /// <summary> Manual action items to take to remediate the alert. </summary>
        public IReadOnlyList<string> RemediationSteps { get; }
        /// <summary> The severity of the alert. </summary>
        public SecurityInsightsAlertSeverity? Severity { get; set; }
        /// <summary> The impact start time of the alert (the time of the first event contributing to the alert). </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The lifecycle status of the alert. </summary>
        public SecurityInsightsAlertStatus? Status { get; }
        /// <summary> Holds the product identifier of the alert for the product. </summary>
        public string SystemAlertId { get; }
        /// <summary> The tactics of the alert. </summary>
        public IReadOnlyList<SecurityInsightsAttackTactic> Tactics { get; }
        /// <summary> The time the alert was generated. </summary>
        public DateTimeOffset? AlertGeneratedOn { get; }
        /// <summary> The name of the vendor that raise the alert. </summary>
        public string VendorName { get; }
        /// <summary> The uri link of the alert. </summary>
        public string AlertLink { get; }
        /// <summary>
        /// The list of resource identifiers of the alert.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyList<BinaryData> ResourceIdentifiers { get; }
    }
}
