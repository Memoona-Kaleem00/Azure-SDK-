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
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis
{
    internal partial class AccessPolicyAssignmentRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AccessPolicyAssignmentRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AccessPolicyAssignmentRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateUpdateRequest(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, RedisCacheAccessPolicyAssignmentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cache/redis/", false);
            uri.AppendPath(cacheName, true);
            uri.AppendPath("/accessPolicyAssignments/", false);
            uri.AppendPath(accessPolicyAssignmentName, true);
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

        /// <summary> Adds the access policy assignment to the specified users. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="accessPolicyAssignmentName"> The name of the access policy assignment. </param>
        /// <param name="data"> Parameters supplied to the Create Update Access Policy Assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/>, <paramref name="accessPolicyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateUpdateAsync(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, RedisCacheAccessPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }
            if (accessPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyAssignmentName));
            }
            if (accessPolicyAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyAssignmentName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateUpdateRequest(subscriptionId, resourceGroupName, cacheName, accessPolicyAssignmentName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Adds the access policy assignment to the specified users. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="accessPolicyAssignmentName"> The name of the access policy assignment. </param>
        /// <param name="data"> Parameters supplied to the Create Update Access Policy Assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/>, <paramref name="accessPolicyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateUpdate(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, RedisCacheAccessPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }
            if (accessPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyAssignmentName));
            }
            if (accessPolicyAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyAssignmentName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateUpdateRequest(subscriptionId, resourceGroupName, cacheName, accessPolicyAssignmentName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cache/redis/", false);
            uri.AppendPath(cacheName, true);
            uri.AppendPath("/accessPolicyAssignments/", false);
            uri.AppendPath(accessPolicyAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the access policy assignment from a redis cache. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="accessPolicyAssignmentName"> The name of the access policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }
            if (accessPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyAssignmentName));
            }
            if (accessPolicyAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyAssignmentName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cacheName, accessPolicyAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the access policy assignment from a redis cache. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="accessPolicyAssignmentName"> The name of the access policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }
            if (accessPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyAssignmentName));
            }
            if (accessPolicyAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyAssignmentName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cacheName, accessPolicyAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cache/redis/", false);
            uri.AppendPath(cacheName, true);
            uri.AppendPath("/accessPolicyAssignments/", false);
            uri.AppendPath(accessPolicyAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of assignments for an access policy of a redis cache. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="accessPolicyAssignmentName"> The name of the access policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RedisCacheAccessPolicyAssignmentData>> GetAsync(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }
            if (accessPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyAssignmentName));
            }
            if (accessPolicyAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyAssignmentName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cacheName, accessPolicyAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisCacheAccessPolicyAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RedisCacheAccessPolicyAssignmentData.DeserializeRedisCacheAccessPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RedisCacheAccessPolicyAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of assignments for an access policy of a redis cache. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="accessPolicyAssignmentName"> The name of the access policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cacheName"/> or <paramref name="accessPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RedisCacheAccessPolicyAssignmentData> Get(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }
            if (accessPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyAssignmentName));
            }
            if (accessPolicyAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyAssignmentName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cacheName, accessPolicyAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisCacheAccessPolicyAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RedisCacheAccessPolicyAssignmentData.DeserializeRedisCacheAccessPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RedisCacheAccessPolicyAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string cacheName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cache/redis/", false);
            uri.AppendPath(cacheName, true);
            uri.AppendPath("/accessPolicyAssignments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of access policy assignments associated with this redis cache. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RedisCacheAccessPolicyAssignmentList>> ListAsync(string subscriptionId, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, cacheName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisCacheAccessPolicyAssignmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RedisCacheAccessPolicyAssignmentList.DeserializeRedisCacheAccessPolicyAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of access policy assignments associated with this redis cache. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RedisCacheAccessPolicyAssignmentList> List(string subscriptionId, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, cacheName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisCacheAccessPolicyAssignmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RedisCacheAccessPolicyAssignmentList.DeserializeRedisCacheAccessPolicyAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string cacheName)
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

        /// <summary> Gets the list of access policy assignments associated with this redis cache. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RedisCacheAccessPolicyAssignmentList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, cacheName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisCacheAccessPolicyAssignmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RedisCacheAccessPolicyAssignmentList.DeserializeRedisCacheAccessPolicyAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of access policy assignments associated with this redis cache. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cacheName"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RedisCacheAccessPolicyAssignmentList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (cacheName == null)
            {
                throw new ArgumentNullException(nameof(cacheName));
            }
            if (cacheName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(cacheName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, cacheName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisCacheAccessPolicyAssignmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RedisCacheAccessPolicyAssignmentList.DeserializeRedisCacheAccessPolicyAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
