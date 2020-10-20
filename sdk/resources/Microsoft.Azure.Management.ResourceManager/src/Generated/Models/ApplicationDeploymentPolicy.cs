// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed application deployment policy.
    /// </summary>
    public partial class ApplicationDeploymentPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationDeploymentPolicy
        /// class.
        /// </summary>
        public ApplicationDeploymentPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationDeploymentPolicy
        /// class.
        /// </summary>
        /// <param name="deploymentMode">The managed application deployment
        /// mode. Possible values include: 'NotSpecified', 'Incremental',
        /// 'Complete'</param>
        public ApplicationDeploymentPolicy(string deploymentMode)
        {
            DeploymentMode = deploymentMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the managed application deployment mode. Possible
        /// values include: 'NotSpecified', 'Incremental', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "deploymentMode")]
        public string DeploymentMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeploymentMode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeploymentMode");
            }
        }
    }
}
