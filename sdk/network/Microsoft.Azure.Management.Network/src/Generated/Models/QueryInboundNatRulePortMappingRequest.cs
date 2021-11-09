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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request for a QueryInboundNatRulePortMapping API. Either
    /// IpConfiguration or IpAddress should be set
    /// </summary>
    public partial class QueryInboundNatRulePortMappingRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// QueryInboundNatRulePortMappingRequest class.
        /// </summary>
        public QueryInboundNatRulePortMappingRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// QueryInboundNatRulePortMappingRequest class.
        /// </summary>
        /// <param name="ipConfiguration">NetworkInterfaceIPConfiguration set
        /// in load balancer backend address.</param>
        /// <param name="ipAddress">IP address set in load balancer backend
        /// address.</param>
        public QueryInboundNatRulePortMappingRequest(SubResource ipConfiguration = default(SubResource), string ipAddress = default(string))
        {
            IpConfiguration = ipConfiguration;
            IpAddress = ipAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets networkInterfaceIPConfiguration set in load balancer
        /// backend address.
        /// </summary>
        [JsonProperty(PropertyName = "ipConfiguration")]
        public SubResource IpConfiguration { get; set; }

        /// <summary>
        /// Gets or sets IP address set in load balancer backend address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

    }
}
