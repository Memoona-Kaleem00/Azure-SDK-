// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a network port. </summary>
    public partial class Port
    {
        /// <summary> Initializes a new instance of Port. </summary>
        public Port()
        {
        }

        /// <summary> Initializes a new instance of Port. </summary>
        /// <param name="transportProtocol"> Protocol type of the port. </param>
        /// <param name="backendPort"> Backend port of the target virtual machine. </param>
        internal Port(TransportProtocol? transportProtocol, int? backendPort)
        {
            TransportProtocol = transportProtocol;
            BackendPort = backendPort;
        }

        /// <summary> Protocol type of the port. </summary>
        public TransportProtocol? TransportProtocol { get; set; }
        /// <summary> Backend port of the target virtual machine. </summary>
        public int? BackendPort { get; set; }
    }
}
