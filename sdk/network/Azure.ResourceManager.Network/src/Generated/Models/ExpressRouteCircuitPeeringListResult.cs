// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListPeering API service call retrieves all peerings that belong to an ExpressRouteCircuit. </summary>
    internal partial class ExpressRouteCircuitPeeringListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringListResult. </summary>
        internal ExpressRouteCircuitPeeringListResult()
        {
            Value = new Core.ChangeTrackingList<ExpressRouteCircuitPeeringData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringListResult. </summary>
        /// <param name="value"> The peerings in an express route circuit. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCircuitPeeringListResult(IReadOnlyList<ExpressRouteCircuitPeeringData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The peerings in an express route circuit. </summary>
        public IReadOnlyList<ExpressRouteCircuitPeeringData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
