// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of virtual network gateway routes. </summary>
    public partial class GatewayRouteListResult
    {
        /// <summary> Initializes a new instance of GatewayRouteListResult. </summary>
        internal GatewayRouteListResult()
        {
            Value = new ChangeTrackingList<GatewayRoute>();
        }

        /// <summary> Initializes a new instance of GatewayRouteListResult. </summary>
        /// <param name="value"> List of gateway routes. </param>
        internal GatewayRouteListResult(IReadOnlyList<GatewayRoute> value)
        {
            Value = value;
        }

        /// <summary> List of gateway routes. </summary>
        public IReadOnlyList<GatewayRoute> Value { get; }
    }
}
