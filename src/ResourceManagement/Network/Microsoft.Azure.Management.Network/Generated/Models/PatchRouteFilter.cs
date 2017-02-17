// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Route Filter Resource.
    /// </summary>
    [JsonTransformation]
    public partial class PatchRouteFilter : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PatchRouteFilter class.
        /// </summary>
        public PatchRouteFilter() { }

        /// <summary>
        /// Initializes a new instance of the PatchRouteFilter class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="rules">Collection of RouteFilterRules contained within
        /// a route filter.</param>
        /// <param name="peerings">A collection of references to express route
        /// circuit peerings.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values are: 'Updating', 'Deleting', 'Succeeded'
        /// and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        public PatchRouteFilter(string id = default(string), IList<RouteFilterRule> rules = default(IList<RouteFilterRule>), IList<ExpressRouteCircuitPeering> peerings = default(IList<ExpressRouteCircuitPeering>), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id)
        {
            Rules = rules;
            Peerings = peerings;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets collection of RouteFilterRules contained within a
        /// route filter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<RouteFilterRule> Rules { get; set; }

        /// <summary>
        /// Gets a collection of references to express route circuit peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerings")]
        public IList<ExpressRouteCircuitPeering> Peerings { get; protected set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values are:
        /// 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets the name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; protected set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}

