// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableListResponse. </summary>
    public partial class LinkTableListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinkTableListResponse"/>. </summary>
        internal LinkTableListResponse()
        {
            Value = new ChangeTrackingList<LinkTableResource>();
        }

        /// <summary> Initializes a new instance of <see cref="LinkTableListResponse"/>. </summary>
        /// <param name="value"> List link table value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkTableListResponse(IReadOnlyList<LinkTableResource> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List link table value. </summary>
        public IReadOnlyList<LinkTableResource> Value { get; }
    }
}
