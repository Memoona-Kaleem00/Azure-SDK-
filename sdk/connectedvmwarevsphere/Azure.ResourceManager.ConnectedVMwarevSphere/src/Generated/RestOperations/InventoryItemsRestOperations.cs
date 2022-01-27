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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal partial class InventoryItemsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of InventoryItemsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public InventoryItemsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2020-10-01-preview";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, InventoryItemData body)
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
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/vcenters/", false);
            uri.AppendPath(vcenterName, true);
            uri.AppendPath("/inventoryItems/", false);
            uri.AppendPath(inventoryItemName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Create Or Update InventoryItem. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vcenterName"/>, or <paramref name="inventoryItemName"/> is null. </exception>
        public async Task<Response<InventoryItemData>> CreateAsync(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, InventoryItemData body = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, vcenterName, inventoryItemName, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InventoryItemData.DeserializeInventoryItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create Or Update InventoryItem. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vcenterName"/>, or <paramref name="inventoryItemName"/> is null. </exception>
        public Response<InventoryItemData> Create(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, InventoryItemData body = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, vcenterName, inventoryItemName, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InventoryItemData.DeserializeInventoryItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName)
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
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/vcenters/", false);
            uri.AppendPath(vcenterName, true);
            uri.AppendPath("/inventoryItems/", false);
            uri.AppendPath(inventoryItemName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Implements InventoryItem GET method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vcenterName"/>, or <paramref name="inventoryItemName"/> is null. </exception>
        public async Task<Response<InventoryItemData>> GetAsync(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vcenterName, inventoryItemName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InventoryItemData.DeserializeInventoryItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((InventoryItemData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Implements InventoryItem GET method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vcenterName"/>, or <paramref name="inventoryItemName"/> is null. </exception>
        public Response<InventoryItemData> Get(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vcenterName, inventoryItemName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InventoryItemData.DeserializeInventoryItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((InventoryItemData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName)
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
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/vcenters/", false);
            uri.AppendPath(vcenterName, true);
            uri.AppendPath("/inventoryItems/", false);
            uri.AppendPath(inventoryItemName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Implements inventoryItem DELETE method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vcenterName"/>, or <paramref name="inventoryItemName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, vcenterName, inventoryItemName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Implements inventoryItem DELETE method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vcenterName"/>, or <paramref name="inventoryItemName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, vcenterName, inventoryItemName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVCenterRequest(string subscriptionId, string resourceGroupName, string vcenterName)
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
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/vcenters/", false);
            uri.AppendPath(vcenterName, true);
            uri.AppendPath("/inventoryItems", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Returns the list of inventoryItems of the given vCenter. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="vcenterName"/> is null. </exception>
        public async Task<Response<InventoryItemsList>> ListByVCenterAsync(string subscriptionId, string resourceGroupName, string vcenterName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var message = CreateListByVCenterRequest(subscriptionId, resourceGroupName, vcenterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InventoryItemsList.DeserializeInventoryItemsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the list of inventoryItems of the given vCenter. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="vcenterName"/> is null. </exception>
        public Response<InventoryItemsList> ListByVCenter(string subscriptionId, string resourceGroupName, string vcenterName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var message = CreateListByVCenterRequest(subscriptionId, resourceGroupName, vcenterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InventoryItemsList.DeserializeInventoryItemsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVCenterNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string vcenterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Returns the list of inventoryItems of the given vCenter. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="vcenterName"/> is null. </exception>
        public async Task<Response<InventoryItemsList>> ListByVCenterNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string vcenterName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var message = CreateListByVCenterNextPageRequest(nextLink, subscriptionId, resourceGroupName, vcenterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InventoryItemsList.DeserializeInventoryItemsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the list of inventoryItems of the given vCenter. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="vcenterName"/> is null. </exception>
        public Response<InventoryItemsList> ListByVCenterNextPage(string nextLink, string subscriptionId, string resourceGroupName, string vcenterName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var message = CreateListByVCenterNextPageRequest(nextLink, subscriptionId, resourceGroupName, vcenterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InventoryItemsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InventoryItemsList.DeserializeInventoryItemsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
