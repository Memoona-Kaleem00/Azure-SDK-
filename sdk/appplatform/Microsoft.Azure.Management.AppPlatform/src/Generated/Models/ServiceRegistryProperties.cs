// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service Registry properties payload
    /// </summary>
    public partial class ServiceRegistryProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServiceRegistryProperties class.
        /// </summary>
        public ServiceRegistryProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceRegistryProperties class.
        /// </summary>
        /// <param name="provisioningState">State of the Service Registry.
        /// Possible values include: 'Creating', 'Updating', 'Succeeded',
        /// 'Failed', 'Deleting'</param>
        /// <param name="resourceRequests">The requested resource quantity for
        /// required CPU and Memory.</param>
        /// <param name="instances">Collection of instances belong to Service
        /// Registry.</param>
        public ServiceRegistryProperties(string provisioningState = default(string), ServiceRegistryResourceRequests resourceRequests = default(ServiceRegistryResourceRequests), IList<ServiceRegistryInstance> instances = default(IList<ServiceRegistryInstance>))
        {
            ProvisioningState = provisioningState;
            ResourceRequests = resourceRequests;
            Instances = instances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets state of the Service Registry. Possible values include:
        /// 'Creating', 'Updating', 'Succeeded', 'Failed', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the requested resource quantity for required CPU and
        /// Memory.
        /// </summary>
        [JsonProperty(PropertyName = "resourceRequests")]
        public ServiceRegistryResourceRequests ResourceRequests { get; set; }

        /// <summary>
        /// Gets collection of instances belong to Service Registry.
        /// </summary>
        [JsonProperty(PropertyName = "instances")]
        public IList<ServiceRegistryInstance> Instances { get; private set; }

    }
}
