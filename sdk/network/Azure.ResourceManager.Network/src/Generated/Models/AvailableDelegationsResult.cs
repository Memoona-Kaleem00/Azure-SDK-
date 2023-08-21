// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An array of available delegations. </summary>
    internal partial class AvailableDelegationsResult
    {
        /// <summary> Initializes a new instance of AvailableDelegationsResult. </summary>
        internal AvailableDelegationsResult()
        {
            Value = new Core.ChangeTrackingList<AvailableDelegation>();
        }

        /// <summary> Initializes a new instance of AvailableDelegationsResult. </summary>
        /// <param name="value"> An array of available delegations. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal AvailableDelegationsResult(IReadOnlyList<AvailableDelegation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of available delegations. </summary>
        public IReadOnlyList<AvailableDelegation> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
