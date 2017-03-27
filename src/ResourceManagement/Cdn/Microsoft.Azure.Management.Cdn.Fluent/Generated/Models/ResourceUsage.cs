// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Microsoft.Azure.Management.Cdn.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Output of check resource usage API.
    /// </summary>
    public partial class ResourceUsage
    {
        /// <summary>
        /// Initializes a new instance of the ResourceUsage class.
        /// </summary>
        public ResourceUsage()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceUsage class.
        /// </summary>
        /// <param name="resourceType">Resource type of the usages.</param>
        /// <param name="unit">Unit of the usage. e.g. Count.</param>
        /// <param name="currentValue">Actual value of the resource
        /// type.</param>
        /// <param name="limit">Quota of the resource type.</param>
        public ResourceUsage(string resourceType = default(string), string unit = default(string), int? currentValue = default(int?), int? limit = default(int?))
        {
            ResourceType = resourceType;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource type of the usages.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets unit of the usage. e.g. Count.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets actual value of the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets quota of the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

    }
}
