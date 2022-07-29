// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to the Update Group operation. </summary>
    public partial class ApiManagementGroupPatch
    {
        /// <summary> Initializes a new instance of ApiManagementGroupPatch. </summary>
        public ApiManagementGroupPatch()
        {
        }

        /// <summary> Group name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Group description. </summary>
        public string Description { get; set; }
        /// <summary> Group type. </summary>
        public ApiManagementGroupType? ApiManagementGroupType { get; set; }
        /// <summary> Identifier of the external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </summary>
        public string ExternalId { get; set; }
    }
}
