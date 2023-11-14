// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A collection of read-only information about the state of the connection to the private remote resource. </summary>
    public partial class StreamAnalyticsPrivateLinkConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateLinkConnectionState"/>. </summary>
        public StreamAnalyticsPrivateLinkConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateLinkConnectionState"/>. </summary>
        /// <param name="status"> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the remote resource/service. </param>
        /// <param name="description"> The reason for approval/rejection of the connection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsPrivateLinkConnectionState(string status, string description, string actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the remote resource/service. </summary>
        public string Status { get; }
        /// <summary> The reason for approval/rejection of the connection. </summary>
        public string Description { get; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public string ActionsRequired { get; }
    }
}
