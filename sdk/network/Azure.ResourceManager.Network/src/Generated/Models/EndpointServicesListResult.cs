// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the ListAvailableEndpointServices API service call. </summary>
    internal partial class EndpointServicesListResult
    {
        /// <summary> Initializes a new instance of EndpointServicesListResult. </summary>
        internal EndpointServicesListResult()
        {
            Value = new Core.ChangeTrackingList<EndpointServiceResult>();
        }

        /// <summary> Initializes a new instance of EndpointServicesListResult. </summary>
        /// <param name="value"> List of available endpoint services in a region. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal EndpointServicesListResult(IReadOnlyList<EndpointServiceResult> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of available endpoint services in a region. </summary>
        public IReadOnlyList<EndpointServiceResult> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
