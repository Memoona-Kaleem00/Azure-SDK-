// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Collection of policy metadata resources. </summary>
    internal partial class PolicyMetadataCollection
    {
        /// <summary> Initializes a new instance of PolicyMetadataCollection. </summary>
        internal PolicyMetadataCollection()
        {
            Value = new Core.ChangeTrackingList<SlimPolicyMetadata>();
        }

        /// <summary> Initializes a new instance of PolicyMetadataCollection. </summary>
        /// <param name="value"> Array of policy metadata definitions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PolicyMetadataCollection(IReadOnlyList<SlimPolicyMetadata> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of policy metadata definitions. </summary>
        public IReadOnlyList<SlimPolicyMetadata> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
