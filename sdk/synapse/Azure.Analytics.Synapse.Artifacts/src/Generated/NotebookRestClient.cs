// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class NotebookRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of NotebookRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public NotebookRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal HttpMessage CreateGetNotebooksByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists Notebooks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<NotebookListResponse>> GetNotebooksByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetNotebooksByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists Notebooks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NotebookListResponse> GetNotebooksByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetNotebooksByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetNotebookSummaryByWorkSpaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooksSummary", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists a summary of Notebooks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<NotebookListResponse>> GetNotebookSummaryByWorkSpaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetNotebookSummaryByWorkSpaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists a summary of Notebooks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NotebookListResponse> GetNotebookSummaryByWorkSpace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetNotebookSummaryByWorkSpaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateNotebookRequest(string notebookName, NotebookResource notebook, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/", false);
            uri.AppendPath(notebookName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<NotebookResource>(notebook);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a Note Book. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="notebook"> Note book resource definition. </param>
        /// <param name="ifMatch"> ETag of the Note book entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> or <paramref name="notebook"/> is null. </exception>
        public async Task<Response> CreateOrUpdateNotebookAsync(string notebookName, NotebookResource notebook, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }
            if (notebook == null)
            {
                throw new ArgumentNullException(nameof(notebook));
            }

            using var message = CreateCreateOrUpdateNotebookRequest(notebookName, notebook, ifMatch);
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

        /// <summary> Creates or updates a Note Book. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="notebook"> Note book resource definition. </param>
        /// <param name="ifMatch"> ETag of the Note book entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> or <paramref name="notebook"/> is null. </exception>
        public Response CreateOrUpdateNotebook(string notebookName, NotebookResource notebook, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }
            if (notebook == null)
            {
                throw new ArgumentNullException(nameof(notebook));
            }

            using var message = CreateCreateOrUpdateNotebookRequest(notebookName, notebook, ifMatch);
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

        internal HttpMessage CreateGetNotebookRequest(string notebookName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/", false);
            uri.AppendPath(notebookName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a Note Book. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="ifNoneMatch"> ETag of the Notebook entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> is null. </exception>
        public async Task<Response<NotebookResource>> GetNotebookAsync(string notebookName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }

            using var message = CreateGetNotebookRequest(notebookName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NotebookResource.DeserializeNotebookResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((NotebookResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a Note Book. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="ifNoneMatch"> ETag of the Notebook entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> is null. </exception>
        public Response<NotebookResource> GetNotebook(string notebookName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }

            using var message = CreateGetNotebookRequest(notebookName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NotebookResource.DeserializeNotebookResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((NotebookResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteNotebookRequest(string notebookName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/", false);
            uri.AppendPath(notebookName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a Note book. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> is null. </exception>
        public async Task<Response> DeleteNotebookAsync(string notebookName, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }

            using var message = CreateDeleteNotebookRequest(notebookName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a Note book. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> is null. </exception>
        public Response DeleteNotebook(string notebookName, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }

            using var message = CreateDeleteNotebookRequest(notebookName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRenameNotebookRequest(string notebookName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/", false);
            uri.AppendPath(notebookName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ArtifactRenameRequest>(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a notebook. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameNotebookAsync(string notebookName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameNotebookRequest(notebookName, request);
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

        /// <summary> Renames a notebook. </summary>
        /// <param name="notebookName"> The notebook name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notebookName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameNotebook(string notebookName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (notebookName == null)
            {
                throw new ArgumentNullException(nameof(notebookName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameNotebookRequest(notebookName, request);
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

        internal HttpMessage CreateGetNotebooksByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists Notebooks. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<NotebookListResponse>> GetNotebooksByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetNotebooksByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists Notebooks. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<NotebookListResponse> GetNotebooksByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetNotebooksByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetNotebookSummaryByWorkSpaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists a summary of Notebooks. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<NotebookListResponse>> GetNotebookSummaryByWorkSpaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetNotebookSummaryByWorkSpaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists a summary of Notebooks. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<NotebookListResponse> GetNotebookSummaryByWorkSpaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetNotebookSummaryByWorkSpaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NotebookListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NotebookListResponse.DeserializeNotebookListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
