// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies a list of virtual machine instance IDs from the VM scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetVMInstanceRequiredIDs
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceRequiredIDs class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceRequiredIDs() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceRequiredIDs class.
        /// </summary>
        /// <param name="instanceIds">The virtual machine scale set instance
        /// ids.</param>
        public VirtualMachineScaleSetVMInstanceRequiredIDs(IList<string> instanceIds)
        {
            InstanceIds = instanceIds;
        }

        /// <summary>
        /// Gets or sets the virtual machine scale set instance ids.
        /// </summary>
        [JsonProperty(PropertyName = "instanceIds")]
        public IList<string> InstanceIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InstanceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstanceIds");
            }
        }
    }
}

