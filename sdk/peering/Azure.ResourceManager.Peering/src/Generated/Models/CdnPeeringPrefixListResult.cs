// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of CDN peering prefixes. </summary>
    internal partial class CdnPeeringPrefixListResult
    {
        /// <summary> Initializes a new instance of CdnPeeringPrefixListResult. </summary>
        internal CdnPeeringPrefixListResult()
        {
            Value = new Core.ChangeTrackingList<CdnPeeringPrefix>();
        }

        /// <summary> Initializes a new instance of CdnPeeringPrefixListResult. </summary>
        /// <param name="value"> The list of CDN peering prefixes. </param>
        /// <param name="nextLink"> The link to fetch the next page of CDN peering prefixes. </param>
        internal CdnPeeringPrefixListResult(IReadOnlyList<CdnPeeringPrefix> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of CDN peering prefixes. </summary>
        public IReadOnlyList<CdnPeeringPrefix> Value { get; }
        /// <summary> The link to fetch the next page of CDN peering prefixes. </summary>
        public string NextLink { get; }
    }
}
