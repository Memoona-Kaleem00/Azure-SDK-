// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPMonitors.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the request body for updating SAP monitor resource.
    /// </summary>
    public partial class UpdateMonitorRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateMonitorRequest class.
        /// </summary>
        public UpdateMonitorRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateMonitorRequest class.
        /// </summary>
        /// <param name="tags">Gets or sets the Resource tags.</param>
        public UpdateMonitorRequest(IDictionary<string, string> tags = default(IDictionary<string, string>), ManagedServiceIdentity identity = default(ManagedServiceIdentity))
        {
            Tags = tags;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
