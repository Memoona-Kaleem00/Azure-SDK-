// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A list of private endpoints. </summary>
    internal partial class StreamAnalyticsPrivateEndpointListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateEndpointListResult"/>. </summary>
        internal StreamAnalyticsPrivateEndpointListResult()
        {
            Value = new ChangeTrackingList<StreamAnalyticsPrivateEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateEndpointListResult"/>. </summary>
        /// <param name="value"> A list of private endpoints. </param>
        /// <param name="nextLink"> The URL to fetch the next set of private endpoints. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsPrivateEndpointListResult(IReadOnlyList<StreamAnalyticsPrivateEndpointData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of private endpoints. </summary>
        public IReadOnlyList<StreamAnalyticsPrivateEndpointData> Value { get; }
        /// <summary> The URL to fetch the next set of private endpoints. </summary>
        public string NextLink { get; }
    }
}
