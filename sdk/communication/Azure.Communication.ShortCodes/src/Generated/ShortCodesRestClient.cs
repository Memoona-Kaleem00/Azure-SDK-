// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.ShortCodes.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.ShortCodes
{
    internal partial class ShortCodesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ShortCodesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public ShortCodesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-10-25-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetShortCodesRequest(int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/shortCodes", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of short codes for the current resource. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Models.ShortCodes>> GetShortCodesAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetShortCodesRequest(skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ShortCodes value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.ShortCodes.DeserializeShortCodes(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of short codes for the current resource. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Models.ShortCodes> GetShortCodes(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetShortCodesRequest(skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ShortCodes value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.ShortCodes.DeserializeShortCodes(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpsertUSProgramBriefRequest(Guid programBriefId, USProgramBrief body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/shortCodes/countries/US/programBriefs/", false);
            uri.AppendPath(programBriefId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/merge-patch+json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue<USProgramBrief>(body);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Creates or updates a US Program Brief. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="body"> Data to create new a Program Brief or fields to update an existing Program Brief. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<USProgramBrief>> UpsertUSProgramBriefAsync(Guid programBriefId, USProgramBrief body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateUpsertUSProgramBriefRequest(programBriefId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        USProgramBrief value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = USProgramBrief.DeserializeUSProgramBrief(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a US Program Brief. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="body"> Data to create new a Program Brief or fields to update an existing Program Brief. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<USProgramBrief> UpsertUSProgramBrief(Guid programBriefId, USProgramBrief body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateUpsertUSProgramBriefRequest(programBriefId, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        USProgramBrief value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = USProgramBrief.DeserializeUSProgramBrief(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteUSProgramBriefRequest(Guid programBriefId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/shortCodes/countries/US/programBriefs/", false);
            uri.AppendPath(programBriefId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a US Program Brief. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteUSProgramBriefAsync(Guid programBriefId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteUSProgramBriefRequest(programBriefId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a US Program Brief. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteUSProgramBrief(Guid programBriefId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteUSProgramBriefRequest(programBriefId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetUSProgramBriefRequest(Guid programBriefId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/shortCodes/countries/US/programBriefs/", false);
            uri.AppendPath(programBriefId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a US Program Brief by id. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<USProgramBrief>> GetUSProgramBriefAsync(Guid programBriefId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetUSProgramBriefRequest(programBriefId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBrief value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = USProgramBrief.DeserializeUSProgramBrief(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a US Program Brief by id. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<USProgramBrief> GetUSProgramBrief(Guid programBriefId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetUSProgramBriefRequest(programBriefId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBrief value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = USProgramBrief.DeserializeUSProgramBrief(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSubmitUSProgramBriefRequest(Guid programBriefId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/shortCodes/countries/US/programBriefs/", false);
            uri.AppendPath(programBriefId, true);
            uri.AppendPath("/:submit", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Submits a US Program Brief for review. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<USProgramBrief>> SubmitUSProgramBriefAsync(Guid programBriefId, CancellationToken cancellationToken = default)
        {
            using var message = CreateSubmitUSProgramBriefRequest(programBriefId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBrief value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = USProgramBrief.DeserializeUSProgramBrief(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Submits a US Program Brief for review. </summary>
        /// <param name="programBriefId"> Program Brief Id. Must be a valid GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<USProgramBrief> SubmitUSProgramBrief(Guid programBriefId, CancellationToken cancellationToken = default)
        {
            using var message = CreateSubmitUSProgramBriefRequest(programBriefId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBrief value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = USProgramBrief.DeserializeUSProgramBrief(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetUSProgramBriefsRequest(int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/shortCodes/countries/US/programBriefs", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of US Program Briefs for the current resource. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<USProgramBriefs>> GetUSProgramBriefsAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetUSProgramBriefsRequest(skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBriefs value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = USProgramBriefs.DeserializeUSProgramBriefs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of US Program Briefs for the current resource. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<USProgramBriefs> GetUSProgramBriefs(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetUSProgramBriefsRequest(skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBriefs value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = USProgramBriefs.DeserializeUSProgramBriefs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetShortCodesNextPageRequest(string nextLink, int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of short codes for the current resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<Models.ShortCodes>> GetShortCodesNextPageAsync(string nextLink, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetShortCodesNextPageRequest(nextLink, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ShortCodes value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.ShortCodes.DeserializeShortCodes(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of short codes for the current resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<Models.ShortCodes> GetShortCodesNextPage(string nextLink, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetShortCodesNextPageRequest(nextLink, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ShortCodes value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.ShortCodes.DeserializeShortCodes(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetUSProgramBriefsNextPageRequest(string nextLink, int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of US Program Briefs for the current resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<USProgramBriefs>> GetUSProgramBriefsNextPageAsync(string nextLink, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetUSProgramBriefsNextPageRequest(nextLink, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBriefs value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = USProgramBriefs.DeserializeUSProgramBriefs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of US Program Briefs for the current resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<USProgramBriefs> GetUSProgramBriefsNextPage(string nextLink, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetUSProgramBriefsNextPageRequest(nextLink, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        USProgramBriefs value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = USProgramBriefs.DeserializeUSProgramBriefs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
