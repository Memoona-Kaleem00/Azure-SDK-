// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuSetting. </summary>
    public partial class ResourceTypeSkuSetting
    {
        /// <summary> Initializes a new instance of ResourceTypeSkuSetting. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceTypeSkuSetting(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Locations = new Core.ChangeTrackingList<string>();
            LocationInfo = new Core.ChangeTrackingList<ResourceTypeSkuLocationInfo>();
            RequiredQuotaIds = new Core.ChangeTrackingList<string>();
            RequiredFeatures = new Core.ChangeTrackingList<string>();
            Costs = new Core.ChangeTrackingList<ResourceTypeSkuCost>();
            Capabilities = new Core.ChangeTrackingList<ResourceSkuCapability>();
        }

        /// <summary> Initializes a new instance of ResourceTypeSkuSetting. </summary>
        /// <param name="name"></param>
        /// <param name="tier"></param>
        /// <param name="size"></param>
        /// <param name="family"></param>
        /// <param name="kind"></param>
        /// <param name="locations"></param>
        /// <param name="locationInfo"></param>
        /// <param name="requiredQuotaIds"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="capacity"></param>
        /// <param name="costs"></param>
        /// <param name="capabilities"></param>
        internal ResourceTypeSkuSetting(string name, string tier, string size, string family, string kind, IList<string> locations, IList<ResourceTypeSkuLocationInfo> locationInfo, IList<string> requiredQuotaIds, IList<string> requiredFeatures, ResourceTypeSkuCapacity capacity, IList<ResourceTypeSkuCost> costs, IList<ResourceSkuCapability> capabilities)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Kind = kind;
            Locations = locations;
            LocationInfo = locationInfo;
            RequiredQuotaIds = requiredQuotaIds;
            RequiredFeatures = requiredFeatures;
            Capacity = capacity;
            Costs = costs;
            Capabilities = capabilities;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the tier. </summary>
        public string Tier { get; set; }
        /// <summary> Gets or sets the size. </summary>
        public string Size { get; set; }
        /// <summary> Gets or sets the family. </summary>
        public string Family { get; set; }
        /// <summary> Gets or sets the kind. </summary>
        public string Kind { get; set; }
        /// <summary> Gets the locations. </summary>
        public IList<string> Locations { get; }
        /// <summary> Gets the location info. </summary>
        public IList<ResourceTypeSkuLocationInfo> LocationInfo { get; }
        /// <summary> Gets the required quota ids. </summary>
        public IList<string> RequiredQuotaIds { get; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
        /// <summary> Gets or sets the capacity. </summary>
        public ResourceTypeSkuCapacity Capacity { get; set; }
        /// <summary> Gets the costs. </summary>
        public IList<ResourceTypeSkuCost> Costs { get; }
        /// <summary> Gets the capabilities. </summary>
        public IList<ResourceSkuCapability> Capabilities { get; }
    }
}
