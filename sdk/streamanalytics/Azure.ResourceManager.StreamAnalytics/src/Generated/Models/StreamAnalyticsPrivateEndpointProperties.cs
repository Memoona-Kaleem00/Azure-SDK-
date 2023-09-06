// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The properties associated with a private endpoint. </summary>
    public partial class StreamAnalyticsPrivateEndpointProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateEndpointProperties"/>. </summary>
        public StreamAnalyticsPrivateEndpointProperties()
        {
            ManualPrivateLinkServiceConnections = new ChangeTrackingList<StreamAnalyticsPrivateLinkServiceConnection>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateEndpointProperties"/>. </summary>
        /// <param name="createdOn"> The date when this private endpoint was created. </param>
        /// <param name="manualPrivateLinkServiceConnections"> A list of connections to the remote resource. Immutable after it is set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsPrivateEndpointProperties(DateTimeOffset? createdOn, IList<StreamAnalyticsPrivateLinkServiceConnection> manualPrivateLinkServiceConnections, Dictionary<string, BinaryData> rawData)
        {
            CreatedOn = createdOn;
            ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
            _rawData = rawData;
        }

        /// <summary> The date when this private endpoint was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> A list of connections to the remote resource. Immutable after it is set. </summary>
        public IList<StreamAnalyticsPrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get; }
    }
}
