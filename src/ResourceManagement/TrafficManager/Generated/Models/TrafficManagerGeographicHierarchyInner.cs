// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Azure.Management.TrafficManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing the Geographic hierarchy used with the Geographic
    /// traffic routing method.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TrafficManagerGeographicHierarchyInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TrafficManagerGeographicHierarchyInner class.
        /// </summary>
        public TrafficManagerGeographicHierarchyInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TrafficManagerGeographicHierarchyInner class.
        /// </summary>
        /// <param name="geographicHierarchy">The region at the root of the
        /// hierarchy from all the regions in the hierarchy can be
        /// retrieved.</param>
        public TrafficManagerGeographicHierarchyInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), GeographicHierarchyRegion geographicHierarchy = default(GeographicHierarchyRegion))
            : base(location, id, name, type, tags)
        {
            GeographicHierarchy = geographicHierarchy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region at the root of the hierarchy from all the
        /// regions in the hierarchy can be retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.geographicHierarchy")]
        public GeographicHierarchyRegion GeographicHierarchy { get; set; }

    }
}
