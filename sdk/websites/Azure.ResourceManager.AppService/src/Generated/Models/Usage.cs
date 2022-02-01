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
    public partial class Usage : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of Usage. </summary>
        public Usage()
        {
        }

        /// <summary> Initializes a new instance of Usage. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="displayName"> Friendly name shown in the UI. </param>
        /// <param name="resourceName"> Name of the quota resource. </param>
        /// <param name="unit"> Units of measurement for the quota resource. </param>
        /// <param name="currentValue"> The current value of the resource counter. </param>
        /// <param name="limit"> The resource limit. </param>
        /// <param name="nextResetTime"> Next reset time for the resource counter. </param>
        /// <param name="computeMode"> Compute mode used for this usage. </param>
        /// <param name="siteMode"> Site mode used for this usage. </param>
        internal Usage(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, string displayName, string resourceName, string unit, long? currentValue, long? limit, DateTimeOffset? nextResetTime, ComputeModeOptions? computeMode, string siteMode) : base(id, name, type, systemData, kind)
        {
            DisplayName = displayName;
            ResourceName = resourceName;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetTime = nextResetTime;
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
        public DateTimeOffset? NextResetTime { get; }
        /// <summary> Compute mode used for this usage. </summary>
        public ComputeModeOptions? ComputeMode { get; }
        /// <summary> Site mode used for this usage. </summary>
        public string SiteMode { get; }
    }
}
