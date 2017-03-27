// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSH configuration for Linux-based VMs running on Azure.
    /// </summary>
    public partial class ContainerServiceSshConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceSshConfiguration
        /// class.
        /// </summary>
        public ContainerServiceSshConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceSshConfiguration
        /// class.
        /// </summary>
        /// <param name="publicKeys">the list of SSH public keys used to
        /// authenticate with Linux-based VMs.</param>
        public ContainerServiceSshConfiguration(IList<ContainerServiceSshPublicKey> publicKeys)
        {
            PublicKeys = publicKeys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of SSH public keys used to authenticate with
        /// Linux-based VMs.
        /// </summary>
        [JsonProperty(PropertyName = "publicKeys")]
        public IList<ContainerServiceSshPublicKey> PublicKeys { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublicKeys == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicKeys");
            }
            if (PublicKeys != null)
            {
                foreach (var element in PublicKeys)
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
