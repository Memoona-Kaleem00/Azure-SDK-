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
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    internal partial class LocationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of LocationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> Azure Resource Manager url. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public LocationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCheckTrialAvailabilityRequestUri(string subscriptionId, string location, AvsSku sku)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AVS/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/checkTrialAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCheckTrialAvailabilityRequest(string subscriptionId, string location, AvsSku sku)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AVS/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/checkTrialAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (sku != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(sku, ModelSerializationExtensions.WireOptions);
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Return trial status for subscription by region. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="location"> A location in a subscription. </param>
        /// <param name="sku"> Optionally, check for a specific SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvsSubscriptionTrialAvailabilityResult>> CheckTrialAvailabilityAsync(string subscriptionId, string location, AvsSku sku = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var message = CreateCheckTrialAvailabilityRequest(subscriptionId, location, sku);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvsSubscriptionTrialAvailabilityResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvsSubscriptionTrialAvailabilityResult.DeserializeAvsSubscriptionTrialAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return trial status for subscription by region. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="location"> A location in a subscription. </param>
        /// <param name="sku"> Optionally, check for a specific SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvsSubscriptionTrialAvailabilityResult> CheckTrialAvailability(string subscriptionId, string location, AvsSku sku = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var message = CreateCheckTrialAvailabilityRequest(subscriptionId, location, sku);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvsSubscriptionTrialAvailabilityResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvsSubscriptionTrialAvailabilityResult.DeserializeAvsSubscriptionTrialAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCheckQuotaAvailabilityRequestUri(string subscriptionId, string location)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AVS/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/checkQuotaAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCheckQuotaAvailabilityRequest(string subscriptionId, string location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AVS/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/checkQuotaAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Return quota for subscription by region. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="location"> A location in a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvsSubscriptionQuotaAvailabilityResult>> CheckQuotaAvailabilityAsync(string subscriptionId, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var message = CreateCheckQuotaAvailabilityRequest(subscriptionId, location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvsSubscriptionQuotaAvailabilityResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvsSubscriptionQuotaAvailabilityResult.DeserializeAvsSubscriptionQuotaAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return quota for subscription by region. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="location"> A location in a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvsSubscriptionQuotaAvailabilityResult> CheckQuotaAvailability(string subscriptionId, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var message = CreateCheckQuotaAvailabilityRequest(subscriptionId, location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvsSubscriptionQuotaAvailabilityResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvsSubscriptionQuotaAvailabilityResult.DeserializeAvsSubscriptionQuotaAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
