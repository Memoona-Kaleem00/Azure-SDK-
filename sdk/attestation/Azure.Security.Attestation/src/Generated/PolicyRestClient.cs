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
    internal partial class PolicyRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _instanceUrl;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of PolicyRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="instanceUrl"> The attestation instance base URI, for example https://mytenant.attest.azure.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="instanceUrl"/> or <paramref name="apiVersion"/> is null. </exception>
        public PolicyRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string instanceUrl, string apiVersion = "2020-10-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _instanceUrl = instanceUrl ?? throw new ArgumentNullException(nameof(instanceUrl));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetRequest(AttestationType attestationType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/policies/", false);
            uri.AppendPath(attestationType.ToString(), true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves the current policy for an attestation type. </summary>
        /// <param name="attestationType"> Specifies the trusted execution environment to be used to validate the evidence. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PolicyResponse>> GetAsync(AttestationType attestationType, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(attestationType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PolicyResponse.DeserializePolicyResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the current policy for an attestation type. </summary>
        /// <param name="attestationType"> Specifies the trusted execution environment to be used to validate the evidence. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PolicyResponse> Get(AttestationType attestationType, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(attestationType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PolicyResponse.DeserializePolicyResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSetRequest(AttestationType attestationType, string newAttestationPolicy)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/policies/", false);
            uri.AppendPath(attestationType.ToString(), true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "text/plain");
            request.Content = new StringRequestContent(newAttestationPolicy);
            return message;
        }

        /// <summary> Sets the policy for a given attestation type. </summary>
        /// <param name="attestationType"> Specifies the trusted execution environment to be used to validate the evidence. </param>
        /// <param name="newAttestationPolicy"> JWT Expressing the new policy whose body is a StoredAttestationPolicy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="newAttestationPolicy"/> is null. </exception>
        public async Task<Response<PolicyResponse>> SetAsync(AttestationType attestationType, string newAttestationPolicy, CancellationToken cancellationToken = default)
        {
            if (newAttestationPolicy == null)
            {
                throw new ArgumentNullException(nameof(newAttestationPolicy));
            }

            using var message = CreateSetRequest(attestationType, newAttestationPolicy);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PolicyResponse.DeserializePolicyResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sets the policy for a given attestation type. </summary>
        /// <param name="attestationType"> Specifies the trusted execution environment to be used to validate the evidence. </param>
        /// <param name="newAttestationPolicy"> JWT Expressing the new policy whose body is a StoredAttestationPolicy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="newAttestationPolicy"/> is null. </exception>
        public Response<PolicyResponse> Set(AttestationType attestationType, string newAttestationPolicy, CancellationToken cancellationToken = default)
        {
            if (newAttestationPolicy == null)
            {
                throw new ArgumentNullException(nameof(newAttestationPolicy));
            }

            using var message = CreateSetRequest(attestationType, newAttestationPolicy);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PolicyResponse.DeserializePolicyResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateResetRequest(AttestationType attestationType, string policyJws)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/policies/", false);
            uri.AppendPath(attestationType.ToString(), true);
            uri.AppendPath(":reset", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "text/plain");
            request.Content = new StringRequestContent(policyJws);
            return message;
        }

        /// <summary> Resets the attestation policy for the specified tenant and reverts to the default policy. </summary>
        /// <param name="attestationType"> Specifies the trusted execution environment to be used to validate the evidence. </param>
        /// <param name="policyJws"> JSON Web Signature with an empty policy document. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyJws"/> is null. </exception>
        public async Task<Response<PolicyResponse>> ResetAsync(AttestationType attestationType, string policyJws, CancellationToken cancellationToken = default)
        {
            if (policyJws == null)
            {
                throw new ArgumentNullException(nameof(policyJws));
            }

            using var message = CreateResetRequest(attestationType, policyJws);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PolicyResponse.DeserializePolicyResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Resets the attestation policy for the specified tenant and reverts to the default policy. </summary>
        /// <param name="attestationType"> Specifies the trusted execution environment to be used to validate the evidence. </param>
        /// <param name="policyJws"> JSON Web Signature with an empty policy document. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyJws"/> is null. </exception>
        public Response<PolicyResponse> Reset(AttestationType attestationType, string policyJws, CancellationToken cancellationToken = default)
        {
            if (policyJws == null)
            {
                throw new ArgumentNullException(nameof(policyJws));
            }

            using var message = CreateResetRequest(attestationType, policyJws);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PolicyResponse.DeserializePolicyResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
