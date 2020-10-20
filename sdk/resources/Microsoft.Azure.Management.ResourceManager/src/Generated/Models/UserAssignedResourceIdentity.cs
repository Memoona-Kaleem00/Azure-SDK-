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
    /// Represents the user assigned identity that is contained within the
    /// UserAssignedIdentities dictionary on ResourceIdentity
    /// </summary>
    public partial class UserAssignedResourceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UserAssignedResourceIdentity
        /// class.
        /// </summary>
        public UserAssignedResourceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAssignedResourceIdentity
        /// class.
        /// </summary>
        /// <param name="principalId">The principal id of user assigned
        /// identity.</param>
        /// <param name="tenantId">The tenant id of user assigned
        /// identity.</param>
        public UserAssignedResourceIdentity(string principalId = default(string), string tenantId = default(string))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

    }
}
