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
using Azure.ResourceManager.HybridContainerService.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    internal partial class HybridIdentityMetadataRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of HybridIdentityMetadataRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public HybridIdentityMetadataRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreatePutRequestUri(string connectedClusterResourceUri, HybridIdentityMetadataData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreatePutRequest(string connectedClusterResourceUri, HybridIdentityMetadataData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates the hybrid identity metadata proxy resource that facilitates the managed identity provisioning. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="data"> Hybrid Identity Metadata resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> or <paramref name="data"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataData>> PutAsync(string connectedClusterResourceUri, HybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreatePutRequest(connectedClusterResourceUri, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates the hybrid identity metadata proxy resource that facilitates the managed identity provisioning. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="data"> Hybrid Identity Metadata resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> or <paramref name="data"/> is null. </exception>
        public Response<HybridIdentityMetadataData> Put(string connectedClusterResourceUri, HybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreatePutRequest(connectedClusterResourceUri, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string connectedClusterResourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string connectedClusterResourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the hybrid identity metadata proxy resource. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataData>> GetAsync(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateGetRequest(connectedClusterResourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridIdentityMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the hybrid identity metadata proxy resource. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public Response<HybridIdentityMetadataData> Get(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateGetRequest(connectedClusterResourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridIdentityMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string connectedClusterResourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string connectedClusterResourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the hybrid identity metadata proxy resource. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public async Task<Response> DeleteAsync(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateDeleteRequest(connectedClusterResourceUri);
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

        /// <summary> Deletes the hybrid identity metadata proxy resource. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public Response Delete(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateDeleteRequest(connectedClusterResourceUri);
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

        internal RequestUriBuilder CreateListByClusterRequestUri(string connectedClusterResourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByClusterRequest(string connectedClusterResourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/hybridIdentityMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the hybrid identity metadata proxy resource in a provisioned cluster instance. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataList>> ListByClusterAsync(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateListByClusterRequest(connectedClusterResourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the hybrid identity metadata proxy resource in a provisioned cluster instance. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public Response<HybridIdentityMetadataList> ListByCluster(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateListByClusterRequest(connectedClusterResourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByClusterNextPageRequestUri(string nextLink, string connectedClusterResourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByClusterNextPageRequest(string nextLink, string connectedClusterResourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the hybrid identity metadata proxy resource in a provisioned cluster instance. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataList>> ListByClusterNextPageAsync(string nextLink, string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateListByClusterNextPageRequest(nextLink, connectedClusterResourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the hybrid identity metadata proxy resource in a provisioned cluster instance. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public Response<HybridIdentityMetadataList> ListByClusterNextPage(string nextLink, string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (connectedClusterResourceUri == null)
            {
                throw new ArgumentNullException(nameof(connectedClusterResourceUri));
            }

            using var message = CreateListByClusterNextPageRequest(nextLink, connectedClusterResourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
