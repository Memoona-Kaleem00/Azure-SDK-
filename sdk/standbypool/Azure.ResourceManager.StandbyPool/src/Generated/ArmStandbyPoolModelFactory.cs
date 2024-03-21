// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmStandbyPoolModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="StandbyPool.StandbyContainerGroupPoolResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="elasticityProfile"> Specifies elasticity profile of standby container group pools. </param>
        /// <param name="containerGroupProperties"> Specifies container group properties of standby container group pools. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="StandbyPool.StandbyContainerGroupPoolResourceData"/> instance for mocking. </returns>
        public static StandbyContainerGroupPoolResourceData StandbyContainerGroupPoolResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, StandbyContainerGroupPoolElasticityProfile elasticityProfile = null, ContainerGroupProperties containerGroupProperties = null, ProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new StandbyContainerGroupPoolResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                elasticityProfile,
                containerGroupProperties,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="StandbyPool.StandbyVirtualMachinePoolResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="elasticityMaxReadyCapacity"> Specifies the elasticity profile of the standby virtual machine pools. </param>
        /// <param name="virtualMachineState"> Specifies the desired state of virtual machines in the pool. </param>
        /// <param name="attachedVirtualMachineScaleSetId"> Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="StandbyPool.StandbyVirtualMachinePoolResourceData"/> instance for mocking. </returns>
        public static StandbyVirtualMachinePoolResourceData StandbyVirtualMachinePoolResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, long? elasticityMaxReadyCapacity = null, VirtualMachineState? virtualMachineState = null, ResourceIdentifier attachedVirtualMachineScaleSetId = null, ProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new StandbyVirtualMachinePoolResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                elasticityMaxReadyCapacity.HasValue ? new StandbyVirtualMachinePoolElasticityProfile(elasticityMaxReadyCapacity.Value, serializedAdditionalRawData: null) : null,
                virtualMachineState,
                attachedVirtualMachineScaleSetId,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="StandbyPool.StandbyVirtualMachineResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualMachineResourceId"> Resource id of the virtual machine. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="StandbyPool.StandbyVirtualMachineResourceData"/> instance for mocking. </returns>
        public static StandbyVirtualMachineResourceData StandbyVirtualMachineResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string virtualMachineResourceId = null, ProvisioningState? provisioningState = null)
        {
            return new StandbyVirtualMachineResourceData(
                id,
                name,
                resourceType,
                systemData,
                virtualMachineResourceId,
                provisioningState,
                serializedAdditionalRawData: null);
        }
    }
}
