// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Topology of the specified resource group. </summary>
    public partial class NetworkTopology
    {
        /// <summary> Initializes a new instance of NetworkTopology. </summary>
        internal NetworkTopology()
        {
            Resources = new ChangeTrackingList<TopologyResourceInfo>();
        }

        /// <summary> Initializes a new instance of NetworkTopology. </summary>
        /// <param name="id"> GUID representing the operation id. </param>
        /// <param name="createdOn"> The datetime when the topology was initially created for the resource group. </param>
        /// <param name="lastModified"> The datetime when the topology was last modified. </param>
        /// <param name="resources"> A list of topology resources. </param>
        internal NetworkTopology(string id, DateTimeOffset? createdOn, DateTimeOffset? lastModified, IReadOnlyList<TopologyResourceInfo> resources)
        {
            Id = id;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Resources = resources;
        }

        /// <summary> GUID representing the operation id. </summary>
        public string Id { get; }
        /// <summary> The datetime when the topology was initially created for the resource group. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The datetime when the topology was last modified. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> A list of topology resources. </summary>
        public IReadOnlyList<TopologyResourceInfo> Resources { get; }
    }
}
