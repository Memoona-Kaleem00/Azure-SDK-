// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Usage of the quota resource. </summary>
    public partial class AppServiceUsage : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AppServiceUsage. </summary>
        public AppServiceUsage()
        {
        }

        /// <summary> Initializes a new instance of AppServiceUsage. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="displayName"> Friendly name shown in the UI. </param>
        /// <param name="resourceName"> Name of the quota resource. </param>
        /// <param name="unit"> Units of measurement for the quota resource. </param>
        /// <param name="currentValue"> The current value of the resource counter. </param>
        /// <param name="limit"> The resource limit. </param>
        /// <param name="nextResetOn"> Next reset time for the resource counter. </param>
        /// <param name="computeMode"> Compute mode used for this usage. </param>
        /// <param name="siteMode"> Site mode used for this usage. </param>
        internal AppServiceUsage(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string displayName, string resourceName, string unit, long? currentValue, long? limit, DateTimeOffset? nextResetOn, ComputeModeOption? computeMode, string siteMode) : base(id, name, resourceType, systemData, kind)
        {
            DisplayName = displayName;
            ResourceName = resourceName;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetOn = nextResetOn;
            ComputeMode = computeMode;
            SiteMode = siteMode;
        }

        /// <summary> Friendly name shown in the UI. </summary>
        public string DisplayName { get; }
        /// <summary> Name of the quota resource. </summary>
        public string ResourceName { get; }
        /// <summary> Units of measurement for the quota resource. </summary>
        public string Unit { get; }
        /// <summary> The current value of the resource counter. </summary>
        public long? CurrentValue { get; }
        /// <summary> The resource limit. </summary>
        public long? Limit { get; }
        /// <summary> Next reset time for the resource counter. </summary>
        public DateTimeOffset? NextResetOn { get; }
        /// <summary> Compute mode used for this usage. </summary>
        public ComputeModeOption? ComputeMode { get; }
        /// <summary> Site mode used for this usage. </summary>
        public string SiteMode { get; }
    }
}
