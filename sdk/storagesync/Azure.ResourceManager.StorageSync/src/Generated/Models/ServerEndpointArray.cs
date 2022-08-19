// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of ServerEndpoint. </summary>
    internal partial class ServerEndpointArray
    {
        /// <summary> Initializes a new instance of ServerEndpointArray. </summary>
        internal ServerEndpointArray()
        {
            Value = new ChangeTrackingList<ServerEndpointData>();
        }

        /// <summary> Initializes a new instance of ServerEndpointArray. </summary>
        /// <param name="value"> Collection of ServerEndpoint. </param>
        internal ServerEndpointArray(IReadOnlyList<ServerEndpointData> value)
        {
            Value = value;
        }

        /// <summary> Collection of ServerEndpoint. </summary>
        public IReadOnlyList<ServerEndpointData> Value { get; }
    }
}
