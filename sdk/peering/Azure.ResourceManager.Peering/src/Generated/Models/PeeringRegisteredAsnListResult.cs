// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of peering registered ASNs. </summary>
    internal partial class PeeringRegisteredAsnListResult
    {
        /// <summary> Initializes a new instance of PeeringRegisteredAsnListResult. </summary>
        internal PeeringRegisteredAsnListResult()
        {
            Value = new Core.ChangeTrackingList<PeeringRegisteredAsnData>();
        }

        /// <summary> Initializes a new instance of PeeringRegisteredAsnListResult. </summary>
        /// <param name="value"> The list of peering registered ASNs. </param>
        /// <param name="nextLink"> The link to fetch the next page of peering registered ASNs. </param>
        internal PeeringRegisteredAsnListResult(IReadOnlyList<PeeringRegisteredAsnData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of peering registered ASNs. </summary>
        public IReadOnlyList<PeeringRegisteredAsnData> Value { get; }
        /// <summary> The link to fetch the next page of peering registered ASNs. </summary>
        public string NextLink { get; }
    }
}
