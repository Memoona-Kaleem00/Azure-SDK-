// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.TextAnalytics.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.TextAnalytics
{
    internal partial class MicrosoftCognitiveLanguageServiceRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of MicrosoftCognitiveLanguageServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt;resource-name&gt;.api.cognitiveservices.azure.com). </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public MicrosoftCognitiveLanguageServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-03-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateAnalyzeRequest(AnalyzeTextTask body, bool? showStats)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/:analyze-text", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (showStats != null)
            {
                uri.AppendQuery("showStats", showStats.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Submit a collection of text documents for analysis.  Specify a single unique task to be executed immediately. </summary>
        /// <param name="body"> Collection of documents to analyze and a single task to execute. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<AnalyzeTextTaskResult>> AnalyzeAsync(AnalyzeTextTask body, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateAnalyzeRequest(body, showStats);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnalyzeTextTaskResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnalyzeTextTaskResult.DeserializeAnalyzeTextTaskResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Submit a collection of text documents for analysis.  Specify a single unique task to be executed immediately. </summary>
        /// <param name="body"> Collection of documents to analyze and a single task to execute. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<AnalyzeTextTaskResult> Analyze(AnalyzeTextTask body, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateAnalyzeRequest(body, showStats);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnalyzeTextTaskResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnalyzeTextTaskResult.DeserializeAnalyzeTextTaskResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeBatchSubmitJobRequest(AnalyzeTextJobsInput body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-text/jobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Submit a collection of text documents for analysis. Specify one or more unique tasks to be executed as a long-running operation. </summary>
        /// <param name="body"> Collection of documents to analyze and one or more tasks to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<ResponseWithHeaders<MicrosoftCognitiveLanguageServiceAnalyzeBatchSubmitJobHeaders>> AnalyzeBatchSubmitJobAsync(AnalyzeTextJobsInput body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateAnalyzeBatchSubmitJobRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MicrosoftCognitiveLanguageServiceAnalyzeBatchSubmitJobHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Submit a collection of text documents for analysis. Specify one or more unique tasks to be executed as a long-running operation. </summary>
        /// <param name="body"> Collection of documents to analyze and one or more tasks to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public ResponseWithHeaders<MicrosoftCognitiveLanguageServiceAnalyzeBatchSubmitJobHeaders> AnalyzeBatchSubmitJob(AnalyzeTextJobsInput body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateAnalyzeBatchSubmitJobRequest(body);
            _pipeline.Send(message, cancellationToken);
            var headers = new MicrosoftCognitiveLanguageServiceAnalyzeBatchSubmitJobHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeBatchJobStatusRequest(Guid jobId, bool? showStats, int? top, int? skip)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-text/jobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (showStats != null)
            {
                uri.AppendQuery("showStats", showStats.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the status of an analysis job.  A job may consist of one or more tasks.  Once all tasks are succeeded, the job will transition to the succeeded state and results will be available for each task. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="top"> The maximum number of resources to return from the collection. </param>
        /// <param name="skip"> An offset into the collection of the first resource to be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AnalyzeTextJobState>> AnalyzeBatchJobStatusAsync(Guid jobId, bool? showStats = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBatchJobStatusRequest(jobId, showStats, top, skip);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnalyzeTextJobState value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnalyzeTextJobState.DeserializeAnalyzeTextJobState(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the status of an analysis job.  A job may consist of one or more tasks.  Once all tasks are succeeded, the job will transition to the succeeded state and results will be available for each task. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="top"> The maximum number of resources to return from the collection. </param>
        /// <param name="skip"> An offset into the collection of the first resource to be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AnalyzeTextJobState> AnalyzeBatchJobStatus(Guid jobId, bool? showStats = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBatchJobStatusRequest(jobId, showStats, top, skip);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnalyzeTextJobState value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnalyzeTextJobState.DeserializeAnalyzeTextJobState(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
