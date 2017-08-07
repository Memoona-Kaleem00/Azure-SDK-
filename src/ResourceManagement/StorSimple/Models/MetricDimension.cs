// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The metric dimension. It indicates the source of the metric.
    /// </summary>
    public partial class MetricDimension
    {
        /// <summary>
        /// Initializes a new instance of the MetricDimension class.
        /// </summary>
        public MetricDimension()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDimension class.
        /// </summary>
        /// <param name="name">The metric dimension name.</param>
        /// <param name="value">The metric dimension values.</param>
        public MetricDimension(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metric dimension name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the metric dimension values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
