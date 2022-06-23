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
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    internal partial class PrivateEndpointConnectionProxiesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxiesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateEndpointConnectionProxiesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-04-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByAccountRequest(string subscriptionId, string resourceGroupName, string accountName)
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
            uri.AppendPath("/providers/Microsoft.DeviceUpdate/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateEndpointConnectionProxies", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PrivateEndpointConnectionProxyListResult>> ListByAccountAsync(string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListByAccountRequest(subscriptionId, resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionProxyListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateEndpointConnectionProxyListResult.DeserializePrivateEndpointConnectionProxyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PrivateEndpointConnectionProxyListResult> ListByAccount(string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListByAccountRequest(subscriptionId, resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionProxyListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateEndpointConnectionProxyListResult.DeserializePrivateEndpointConnectionProxyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidateRequest(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DeviceUpdate/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateEndpointConnectionProxies/", false);
            uri.AppendPath(privateEndpointConnectionProxyId, true);
            uri.AppendPath("/validate", false);
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

        /// <summary> (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ValidateAsync(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateValidateRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Validate(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateValidateRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdatePrivateEndpointPropertiesRequest(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointUpdate privateEndpointUpdate)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DeviceUpdate/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateEndpointConnectionProxies/", false);
            uri.AppendPath(privateEndpointConnectionProxyId, true);
            uri.AppendPath("/updatePrivateEndpointProperties", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(privateEndpointUpdate);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> (INTERNAL - DO NOT USE) Updates a private endpoint inside the private endpoint connection proxy object. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="privateEndpointUpdate"> The parameters for updating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="privateEndpointUpdate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdatePrivateEndpointPropertiesAsync(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointUpdate privateEndpointUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(privateEndpointUpdate, nameof(privateEndpointUpdate));

            using var message = CreateUpdatePrivateEndpointPropertiesRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId, privateEndpointUpdate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Updates a private endpoint inside the private endpoint connection proxy object. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="privateEndpointUpdate"> The parameters for updating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="privateEndpointUpdate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response UpdatePrivateEndpointProperties(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointUpdate privateEndpointUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(privateEndpointUpdate, nameof(privateEndpointUpdate));

            using var message = CreateUpdatePrivateEndpointPropertiesRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId, privateEndpointUpdate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId)
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
            uri.AppendPath("/providers/Microsoft.DeviceUpdate/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateEndpointConnectionProxies/", false);
            uri.AppendPath(privateEndpointConnectionProxyId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PrivateEndpointConnectionProxyData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionProxyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateEndpointConnectionProxyData.DeserializePrivateEndpointConnectionProxyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateEndpointConnectionProxyData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PrivateEndpointConnectionProxyData> Get(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionProxyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateEndpointConnectionProxyData.DeserializePrivateEndpointConnectionProxyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateEndpointConnectionProxyData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data)
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
            uri.AppendPath("/providers/Microsoft.DeviceUpdate/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateEndpointConnectionProxies/", false);
            uri.AppendPath(privateEndpointConnectionProxyId, true);
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

        /// <summary> (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId)
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
            uri.AppendPath("/providers/Microsoft.DeviceUpdate/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateEndpointConnectionProxies/", false);
            uri.AppendPath(privateEndpointConnectionProxyId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId);
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

        /// <summary> (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionProxyId);
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
    }
}
