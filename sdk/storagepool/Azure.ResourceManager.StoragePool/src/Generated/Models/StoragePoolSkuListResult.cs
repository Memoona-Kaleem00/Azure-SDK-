// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> List Disk Pool skus operation response. </summary>
    internal partial class StoragePoolSkuListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuListResult"/>. </summary>
        internal StoragePoolSkuListResult()
        {
            Value = new ChangeTrackingList<StoragePoolSkuInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuListResult"/>. </summary>
        /// <param name="value"> The list of StoragePool resource skus. </param>
        /// <param name="nextLink"> URI to fetch the next section of the paginated response. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePoolSkuListResult(IReadOnlyList<StoragePoolSkuInfo> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of StoragePool resource skus. </summary>
        public IReadOnlyList<StoragePoolSkuInfo> Value { get; }
        /// <summary> URI to fetch the next section of the paginated response. </summary>
        public string NextLink { get; }
    }
}
