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
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    internal partial class ReceivedRoutesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReceivedRoutesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReceivedRoutesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByPeeringRequest(string subscriptionId, string resourceGroupName, string peeringName, string prefix, string asPath, string originAsValidationState, string rpkiValidationState, string skipToken)
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
            uri.AppendPath("/providers/Microsoft.Peering/peerings/", false);
            uri.AppendPath(peeringName, true);
            uri.AppendPath("/receivedRoutes", false);
            if (prefix != null)
            {
                uri.AppendQuery("prefix", prefix, true);
            }
            if (asPath != null)
            {
                uri.AppendQuery("asPath", asPath, true);
            }
            if (originAsValidationState != null)
            {
                uri.AppendQuery("originAsValidationState", originAsValidationState, true);
            }
            if (rpkiValidationState != null)
            {
                uri.AppendQuery("rpkiValidationState", rpkiValidationState, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the prefixes received over the specified peering under the given subscription and resource group. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="prefix"> The optional prefix that can be used to filter the routes. </param>
        /// <param name="asPath"> The optional AS path that can be used to filter the routes. </param>
        /// <param name="originAsValidationState"> The optional origin AS validation state that can be used to filter the routes. </param>
        /// <param name="rpkiValidationState"> The optional RPKI validation state that can be used to filter the routes. </param>
        /// <param name="skipToken"> The optional page continuation token that is used in the event of paginated result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PeeringReceivedRouteListResult>> ListByPeeringAsync(string subscriptionId, string resourceGroupName, string peeringName, string prefix = null, string asPath = null, string originAsValidationState = null, string rpkiValidationState = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListByPeeringRequest(subscriptionId, resourceGroupName, peeringName, prefix, asPath, originAsValidationState, rpkiValidationState, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringReceivedRouteListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PeeringReceivedRouteListResult.DeserializePeeringReceivedRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the prefixes received over the specified peering under the given subscription and resource group. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="prefix"> The optional prefix that can be used to filter the routes. </param>
        /// <param name="asPath"> The optional AS path that can be used to filter the routes. </param>
        /// <param name="originAsValidationState"> The optional origin AS validation state that can be used to filter the routes. </param>
        /// <param name="rpkiValidationState"> The optional RPKI validation state that can be used to filter the routes. </param>
        /// <param name="skipToken"> The optional page continuation token that is used in the event of paginated result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PeeringReceivedRouteListResult> ListByPeering(string subscriptionId, string resourceGroupName, string peeringName, string prefix = null, string asPath = null, string originAsValidationState = null, string rpkiValidationState = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListByPeeringRequest(subscriptionId, resourceGroupName, peeringName, prefix, asPath, originAsValidationState, rpkiValidationState, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringReceivedRouteListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PeeringReceivedRouteListResult.DeserializePeeringReceivedRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPeeringNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, string prefix, string asPath, string originAsValidationState, string rpkiValidationState, string skipToken)
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

        /// <summary> Lists the prefixes received over the specified peering under the given subscription and resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="prefix"> The optional prefix that can be used to filter the routes. </param>
        /// <param name="asPath"> The optional AS path that can be used to filter the routes. </param>
        /// <param name="originAsValidationState"> The optional origin AS validation state that can be used to filter the routes. </param>
        /// <param name="rpkiValidationState"> The optional RPKI validation state that can be used to filter the routes. </param>
        /// <param name="skipToken"> The optional page continuation token that is used in the event of paginated result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PeeringReceivedRouteListResult>> ListByPeeringNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, string prefix = null, string asPath = null, string originAsValidationState = null, string rpkiValidationState = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListByPeeringNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringName, prefix, asPath, originAsValidationState, rpkiValidationState, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringReceivedRouteListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PeeringReceivedRouteListResult.DeserializePeeringReceivedRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the prefixes received over the specified peering under the given subscription and resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="prefix"> The optional prefix that can be used to filter the routes. </param>
        /// <param name="asPath"> The optional AS path that can be used to filter the routes. </param>
        /// <param name="originAsValidationState"> The optional origin AS validation state that can be used to filter the routes. </param>
        /// <param name="rpkiValidationState"> The optional RPKI validation state that can be used to filter the routes. </param>
        /// <param name="skipToken"> The optional page continuation token that is used in the event of paginated result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PeeringReceivedRouteListResult> ListByPeeringNextPage(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, string prefix = null, string asPath = null, string originAsValidationState = null, string rpkiValidationState = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListByPeeringNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringName, prefix, asPath, originAsValidationState, rpkiValidationState, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringReceivedRouteListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PeeringReceivedRouteListResult.DeserializePeeringReceivedRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
