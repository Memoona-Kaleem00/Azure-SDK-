// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ConsoleList represents a list of virtual machine consoles. </summary>
    internal partial class ConsoleList
    {
        /// <summary> Initializes a new instance of ConsoleList. </summary>
        internal ConsoleList()
        {
            Value = new Core.ChangeTrackingList<NetworkCloudVirtualMachineConsoleData>();
        }

        /// <summary> Initializes a new instance of ConsoleList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of virtual machine consoles. </param>
        internal ConsoleList(string nextLink, IReadOnlyList<NetworkCloudVirtualMachineConsoleData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of virtual machine consoles. </summary>
        public IReadOnlyList<NetworkCloudVirtualMachineConsoleData> Value { get; }
    }
}
