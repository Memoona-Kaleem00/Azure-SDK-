// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the service principal.
    /// </summary>
    public partial class ServicePrincipalProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalProperties class.
        /// </summary>
        public ServicePrincipalProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalProperties class.
        /// </summary>
        /// <param name="applicationId">Application id of service
        /// principal.</param>
        /// <param name="secret">A secret string that the application uses to
        /// prove its identity, also can be referred to as application password
        /// (write only).</param>
        public ServicePrincipalProperties(string applicationId = default(string), string secret = default(string))
        {
            ApplicationId = applicationId;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application id of service principal.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets a secret string that the application uses to prove its
        /// identity, also can be referred to as application password (write
        /// only).
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

    }
}
