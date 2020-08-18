// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list P2SVpnGateways. It contains a list of P2SVpnGateways and a URL nextLink to get the next set of results. </summary>
    public partial class ListP2SVpnGatewaysResult
    {
        /// <summary> Initializes a new instance of ListP2SVpnGatewaysResult. </summary>
        internal ListP2SVpnGatewaysResult()
        {
            Value = new ChangeTrackingList<P2SVpnGateway>();
        }

        /// <summary> Initializes a new instance of ListP2SVpnGatewaysResult. </summary>
        /// <param name="value"> List of P2SVpnGateways. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListP2SVpnGatewaysResult(IReadOnlyList<P2SVpnGateway> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of P2SVpnGateways. </summary>
        public IReadOnlyList<P2SVpnGateway> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
