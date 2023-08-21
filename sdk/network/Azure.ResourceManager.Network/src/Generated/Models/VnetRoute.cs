// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of routes that control routing from VirtualHub into a virtual network connection. </summary>
    public partial class VnetRoute
    {
        /// <summary> Initializes a new instance of VnetRoute. </summary>
        public VnetRoute()
        {
            StaticRoutes = new Core.ChangeTrackingList<StaticRoute>();
            BgpConnections = new Core.ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of VnetRoute. </summary>
        /// <param name="staticRoutesConfig"> Configuration for static routes on this HubVnetConnection. </param>
        /// <param name="staticRoutes"> List of all Static Routes. </param>
        /// <param name="bgpConnections"> The list of references to HubBgpConnection objects. </param>
        internal VnetRoute(StaticRoutesConfig staticRoutesConfig, IList<StaticRoute> staticRoutes, IReadOnlyList<WritableSubResource> bgpConnections)
        {
            StaticRoutesConfig = staticRoutesConfig;
            StaticRoutes = staticRoutes;
            BgpConnections = bgpConnections;
        }

        /// <summary> Configuration for static routes on this HubVnetConnection. </summary>
        public StaticRoutesConfig StaticRoutesConfig { get; set; }
        /// <summary> List of all Static Routes. </summary>
        public IList<StaticRoute> StaticRoutes { get; }
        /// <summary> The list of references to HubBgpConnection objects. </summary>
        public IReadOnlyList<WritableSubResource> BgpConnections { get; }
    }
}
