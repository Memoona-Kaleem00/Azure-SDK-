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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    internal partial class VirtualRouterPeeringsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VirtualRouterPeeringsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public VirtualRouterPeeringsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string virtualRouterName, string peeringName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualRouters/", false);
            uri.AppendPath(virtualRouterName, true);
            uri.AppendPath("/peerings/", false);
            uri.AppendPath(peeringName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified peering from a Virtual Router. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualRouterName"/>, or <paramref name="peeringName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string virtualRouterName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, virtualRouterName, peeringName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified peering from a Virtual Router. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualRouterName"/>, or <paramref name="peeringName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string virtualRouterName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, virtualRouterName, peeringName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string virtualRouterName, string peeringName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualRouters/", false);
            uri.AppendPath(virtualRouterName, true);
            uri.AppendPath("/peerings/", false);
            uri.AppendPath(peeringName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the specified Virtual Router Peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualRouterName"/>, or <paramref name="peeringName"/> is null. </exception>
        public async Task<Response<VirtualRouterPeering>> GetAsync(string resourceGroupName, string virtualRouterName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var message = CreateGetRequest(resourceGroupName, virtualRouterName, peeringName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualRouterPeering value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualRouterPeering.DeserializeVirtualRouterPeering(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified Virtual Router Peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualRouterName"/>, or <paramref name="peeringName"/> is null. </exception>
        public Response<VirtualRouterPeering> Get(string resourceGroupName, string virtualRouterName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var message = CreateGetRequest(resourceGroupName, virtualRouterName, peeringName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualRouterPeering value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualRouterPeering.DeserializeVirtualRouterPeering(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string virtualRouterName, string peeringName, VirtualRouterPeering parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualRouters/", false);
            uri.AppendPath(virtualRouterName, true);
            uri.AppendPath("/peerings/", false);
            uri.AppendPath(peeringName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualRouterName"/>, <paramref name="peeringName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string virtualRouterName, string peeringName, VirtualRouterPeering parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualRouterName, peeringName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualRouterName"/>, <paramref name="peeringName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string virtualRouterName, string peeringName, VirtualRouterPeering parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualRouterName, peeringName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string virtualRouterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualRouters/", false);
            uri.AppendPath(virtualRouterName, true);
            uri.AppendPath("/peerings", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="virtualRouterName"/> is null. </exception>
        public async Task<Response<VirtualRouterPeeringListResult>> ListAsync(string resourceGroupName, string virtualRouterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }

            using var message = CreateListRequest(resourceGroupName, virtualRouterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualRouterPeeringListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualRouterPeeringListResult.DeserializeVirtualRouterPeeringListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="virtualRouterName"/> is null. </exception>
        public Response<VirtualRouterPeeringListResult> List(string resourceGroupName, string virtualRouterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }

            using var message = CreateListRequest(resourceGroupName, virtualRouterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualRouterPeeringListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualRouterPeeringListResult.DeserializeVirtualRouterPeeringListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string virtualRouterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualRouterName"/> is null. </exception>
        public async Task<Response<VirtualRouterPeeringListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string virtualRouterName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, virtualRouterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualRouterPeeringListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualRouterPeeringListResult.DeserializeVirtualRouterPeeringListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualRouterName"/> is null. </exception>
        public Response<VirtualRouterPeeringListResult> ListNextPage(string nextLink, string resourceGroupName, string virtualRouterName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, virtualRouterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualRouterPeeringListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualRouterPeeringListResult.DeserializeVirtualRouterPeeringListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
