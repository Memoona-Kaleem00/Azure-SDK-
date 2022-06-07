// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network security default user rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Default")]
    [Rest.Serialization.JsonTransformation]
    public partial class ActiveDefaultSecurityUserRule : ActiveBaseSecurityUserRule
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDefaultSecurityUserRule
        /// class.
        /// </summary>
        public ActiveDefaultSecurityUserRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveDefaultSecurityUserRule
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="commitTime">Deployment time string.</param>
        /// <param name="region">Deployment region.</param>
        /// <param name="configurationDescription">A description of the
        /// security user configuration.</param>
        /// <param name="ruleCollectionDescription">A description of the rule
        /// collection.</param>
        /// <param name="ruleCollectionAppliesToGroups">Groups for rule
        /// collection</param>
        /// <param name="ruleGroups">Effective configuration groups.</param>
        /// <param name="description">A description for this rule. Restricted
        /// to 140 chars.</param>
        /// <param name="flag">Default rule flag.</param>
        /// <param name="protocol">Network protocol this rule applies to.
        /// Possible values include: 'Tcp', 'Udp', 'Icmp', 'Esp', 'Any',
        /// 'Ah'</param>
        /// <param name="sources">The CIDR or source IP ranges.</param>
        /// <param name="destinations">The destination address prefixes. CIDR
        /// or destination IP ranges.</param>
        /// <param name="sourcePortRanges">The source port ranges.</param>
        /// <param name="destinationPortRanges">The destination port
        /// ranges.</param>
        /// <param name="direction">Indicates if the traffic matched against
        /// the rule in inbound or outbound. Possible values include:
        /// 'Inbound', 'Outbound'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// security configuration user rule resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        public ActiveDefaultSecurityUserRule(string id = default(string), System.DateTime? commitTime = default(System.DateTime?), string region = default(string), string configurationDescription = default(string), string ruleCollectionDescription = default(string), IList<NetworkManagerSecurityGroupItem> ruleCollectionAppliesToGroups = default(IList<NetworkManagerSecurityGroupItem>), IList<ConfigurationGroup> ruleGroups = default(IList<ConfigurationGroup>), string description = default(string), string flag = default(string), string protocol = default(string), IList<AddressPrefixItem> sources = default(IList<AddressPrefixItem>), IList<AddressPrefixItem> destinations = default(IList<AddressPrefixItem>), IList<string> sourcePortRanges = default(IList<string>), IList<string> destinationPortRanges = default(IList<string>), string direction = default(string), string provisioningState = default(string))
            : base(id, commitTime, region, configurationDescription, ruleCollectionDescription, ruleCollectionAppliesToGroups, ruleGroups)
        {
            Description = description;
            Flag = flag;
            Protocol = protocol;
            Sources = sources;
            Destinations = destinations;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Direction = direction;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a description for this rule. Restricted to 140 chars.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets or sets default rule flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.flag")]
        public string Flag { get; set; }

        /// <summary>
        /// Gets network protocol this rule applies to. Possible values
        /// include: 'Tcp', 'Udp', 'Icmp', 'Esp', 'Any', 'Ah'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; private set; }

        /// <summary>
        /// Gets the CIDR or source IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sources")]
        public IList<AddressPrefixItem> Sources { get; private set; }

        /// <summary>
        /// Gets the destination address prefixes. CIDR or destination IP
        /// ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinations")]
        public IList<AddressPrefixItem> Destinations { get; private set; }

        /// <summary>
        /// Gets the source port ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourcePortRanges")]
        public IList<string> SourcePortRanges { get; private set; }

        /// <summary>
        /// Gets the destination port ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationPortRanges")]
        public IList<string> DestinationPortRanges { get; private set; }

        /// <summary>
        /// Gets indicates if the traffic matched against the rule in inbound
        /// or outbound. Possible values include: 'Inbound', 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "properties.direction")]
        public string Direction { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the security configuration user rule
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
