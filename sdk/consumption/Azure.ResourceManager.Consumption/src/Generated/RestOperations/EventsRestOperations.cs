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
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    internal partial class EventsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of EventsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public EventsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByBillingProfileRequest(string billingAccountId, string billingProfileId, string startDate, string endDate)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingProfiles/", false);
            uri.AppendPath(billingProfileId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/events", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("startDate", startDate, true);
            uri.AppendQuery("endDate", endDate, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="startDate"> Start date. </param>
        /// <param name="endDate"> End date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/>, <paramref name="billingProfileId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Events>> ListByBillingProfileAsync(string billingAccountId, string billingProfileId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateListByBillingProfileRequest(billingAccountId, billingProfileId, startDate, endDate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="startDate"> Start date. </param>
        /// <param name="endDate"> End date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/>, <paramref name="billingProfileId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Events> ListByBillingProfile(string billingAccountId, string billingProfileId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateListByBillingProfileRequest(billingAccountId, billingProfileId, startDate, endDate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBillingAccountRequest(string billingAccountId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/events", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the events by lotId, lotSource etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Events>> ListByBillingAccountAsync(string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountRequest(billingAccountId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the events by lotId, lotSource etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Events> ListByBillingAccount(string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountRequest(billingAccountId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBillingProfileNextPageRequest(string nextLink, string billingAccountId, string billingProfileId, string startDate, string endDate)
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

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="startDate"> Start date. </param>
        /// <param name="endDate"> End date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/>, <paramref name="billingProfileId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Events>> ListByBillingProfileNextPageAsync(string nextLink, string billingAccountId, string billingProfileId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateListByBillingProfileNextPageRequest(nextLink, billingAccountId, billingProfileId, startDate, endDate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="startDate"> Start date. </param>
        /// <param name="endDate"> End date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/>, <paramref name="billingProfileId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Events> ListByBillingProfileNextPage(string nextLink, string billingAccountId, string billingProfileId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateListByBillingProfileNextPageRequest(nextLink, billingAccountId, billingProfileId, startDate, endDate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBillingAccountNextPageRequest(string nextLink, string billingAccountId, string filter)
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

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the events by lotId, lotSource etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Events>> ListByBillingAccountNextPageAsync(string nextLink, string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the events by lotId, lotSource etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Events> ListByBillingAccountNextPage(string nextLink, string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Events value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Events.DeserializeEvents(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
