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
    /// A class representing the RouteFilterRule data model.
    /// Route Filter Rule Resource.
    /// </summary>
    public partial class RouteFilterRuleData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of RouteFilterRuleData. </summary>
        public RouteFilterRuleData()
        {
            Communities = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RouteFilterRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="access"> The access type of the rule. </param>
        /// <param name="routeFilterRuleType"> The rule type of the rule. </param>
        /// <param name="communities"> The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']. </param>
        /// <param name="provisioningState"> The provisioning state of the route filter rule resource. </param>
        internal RouteFilterRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, ETag? etag, NetworkAccess? access, RouteFilterRuleType? routeFilterRuleType, IList<string> communities, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Location = location;
            ETag = etag;
            Access = access;
            RouteFilterRuleType = routeFilterRuleType;
            Communities = communities;
            ProvisioningState = provisioningState;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The access type of the rule. </summary>
        public NetworkAccess? Access { get; set; }
        /// <summary> The rule type of the rule. </summary>
        public RouteFilterRuleType? RouteFilterRuleType { get; set; }
        /// <summary> The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']. </summary>
        public IList<string> Communities { get; }
        /// <summary> The provisioning state of the route filter rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
