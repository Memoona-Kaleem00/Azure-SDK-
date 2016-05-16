// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The configuration for compute nodes in a pool based on the Azure
    /// Virtual Machines infrastructure.
    /// </summary>
    public partial class VirtualMachineConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineConfiguration
        /// class.
        /// </summary>
        public VirtualMachineConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineConfiguration
        /// class.
        /// </summary>
        public VirtualMachineConfiguration(ImageReference imageReference, string nodeAgentSKUId = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration))
        {
            ImageReference = imageReference;
            NodeAgentSKUId = nodeAgentSKUId;
            WindowsConfiguration = windowsConfiguration;
        }

        /// <summary>
        /// Gets or sets a reference to the Azure Virtual Machines Marketplace
        /// image to use.
        /// </summary>
        [JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets the SKU of Batch Node Agent to be provisioned on the
        /// compute node. The Batch node agent is a program that runs on each
        /// node in the pool, and provides the command-and-control interface
        /// between the node and the Batch service. There are different
        /// implementations of the node agent, known as SKUs, for different
        /// operating systems.
        /// </summary>
        [JsonProperty(PropertyName = "nodeAgentSKUId")]
        public string NodeAgentSKUId { get; set; }

        /// <summary>
        /// Gets or sets windows operating system settings on the virtual
        /// machine. This property must not be specified if the
        /// ImageReference property specifies a Linux OS image.
        /// </summary>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ImageReference == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ImageReference");
            }
            if (this.ImageReference != null)
            {
                this.ImageReference.Validate();
            }
        }
    }
}
