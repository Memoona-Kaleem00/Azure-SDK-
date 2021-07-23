// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> (Optional) The ID of the parent management group used during creation. </summary>
    public partial class CreateParentGroupInfo
    {
        /// <summary> Initializes a new instance of CreateParentGroupInfo. </summary>
        public CreateParentGroupInfo()
        {
        }

        /// <summary> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; set; }
        /// <summary> The name of the parent management group. </summary>
        public string Name { get; }
        /// <summary> The friendly name of the parent management group. </summary>
        public string DisplayName { get; }
    }
}
