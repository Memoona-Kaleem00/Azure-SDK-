// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    public partial class VirtualMachineScaleSetStorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetStorageProfile class.
        /// </summary>
        public VirtualMachineScaleSetStorageProfile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetStorageProfile class.
        /// </summary>
        /// <param name="imageReference">Specifies information about the image
        /// to use. You can specify information about platform images,
        /// marketplace images, or virtual machine images. This element is
        /// required when you want to use a platform image, marketplace image,
        /// or virtual machine image, but is not used in other creation
        /// operations.</param>
        /// <param name="osDisk">Specifies information about the operating
        /// system disk used by the virtual machines in the scale set.
        /// &lt;br&gt;&lt;br&gt; For more information about disks, see [About
        /// disks and VHDs for Azure virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).</param>
        /// <param name="dataDisks">Specifies the parameters that are used to
        /// add data disks to the virtual machines in the scale set.
        /// &lt;br&gt;&lt;br&gt; For more information about disks, see [About
        /// disks and VHDs for Azure virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).</param>
        public VirtualMachineScaleSetStorageProfile(ImageReference imageReference = default(ImageReference), VirtualMachineScaleSetOSDisk osDisk = default(VirtualMachineScaleSetOSDisk), IList<VirtualMachineScaleSetDataDisk> dataDisks = default(IList<VirtualMachineScaleSetDataDisk>))
        {
            ImageReference = imageReference;
            OsDisk = osDisk;
            DataDisks = dataDisks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies information about the image to use. You can
        /// specify information about platform images, marketplace images, or
        /// virtual machine images. This element is required when you want to
        /// use a platform image, marketplace image, or virtual machine image,
        /// but is not used in other creation operations.
        /// </summary>
        [JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the operating system disk
        /// used by the virtual machines in the scale set.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For more information about
        /// disks, see [About disks and VHDs for Azure virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// </summary>
        [JsonProperty(PropertyName = "osDisk")]
        public VirtualMachineScaleSetOSDisk OsDisk { get; set; }

        /// <summary>
        /// Gets or sets specifies the parameters that are used to add data
        /// disks to the virtual machines in the scale set.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For more information about
        /// disks, see [About disks and VHDs for Azure virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// </summary>
        [JsonProperty(PropertyName = "dataDisks")]
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OsDisk != null)
            {
                OsDisk.Validate();
            }
            if (DataDisks != null)
            {
                foreach (var element in DataDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
