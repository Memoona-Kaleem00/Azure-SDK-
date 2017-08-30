// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base Properties of an API Management service resource description.
    /// </summary>
    public partial class ApiManagementServiceBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceBaseProperties class.
        /// </summary>
        public ApiManagementServiceBaseProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceBaseProperties class.
        /// </summary>
        /// <param name="notificationSenderEmail">Email address from which the
        /// notification will be sent.</param>
        /// <param name="provisioningState">The current provisioning state of
        /// the API Management service which can be one of the following:
        /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.</param>
        /// <param name="targetProvisioningState">The provisioning state of the
        /// API Management service, which is targeted by the long running
        /// operation started on the service.</param>
        /// <param name="createdAtUtc">Creation UTC date of the API Management
        /// service.The date conforms to the following format:
        /// `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601
        /// standard.</param>
        /// <param name="gatewayUrl">Gateway URL of the API Management
        /// service.</param>
        /// <param name="portalUrl">Publisher portal endpoint Url of the API
        /// Management service.</param>
        /// <param name="managementApiUrl">Management API endpoint URL of the
        /// API Management service.</param>
        /// <param name="scmUrl">SCM endpoint URL of the API Management
        /// service.</param>
        /// <param name="hostnameConfigurations">Custom hostname configuration
        /// of the API Management service.</param>
        /// <param name="staticIps">Static IP addresses of the API Management
        /// service virtual machines. Available only for Standard and Premium
        /// SKU.</param>
        /// <param name="virtualNetworkConfiguration">Virtual network
        /// configuration of the API Management service.</param>
        /// <param name="additionalLocations">Additional datacenter locations
        /// of the API Management service.</param>
        /// <param name="customProperties">Custom properties of the API
        /// Management service, like disabling TLS 1.0.</param>
        /// <param name="virtualNetworkType">The type of VPN in which API
        /// Managemet service needs to be configured in. None (Default Value)
        /// means the API Management service is not part of any Virtual
        /// Network, External means the API Management deployment is set up
        /// inside a Virtual Network having an Internet Facing Endpoint, and
        /// Internal means that API Management deployment is setup inside a
        /// Virtual Network having an Intranet Facing Endpoint only. Possible
        /// values include: 'None', 'External', 'Internal'</param>
        public ApiManagementServiceBaseProperties(string notificationSenderEmail = default(string), string provisioningState = default(string), string targetProvisioningState = default(string), System.DateTime? createdAtUtc = default(System.DateTime?), string gatewayUrl = default(string), string portalUrl = default(string), string managementApiUrl = default(string), string scmUrl = default(string), IList<HostnameConfiguration> hostnameConfigurations = default(IList<HostnameConfiguration>), IList<string> staticIps = default(IList<string>), VirtualNetworkConfiguration virtualNetworkConfiguration = default(VirtualNetworkConfiguration), IList<AdditionalLocation> additionalLocations = default(IList<AdditionalLocation>), IDictionary<string, string> customProperties = default(IDictionary<string, string>), VirtualNetworkType? virtualNetworkType = default(VirtualNetworkType?))
        {
            NotificationSenderEmail = notificationSenderEmail;
            ProvisioningState = provisioningState;
            TargetProvisioningState = targetProvisioningState;
            CreatedAtUtc = createdAtUtc;
            GatewayUrl = gatewayUrl;
            PortalUrl = portalUrl;
            ManagementApiUrl = managementApiUrl;
            ScmUrl = scmUrl;
            HostnameConfigurations = hostnameConfigurations;
            StaticIps = staticIps;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            AdditionalLocations = additionalLocations;
            CustomProperties = customProperties;
            VirtualNetworkType = virtualNetworkType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets email address from which the notification will be
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "notificationSenderEmail")]
        public string NotificationSenderEmail { get; set; }

        /// <summary>
        /// Gets the current provisioning state of the API Management service
        /// which can be one of the following:
        /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the API Management service, which is
        /// targeted by the long running operation started on the service.
        /// </summary>
        [JsonProperty(PropertyName = "targetProvisioningState")]
        public string TargetProvisioningState { get; private set; }

        /// <summary>
        /// Gets creation UTC date of the API Management service.The date
        /// conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
        /// specified by the ISO 8601 standard.
        /// </summary>
        [JsonProperty(PropertyName = "createdAtUtc")]
        public System.DateTime? CreatedAtUtc { get; private set; }

        /// <summary>
        /// Gets gateway URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayUrl")]
        public string GatewayUrl { get; private set; }

        /// <summary>
        /// Gets publisher portal endpoint Url of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "portalUrl")]
        public string PortalUrl { get; private set; }

        /// <summary>
        /// Gets management API endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "managementApiUrl")]
        public string ManagementApiUrl { get; private set; }

        /// <summary>
        /// Gets SCM endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "scmUrl")]
        public string ScmUrl { get; private set; }

        /// <summary>
        /// Gets or sets custom hostname configuration of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "hostnameConfigurations")]
        public IList<HostnameConfiguration> HostnameConfigurations { get; set; }

        /// <summary>
        /// Gets static IP addresses of the API Management service virtual
        /// machines. Available only for Standard and Premium SKU.
        /// </summary>
        [JsonProperty(PropertyName = "staticIps")]
        public IList<string> StaticIps { get; private set; }

        /// <summary>
        /// Gets or sets virtual network configuration of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkConfiguration")]
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets additional datacenter locations of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "additionalLocations")]
        public IList<AdditionalLocation> AdditionalLocations { get; set; }

        /// <summary>
        /// Gets or sets custom properties of the API Management service, like
        /// disabling TLS 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "customProperties")]
        public IDictionary<string, string> CustomProperties { get; set; }

        /// <summary>
        /// Gets or sets the type of VPN in which API Managemet service needs
        /// to be configured in. None (Default Value) means the API Management
        /// service is not part of any Virtual Network, External means the API
        /// Management deployment is set up inside a Virtual Network having an
        /// Internet Facing Endpoint, and Internal means that API Management
        /// deployment is setup inside a Virtual Network having an Intranet
        /// Facing Endpoint only. Possible values include: 'None', 'External',
        /// 'Internal'
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkType")]
        public VirtualNetworkType? VirtualNetworkType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NotificationSenderEmail != null)
            {
                if (NotificationSenderEmail.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "NotificationSenderEmail", 100);
                }
            }
            if (HostnameConfigurations != null)
            {
                foreach (var element in HostnameConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (VirtualNetworkConfiguration != null)
            {
                VirtualNetworkConfiguration.Validate();
            }
            if (AdditionalLocations != null)
            {
                foreach (var element1 in AdditionalLocations)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
