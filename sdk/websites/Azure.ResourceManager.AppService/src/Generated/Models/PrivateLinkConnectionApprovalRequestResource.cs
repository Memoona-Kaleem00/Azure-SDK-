// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Private Endpoint Connection Approval ARM resource.
    /// Serialized Name: PrivateLinkConnectionApprovalRequestResource
    /// </summary>
    public partial class PrivateLinkConnectionApprovalRequestResource : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateLinkConnectionApprovalRequestResource. </summary>
        public PrivateLinkConnectionApprovalRequestResource()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkConnectionApprovalRequestResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateLinkServiceConnectionState">
        /// The state of a private link connection
        /// Serialized Name: PrivateLinkConnectionApprovalRequestResource.properties.privateLinkServiceConnectionState
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal PrivateLinkConnectionApprovalRequestResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PrivateLinkConnectionState privateLinkServiceConnectionState, string kind) : base(id, name, resourceType, systemData)
        {
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            Kind = kind;
        }

        /// <summary>
        /// The state of a private link connection
        /// Serialized Name: PrivateLinkConnectionApprovalRequestResource.properties.privateLinkServiceConnectionState
        /// </summary>
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
