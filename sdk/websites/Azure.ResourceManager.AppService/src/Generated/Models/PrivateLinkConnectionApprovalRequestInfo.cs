// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Private Endpoint Connection Approval ARM resource. </summary>
    public partial class PrivateLinkConnectionApprovalRequestInfo : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionApprovalRequestInfo"/>. </summary>
        public PrivateLinkConnectionApprovalRequestInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionApprovalRequestInfo"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateLinkServiceConnectionState"> The state of a private link connection. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkConnectionApprovalRequestInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PrivateLinkConnectionState privateLinkServiceConnectionState, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> The state of a private link connection. </summary>
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
