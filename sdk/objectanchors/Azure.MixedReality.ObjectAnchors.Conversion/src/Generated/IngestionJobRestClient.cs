// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    internal partial class IngestionJobRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of IngestionJobRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IngestionJobRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "0.3-preview.2")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateRequest(Guid accountId, Guid jobId, AssetConversionProperties body, string xMrcCv)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/accounts/", false);
            uri.AppendPath(accountId, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (xMrcCv != null)
            {
                request.Headers.Add("x-mrc-cv", xMrcCv);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a job request. </summary>
        /// <param name="accountId"> Identifier for the Azure Object Anchors account. </param>
        /// <param name="jobId"> Identifier for the Azure Object Anchors ingestion job. </param>
        /// <param name="body"> The Azure Object Anchors ingestion request. </param>
        /// <param name="xMrcCv"> The client request correlation vector, which should be set to a new value for each request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Core.ResponseWithHeaders<AssetConversionProperties, IngestionJobCreateHeaders>> CreateAsync(Guid accountId, Guid jobId, AssetConversionProperties body, string xMrcCv = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateCreateRequest(accountId, jobId, body, xMrcCv);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new IngestionJobCreateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        AssetConversionProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetConversionProperties.DeserializeAssetConversionProperties(document.RootElement);
                        return Core.ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a job request. </summary>
        /// <param name="accountId"> Identifier for the Azure Object Anchors account. </param>
        /// <param name="jobId"> Identifier for the Azure Object Anchors ingestion job. </param>
        /// <param name="body"> The Azure Object Anchors ingestion request. </param>
        /// <param name="xMrcCv"> The client request correlation vector, which should be set to a new value for each request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Core.ResponseWithHeaders<AssetConversionProperties, IngestionJobCreateHeaders> Create(Guid accountId, Guid jobId, AssetConversionProperties body, string xMrcCv = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateCreateRequest(accountId, jobId, body, xMrcCv);
            _pipeline.Send(message, cancellationToken);
            var headers = new IngestionJobCreateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        AssetConversionProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetConversionProperties.DeserializeAssetConversionProperties(document.RootElement);
                        return Core.ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(Guid accountId, Guid jobId, string xMrcCv)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/accounts/", false);
            uri.AppendPath(accountId, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (xMrcCv != null)
            {
                request.Headers.Add("x-mrc-cv", xMrcCv);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the status of a job request. </summary>
        /// <param name="accountId"> Identifier for the Azure Object Anchors account. </param>
        /// <param name="jobId"> Identifier for the Azure Object Anchors ingestion job. </param>
        /// <param name="xMrcCv"> The client request correlation vector, which should be set to a new value for each request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Core.ResponseWithHeaders<AssetConversionProperties, IngestionJobGetHeaders>> GetAsync(Guid accountId, Guid jobId, string xMrcCv = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(accountId, jobId, xMrcCv);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new IngestionJobGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetConversionProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetConversionProperties.DeserializeAssetConversionProperties(document.RootElement);
                        return Core.ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the status of a job request. </summary>
        /// <param name="accountId"> Identifier for the Azure Object Anchors account. </param>
        /// <param name="jobId"> Identifier for the Azure Object Anchors ingestion job. </param>
        /// <param name="xMrcCv"> The client request correlation vector, which should be set to a new value for each request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Core.ResponseWithHeaders<AssetConversionProperties, IngestionJobGetHeaders> Get(Guid accountId, Guid jobId, string xMrcCv = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(accountId, jobId, xMrcCv);
            _pipeline.Send(message, cancellationToken);
            var headers = new IngestionJobGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetConversionProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetConversionProperties.DeserializeAssetConversionProperties(document.RootElement);
                        return Core.ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
