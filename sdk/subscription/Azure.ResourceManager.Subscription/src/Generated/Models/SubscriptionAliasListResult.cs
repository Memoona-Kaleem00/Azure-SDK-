// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Subscription;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The list of aliases. </summary>
    internal partial class SubscriptionAliasListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SubscriptionAliasListResult"/>. </summary>
        internal SubscriptionAliasListResult()
        {
            Value = new ChangeTrackingList<SubscriptionAliasData>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionAliasListResult"/>. </summary>
        /// <param name="value"> The list of alias. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionAliasListResult(IReadOnlyList<SubscriptionAliasData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of alias. </summary>
        public IReadOnlyList<SubscriptionAliasData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
