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
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Avs
{
    internal partial class HcxEnterpriseSitesRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of HcxEnterpriseSitesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public HcxEnterpriseSitesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, Uri endpoint = null, string apiVersion = "2021-12-01")
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string privateCloudName)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/hcxEnterpriseSites", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List HCX Enterprise Sites in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="privateCloudName"/> is null. </exception>
        public async Task<Response<HcxEnterpriseSiteList>> ListAsync(string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HcxEnterpriseSiteList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HcxEnterpriseSiteList.DeserializeHcxEnterpriseSiteList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List HCX Enterprise Sites in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="privateCloudName"/> is null. </exception>
        public Response<HcxEnterpriseSiteList> List(string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HcxEnterpriseSiteList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HcxEnterpriseSiteList.DeserializeHcxEnterpriseSiteList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/hcxEnterpriseSites/", false);
            uri.AppendPath(hcxEnterpriseSiteName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get an HCX Enterprise Site by name in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public async Task<Response<HcxEnterpriseSiteData>> GetAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (hcxEnterpriseSiteName == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSiteName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, hcxEnterpriseSiteName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HcxEnterpriseSiteData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HcxEnterpriseSiteData.DeserializeHcxEnterpriseSiteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HcxEnterpriseSiteData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get an HCX Enterprise Site by name in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public Response<HcxEnterpriseSiteData> Get(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (hcxEnterpriseSiteName == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSiteName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, hcxEnterpriseSiteName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HcxEnterpriseSiteData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HcxEnterpriseSiteData.DeserializeHcxEnterpriseSiteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HcxEnterpriseSiteData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, HcxEnterpriseSiteData hcxEnterpriseSite)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/hcxEnterpriseSites/", false);
            uri.AppendPath(hcxEnterpriseSiteName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(hcxEnterpriseSite);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Create or update an HCX Enterprise Site in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> The name of the private cloud. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="hcxEnterpriseSite"> The HCX Enterprise Site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="hcxEnterpriseSiteName"/>, or <paramref name="hcxEnterpriseSite"/> is null. </exception>
        public async Task<Response<HcxEnterpriseSiteData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, HcxEnterpriseSiteData hcxEnterpriseSite, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (hcxEnterpriseSiteName == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSiteName));
            }
            if (hcxEnterpriseSite == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSite));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, privateCloudName, hcxEnterpriseSiteName, hcxEnterpriseSite);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        HcxEnterpriseSiteData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HcxEnterpriseSiteData.DeserializeHcxEnterpriseSiteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update an HCX Enterprise Site in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> The name of the private cloud. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="hcxEnterpriseSite"> The HCX Enterprise Site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="hcxEnterpriseSiteName"/>, or <paramref name="hcxEnterpriseSite"/> is null. </exception>
        public Response<HcxEnterpriseSiteData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, HcxEnterpriseSiteData hcxEnterpriseSite, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (hcxEnterpriseSiteName == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSiteName));
            }
            if (hcxEnterpriseSite == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSite));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, privateCloudName, hcxEnterpriseSiteName, hcxEnterpriseSite);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        HcxEnterpriseSiteData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HcxEnterpriseSiteData.DeserializeHcxEnterpriseSiteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/hcxEnterpriseSites/", false);
            uri.AppendPath(hcxEnterpriseSiteName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Delete an HCX Enterprise Site in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (hcxEnterpriseSiteName == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSiteName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, privateCloudName, hcxEnterpriseSiteName);
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

        /// <summary> Delete an HCX Enterprise Site in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (hcxEnterpriseSiteName == null)
            {
                throw new ArgumentNullException(nameof(hcxEnterpriseSiteName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, privateCloudName, hcxEnterpriseSiteName);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName)
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

        /// <summary> List HCX Enterprise Sites in a private cloud. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="privateCloudName"/> is null. </exception>
        public async Task<Response<HcxEnterpriseSiteList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
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
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HcxEnterpriseSiteList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HcxEnterpriseSiteList.DeserializeHcxEnterpriseSiteList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List HCX Enterprise Sites in a private cloud. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="privateCloudName"/> is null. </exception>
        public Response<HcxEnterpriseSiteList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
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
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HcxEnterpriseSiteList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HcxEnterpriseSiteList.DeserializeHcxEnterpriseSiteList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
