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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class IntegrationServiceEnvironmentManagedApiRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentManagedApiRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationServiceEnvironmentManagedApiRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/managedApis/", false);
            uri.AppendPath(apiName, true);
            uri.AppendPath("/apiOperations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/managedApis/", false);
            uri.AppendPath(apiName, true);
            uri.AppendPath("/apiOperations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the managed Api operations. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicApiOperationListResult>> ListAsync(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicApiOperationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicApiOperationListResult.DeserializeLogicApiOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the managed Api operations. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicApiOperationListResult> List(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicApiOperationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicApiOperationListResult.DeserializeLogicApiOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
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

        /// <summary> Gets the managed Api operations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicApiOperationListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
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
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicApiOperationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicApiOperationListResult.DeserializeLogicApiOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the managed Api operations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicApiOperationListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
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
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicApiOperationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicApiOperationListResult.DeserializeLogicApiOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
