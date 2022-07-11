// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteLogsConfig data model. </summary>
    public partial class SiteLogsConfigData : ResourceData
    {
        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        public SiteLogsConfigData()
        {
        }

        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="applicationLogs">
        /// Application logs configuration.
        /// Serialized Name: SiteLogsConfig.properties.applicationLogs
        /// </param>
        /// <param name="httpLogs">
        /// HTTP logs configuration.
        /// Serialized Name: SiteLogsConfig.properties.httpLogs
        /// </param>
        /// <param name="failedRequestsTracing">
        /// Failed requests tracing configuration.
        /// Serialized Name: SiteLogsConfig.properties.failedRequestsTracing
        /// </param>
        /// <param name="detailedErrorMessages">
        /// Detailed error messages configuration.
        /// Serialized Name: SiteLogsConfig.properties.detailedErrorMessages
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal SiteLogsConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ApplicationLogsConfig applicationLogs, HttpLogsConfig httpLogs, EnabledConfig failedRequestsTracing, EnabledConfig detailedErrorMessages, string kind) : base(id, name, resourceType, systemData)
        {
            ApplicationLogs = applicationLogs;
            HttpLogs = httpLogs;
            FailedRequestsTracing = failedRequestsTracing;
            DetailedErrorMessages = detailedErrorMessages;
            Kind = kind;
        }

        /// <summary>
        /// Application logs configuration.
        /// Serialized Name: SiteLogsConfig.properties.applicationLogs
        /// </summary>
        public ApplicationLogsConfig ApplicationLogs { get; set; }
        /// <summary>
        /// HTTP logs configuration.
        /// Serialized Name: SiteLogsConfig.properties.httpLogs
        /// </summary>
        public HttpLogsConfig HttpLogs { get; set; }
        /// <summary>
        /// Failed requests tracing configuration.
        /// Serialized Name: SiteLogsConfig.properties.failedRequestsTracing
        /// </summary>
        internal EnabledConfig FailedRequestsTracing { get; set; }
        /// <summary>
        /// True if configuration is enabled, false if it is disabled and null if configuration is not set.
        /// Serialized Name: EnabledConfig.enabled
        /// </summary>
        public bool? IsDetailedErrorMessagesEnabled
        {
            get => FailedRequestsTracing is null ? default : FailedRequestsTracing.IsDetailedErrorMessagesEnabled;
            set
            {
                if (FailedRequestsTracing is null)
                    FailedRequestsTracing = new EnabledConfig();
                FailedRequestsTracing.IsDetailedErrorMessagesEnabled = value;
            }
        }

        /// <summary>
        /// Detailed error messages configuration.
        /// Serialized Name: SiteLogsConfig.properties.detailedErrorMessages
        /// </summary>
        internal EnabledConfig DetailedErrorMessages { get; set; }
        /// <summary>
        /// True if configuration is enabled, false if it is disabled and null if configuration is not set.
        /// Serialized Name: EnabledConfig.enabled
        /// </summary>
        public bool? IsDetailedErrorMessagesEnabled
        {
            get => DetailedErrorMessages is null ? default : DetailedErrorMessages.IsDetailedErrorMessagesEnabled;
            set
            {
                if (DetailedErrorMessages is null)
                    DetailedErrorMessages = new EnabledConfig();
                DetailedErrorMessages.IsDetailedErrorMessagesEnabled = value;
            }
        }

        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
