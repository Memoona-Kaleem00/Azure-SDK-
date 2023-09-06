// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing the StreamAnalyticsPrivateEndpoint data model.
    /// Complete information about the private endpoint.
    /// </summary>
    public partial class StreamAnalyticsPrivateEndpointData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateEndpointData"/>. </summary>
        public StreamAnalyticsPrivateEndpointData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsPrivateEndpointData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties associated with a private endpoint. </param>
        /// <param name="etag"> Unique opaque string (generally a GUID) that represents the metadata state of the resource (private endpoint) and changes whenever the resource is updated. Required on PUT (CreateOrUpdate) requests. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsPrivateEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StreamAnalyticsPrivateEndpointProperties properties, ETag? etag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = etag;
            _rawData = rawData;
        }

        /// <summary> The properties associated with a private endpoint. </summary>
        public StreamAnalyticsPrivateEndpointProperties Properties { get; set; }
        /// <summary> Unique opaque string (generally a GUID) that represents the metadata state of the resource (private endpoint) and changes whenever the resource is updated. Required on PUT (CreateOrUpdate) requests. </summary>
        public ETag? ETag { get; }
    }
}
