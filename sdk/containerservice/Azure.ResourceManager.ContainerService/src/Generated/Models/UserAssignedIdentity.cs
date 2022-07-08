// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Details about a user assigned identity. </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        public UserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        /// <param name="resourceId"> The resource ID of the user assigned identity. </param>
        /// <param name="clientId"> The client ID of the user assigned identity. </param>
        /// <param name="objectId"> The object ID of the user assigned identity. </param>
        internal UserAssignedIdentity(string resourceId, string clientId, string objectId)
        {
            ResourceId = resourceId;
            ClientId = clientId;
            ObjectId = objectId;
        }

        /// <summary> The resource ID of the user assigned identity. </summary>
        public string ResourceId { get; set; }
        /// <summary> The client ID of the user assigned identity. </summary>
        public string ClientId { get; set; }
        /// <summary> The object ID of the user assigned identity. </summary>
        public string ObjectId { get; set; }
    }
}
