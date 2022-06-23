// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Network profile. </summary>
    public partial class NetworkProfile
    {
        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        /// <param name="loadBalancerType"> Load balancer type. </param>
        public NetworkProfile(LoadBalancerType loadBalancerType)
        {
            LoadBalancerType = loadBalancerType;
            OutboundPublicIPResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        /// <param name="loadBalancerType"> Load balancer type. </param>
        /// <param name="loadBalancerSku"> Load balancer SKU. </param>
        /// <param name="loadBalancerTier"> Load balancer tier. </param>
        /// <param name="capacity"> Capacity, applicable only for Application Gateway. </param>
        /// <param name="azureFrontDoorEnabled"> Whether to enable Azure front door. </param>
        /// <param name="vNetResourceId"> Virtual network resource Id. </param>
        /// <param name="loadBalancerResourceId"> Azure Loadbalancer or ApplicationGateway resource Id. </param>
        /// <param name="azureFrontDoorResourceId"> Azure front door resource id. </param>
        /// <param name="frontEndPublicIPResourceId"> Loadbalancer front-end IP address resource Id. </param>
        /// <param name="outboundPublicIPResourceIds"> List of outbound public IP resource IDs. </param>
        internal NetworkProfile(LoadBalancerType loadBalancerType, string loadBalancerSku, string loadBalancerTier, int? capacity, AzureFrontDoorEnabled? azureFrontDoorEnabled, ResourceIdentifier vNetResourceId, ResourceIdentifier loadBalancerResourceId, ResourceIdentifier azureFrontDoorResourceId, ResourceIdentifier frontEndPublicIPResourceId, IReadOnlyList<string> outboundPublicIPResourceIds)
        {
            LoadBalancerType = loadBalancerType;
            LoadBalancerSku = loadBalancerSku;
            LoadBalancerTier = loadBalancerTier;
            Capacity = capacity;
            AzureFrontDoorEnabled = azureFrontDoorEnabled;
            VNetResourceId = vNetResourceId;
            LoadBalancerResourceId = loadBalancerResourceId;
            AzureFrontDoorResourceId = azureFrontDoorResourceId;
            FrontEndPublicIPResourceId = frontEndPublicIPResourceId;
            OutboundPublicIPResourceIds = outboundPublicIPResourceIds;
        }

        /// <summary> Load balancer type. </summary>
        public LoadBalancerType LoadBalancerType { get; set; }
        /// <summary> Load balancer SKU. </summary>
        public string LoadBalancerSku { get; set; }
        /// <summary> Load balancer tier. </summary>
        public string LoadBalancerTier { get; set; }
        /// <summary> Capacity, applicable only for Application Gateway. </summary>
        public int? Capacity { get; set; }
        /// <summary> Whether to enable Azure front door. </summary>
        public AzureFrontDoorEnabled? AzureFrontDoorEnabled { get; set; }
        /// <summary> Virtual network resource Id. </summary>
        public ResourceIdentifier VNetResourceId { get; }
        /// <summary> Azure Loadbalancer or ApplicationGateway resource Id. </summary>
        public ResourceIdentifier LoadBalancerResourceId { get; }
        /// <summary> Azure front door resource id. </summary>
        public ResourceIdentifier AzureFrontDoorResourceId { get; }
        /// <summary> Loadbalancer front-end IP address resource Id. </summary>
        public ResourceIdentifier FrontEndPublicIPResourceId { get; }
        /// <summary> List of outbound public IP resource IDs. </summary>
        public IReadOnlyList<string> OutboundPublicIPResourceIds { get; }
    }
}
