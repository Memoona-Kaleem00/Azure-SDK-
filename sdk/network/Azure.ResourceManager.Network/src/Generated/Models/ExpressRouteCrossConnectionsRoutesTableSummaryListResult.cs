// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListRoutesTable associated with the Express Route Cross Connections. </summary>
    public partial class ExpressRouteCrossConnectionsRoutesTableSummaryListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionsRoutesTableSummaryListResult. </summary>
        internal ExpressRouteCrossConnectionsRoutesTableSummaryListResult()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionsRoutesTableSummaryListResult. </summary>
        /// <param name="value"> A list of the routes table. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCrossConnectionsRoutesTableSummaryListResult(IReadOnlyList<ExpressRouteCrossConnectionRoutesTableSummary> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of the routes table. </summary>
        public IReadOnlyList<ExpressRouteCrossConnectionRoutesTableSummary> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
