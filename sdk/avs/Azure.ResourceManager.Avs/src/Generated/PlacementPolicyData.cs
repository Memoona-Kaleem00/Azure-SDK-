// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary> A class representing the PlacementPolicy data model. </summary>
    public partial class PlacementPolicyData : Resource
    {
        /// <summary> Initializes a new instance of PlacementPolicyData. </summary>
        public PlacementPolicyData()
        {
        }

        /// <summary> Initializes a new instance of PlacementPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> placement policy properties. </param>
        internal PlacementPolicyData(ResourceIdentifier id, string name, ResourceType type, PlacementPolicyProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> placement policy properties. </summary>
        public PlacementPolicyProperties Properties { get; set; }
    }
}
