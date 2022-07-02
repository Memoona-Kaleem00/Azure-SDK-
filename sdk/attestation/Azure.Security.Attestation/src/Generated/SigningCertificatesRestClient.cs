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

namespace Azure.Security.Attestation
{
    internal partial class SigningCertificatesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _instanceUrl;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SigningCertificatesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="instanceUrl"> The attestation instance base URI, for example https://mytenant.attest.azure.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="instanceUrl"/> is null. </exception>
        public SigningCertificatesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string instanceUrl)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _instanceUrl = instanceUrl ?? throw new ArgumentNullException(nameof(instanceUrl));
        }

        internal HttpMessage CreateGetRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/certs", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/jwk+json, application/json");
            return message;
        }

        /// <summary> Retrieves metadata signing certificates in use by the attestation service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<JsonWebKeySet>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JsonWebKeySet value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JsonWebKeySet.DeserializeJsonWebKeySet(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves metadata signing certificates in use by the attestation service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<JsonWebKeySet> Get(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JsonWebKeySet value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JsonWebKeySet.DeserializeJsonWebKeySet(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
