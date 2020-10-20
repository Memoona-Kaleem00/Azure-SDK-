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
    /// Managed application notification endpoint.
    /// </summary>
    public partial class ApplicationNotificationEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationNotificationEndpoint
        /// class.
        /// </summary>
        public ApplicationNotificationEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNotificationEndpoint
        /// class.
        /// </summary>
        /// <param name="uri">The managed application notification endpoint
        /// uri.</param>
        public ApplicationNotificationEndpoint(string uri)
        {
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the managed application notification endpoint uri.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
