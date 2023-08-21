// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the RoutingIntent data model.
    /// The routing intent child resource of a Virtual hub.
    /// </summary>
    public partial class RoutingIntentData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of RoutingIntentData. </summary>
        public RoutingIntentData()
        {
            RoutingPolicies = new Core.ChangeTrackingList<RoutingPolicy>();
        }

        /// <summary> Initializes a new instance of RoutingIntentData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routingPolicies"> List of routing policies. </param>
        /// <param name="provisioningState"> The provisioning state of the RoutingIntent resource. </param>
        internal RoutingIntentData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IList<RoutingPolicy> routingPolicies, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            RoutingPolicies = routingPolicies;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> List of routing policies. </summary>
        public IList<RoutingPolicy> RoutingPolicies { get; }
        /// <summary> The provisioning state of the RoutingIntent resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
