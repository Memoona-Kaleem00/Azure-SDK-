// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A private link resource. </summary>
    public partial class PrivateLinkResource : Resource
    {
        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        public PrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        /// <param name="id"> Fully qualified identifier of the key vault resource. </param>
        /// <param name="name"> Name of the key vault resource. </param>
        /// <param name="type"> Resource type of the key vault resource. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <param name="groupId"> Group identifier of private link resource. </param>
        /// <param name="requiredMembers"> Required member names of private link resource. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        internal PrivateLinkResource(string id, string name, string type, string location, IDictionary<string, string> tags, string groupId, IList<string> requiredMembers, IList<string> requiredZoneNames) : base(id, name, type, location, tags)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> Group identifier of private link resource. </summary>
        public string GroupId { get; }
        /// <summary> Required member names of private link resource. </summary>
        public IList<string> RequiredMembers { get; }
        /// <summary> Required DNS zone names of the the private link resource. </summary>
        public IList<string> RequiredZoneNames { get; set; }
    }
}
