// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints
{
    internal partial class ManagedPrivateEndpointsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ManagedPrivateEndpointsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagedPrivateEndpointsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2020-12-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal RequestUriBuilder CreateGetRequestUri(string managedVirtualNetworkName, string managedPrivateEndpointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string managedVirtualNetworkName, string managedPrivateEndpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> or <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpoint>> GetAsync(string managedVirtualNetworkName, string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }

            using var message = CreateGetRequest(managedVirtualNetworkName, managedPrivateEndpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> or <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public Response<ManagedPrivateEndpoint> Get(string managedVirtualNetworkName, string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }

            using var message = CreateGetRequest(managedVirtualNetworkName, managedPrivateEndpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateRequestUri(string managedVirtualNetworkName, string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string managedVirtualNetworkName, string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(managedPrivateEndpoint);
            request.Content = content;
            return message;
        }

        /// <summary> Create Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedPrivateEndpoint"> Managed private endpoint properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/>, <paramref name="managedPrivateEndpointName"/> or <paramref name="managedPrivateEndpoint"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpoint>> CreateAsync(string managedVirtualNetworkName, string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpoint == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpoint));
            }

            using var message = CreateCreateRequest(managedVirtualNetworkName, managedPrivateEndpointName, managedPrivateEndpoint);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedPrivateEndpoint"> Managed private endpoint properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/>, <paramref name="managedPrivateEndpointName"/> or <paramref name="managedPrivateEndpoint"/> is null. </exception>
        public Response<ManagedPrivateEndpoint> Create(string managedVirtualNetworkName, string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpoint == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpoint));
            }

            using var message = CreateCreateRequest(managedVirtualNetworkName, managedPrivateEndpointName, managedPrivateEndpoint);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string managedVirtualNetworkName, string managedPrivateEndpointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string managedVirtualNetworkName, string managedPrivateEndpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> or <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string managedVirtualNetworkName, string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }

            using var message = CreateDeleteRequest(managedVirtualNetworkName, managedPrivateEndpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> or <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public Response Delete(string managedVirtualNetworkName, string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }

            using var message = CreateDeleteRequest(managedVirtualNetworkName, managedPrivateEndpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string managedVirtualNetworkName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpointListResponse>> ListAsync(string managedVirtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListRequest(managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response<ManagedPrivateEndpointListResponse> List(string managedVirtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListRequest(managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string managedVirtualNetworkName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpointListResponse>> ListNextPageAsync(string nextLink, string managedVirtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListNextPageRequest(nextLink, managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. The default value is "default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response<ManagedPrivateEndpointListResponse> ListNextPage(string nextLink, string managedVirtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListNextPageRequest(nextLink, managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
