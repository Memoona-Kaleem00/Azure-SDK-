// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Monitor.OpenTelemetry.Exporter.Models;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    internal partial class ApplicationInsightsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _host;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ApplicationInsightsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="host"> Breeze endpoint: https://dc.services.visualstudio.com. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="host"/> is null. </exception>
        public ApplicationInsightsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "https://dc.services.visualstudio.com")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _host = host ?? throw new ArgumentNullException(nameof(host));
        }

        /// <summary> This operation sends a sequence of telemetry events that will be monitored by Azure Monitor. </summary>
        /// <param name="body"> The list of telemetry events to track. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<TrackResponse>> TrackAsync(IEnumerable<TelemetryItem> body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateTrackRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 206:
                    {
                        TrackResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TrackResponse.DeserializeTrackResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This operation sends a sequence of telemetry events that will be monitored by Azure Monitor. </summary>
        /// <param name="body"> The list of telemetry events to track. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<TrackResponse> Track(IEnumerable<TelemetryItem> body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateTrackRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 206:
                    {
                        TrackResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TrackResponse.DeserializeTrackResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
