// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// CDN CustomDomain represents a mapping between a user specified domain
    /// name and a CDN endpoint. This is to use custom domain names to
    /// represent the URLs for branding purposes.
    /// </summary>
    public partial class CustomDomain : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain() { }

        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain(string hostName, string id = default(string), string name = default(string), string type = default(string), CustomDomainResourceState? resourceState = default(CustomDomainResourceState?), ProvisioningState? provisioningState = default(ProvisioningState?))
            : base(id, name, type)
        {
            HostName = hostName;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// The host name of the custom domain. Must be a domain name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Resource status of the custom domain. Possible values for this
        /// property include: 'Creating', 'Active', 'Deleting'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public CustomDomainResourceState? ResourceState { get; private set; }

        /// <summary>
        /// Provisioning status of the custom domain. Possible values for this
        /// property include: 'Creating', 'Succeeded', 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
