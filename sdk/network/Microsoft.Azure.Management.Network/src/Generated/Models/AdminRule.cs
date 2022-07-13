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
    /// Network admin rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Custom")]
    [Rest.Serialization.JsonTransformation]
    public partial class AdminRule : BaseAdminRule
    {
        /// <summary>
        /// Initializes a new instance of the AdminRule class.
        /// </summary>
        public AdminRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminRule class.
        /// </summary>
        /// <param name="protocol">Network protocol this rule applies to.
        /// Possible values include: 'Tcp', 'Udp', 'Icmp', 'Esp', 'Any',
        /// 'Ah'</param>
        /// <param name="access">Indicates the access allowed for this
        /// particular rule. Possible values include: 'Allow', 'Deny',
        /// 'AlwaysAllow'</param>
        /// <param name="priority">The priority of the rule. The value can be
        /// between 1 and 4096. The priority number must be unique for each
        /// rule in the collection. The lower the priority number, the higher
        /// the priority of the rule.</param>
        /// <param name="direction">Indicates if the traffic matched against
        /// the rule in inbound or outbound. Possible values include:
        /// 'Inbound', 'Outbound'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        /// <param name="description">A description for this rule. Restricted
        /// to 140 chars.</param>
        /// <param name="sources">The CIDR or source IP ranges.</param>
        /// <param name="destinations">The destination address prefixes. CIDR
        /// or destination IP ranges.</param>
        /// <param name="sourcePortRanges">The source port ranges.</param>
        /// <param name="destinationPortRanges">The destination port
        /// ranges.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        public AdminRule(string protocol, string access, int priority, string direction, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), SystemData systemData = default(SystemData), string description = default(string), IList<AddressPrefixItem> sources = default(IList<AddressPrefixItem>), IList<AddressPrefixItem> destinations = default(IList<AddressPrefixItem>), IList<string> sourcePortRanges = default(IList<string>), IList<string> destinationPortRanges = default(IList<string>), string provisioningState = default(string))
            : base(id, name, type, etag, systemData)
        {
            Description = description;
            Protocol = protocol;
            Sources = sources;
            Destinations = destinations;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Access = access;
            Priority = priority;
            Direction = direction;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a description for this rule. Restricted to 140 chars.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets network protocol this rule applies to. Possible values
        /// include: 'Tcp', 'Udp', 'Icmp', 'Esp', 'Any', 'Ah'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the CIDR or source IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sources")]
        public IList<AddressPrefixItem> Sources { get; set; }

        /// <summary>
        /// Gets or sets the destination address prefixes. CIDR or destination
        /// IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinations")]
        public IList<AddressPrefixItem> Destinations { get; set; }

        /// <summary>
        /// Gets or sets the source port ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourcePortRanges")]
        public IList<string> SourcePortRanges { get; set; }

        /// <summary>
        /// Gets or sets the destination port ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationPortRanges")]
        public IList<string> DestinationPortRanges { get; set; }

        /// <summary>
        /// Gets or sets indicates the access allowed for this particular rule.
        /// Possible values include: 'Allow', 'Deny', 'AlwaysAllow'
        /// </summary>
        [JsonProperty(PropertyName = "properties.access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets the priority of the rule. The value can be between 1
        /// and 4096. The priority number must be unique for each rule in the
        /// collection. The lower the priority number, the higher the priority
        /// of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets indicates if the traffic matched against the rule in
        /// inbound or outbound. Possible values include: 'Inbound', 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "properties.direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
            if (Access == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Access");
            }
            if (Direction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Direction");
            }
            if (Priority > 4096)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 4096);
            }
            if (Priority < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 1);
            }
        }
    }
}
