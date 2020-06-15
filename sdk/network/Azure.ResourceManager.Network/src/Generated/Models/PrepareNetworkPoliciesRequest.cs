// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details of PrepareNetworkPolicies for Subnet. </summary>
    public partial class PrepareNetworkPoliciesRequest
    {
        /// <summary> Initializes a new instance of PrepareNetworkPoliciesRequest. </summary>
        public PrepareNetworkPoliciesRequest()
        {
        }

        /// <summary> Initializes a new instance of PrepareNetworkPoliciesRequest. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        internal PrepareNetworkPoliciesRequest(string serviceName, IList<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations)
        {
            ServiceName = serviceName;
            NetworkIntentPolicyConfigurations = networkIntentPolicyConfigurations;
        }

        /// <summary> The name of the service for which subnet is being prepared for. </summary>
        public string ServiceName { get; set; }
        /// <summary> A list of NetworkIntentPolicyConfiguration. </summary>
        public IList<NetworkIntentPolicyConfiguration> NetworkIntentPolicyConfigurations { get; set; }
    }
}
