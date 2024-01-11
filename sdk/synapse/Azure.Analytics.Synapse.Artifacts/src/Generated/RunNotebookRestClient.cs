// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class RunNotebookRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RunNotebookRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public RunNotebookRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal RequestUriBuilder CreateCreateRunRequestUri(string runId, RunNotebookRequest runNotebookRequest)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            return uri;
        }

        internal HttpMessage CreateCreateRunRequest(string runId, RunNotebookRequest runNotebookRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(runNotebookRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Run notebook. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="runNotebookRequest"> Run notebook request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> or <paramref name="runNotebookRequest"/> is null. </exception>
        public async Task<ResponseWithHeaders<RunNotebookCreateRunHeaders>> CreateRunAsync(string runId, RunNotebookRequest runNotebookRequest, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runNotebookRequest == null)
            {
                throw new ArgumentNullException(nameof(runNotebookRequest));
            }

            using var message = CreateCreateRunRequest(runId, runNotebookRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new RunNotebookCreateRunHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Run notebook. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="runNotebookRequest"> Run notebook request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> or <paramref name="runNotebookRequest"/> is null. </exception>
        public ResponseWithHeaders<RunNotebookCreateRunHeaders> CreateRun(string runId, RunNotebookRequest runNotebookRequest, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runNotebookRequest == null)
            {
                throw new ArgumentNullException(nameof(runNotebookRequest));
            }

            using var message = CreateCreateRunRequest(runId, runNotebookRequest);
            _pipeline.Send(message, cancellationToken);
            var headers = new RunNotebookCreateRunHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetStatusRequestUri(string runId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            return uri;
        }

        internal HttpMessage CreateGetStatusRequest(string runId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get RunNotebook Status for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public async Task<Response<RunNotebookResponse>> GetStatusAsync(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateGetStatusRequest(runId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RunNotebookResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RunNotebookResponse.DeserializeRunNotebookResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get RunNotebook Status for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public Response<RunNotebookResponse> GetStatus(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateGetStatusRequest(runId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RunNotebookResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RunNotebookResponse.DeserializeRunNotebookResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCancelRunRequestUri(string runId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            return uri;
        }

        internal HttpMessage CreateCancelRunRequest(string runId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancel notebook run. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public async Task<Response<RunNotebookResponse>> CancelRunAsync(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateCancelRunRequest(runId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RunNotebookResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RunNotebookResponse.DeserializeRunNotebookResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancel notebook run. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public Response<RunNotebookResponse> CancelRun(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateCancelRunRequest(runId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RunNotebookResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RunNotebookResponse.DeserializeRunNotebookResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetSnapshotRequestUri(string runId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/snapshot", false);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            return uri;
        }

        internal HttpMessage CreateGetSnapshotRequest(string runId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/notebooks/runs/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/snapshot", false);
            uri.AppendQuery("api-version", "2022-03-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get RunNotebook Snapshot for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public async Task<Response<RunNotebookSnapshotResponse>> GetSnapshotAsync(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateGetSnapshotRequest(runId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RunNotebookSnapshotResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RunNotebookSnapshotResponse.DeserializeRunNotebookSnapshotResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get RunNotebook Snapshot for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public Response<RunNotebookSnapshotResponse> GetSnapshot(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateGetSnapshotRequest(runId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RunNotebookSnapshotResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RunNotebookSnapshotResponse.DeserializeRunNotebookSnapshotResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
