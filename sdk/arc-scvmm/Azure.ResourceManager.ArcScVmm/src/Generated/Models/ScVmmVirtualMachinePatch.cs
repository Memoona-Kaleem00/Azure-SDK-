// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the virtualMachineUpdate. </summary>
    public partial class ScVmmVirtualMachinePatch
    {
        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachinePatch"/>. </summary>
        public ScVmmVirtualMachinePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Defines the resource properties. </summary>
        public VirtualMachineUpdateProperties Properties { get; set; }
        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
