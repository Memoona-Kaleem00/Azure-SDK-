// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> RTSP source allows for media from an RTSP camera or generic RTSP server to be ingested into a live pipeline. </summary>
    public partial class RtspSource : SourceNodeBase
    {
        /// <summary> Initializes a new instance of <see cref="RtspSource"/>. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="endpoint">
        /// RTSP endpoint information for Video Analyzer to connect to. This contains the required information for Video Analyzer to connect to RTSP cameras and/or generic RTSP servers.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="endpoint"/> is null. </exception>
        public RtspSource(string name, EndpointBase endpoint) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            Type = "#Microsoft.VideoAnalyzer.RtspSource";
        }

        /// <summary> Initializes a new instance of <see cref="RtspSource"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="transport"> Network transport utilized by the RTSP and RTP exchange: TCP or HTTP. When using TCP, the RTP packets are interleaved on the TCP RTSP connection. When using HTTP, the RTSP messages are exchanged through long lived HTTP connections, and the RTP packages are interleaved in the HTTP connections alongside the RTSP messages. </param>
        /// <param name="endpoint">
        /// RTSP endpoint information for Video Analyzer to connect to. This contains the required information for Video Analyzer to connect to RTSP cameras and/or generic RTSP servers.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RtspSource(string type, string name, RtspTransport? transport, EndpointBase endpoint, Dictionary<string, BinaryData> rawData) : base(type, name, rawData)
        {
            Transport = transport;
            Endpoint = endpoint;
            Type = type ?? "#Microsoft.VideoAnalyzer.RtspSource";
        }

        /// <summary> Initializes a new instance of <see cref="RtspSource"/> for deserialization. </summary>
        internal RtspSource()
        {
        }

        /// <summary> Network transport utilized by the RTSP and RTP exchange: TCP or HTTP. When using TCP, the RTP packets are interleaved on the TCP RTSP connection. When using HTTP, the RTSP messages are exchanged through long lived HTTP connections, and the RTP packages are interleaved in the HTTP connections alongside the RTSP messages. </summary>
        public RtspTransport? Transport { get; set; }
        /// <summary>
        /// RTSP endpoint information for Video Analyzer to connect to. This contains the required information for Video Analyzer to connect to RTSP cameras and/or generic RTSP servers.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </summary>
        public EndpointBase Endpoint { get; set; }
    }
}
