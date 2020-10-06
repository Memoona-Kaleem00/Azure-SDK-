// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of topic resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkRuleSet : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        public NetworkRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="defaultAction">Default Action for Network Rule Set.
        /// Possible values include: 'Allow', 'Deny'</param>
        /// <param name="virtualNetworkRules">List VirtualNetwork Rules</param>
        /// <param name="ipRules">List of IpRules</param>
        public NetworkRuleSet(string id = default(string), string name = default(string), string type = default(string), string defaultAction = default(string), IList<NWRuleSetVirtualNetworkRules> virtualNetworkRules = default(IList<NWRuleSetVirtualNetworkRules>), IList<NWRuleSetIpRules> ipRules = default(IList<NWRuleSetIpRules>))
            : base(id, name, type)
        {
            DefaultAction = defaultAction;
            VirtualNetworkRules = virtualNetworkRules;
            IpRules = ipRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets default Action for Network Rule Set. Possible values
        /// include: 'Allow', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultAction")]
        public string DefaultAction { get; set; }

        /// <summary>
        /// Gets or sets list VirtualNetwork Rules
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkRules")]
        public IList<NWRuleSetVirtualNetworkRules> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets or sets list of IpRules
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipRules")]
        public IList<NWRuleSetIpRules> IpRules { get; set; }

    }
}
