// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the Alert data model. </summary>
    public partial class AlertData : ResourceData
    {
        /// <summary> Initializes a new instance of AlertData. </summary>
        public AlertData()
        {
            ResourceIdentifiers = new ChangeTrackingList<AlertResourceIdentifier>();
            RemediationSteps = new ChangeTrackingList<string>();
            ExtendedLinks = new ChangeTrackingList<IDictionary<string, string>>();
            Entities = new ChangeTrackingList<AlertEntity>();
            ExtendedProperties = new ChangeTrackingDictionary<string, string>();
            Techniques = new ChangeTrackingList<string>();
            SubTechniques = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="version"> Schema version. </param>
        /// <param name="alertType"> Unique identifier for the detection logic (all alert instances from the same detection logic will have the same alertType). </param>
        /// <param name="systemAlertId"> Unique identifier for the alert. </param>
        /// <param name="productComponentName"> The name of Azure Security Center pricing tier which powering this alert. Learn more: https://docs.microsoft.com/en-us/azure/security-center/security-center-pricing. </param>
        /// <param name="alertDisplayName"> The display name of the alert. </param>
        /// <param name="description"> Description of the suspicious activity that was detected. </param>
        /// <param name="severity"> The risk level of the threat that was detected. Learn more: https://docs.microsoft.com/en-us/azure/security-center/security-center-alerts-overview#how-are-alerts-classified. </param>
        /// <param name="intent"> The kill chain related intent behind the alert. For list of supported values, and explanations of Azure Security Center&apos;s supported kill chain intents. </param>
        /// <param name="startTimeUtc"> The UTC time of the first event or activity included in the alert in ISO8601 format. </param>
        /// <param name="endTimeUtc"> The UTC time of the last event or activity included in the alert in ISO8601 format. </param>
        /// <param name="resourceIdentifiers">
        /// The resource identifiers that can be used to direct the alert to the right product exposure group (tenant, workspace, subscription etc.). There can be multiple identifiers of different type per alert.
        /// Please note <see cref="AlertResourceIdentifier"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceIdentifier"/> and <see cref="LogAnalyticsIdentifier"/>.
        /// </param>
        /// <param name="remediationSteps"> Manual action items to take to remediate the alert. </param>
        /// <param name="vendorName"> The name of the vendor that raises the alert. </param>
        /// <param name="status"> The life cycle status of the alert. </param>
        /// <param name="extendedLinks"> Links related to the alert. </param>
        /// <param name="alertUri"> A direct link to the alert page in Azure Portal. </param>
        /// <param name="timeGeneratedUtc"> The UTC time the alert was generated in ISO8601 format. </param>
        /// <param name="productName"> The name of the product which published this alert (Azure Security Center, Azure ATP, Microsoft Defender ATP, O365 ATP, MCAS, and so on). </param>
        /// <param name="processingEndTimeUtc"> The UTC processing end time of the alert in ISO8601 format. </param>
        /// <param name="entities"> A list of entities related to the alert. </param>
        /// <param name="isIncident"> This field determines whether the alert is an incident (a compound grouping of several alerts) or a single alert. </param>
        /// <param name="correlationKey"> Key for corelating related alerts. Alerts with the same correlation key considered to be related. </param>
        /// <param name="extendedProperties"> Custom properties for the alert. </param>
        /// <param name="compromisedEntity"> The display name of the resource most related to this alert. </param>
        /// <param name="techniques"> kill chain related techniques behind the alert. </param>
        /// <param name="subTechniques"> Kill chain related sub-techniques behind the alert. </param>
        /// <param name="supportingEvidence"> Changing set of properties depending on the supportingEvidence type. </param>
        internal AlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string version, string alertType, string systemAlertId, string productComponentName, string alertDisplayName, string description, AlertSeverity? severity, Intent? intent, DateTimeOffset? startTimeUtc, DateTimeOffset? endTimeUtc, IReadOnlyList<AlertResourceIdentifier> resourceIdentifiers, IReadOnlyList<string> remediationSteps, string vendorName, AlertStatus? status, IReadOnlyList<IDictionary<string, string>> extendedLinks, Uri alertUri, DateTimeOffset? timeGeneratedUtc, string productName, DateTimeOffset? processingEndTimeUtc, IReadOnlyList<AlertEntity> entities, bool? isIncident, string correlationKey, IDictionary<string, string> extendedProperties, string compromisedEntity, IReadOnlyList<string> techniques, IReadOnlyList<string> subTechniques, AlertPropertiesSupportingEvidence supportingEvidence) : base(id, name, resourceType, systemData)
        {
            Version = version;
            AlertType = alertType;
            SystemAlertId = systemAlertId;
            ProductComponentName = productComponentName;
            AlertDisplayName = alertDisplayName;
            Description = description;
            Severity = severity;
            Intent = intent;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            ResourceIdentifiers = resourceIdentifiers;
            RemediationSteps = remediationSteps;
            VendorName = vendorName;
            Status = status;
            ExtendedLinks = extendedLinks;
            AlertUri = alertUri;
            TimeGeneratedUtc = timeGeneratedUtc;
            ProductName = productName;
            ProcessingEndTimeUtc = processingEndTimeUtc;
            Entities = entities;
            IsIncident = isIncident;
            CorrelationKey = correlationKey;
            ExtendedProperties = extendedProperties;
            CompromisedEntity = compromisedEntity;
            Techniques = techniques;
            SubTechniques = subTechniques;
            SupportingEvidence = supportingEvidence;
        }

        /// <summary> Schema version. </summary>
        public string Version { get; }
        /// <summary> Unique identifier for the detection logic (all alert instances from the same detection logic will have the same alertType). </summary>
        public string AlertType { get; }
        /// <summary> Unique identifier for the alert. </summary>
        public string SystemAlertId { get; }
        /// <summary> The name of Azure Security Center pricing tier which powering this alert. Learn more: https://docs.microsoft.com/en-us/azure/security-center/security-center-pricing. </summary>
        public string ProductComponentName { get; }
        /// <summary> The display name of the alert. </summary>
        public string AlertDisplayName { get; }
        /// <summary> Description of the suspicious activity that was detected. </summary>
        public string Description { get; }
        /// <summary> The risk level of the threat that was detected. Learn more: https://docs.microsoft.com/en-us/azure/security-center/security-center-alerts-overview#how-are-alerts-classified. </summary>
        public AlertSeverity? Severity { get; }
        /// <summary> The kill chain related intent behind the alert. For list of supported values, and explanations of Azure Security Center&apos;s supported kill chain intents. </summary>
        public Intent? Intent { get; }
        /// <summary> The UTC time of the first event or activity included in the alert in ISO8601 format. </summary>
        public DateTimeOffset? StartTimeUtc { get; }
        /// <summary> The UTC time of the last event or activity included in the alert in ISO8601 format. </summary>
        public DateTimeOffset? EndTimeUtc { get; }
        /// <summary>
        /// The resource identifiers that can be used to direct the alert to the right product exposure group (tenant, workspace, subscription etc.). There can be multiple identifiers of different type per alert.
        /// Please note <see cref="AlertResourceIdentifier"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceIdentifier"/> and <see cref="LogAnalyticsIdentifier"/>.
        /// </summary>
        public IReadOnlyList<AlertResourceIdentifier> ResourceIdentifiers { get; }
        /// <summary> Manual action items to take to remediate the alert. </summary>
        public IReadOnlyList<string> RemediationSteps { get; }
        /// <summary> The name of the vendor that raises the alert. </summary>
        public string VendorName { get; }
        /// <summary> The life cycle status of the alert. </summary>
        public AlertStatus? Status { get; }
        /// <summary> Links related to the alert. </summary>
        public IReadOnlyList<IDictionary<string, string>> ExtendedLinks { get; }
        /// <summary> A direct link to the alert page in Azure Portal. </summary>
        public Uri AlertUri { get; }
        /// <summary> The UTC time the alert was generated in ISO8601 format. </summary>
        public DateTimeOffset? TimeGeneratedUtc { get; }
        /// <summary> The name of the product which published this alert (Azure Security Center, Azure ATP, Microsoft Defender ATP, O365 ATP, MCAS, and so on). </summary>
        public string ProductName { get; }
        /// <summary> The UTC processing end time of the alert in ISO8601 format. </summary>
        public DateTimeOffset? ProcessingEndTimeUtc { get; }
        /// <summary> A list of entities related to the alert. </summary>
        public IReadOnlyList<AlertEntity> Entities { get; }
        /// <summary> This field determines whether the alert is an incident (a compound grouping of several alerts) or a single alert. </summary>
        public bool? IsIncident { get; }
        /// <summary> Key for corelating related alerts. Alerts with the same correlation key considered to be related. </summary>
        public string CorrelationKey { get; }
        /// <summary> Custom properties for the alert. </summary>
        public IDictionary<string, string> ExtendedProperties { get; }
        /// <summary> The display name of the resource most related to this alert. </summary>
        public string CompromisedEntity { get; }
        /// <summary> kill chain related techniques behind the alert. </summary>
        public IReadOnlyList<string> Techniques { get; }
        /// <summary> Kill chain related sub-techniques behind the alert. </summary>
        public IReadOnlyList<string> SubTechniques { get; }
        /// <summary> Changing set of properties depending on the supportingEvidence type. </summary>
        public AlertPropertiesSupportingEvidence SupportingEvidence { get; set; }
    }
}
