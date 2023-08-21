// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Properties of a private link resource. </summary>
    public partial class MySqlPrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of MySqlPrivateLinkResourceProperties. </summary>
        internal MySqlPrivateLinkResourceProperties()
        {
            RequiredMembers = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MySqlPrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        internal MySqlPrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
    }
}
