// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Management group creation parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CreateManagementGroupRequest : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CreateManagementGroupRequest
        /// class.
        /// </summary>
        public CreateManagementGroupRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateManagementGroupRequest
        /// class.
        /// </summary>
        /// <param name="id">The fully qualified ID for the management group.
        /// For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000</param>
        /// <param name="type">The type of the resource.  For example,
        /// Microsoft.Management/managementGroups</param>
        /// <param name="name">The name of the management group. For example,
        /// 00000000-0000-0000-0000-000000000000</param>
        /// <param name="tenantId">The AAD Tenant ID associated with the
        /// management group. For example,
        /// 00000000-0000-0000-0000-000000000000</param>
        /// <param name="displayName">The friendly name of the management
        /// group. If no value is passed then this  field will be set to the
        /// groupId.</param>
        /// <param name="details">Details</param>
        /// <param name="children">The list of children.</param>
        public CreateManagementGroupRequest(string id = default(string), string type = default(string), string name = default(string), string tenantId = default(string), string displayName = default(string), CreateManagementGroupDetails details = default(CreateManagementGroupDetails), IList<CreateManagementGroupChildInfo> children = default(IList<CreateManagementGroupChildInfo>))
        {
            Id = id;
            Type = type;
            Name = name;
            TenantId = tenantId;
            DisplayName = displayName;
            Details = details;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the fully qualified ID for the management group.  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the resource.  For example,
        /// Microsoft.Management/managementGroups
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the name of the management group. For example,
        /// 00000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the AAD Tenant ID associated with the management group. For
        /// example, 00000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the friendly name of the management group. If no value
        /// is passed then this  field will be set to the groupId.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets details
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public CreateManagementGroupDetails Details { get; set; }

        /// <summary>
        /// Gets the list of children.
        /// </summary>
        [JsonProperty(PropertyName = "properties.children")]
        public IList<CreateManagementGroupChildInfo> Children { get; private set; }

    }
}
