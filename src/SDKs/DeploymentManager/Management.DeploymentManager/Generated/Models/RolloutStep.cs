// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a specific step on a target service unit.
    /// </summary>
    public partial class RolloutStep
    {
        /// <summary>
        /// Initializes a new instance of the RolloutStep class.
        /// </summary>
        public RolloutStep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RolloutStep class.
        /// </summary>
        /// <param name="name">Name of the step.</param>
        /// <param name="status">Current state of the step.</param>
        /// <param name="stepGroup">The step group the current step is part
        /// of.</param>
        /// <param name="operationInfo">Detailed information of specific action
        /// execution.</param>
        /// <param name="resourceOperations">Set of resource operations that
        /// were performed, if any, on an Azure resource.</param>
        /// <param name="messages">Supplementary informative messages during
        /// rollout.</param>
        public RolloutStep(string name, string status = default(string), string stepGroup = default(string), StepOperationInfo operationInfo = default(StepOperationInfo), IList<ResourceOperation> resourceOperations = default(IList<ResourceOperation>), IList<Message> messages = default(IList<Message>))
        {
            Name = name;
            Status = status;
            StepGroup = stepGroup;
            OperationInfo = operationInfo;
            ResourceOperations = resourceOperations;
            Messages = messages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the step.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets current state of the step.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets the step group the current step is part of.
        /// </summary>
        [JsonProperty(PropertyName = "stepGroup")]
        public string StepGroup { get; set; }

        /// <summary>
        /// Gets detailed information of specific action execution.
        /// </summary>
        [JsonProperty(PropertyName = "operationInfo")]
        public StepOperationInfo OperationInfo { get; private set; }

        /// <summary>
        /// Gets set of resource operations that were performed, if any, on an
        /// Azure resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceOperations")]
        public IList<ResourceOperation> ResourceOperations { get; private set; }

        /// <summary>
        /// Gets supplementary informative messages during rollout.
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public IList<Message> Messages { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
