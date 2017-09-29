// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Get monitoring data response.
    /// </summary>
    public partial class IntegrationRuntimeMonitoringData
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeMonitoringData
        /// class.
        /// </summary>
        public IntegrationRuntimeMonitoringData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeMonitoringData
        /// class.
        /// </summary>
        /// <param name="name">Integration runtime name.</param>
        /// <param name="nodes">Integration runtime node monitoring
        /// data.</param>
        public IntegrationRuntimeMonitoringData(string name = default(string), IList<IntegrationRuntimeNodeMonitoringData> nodes = default(IList<IntegrationRuntimeNodeMonitoringData>))
        {
            Name = name;
            Nodes = nodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets integration runtime name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets integration runtime node monitoring data.
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<IntegrationRuntimeNodeMonitoringData> Nodes { get; set; }

    }
}
