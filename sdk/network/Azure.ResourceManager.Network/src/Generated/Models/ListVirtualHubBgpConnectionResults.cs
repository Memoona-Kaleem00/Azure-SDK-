// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VirtualHubBgpConnections list. </summary>
    internal partial class ListVirtualHubBgpConnectionResults
    {
        /// <summary> Initializes a new instance of ListVirtualHubBgpConnectionResults. </summary>
        internal ListVirtualHubBgpConnectionResults()
        {
            Value = new Core.ChangeTrackingList<BgpConnectionData>();
        }

        /// <summary> Initializes a new instance of ListVirtualHubBgpConnectionResults. </summary>
        /// <param name="value"> The list of VirtualHubBgpConnections. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal ListVirtualHubBgpConnectionResults(IReadOnlyList<BgpConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of VirtualHubBgpConnections. </summary>
        public IReadOnlyList<BgpConnectionData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
