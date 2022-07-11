// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Description of a SKU for a scalable resource.
    /// Serialized Name: SkuDescription
    /// </summary>
    public partial class SkuDescription
    {
        /// <summary> Initializes a new instance of SkuDescription. </summary>
        public SkuDescription()
        {
            AzureLocations = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<Capability>();
        }

        /// <summary> Initializes a new instance of SkuDescription. </summary>
        /// <param name="name">
        /// Name of the resource SKU.
        /// Serialized Name: SkuDescription.name
        /// </param>
        /// <param name="tier">
        /// Service tier of the resource SKU.
        /// Serialized Name: SkuDescription.tier
        /// </param>
        /// <param name="size">
        /// Size specifier of the resource SKU.
        /// Serialized Name: SkuDescription.size
        /// </param>
        /// <param name="family">
        /// Family code of the resource SKU.
        /// Serialized Name: SkuDescription.family
        /// </param>
        /// <param name="capacity">
        /// Current number of instances assigned to the resource.
        /// Serialized Name: SkuDescription.capacity
        /// </param>
        /// <param name="skuCapacity">
        /// Min, max, and default scale values of the SKU.
        /// Serialized Name: SkuDescription.skuCapacity
        /// </param>
        /// <param name="azureLocations">
        /// Locations of the SKU.
        /// Serialized Name: SkuDescription.locations
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of the SKU, e.g., is traffic manager enabled?
        /// Serialized Name: SkuDescription.capabilities
        /// </param>
        internal SkuDescription(string name, string tier, string size, string family, int? capacity, SkuCapacity skuCapacity, IList<string> azureLocations, IList<Capability> capabilities)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            SkuCapacity = skuCapacity;
            AzureLocations = azureLocations;
            Capabilities = capabilities;
        }

        /// <summary>
        /// Name of the resource SKU.
        /// Serialized Name: SkuDescription.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Service tier of the resource SKU.
        /// Serialized Name: SkuDescription.tier
        /// </summary>
        public string Tier { get; set; }
        /// <summary>
        /// Size specifier of the resource SKU.
        /// Serialized Name: SkuDescription.size
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// Family code of the resource SKU.
        /// Serialized Name: SkuDescription.family
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// Current number of instances assigned to the resource.
        /// Serialized Name: SkuDescription.capacity
        /// </summary>
        public int? Capacity { get; set; }
        /// <summary>
        /// Min, max, and default scale values of the SKU.
        /// Serialized Name: SkuDescription.skuCapacity
        /// </summary>
        public SkuCapacity SkuCapacity { get; set; }
        /// <summary>
        /// Locations of the SKU.
        /// Serialized Name: SkuDescription.locations
        /// </summary>
        public IList<string> AzureLocations { get; }
        /// <summary>
        /// Capabilities of the SKU, e.g., is traffic manager enabled?
        /// Serialized Name: SkuDescription.capabilities
        /// </summary>
        public IList<Capability> Capabilities { get; }
    }
}
