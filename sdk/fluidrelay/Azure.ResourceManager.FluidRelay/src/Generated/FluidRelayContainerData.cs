// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.FluidRelay.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FluidRelay
{
    /// <summary> A class representing the FluidRelayContainer data model. </summary>
    public partial class FluidRelayContainerData : ResourceData
    {
        /// <summary> Initializes a new instance of FluidRelayContainerData. </summary>
        public FluidRelayContainerData()
        {
        }

        /// <summary> Initializes a new instance of FluidRelayContainerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="frsTenantId"> The Fluid tenantId for this container. </param>
        /// <param name="frsContainerId"> The frsContainerId for this container. </param>
        /// <param name="provisioningState"> Provision states for FluidRelay RP. </param>
        internal FluidRelayContainerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string frsTenantId, string frsContainerId, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            FrsTenantId = frsTenantId;
            FrsContainerId = frsContainerId;
            ProvisioningState = provisioningState;
        }

        /// <summary> The Fluid tenantId for this container. </summary>
        public string FrsTenantId { get; }
        /// <summary> The frsContainerId for this container. </summary>
        public string FrsContainerId { get; }
        /// <summary> Provision states for FluidRelay RP. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
