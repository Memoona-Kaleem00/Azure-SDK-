// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Managed identity credential.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ManagedIdentity")]
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedIdentityCredential : Credential
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIdentityCredential class.
        /// </summary>
        public ManagedIdentityCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIdentityCredential class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Credential description.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Credential.</param>
        /// <param name="resourceId">The resource id of user assigned managed
        /// identity</param>
        public ManagedIdentityCredential(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<object> annotations = default(IList<object>), string resourceId = default(string))
            : base(additionalProperties, description, annotations)
        {
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of user assigned managed identity
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.resourceId")]
        public string ResourceId { get; set; }

    }
}
