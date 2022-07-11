// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the MSDeployStatus data model. </summary>
    public partial class MSDeployStatusData : ResourceData
    {
        /// <summary> Initializes a new instance of MSDeployStatusData. </summary>
        public MSDeployStatusData()
        {
        }

        /// <summary> Initializes a new instance of MSDeployStatusData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deployer">
        /// Username of deployer
        /// Serialized Name: MSDeployStatus.properties.deployer
        /// </param>
        /// <param name="provisioningState">
        /// Provisioning state
        /// Serialized Name: MSDeployStatus.properties.provisioningState
        /// </param>
        /// <param name="startOn">
        /// Start time of deploy operation
        /// Serialized Name: MSDeployStatus.properties.startTime
        /// </param>
        /// <param name="endOn">
        /// End time of deploy operation
        /// Serialized Name: MSDeployStatus.properties.endTime
        /// </param>
        /// <param name="isComplete">
        /// Whether the deployment operation has completed
        /// Serialized Name: MSDeployStatus.properties.complete
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal MSDeployStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deployer, MSDeployProvisioningState? provisioningState, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? isComplete, string kind) : base(id, name, resourceType, systemData)
        {
            Deployer = deployer;
            ProvisioningState = provisioningState;
            StartOn = startOn;
            EndOn = endOn;
            IsComplete = isComplete;
            Kind = kind;
        }

        /// <summary>
        /// Username of deployer
        /// Serialized Name: MSDeployStatus.properties.deployer
        /// </summary>
        public string Deployer { get; }
        /// <summary>
        /// Provisioning state
        /// Serialized Name: MSDeployStatus.properties.provisioningState
        /// </summary>
        public MSDeployProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Start time of deploy operation
        /// Serialized Name: MSDeployStatus.properties.startTime
        /// </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary>
        /// End time of deploy operation
        /// Serialized Name: MSDeployStatus.properties.endTime
        /// </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary>
        /// Whether the deployment operation has completed
        /// Serialized Name: MSDeployStatus.properties.complete
        /// </summary>
        public bool? IsComplete { get; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
