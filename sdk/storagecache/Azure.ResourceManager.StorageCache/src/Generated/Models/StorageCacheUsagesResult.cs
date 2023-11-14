// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Result of the request to list resource usages. It contains a list of resource usages &amp; limits and a URL link to get the next set of results. </summary>
    internal partial class StorageCacheUsagesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheUsagesResult"/>. </summary>
        internal StorageCacheUsagesResult()
        {
            Value = new ChangeTrackingList<StorageCacheUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheUsagesResult"/>. </summary>
        /// <param name="nextLink"> URL to get the next set of resource usage list results if there are any. </param>
        /// <param name="value"> List of usages and limits for resources controlled by the Microsoft.StorageCache resource provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheUsagesResult(string nextLink, IReadOnlyList<StorageCacheUsage> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> URL to get the next set of resource usage list results if there are any. </summary>
        public string NextLink { get; }
        /// <summary> List of usages and limits for resources controlled by the Microsoft.StorageCache resource provider. </summary>
        public IReadOnlyList<StorageCacheUsage> Value { get; }
    }
}
