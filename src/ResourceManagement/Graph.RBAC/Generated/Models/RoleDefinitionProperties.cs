// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Role definition properties.
    /// </summary>
    public partial class RoleDefinitionProperties
    {
        /// <summary>
        /// Initializes a new instance of the RoleDefinitionProperties class.
        /// </summary>
        public RoleDefinitionProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDefinitionProperties class.
        /// </summary>
        /// <param name="roleName">The role name.</param>
        /// <param name="description">The role definition description.</param>
        /// <param name="type">The role type.</param>
        /// <param name="permissions">Role definition permissions.</param>
        /// <param name="assignableScopes">Role definition assignable
        /// scopes.</param>
        public RoleDefinitionProperties(string roleName = default(string), string description = default(string), string type = default(string), IList<Permission> permissions = default(IList<Permission>), IList<string> assignableScopes = default(IList<string>))
        {
            RoleName = roleName;
            Description = description;
            Type = type;
            Permissions = permissions;
            AssignableScopes = assignableScopes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the role definition description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the role type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets role definition permissions.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public IList<Permission> Permissions { get; set; }

        /// <summary>
        /// Gets or sets role definition assignable scopes.
        /// </summary>
        [JsonProperty(PropertyName = "assignableScopes")]
        public IList<string> AssignableScopes { get; set; }

    }
}
