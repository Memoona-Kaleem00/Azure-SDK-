// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of network manager connections. </summary>
    internal partial class NetworkManagerConnectionListResult
    {
        /// <summary> Initializes a new instance of NetworkManagerConnectionListResult. </summary>
        internal NetworkManagerConnectionListResult()
        {
            Value = new Core.ChangeTrackingList<NetworkManagerConnectionData>();
        }

        /// <summary> Initializes a new instance of NetworkManagerConnectionListResult. </summary>
        /// <param name="value"> List of network manager connections. </param>
        /// <param name="nextLink"> Gets the URL to get the next page of results. </param>
        internal NetworkManagerConnectionListResult(IReadOnlyList<NetworkManagerConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of network manager connections. </summary>
        public IReadOnlyList<NetworkManagerConnectionData> Value { get; }
        /// <summary> Gets the URL to get the next page of results. </summary>
        public string NextLink { get; }
    }
}
