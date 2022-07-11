// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Information needed for cloning operation.
    /// Serialized Name: CloningInfo
    /// </summary>
    public partial class CloningInfo
    {
        /// <summary> Initializes a new instance of CloningInfo. </summary>
        /// <param name="sourceWebAppId">
        /// ARM resource ID of the source app. App resource ID is of the form 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// Serialized Name: CloningInfo.sourceWebAppId
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceWebAppId"/> is null. </exception>
        public CloningInfo(string sourceWebAppId)
        {
            if (sourceWebAppId == null)
            {
                throw new ArgumentNullException(nameof(sourceWebAppId));
            }

            SourceWebAppId = sourceWebAppId;
            AppSettingsOverrides = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of CloningInfo. </summary>
        /// <param name="correlationId">
        /// Correlation ID of cloning operation. This ID ties multiple cloning operations
        /// together to use the same snapshot.
        /// Serialized Name: CloningInfo.correlationId
        /// </param>
        /// <param name="isOverwrite">
        /// &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: CloningInfo.overwrite
        /// </param>
        /// <param name="isCloneCustomHostNames">
        /// &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: CloningInfo.cloneCustomHostNames
        /// </param>
        /// <param name="isCloneSourceControl">
        /// &lt;code&gt;true&lt;/code&gt; to clone source control from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: CloningInfo.cloneSourceControl
        /// </param>
        /// <param name="sourceWebAppId">
        /// ARM resource ID of the source app. App resource ID is of the form 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// Serialized Name: CloningInfo.sourceWebAppId
        /// </param>
        /// <param name="sourceWebAppLocation">
        /// Location of source app ex: West US or North Europe
        /// Serialized Name: CloningInfo.sourceWebAppLocation
        /// </param>
        /// <param name="hostingEnvironment">
        /// App Service Environment.
        /// Serialized Name: CloningInfo.hostingEnvironment
        /// </param>
        /// <param name="appSettingsOverrides">
        /// Application setting overrides for cloned app. If specified, these settings override the settings cloned 
        /// from source app. Otherwise, application settings from source app are retained.
        /// Serialized Name: CloningInfo.appSettingsOverrides
        /// </param>
        /// <param name="isConfigureLoadBalancing">
        /// &lt;code&gt;true&lt;/code&gt; to configure load balancing for source and destination app.
        /// Serialized Name: CloningInfo.configureLoadBalancing
        /// </param>
        /// <param name="trafficManagerProfileId">
        /// ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource ID is of the form 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
        /// Serialized Name: CloningInfo.trafficManagerProfileId
        /// </param>
        /// <param name="trafficManagerProfileName">
        /// Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile does not already exist.
        /// Serialized Name: CloningInfo.trafficManagerProfileName
        /// </param>
        internal CloningInfo(Guid? correlationId, bool? isOverwrite, bool? isCloneCustomHostNames, bool? isCloneSourceControl, string sourceWebAppId, string sourceWebAppLocation, string hostingEnvironment, IDictionary<string, string> appSettingsOverrides, bool? isConfigureLoadBalancing, string trafficManagerProfileId, string trafficManagerProfileName)
        {
            CorrelationId = correlationId;
            IsOverwrite = isOverwrite;
            IsCloneCustomHostNames = isCloneCustomHostNames;
            IsCloneSourceControl = isCloneSourceControl;
            SourceWebAppId = sourceWebAppId;
            SourceWebAppLocation = sourceWebAppLocation;
            HostingEnvironment = hostingEnvironment;
            AppSettingsOverrides = appSettingsOverrides;
            IsConfigureLoadBalancing = isConfigureLoadBalancing;
            TrafficManagerProfileId = trafficManagerProfileId;
            TrafficManagerProfileName = trafficManagerProfileName;
        }

        /// <summary>
        /// Correlation ID of cloning operation. This ID ties multiple cloning operations
        /// together to use the same snapshot.
        /// Serialized Name: CloningInfo.correlationId
        /// </summary>
        public Guid? CorrelationId { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: CloningInfo.overwrite
        /// </summary>
        public bool? IsOverwrite { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: CloningInfo.cloneCustomHostNames
        /// </summary>
        public bool? IsCloneCustomHostNames { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to clone source control from source app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: CloningInfo.cloneSourceControl
        /// </summary>
        public bool? IsCloneSourceControl { get; set; }
        /// <summary>
        /// ARM resource ID of the source app. App resource ID is of the form 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// Serialized Name: CloningInfo.sourceWebAppId
        /// </summary>
        public string SourceWebAppId { get; set; }
        /// <summary>
        /// Location of source app ex: West US or North Europe
        /// Serialized Name: CloningInfo.sourceWebAppLocation
        /// </summary>
        public string SourceWebAppLocation { get; set; }
        /// <summary>
        /// App Service Environment.
        /// Serialized Name: CloningInfo.hostingEnvironment
        /// </summary>
        public string HostingEnvironment { get; set; }
        /// <summary>
        /// Application setting overrides for cloned app. If specified, these settings override the settings cloned 
        /// from source app. Otherwise, application settings from source app are retained.
        /// Serialized Name: CloningInfo.appSettingsOverrides
        /// </summary>
        public IDictionary<string, string> AppSettingsOverrides { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to configure load balancing for source and destination app.
        /// Serialized Name: CloningInfo.configureLoadBalancing
        /// </summary>
        public bool? IsConfigureLoadBalancing { get; set; }
        /// <summary>
        /// ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource ID is of the form 
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
        /// Serialized Name: CloningInfo.trafficManagerProfileId
        /// </summary>
        public string TrafficManagerProfileId { get; set; }
        /// <summary>
        /// Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile does not already exist.
        /// Serialized Name: CloningInfo.trafficManagerProfileName
        /// </summary>
        public string TrafficManagerProfileName { get; set; }
    }
}
