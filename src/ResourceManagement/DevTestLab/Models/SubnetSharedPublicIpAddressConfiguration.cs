// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Configuration for public IP address sharing.
    /// </summary>
    public partial class SubnetSharedPublicIpAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubnetSharedPublicIpAddressConfiguration class.
        /// </summary>
        public SubnetSharedPublicIpAddressConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubnetSharedPublicIpAddressConfiguration class.
        /// </summary>
        /// <param name="allowedPorts">Backend ports that virtual machines on
        /// this subnet are allowed to expose</param>
        public SubnetSharedPublicIpAddressConfiguration(IList<Port> allowedPorts = default(IList<Port>))
        {
            AllowedPorts = allowedPorts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backend ports that virtual machines on this subnet are
        /// allowed to expose
        /// </summary>
        [JsonProperty(PropertyName = "allowedPorts")]
        public IList<Port> AllowedPorts { get; set; }

    }
}
