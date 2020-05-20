// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListExpressRouteServiceProvider API service call. </summary>
    public partial class ExpressRouteServiceProviderListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteServiceProviderListResult. </summary>
        internal ExpressRouteServiceProviderListResult()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteServiceProviderListResult. </summary>
        /// <param name="value"> A list of ExpressRouteResourceProvider resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteServiceProviderListResult(IReadOnlyList<ExpressRouteServiceProvider> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of ExpressRouteResourceProvider resources. </summary>
        public IReadOnlyList<ExpressRouteServiceProvider> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
