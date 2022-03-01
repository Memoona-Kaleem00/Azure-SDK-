// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies a list of virtual machine instance IDs from the VM scale set. </summary>
    public partial class VirtualMachineScaleSetVmInstanceRequiredIds
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmInstanceRequiredIds. </summary>
        /// <param name="instanceIds"> The virtual machine scale set instance ids. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceIds"/> is null. </exception>
        public VirtualMachineScaleSetVmInstanceRequiredIds(IEnumerable<string> instanceIds)
        {
            if (instanceIds == null)
            {
                throw new ArgumentNullException(nameof(instanceIds));
            }

            InstanceIds = instanceIds.ToList();
        }

        /// <summary> The virtual machine scale set instance ids. </summary>
        public IList<string> InstanceIds { get; }
    }
}
