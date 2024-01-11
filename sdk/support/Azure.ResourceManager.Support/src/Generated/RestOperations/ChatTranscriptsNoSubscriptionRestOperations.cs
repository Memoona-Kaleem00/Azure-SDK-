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

namespace Azure.ResourceManager.Support
{
    internal partial class ChatTranscriptsNoSubscriptionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ChatTranscriptsNoSubscriptionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ChatTranscriptsNoSubscriptionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string supportTicketName, string chatTranscriptName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendPath("/chatTranscripts/", false);
            uri.AppendPath(chatTranscriptName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string supportTicketName, string chatTranscriptName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Support/supportTickets/", false);
            uri.AppendPath(supportTicketName, true);
            uri.AppendPath("/chatTranscripts/", false);
            uri.AppendPath(chatTranscriptName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns chatTranscript details for a no subscription support ticket. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="chatTranscriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> or <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ChatTranscriptDetailData>> GetAsync(string supportTicketName, string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNullOrEmpty(chatTranscriptName, nameof(chatTranscriptName));

            using var message = CreateGetRequest(supportTicketName, chatTranscriptName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChatTranscriptDetailData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChatTranscriptDetailData.DeserializeChatTranscriptDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ChatTranscriptDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns chatTranscript details for a no subscription support ticket. </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="chatTranscriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> or <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ChatTranscriptDetailData> Get(string supportTicketName, string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNullOrEmpty(chatTranscriptName, nameof(chatTranscriptName));

            using var message = CreateGetRequest(supportTicketName, chatTranscriptName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChatTranscriptDetailData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChatTranscriptDetailData.DeserializeChatTranscriptDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ChatTranscriptDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
