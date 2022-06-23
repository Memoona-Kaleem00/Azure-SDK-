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

namespace Azure.Communication.PhoneNumbers.SipRouting
{
    internal partial class SipRoutingRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of SipRoutingRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public SipRoutingRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-05-01-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetSipConfigurationRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/sip", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets SIP configuration for resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SipConfiguration>> GetSipConfigurationAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSipConfigurationRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SipConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SipConfiguration.DeserializeSipConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets SIP configuration for resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SipConfiguration> GetSipConfiguration(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSipConfigurationRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SipConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SipConfiguration.DeserializeSipConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        /// <summary> Patches SIP configuration for resource. </summary>
        /// <param name="body"> Configuration patch. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SipConfiguration>> PatchSipConfigurationAsync(SipConfiguration body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePatchSipConfigurationRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SipConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SipConfiguration.DeserializeSipConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Patches SIP configuration for resource. </summary>
        /// <param name="body"> Configuration patch. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SipConfiguration> PatchSipConfiguration(SipConfiguration body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePatchSipConfigurationRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SipConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SipConfiguration.DeserializeSipConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
