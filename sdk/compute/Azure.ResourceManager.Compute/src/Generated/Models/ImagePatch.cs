// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source user image virtual hard disk. Only tags may be updated. </summary>
    public partial class ImagePatch : ComputeUpdateResourceData
    {
        /// <summary> Initializes a new instance of ImagePatch. </summary>
        public ImagePatch()
        {
        }

        /// <summary> The source virtual machine from which Image is created. </summary>
        internal WritableSubResource SourceVirtualMachine { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceVirtualMachineId
        {
            get => SourceVirtualMachine is null ? default : SourceVirtualMachine.Id;
            set
            {
                if (SourceVirtualMachine is null)
                    SourceVirtualMachine = new WritableSubResource();
                SourceVirtualMachine.Id = value;
            }
        }

        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public ImageStorageProfile StorageProfile { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed resource. </summary>
        public HyperVGenerationTypes? HyperVGeneration { get; set; }
    }
}
