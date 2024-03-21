// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the RouteTable data model.
    /// Route table resource.
    /// </summary>
    public partial class RouteTableData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RouteTableData"/>. </summary>
        public RouteTableData()
        {
            Routes = new ChangeTrackingList<RouteData>();
            Subnets = new ChangeTrackingList<SubnetData>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteTableData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routes"> Collection of routes contained within a route table. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="disableBgpRoutePropagation"> Whether to disable the routes learned by BGP on that route table. True means disable. </param>
        /// <param name="provisioningState"> The provisioning state of the route table resource. </param>
        /// <param name="resourceGuid"> The resource GUID property of the route table. </param>
        internal RouteTableData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, IList<RouteData> routes, IReadOnlyList<SubnetData> subnets, bool? disableBgpRoutePropagation, NetworkProvisioningState? provisioningState, Guid? resourceGuid) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            Routes = routes;
            Subnets = subnets;
            DisableBgpRoutePropagation = disableBgpRoutePropagation;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Collection of routes contained within a route table. </summary>
        public IList<RouteData> Routes { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<SubnetData> Subnets { get; }
        /// <summary> Whether to disable the routes learned by BGP on that route table. True means disable. </summary>
        public bool? DisableBgpRoutePropagation { get; set; }
        /// <summary> The provisioning state of the route table resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The resource GUID property of the route table. </summary>
        public Guid? ResourceGuid { get; }
    }
}
