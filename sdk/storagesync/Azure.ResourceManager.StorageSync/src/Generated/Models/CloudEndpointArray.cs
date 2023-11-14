// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of CloudEndpoint. </summary>
    internal partial class CloudEndpointArray
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudEndpointArray"/>. </summary>
        internal CloudEndpointArray()
        {
            Value = new ChangeTrackingList<CloudEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointArray"/>. </summary>
        /// <param name="value"> Collection of CloudEndpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudEndpointArray(IReadOnlyList<CloudEndpointData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Collection of CloudEndpoint. </summary>
        public IReadOnlyList<CloudEndpointData> Value { get; }
    }
}
