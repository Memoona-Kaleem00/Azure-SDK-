// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> An enumeration of blobs. </summary>
    internal partial class ListBlobsHierarchySegmentResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListBlobsHierarchySegmentResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="containerName"></param>
        /// <param name="segment"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/>, <paramref name="containerName"/> or <paramref name="segment"/> is null. </exception>
        internal ListBlobsHierarchySegmentResponse(string serviceEndpoint, string containerName, BlobHierarchyListSegment segment)
        {
            Argument.AssertNotNull(serviceEndpoint, nameof(serviceEndpoint));
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(segment, nameof(segment));

            ServiceEndpoint = serviceEndpoint;
            ContainerName = containerName;
            Segment = segment;
        }

        /// <summary> Initializes a new instance of <see cref="ListBlobsHierarchySegmentResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="containerName"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="delimiter"></param>
        /// <param name="segment"></param>
        /// <param name="nextMarker"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListBlobsHierarchySegmentResponse(string serviceEndpoint, string containerName, string prefix, string marker, int? maxResults, string delimiter, BlobHierarchyListSegment segment, string nextMarker, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceEndpoint = serviceEndpoint;
            ContainerName = containerName;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            Delimiter = delimiter;
            Segment = segment;
            NextMarker = nextMarker;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ListBlobsHierarchySegmentResponse"/> for deserialization. </summary>
        internal ListBlobsHierarchySegmentResponse()
        {
        }

        /// <summary> Gets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets the container name. </summary>
        public string ContainerName { get; }
        /// <summary> Gets the prefix. </summary>
        public string Prefix { get; }
        /// <summary> Gets the marker. </summary>
        public string Marker { get; }
        /// <summary> Gets the max results. </summary>
        public int? MaxResults { get; }
        /// <summary> Gets the delimiter. </summary>
        public string Delimiter { get; }
        /// <summary> Gets the segment. </summary>
        public BlobHierarchyListSegment Segment { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
