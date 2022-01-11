// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the Gallery data model. </summary>
    public partial class GalleryData : TrackedResource
    {
        /// <summary> Initializes a new instance of GalleryData. </summary>
        /// <param name="location"> The location. </param>
        public GalleryData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of GalleryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of this Shared Image Gallery resource. This property is updatable. </param>
        /// <param name="identifier"> Describes the gallery unique name. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="sharingProfile"> Profile for gallery sharing to subscription or tenant. </param>
        internal GalleryData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string description, GalleryIdentifier identifier, GalleryPropertiesProvisioningState? provisioningState, SharingProfile sharingProfile) : base(id, name, type, tags, location)
        {
            Description = description;
            Identifier = identifier;
            ProvisioningState = provisioningState;
            SharingProfile = sharingProfile;
        }

        /// <summary> The description of this Shared Image Gallery resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> Describes the gallery unique name. </summary>
        public GalleryIdentifier Identifier { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> Profile for gallery sharing to subscription or tenant. </summary>
        public SharingProfile SharingProfile { get; set; }
    }
}
