// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary>
    /// Lab services virtual machine image for updates.
    /// Serialized Name: ImageUpdate
    /// </summary>
    public partial class LabServicesImagePatch
    {
        /// <summary> Initializes a new instance of LabServicesImagePatch. </summary>
        public LabServicesImagePatch()
        {
        }

        /// <summary>
        /// Is the image enabled
        /// Serialized Name: ImageUpdate.properties.enabledState
        /// </summary>
        public EnableState? EnabledState { get; set; }
    }
}
