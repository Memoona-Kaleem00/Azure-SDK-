// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListLoadBalancingRule API service call. </summary>
    internal partial class LoadBalancerLoadBalancingRuleListResult
    {
        /// <summary> Initializes a new instance of LoadBalancerLoadBalancingRuleListResult. </summary>
        internal LoadBalancerLoadBalancingRuleListResult()
        {
            Value = new Core.ChangeTrackingList<LoadBalancingRuleData>();
        }

        /// <summary> Initializes a new instance of LoadBalancerLoadBalancingRuleListResult. </summary>
        /// <param name="value"> A list of load balancing rules in a load balancer. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal LoadBalancerLoadBalancingRuleListResult(IReadOnlyList<LoadBalancingRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of load balancing rules in a load balancer. </summary>
        public IReadOnlyList<LoadBalancingRuleData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
