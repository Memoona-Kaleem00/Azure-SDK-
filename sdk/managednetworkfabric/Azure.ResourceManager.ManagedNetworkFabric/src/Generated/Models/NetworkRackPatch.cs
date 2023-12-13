// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Base tracked resource type for PATCH updates. </summary>
    public partial class NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkRackPatch"/>. </summary>
        public NetworkRackPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRackPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal NetworkRackPatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
