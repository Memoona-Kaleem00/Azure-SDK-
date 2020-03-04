// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Consent for Office365 tenant that already made.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OfficeConsent : Resource
    {
        /// <summary>
        /// Initializes a new instance of the OfficeConsent class.
        /// </summary>
        public OfficeConsent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfficeConsent class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tenantId">The tenantId of the Office365 with the
        /// consent.</param>
        /// <param name="tenantName">The tenant name of the Office365 with the
        /// consent.</param>
        public OfficeConsent(string id = default(string), string name = default(string), string type = default(string), string tenantId = default(string), string tenantName = default(string))
            : base(id, name, type)
        {
            TenantId = tenantId;
            TenantName = tenantName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tenantId of the Office365 with the consent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets the tenant name of the Office365 with the consent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantName")]
        public string TenantName { get; private set; }

    }
}
