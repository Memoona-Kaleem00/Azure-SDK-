// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessPolicyInitiateVirtualMachine. </summary>
    public partial class JitNetworkAccessPolicyInitiateVirtualMachine
    {
        /// <summary> Initializes a new instance of JitNetworkAccessPolicyInitiateVirtualMachine. </summary>
        /// <param name="id"> Resource ID of the virtual machine that is linked to this policy. </param>
        /// <param name="ports"> The ports to open for the resource with the `id`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="ports"/> is null. </exception>
        public JitNetworkAccessPolicyInitiateVirtualMachine(string id, IEnumerable<JitNetworkAccessPolicyInitiatePort> ports)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (ports == null)
            {
                throw new ArgumentNullException(nameof(ports));
            }

            Id = id;
            Ports = ports.ToList();
        }

        /// <summary> Resource ID of the virtual machine that is linked to this policy. </summary>
        public string Id { get; }
        /// <summary> The ports to open for the resource with the `id`. </summary>
        public IList<JitNetworkAccessPolicyInitiatePort> Ports { get; }
    }
}
