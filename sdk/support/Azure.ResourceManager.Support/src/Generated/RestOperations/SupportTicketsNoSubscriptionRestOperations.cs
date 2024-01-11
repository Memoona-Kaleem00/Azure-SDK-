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
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    internal partial class SupportTicketsNoSubscriptionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SupportTicketsNoSubscriptionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SupportTicketsNoSubscriptionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCheckNameAvailabilityRequestUri(SupportNameAvailabilityContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/checkNameAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCheckNameAvailabilityRequest(SupportNameAvailabilityContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/checkNameAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Check the availability of a resource name. This API should be used to check the uniqueness of the name for support ticket creation for the selected subscription. </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response<SupportNameAvailabilityResult>> CheckNameAvailabilityAsync(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckNameAvailabilityRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportNameAvailabilityResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportNameAvailabilityResult.DeserializeSupportNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Check the availability of a resource name. This API should be used to check the uniqueness of the name for support ticket creation for the selected subscription. </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response<SupportNameAvailabilityResult> CheckNameAvailability(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckNameAvailabilityRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportNameAvailabilityResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportNameAvailabilityResult.DeserializeSupportNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(int? top, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets", false);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(int? top, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets", false);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the support tickets. &lt;br/&gt;&lt;br/&gt;You can also filter the support tickets by &lt;i&gt;Status&lt;/i&gt;, &lt;i&gt;CreatedDate&lt;/i&gt;, , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; using the $filter parameter. Output will be a paged result with &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support 'odata v4.0' filter semantics. &lt;a target='_blank' href='https://docs.microsoft.com/odata/concepts/queryoptions-overview'&gt;Learn more&lt;/a&gt; &lt;br/&gt;&lt;i&gt;Status&lt;/i&gt; , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; filters can only be used with 'eq' operator. For &lt;i&gt;CreatedDate&lt;/i&gt; filter, the supported operators are 'gt' and 'ge'. When using both filters, combine them using the logical 'AND'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SupportTicketsListResult>> ListAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(top, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportTicketsListResult.DeserializeSupportTicketsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the support tickets. &lt;br/&gt;&lt;br/&gt;You can also filter the support tickets by &lt;i&gt;Status&lt;/i&gt;, &lt;i&gt;CreatedDate&lt;/i&gt;, , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; using the $filter parameter. Output will be a paged result with &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support 'odata v4.0' filter semantics. &lt;a target='_blank' href='https://docs.microsoft.com/odata/concepts/queryoptions-overview'&gt;Learn more&lt;/a&gt; &lt;br/&gt;&lt;i&gt;Status&lt;/i&gt; , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; filters can only be used with 'eq' operator. For &lt;i&gt;CreatedDate&lt;/i&gt; filter, the supported operators are 'gt' and 'ge'. When using both filters, combine them using the logical 'AND'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SupportTicketsListResult> List(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(top, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportTicketsListResult.DeserializeSupportTicketsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string supportTicketName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string supportTicketName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SupportTicketData>> GetAsync(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var message = CreateGetRequest(supportTicketName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SupportTicketData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SupportTicketData> Get(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var message = CreateGetRequest(supportTicketName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SupportTicketData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string supportTicketName, UpdateSupportTicket updateSupportTicket)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string supportTicketName, UpdateSupportTicket updateSupportTicket)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(updateSupportTicket);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This API allows you to update the severity level, ticket status, and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="updateSupportTicket"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SupportTicketData>> UpdateAsync(string supportTicketName, UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(updateSupportTicket, nameof(updateSupportTicket));

            using var message = CreateUpdateRequest(supportTicketName, updateSupportTicket);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This API allows you to update the severity level, ticket status, and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="updateSupportTicket"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SupportTicketData> Update(string supportTicketName, UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(updateSupportTicket, nameof(updateSupportTicket));

            using var message = CreateUpdateRequest(supportTicketName, updateSupportTicket);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateRequestUri(string supportTicketName, SupportTicketData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string supportTicketName, SupportTicketData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
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

        /// <summary> Creates a new support ticket for Billing, and Subscription Management issues. Learn the [prerequisites](https://aka.ms/supportAPI) required to create a support ticket.&lt;br/&gt;&lt;br/&gt;Always call the Services and ProblemClassifications API to get the most recent set of services and problem categories required for support ticket creation.&lt;br/&gt;&lt;br/&gt;Adding attachments is not currently supported via the API. To add a file to an existing support ticket, visit the [Manage support ticket](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest) page in the Azure portal, select the support ticket, and use the file upload control to add a new file.&lt;br/&gt;&lt;br/&gt;Providing consent to share diagnostic information with Azure support is currently not supported via the API. The Azure support engineer working on your ticket will reach out to you for consent if your issue requires gathering diagnostic information from your Azure resources.&lt;br/&gt;&lt;br/&gt;. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="data"> Support ticket request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string supportTicketName, SupportTicketData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(supportTicketName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new support ticket for Billing, and Subscription Management issues. Learn the [prerequisites](https://aka.ms/supportAPI) required to create a support ticket.&lt;br/&gt;&lt;br/&gt;Always call the Services and ProblemClassifications API to get the most recent set of services and problem categories required for support ticket creation.&lt;br/&gt;&lt;br/&gt;Adding attachments is not currently supported via the API. To add a file to an existing support ticket, visit the [Manage support ticket](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest) page in the Azure portal, select the support ticket, and use the file upload control to add a new file.&lt;br/&gt;&lt;br/&gt;Providing consent to share diagnostic information with Azure support is currently not supported via the API. The Azure support engineer working on your ticket will reach out to you for consent if your issue requires gathering diagnostic information from your Azure resources.&lt;br/&gt;&lt;br/&gt;. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="data"> Support ticket request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string supportTicketName, SupportTicketData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(supportTicketName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, int? top, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, int? top, string filter)
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

        /// <summary> Lists all the support tickets. &lt;br/&gt;&lt;br/&gt;You can also filter the support tickets by &lt;i&gt;Status&lt;/i&gt;, &lt;i&gt;CreatedDate&lt;/i&gt;, , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; using the $filter parameter. Output will be a paged result with &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support 'odata v4.0' filter semantics. &lt;a target='_blank' href='https://docs.microsoft.com/odata/concepts/queryoptions-overview'&gt;Learn more&lt;/a&gt; &lt;br/&gt;&lt;i&gt;Status&lt;/i&gt; , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; filters can only be used with 'eq' operator. For &lt;i&gt;CreatedDate&lt;/i&gt; filter, the supported operators are 'gt' and 'ge'. When using both filters, combine them using the logical 'AND'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<SupportTicketsListResult>> ListNextPageAsync(string nextLink, int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink, top, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportTicketsListResult.DeserializeSupportTicketsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the support tickets. &lt;br/&gt;&lt;br/&gt;You can also filter the support tickets by &lt;i&gt;Status&lt;/i&gt;, &lt;i&gt;CreatedDate&lt;/i&gt;, , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; using the $filter parameter. Output will be a paged result with &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support 'odata v4.0' filter semantics. &lt;a target='_blank' href='https://docs.microsoft.com/odata/concepts/queryoptions-overview'&gt;Learn more&lt;/a&gt; &lt;br/&gt;&lt;i&gt;Status&lt;/i&gt; , &lt;i&gt;ServiceId&lt;/i&gt;, and &lt;i&gt;ProblemClassificationId&lt;/i&gt; filters can only be used with 'eq' operator. For &lt;i&gt;CreatedDate&lt;/i&gt; filter, the supported operators are 'gt' and 'ge'. When using both filters, combine them using the logical 'AND'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<SupportTicketsListResult> ListNextPage(string nextLink, int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink, top, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportTicketsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportTicketsListResult.DeserializeSupportTicketsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
