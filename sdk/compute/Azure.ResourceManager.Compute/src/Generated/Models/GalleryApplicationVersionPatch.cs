// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Version that you want to update. </summary>
    public partial class GalleryApplicationVersionPatch : GalleryUpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionPatch. </summary>
        public GalleryApplicationVersionPatch()
        {
        }

        /// <summary> The publishing profile of a gallery image version. </summary>
        public GalleryApplicationVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryApplicationVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the replication status of the gallery image version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}
