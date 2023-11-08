// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Communication;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> A class representing a Domains SuppressionListResource collection. </summary>
    internal partial class SuppressionListResourceCollection
    {
        /// <summary> Initializes a new instance of SuppressionListResourceCollection. </summary>
        internal SuppressionListResourceCollection()
        {
            Value = new ChangeTrackingList<SuppressionListResourceData>();
        }

        /// <summary> Initializes a new instance of SuppressionListResourceCollection. </summary>
        /// <param name="value"> List of SuppressionListResource. </param>
        /// <param name="nextLink"> The URL the client should use to fetch the next page (per server side paging). </param>
        internal SuppressionListResourceCollection(IReadOnlyList<SuppressionListResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of SuppressionListResource. </summary>
        public IReadOnlyList<SuppressionListResourceData> Value { get; }
        /// <summary> The URL the client should use to fetch the next page (per server side paging). </summary>
        public string NextLink { get; }
    }
}
