// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a virtual machine that determine how it is connected to a
    /// load balancer.
    /// </summary>
    public partial class SharedPublicIpAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedPublicIpAddressConfiguration class.
        /// </summary>
        public SharedPublicIpAddressConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedPublicIpAddressConfiguration class.
        /// </summary>
        /// <param name="inboundNatRules">The incoming NAT rules</param>
        public SharedPublicIpAddressConfiguration(IList<InboundNatRule> inboundNatRules = default(IList<InboundNatRule>))
        {
            InboundNatRules = inboundNatRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the incoming NAT rules
        /// </summary>
        [JsonProperty(PropertyName = "inboundNatRules")]
        public IList<InboundNatRule> InboundNatRules { get; set; }

    }
}
