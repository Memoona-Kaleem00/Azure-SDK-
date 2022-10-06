// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents security alert timeline item. </summary>
    public partial class SecurityAlertTimelineItem : EntityTimelineItem
    {
        /// <summary> Initializes a new instance of SecurityAlertTimelineItem. </summary>
        /// <param name="azureResourceId"> The alert azure resource id. </param>
        /// <param name="displayName"> The alert name. </param>
        /// <param name="severity"> The alert severity. </param>
        /// <param name="endTimeUtc"> The alert end time. </param>
        /// <param name="startTimeUtc"> The alert start time. </param>
        /// <param name="timeGenerated"> The alert generated time. </param>
        /// <param name="alertType"> The name of the alert type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureResourceId"/>, <paramref name="displayName"/> or <paramref name="alertType"/> is null. </exception>
        internal SecurityAlertTimelineItem(string azureResourceId, string displayName, AlertSeverity severity, DateTimeOffset endTimeUtc, DateTimeOffset startTimeUtc, DateTimeOffset timeGenerated, string alertType)
        {
            if (azureResourceId == null)
            {
                throw new ArgumentNullException(nameof(azureResourceId));
            }
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (alertType == null)
            {
                throw new ArgumentNullException(nameof(alertType));
            }

            AzureResourceId = azureResourceId;
            DisplayName = displayName;
            Severity = severity;
            EndTimeUtc = endTimeUtc;
            StartTimeUtc = startTimeUtc;
            TimeGenerated = timeGenerated;
            AlertType = alertType;
            Kind = EntityTimelineKind.SecurityAlert;
        }

        /// <summary> Initializes a new instance of SecurityAlertTimelineItem. </summary>
        /// <param name="kind"> The entity query kind type. </param>
        /// <param name="azureResourceId"> The alert azure resource id. </param>
        /// <param name="productName"> The alert product name. </param>
        /// <param name="description"> The alert description. </param>
        /// <param name="displayName"> The alert name. </param>
        /// <param name="severity"> The alert severity. </param>
        /// <param name="endTimeUtc"> The alert end time. </param>
        /// <param name="startTimeUtc"> The alert start time. </param>
        /// <param name="timeGenerated"> The alert generated time. </param>
        /// <param name="alertType"> The name of the alert type. </param>
        internal SecurityAlertTimelineItem(EntityTimelineKind kind, string azureResourceId, string productName, string description, string displayName, AlertSeverity severity, DateTimeOffset endTimeUtc, DateTimeOffset startTimeUtc, DateTimeOffset timeGenerated, string alertType) : base(kind)
        {
            AzureResourceId = azureResourceId;
            ProductName = productName;
            Description = description;
            DisplayName = displayName;
            Severity = severity;
            EndTimeUtc = endTimeUtc;
            StartTimeUtc = startTimeUtc;
            TimeGenerated = timeGenerated;
            AlertType = alertType;
            Kind = kind;
        }

        /// <summary> The alert azure resource id. </summary>
        public string AzureResourceId { get; }
        /// <summary> The alert product name. </summary>
        public string ProductName { get; }
        /// <summary> The alert description. </summary>
        public string Description { get; }
        /// <summary> The alert name. </summary>
        public string DisplayName { get; }
        /// <summary> The alert severity. </summary>
        public AlertSeverity Severity { get; }
        /// <summary> The alert end time. </summary>
        public DateTimeOffset EndTimeUtc { get; }
        /// <summary> The alert start time. </summary>
        public DateTimeOffset StartTimeUtc { get; }
        /// <summary> The alert generated time. </summary>
        public DateTimeOffset TimeGenerated { get; }
        /// <summary> The name of the alert type. </summary>
        public string AlertType { get; }
    }
}
