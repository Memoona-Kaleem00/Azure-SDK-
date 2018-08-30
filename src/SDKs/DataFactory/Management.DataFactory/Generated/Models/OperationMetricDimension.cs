// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the metric dimension.
    /// </summary>
    public partial class OperationMetricDimension
    {
        /// <summary>
        /// Initializes a new instance of the OperationMetricDimension class.
        /// </summary>
        public OperationMetricDimension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationMetricDimension class.
        /// </summary>
        /// <param name="name">The name of the dimension for the
        /// metric.</param>
        /// <param name="displayName">The display name of the metric
        /// dimension.</param>
        /// <param name="toBeExportedForShoebox">Whether the dimension should
        /// be exported to Azure Monitor.</param>
        public OperationMetricDimension(string name = default(string), string displayName = default(string), bool? toBeExportedForShoebox = default(bool?))
        {
            Name = name;
            DisplayName = displayName;
            ToBeExportedForShoebox = toBeExportedForShoebox;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the dimension for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the metric dimension.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets whether the dimension should be exported to Azure
        /// Monitor.
        /// </summary>
        [JsonProperty(PropertyName = "toBeExportedForShoebox")]
        public bool? ToBeExportedForShoebox { get; set; }

    }
}
