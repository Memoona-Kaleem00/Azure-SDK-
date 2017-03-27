// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Application gateway web application firewall configuration.
    /// </summary>
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayWebApplicationFirewallConfiguration class.
        /// </summary>
        public ApplicationGatewayWebApplicationFirewallConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayWebApplicationFirewallConfiguration class.
        /// </summary>
        /// <param name="enabled">Whether the web application firewall is
        /// enabled or not.</param>
        /// <param name="firewallMode">Web application firewall mode. Possible
        /// values are: 'Detection' and 'Prevention'. Possible values include:
        /// 'Detection', 'Prevention'</param>
        public ApplicationGatewayWebApplicationFirewallConfiguration(bool enabled, string firewallMode = default(string))
        {
            Enabled = enabled;
            FirewallMode = firewallMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the web application firewall is enabled or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets web application firewall mode. Possible values are:
        /// 'Detection' and 'Prevention'. Possible values include: 'Detection',
        /// 'Prevention'
        /// </summary>
        [JsonProperty(PropertyName = "firewallMode")]
        public string FirewallMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
