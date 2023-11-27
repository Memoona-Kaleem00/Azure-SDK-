// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a task. </summary>
    public partial class ContainerRegistryTaskPatch
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskPatch"/>. </summary>
        public ContainerRegistryTaskPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The ARM resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The current status of task. </summary>
        public ContainerRegistryTaskStatus? Status { get; set; }
        /// <summary> The platform properties against which the run has to happen. </summary>
        public ContainerRegistryPlatformUpdateContent Platform { get; set; }
        /// <summary> The machine configuration of the run agent. </summary>
        internal ContainerRegistryAgentProperties AgentConfiguration { get; set; }
        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        public int? AgentCpu
        {
            get => AgentConfiguration is null ? default : AgentConfiguration.Cpu;
            set
            {
                if (AgentConfiguration is null)
                    AgentConfiguration = new ContainerRegistryAgentProperties();
                AgentConfiguration.Cpu = value;
            }
        }

        /// <summary> The dedicated agent pool for the task. </summary>
        public string AgentPoolName { get; set; }
        /// <summary> Run timeout in seconds. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary>
        /// The properties for updating a task step.
        /// Please note <see cref="ContainerRegistryTaskStepUpdateContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryDockerBuildStepUpdateContent"/>, <see cref="ContainerRegistryEncodedTaskStepUpdateContent"/> and <see cref="ContainerRegistryFileTaskStepUpdateContent"/>.
        /// </summary>
        public ContainerRegistryTaskStepUpdateContent Step { get; set; }
        /// <summary> The properties for updating trigger properties. </summary>
        public ContainerRegistryTriggerUpdateContent Trigger { get; set; }
        /// <summary> The parameters that describes a set of credentials that will be used when this run is invoked. </summary>
        public ContainerRegistryCredentials Credentials { get; set; }
        /// <summary> The template that describes the repository and tag information for run log artifact. </summary>
        public string LogTemplate { get; set; }
    }
}
