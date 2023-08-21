// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Load Distribution Policy of an application gateway. </summary>
    public partial class ApplicationGatewayLoadDistributionPolicy : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayLoadDistributionPolicy. </summary>
        public ApplicationGatewayLoadDistributionPolicy()
        {
            LoadDistributionTargets = new Core.ChangeTrackingList<ApplicationGatewayLoadDistributionTarget>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayLoadDistributionPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="loadDistributionTargets"> Load Distribution Targets resource of an application gateway. </param>
        /// <param name="loadDistributionAlgorithm"> Load Distribution Targets resource of an application gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the Load Distribution Policy resource. </param>
        internal ApplicationGatewayLoadDistributionPolicy(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IList<ApplicationGatewayLoadDistributionTarget> loadDistributionTargets, ApplicationGatewayLoadDistributionAlgorithm? loadDistributionAlgorithm, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            LoadDistributionTargets = loadDistributionTargets;
            LoadDistributionAlgorithm = loadDistributionAlgorithm;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Load Distribution Targets resource of an application gateway. </summary>
        public IList<ApplicationGatewayLoadDistributionTarget> LoadDistributionTargets { get; }
        /// <summary> Load Distribution Targets resource of an application gateway. </summary>
        public ApplicationGatewayLoadDistributionAlgorithm? LoadDistributionAlgorithm { get; set; }
        /// <summary> The provisioning state of the Load Distribution Policy resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
