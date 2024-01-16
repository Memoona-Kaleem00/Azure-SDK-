// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ServiceAssociationLink resource. </summary>
    public partial class ServiceAssociationLink : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceAssociationLink"/>. </summary>
        public ServiceAssociationLink()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAssociationLink"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="linkedResourceType"> Resource type of the linked resource. </param>
        /// <param name="link"> Link to the external resource. </param>
        /// <param name="provisioningState"> The provisioning state of the service association link resource. </param>
        /// <param name="allowDelete"> If true, the resource can be deleted. </param>
        /// <param name="locations"> A list of locations. </param>
        internal ServiceAssociationLink(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, ResourceType? linkedResourceType, ResourceIdentifier link, NetworkProvisioningState? provisioningState, bool? allowDelete, IList<AzureLocation> locations) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            LinkedResourceType = linkedResourceType;
            Link = link;
            ProvisioningState = provisioningState;
            AllowDelete = allowDelete;
            Locations = locations;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource type of the linked resource. </summary>
        public ResourceType? LinkedResourceType { get; set; }
        /// <summary> Link to the external resource. </summary>
        public ResourceIdentifier Link { get; set; }
        /// <summary> The provisioning state of the service association link resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> If true, the resource can be deleted. </summary>
        public bool? AllowDelete { get; set; }
        /// <summary> A list of locations. </summary>
        public IList<AzureLocation> Locations { get; }
    }
}
