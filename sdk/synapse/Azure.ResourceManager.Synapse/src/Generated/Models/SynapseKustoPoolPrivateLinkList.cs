// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto Private Link Resources operation response. </summary>
    internal partial class SynapseKustoPoolPrivateLinkList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseKustoPoolPrivateLinkList"/>. </summary>
        internal SynapseKustoPoolPrivateLinkList()
        {
            Value = new ChangeTrackingList<SynapseKustoPoolPrivateLinkData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseKustoPoolPrivateLinkList"/>. </summary>
        /// <param name="value"> The list of Kusto Private Link Resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseKustoPoolPrivateLinkList(IReadOnlyList<SynapseKustoPoolPrivateLinkData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of Kusto Private Link Resources. </summary>
        public IReadOnlyList<SynapseKustoPoolPrivateLinkData> Value { get; }
    }
}
