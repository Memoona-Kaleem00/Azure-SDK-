// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListRoutesTable associated with the Express Route Circuits API. </summary>
    public partial class ExpressRouteCircuitsRoutesTableListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitsRoutesTableListResult. </summary>
        internal ExpressRouteCircuitsRoutesTableListResult()
        {
            Value = new Core.ChangeTrackingList<ExpressRouteCircuitRoutesTable>();
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitsRoutesTableListResult. </summary>
        /// <param name="value"> The list of routes table. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCircuitsRoutesTableListResult(IReadOnlyList<ExpressRouteCircuitRoutesTable> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of routes table. </summary>
        public IReadOnlyList<ExpressRouteCircuitRoutesTable> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
