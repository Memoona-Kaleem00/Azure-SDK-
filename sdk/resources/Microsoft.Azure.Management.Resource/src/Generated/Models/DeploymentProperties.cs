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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment properties.
    /// </summary>
    public partial class DeploymentProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        public DeploymentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        /// <param name="mode">The mode that is used to deploy resources. This
        /// value can be either Incremental or Complete. In Incremental mode,
        /// resources are deployed without deleting existing resources that are
        /// not included in the template. In Complete mode, resources are
        /// deployed and existing resources in the resource group that are not
        /// included in the template are deleted. Be careful when using
        /// Complete mode as you may unintentionally delete resources. Possible
        /// values include: 'Incremental', 'Complete'</param>
        /// <param name="template">The template content. You use this element
        /// when you want to pass the template syntax directly in the request
        /// rather than link to an existing template. It can be a JObject or
        /// well-formed JSON string. Use either the templateLink property or
        /// the template property, but not both.</param>
        /// <param name="templateLink">The URI of the template. Use either the
        /// templateLink property or the template property, but not
        /// both.</param>
        /// <param name="parameters">Name and value pairs that define the
        /// deployment parameters for the template. You use this element when
        /// you want to provide the parameter values directly in the request
        /// rather than link to an existing parameter file. Use either the
        /// parametersLink property or the parameters property, but not both.
        /// It can be a JObject or a well formed JSON string.</param>
        /// <param name="parametersLink">The URI of parameters file. You use
        /// this element to link to an existing parameters file. Use either the
        /// parametersLink property or the parameters property, but not
        /// both.</param>
        /// <param name="debugSetting">The debug setting of the
        /// deployment.</param>
        /// <param name="onErrorDeployment">The deployment on error
        /// behavior.</param>
        public DeploymentProperties(DeploymentMode mode, object template = default(object), TemplateLink templateLink = default(TemplateLink), object parameters = default(object), ParametersLink parametersLink = default(ParametersLink), DebugSetting debugSetting = default(DebugSetting), OnErrorDeployment onErrorDeployment = default(OnErrorDeployment))
        {
            Template = template;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
            OnErrorDeployment = onErrorDeployment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template content. You use this element when you
        /// want to pass the template syntax directly in the request rather
        /// than link to an existing template. It can be a JObject or
        /// well-formed JSON string. Use either the templateLink property or
        /// the template property, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the URI of the template. Use either the templateLink
        /// property or the template property, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "templateLink")]
        public TemplateLink TemplateLink { get; set; }

        /// <summary>
        /// Gets or sets name and value pairs that define the deployment
        /// parameters for the template. You use this element when you want to
        /// provide the parameter values directly in the request rather than
        /// link to an existing parameter file. Use either the parametersLink
        /// property or the parameters property, but not both. It can be a
        /// JObject or a well formed JSON string.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the URI of parameters file. You use this element to
        /// link to an existing parameters file. Use either the parametersLink
        /// property or the parameters property, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "parametersLink")]
        public ParametersLink ParametersLink { get; set; }

        /// <summary>
        /// Gets or sets the mode that is used to deploy resources. This value
        /// can be either Incremental or Complete. In Incremental mode,
        /// resources are deployed without deleting existing resources that are
        /// not included in the template. In Complete mode, resources are
        /// deployed and existing resources in the resource group that are not
        /// included in the template are deleted. Be careful when using
        /// Complete mode as you may unintentionally delete resources. Possible
        /// values include: 'Incremental', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeploymentMode Mode { get; set; }

        /// <summary>
        /// Gets or sets the debug setting of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "debugSetting")]
        public DebugSetting DebugSetting { get; set; }

        /// <summary>
        /// Gets or sets the deployment on error behavior.
        /// </summary>
        [JsonProperty(PropertyName = "onErrorDeployment")]
        public OnErrorDeployment OnErrorDeployment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ParametersLink != null)
            {
                ParametersLink.Validate();
            }
        }
    }
}
