// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    internal partial class ConsumerSourceDataSetsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConsumerSourceDataSetsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConsumerSourceDataSetsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByShareSubscriptionRequest(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken)
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
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/consumerSourceDataSets", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get source dataSets of a shareSubscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumerSourceDataSetList>> ListByShareSubscriptionAsync(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerSourceDataSetList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumerSourceDataSetList.DeserializeConsumerSourceDataSetList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get source dataSets of a shareSubscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumerSourceDataSetList> ListByShareSubscription(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerSourceDataSetList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumerSourceDataSetList.DeserializeConsumerSourceDataSetList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByShareSubscriptionNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken)
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

        /// <summary> Get source dataSets of a shareSubscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumerSourceDataSetList>> ListByShareSubscriptionNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerSourceDataSetList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumerSourceDataSetList.DeserializeConsumerSourceDataSetList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get source dataSets of a shareSubscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumerSourceDataSetList> ListByShareSubscriptionNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerSourceDataSetList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumerSourceDataSetList.DeserializeConsumerSourceDataSetList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
