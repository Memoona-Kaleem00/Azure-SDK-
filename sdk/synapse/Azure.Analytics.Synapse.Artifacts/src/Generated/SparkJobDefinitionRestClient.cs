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
    internal partial class SparkJobDefinitionRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SparkJobDefinitionRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public SparkJobDefinitionRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal RequestUriBuilder CreateGetSparkJobDefinitionsByWorkspaceRequestUri()
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateGetSparkJobDefinitionsByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists spark job definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkJobDefinitionsListResponse>> GetSparkJobDefinitionsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkJobDefinitionsByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobDefinitionsListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkJobDefinitionsListResponse.DeserializeSparkJobDefinitionsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists spark job definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkJobDefinitionsListResponse> GetSparkJobDefinitionsByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkJobDefinitionsByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobDefinitionsListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkJobDefinitionsListResponse.DeserializeSparkJobDefinitionsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateSparkJobDefinitionRequestUri(string sparkJobDefinitionName, SparkJobDefinitionResource sparkJobDefinition, string ifMatch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateSparkJobDefinitionRequest(string sparkJobDefinitionName, SparkJobDefinitionResource sparkJobDefinition, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sparkJobDefinition);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="sparkJobDefinition"> Spark Job Definition resource definition. </param>
        /// <param name="ifMatch"> ETag of the Spark Job Definition entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="sparkJobDefinition"/> is null. </exception>
        public async Task<Response> CreateOrUpdateSparkJobDefinitionAsync(string sparkJobDefinitionName, SparkJobDefinitionResource sparkJobDefinition, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (sparkJobDefinition == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinition));
            }

            using var message = CreateCreateOrUpdateSparkJobDefinitionRequest(sparkJobDefinitionName, sparkJobDefinition, ifMatch);
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

        /// <summary> Creates or updates a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="sparkJobDefinition"> Spark Job Definition resource definition. </param>
        /// <param name="ifMatch"> ETag of the Spark Job Definition entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="sparkJobDefinition"/> is null. </exception>
        public Response CreateOrUpdateSparkJobDefinition(string sparkJobDefinitionName, SparkJobDefinitionResource sparkJobDefinition, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (sparkJobDefinition == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinition));
            }

            using var message = CreateCreateOrUpdateSparkJobDefinitionRequest(sparkJobDefinitionName, sparkJobDefinition, ifMatch);
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

        internal RequestUriBuilder CreateGetSparkJobDefinitionRequestUri(string sparkJobDefinitionName, string ifNoneMatch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateGetSparkJobDefinitionRequest(string sparkJobDefinitionName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="ifNoneMatch"> ETag of the Spark Job Definition entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public async Task<Response<SparkJobDefinitionResource>> GetSparkJobDefinitionAsync(string sparkJobDefinitionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var message = CreateGetSparkJobDefinitionRequest(sparkJobDefinitionName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobDefinitionResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkJobDefinitionResource.DeserializeSparkJobDefinitionResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((SparkJobDefinitionResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="ifNoneMatch"> ETag of the Spark Job Definition entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public Response<SparkJobDefinitionResource> GetSparkJobDefinition(string sparkJobDefinitionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var message = CreateGetSparkJobDefinitionRequest(sparkJobDefinitionName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobDefinitionResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkJobDefinitionResource.DeserializeSparkJobDefinitionResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((SparkJobDefinitionResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteSparkJobDefinitionRequestUri(string sparkJobDefinitionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateDeleteSparkJobDefinitionRequest(string sparkJobDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public async Task<Response> DeleteSparkJobDefinitionAsync(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var message = CreateDeleteSparkJobDefinitionRequest(sparkJobDefinitionName);
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

        /// <summary> Deletes a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public Response DeleteSparkJobDefinition(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var message = CreateDeleteSparkJobDefinitionRequest(sparkJobDefinitionName);
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

        internal RequestUriBuilder CreateExecuteSparkJobDefinitionRequestUri(string sparkJobDefinitionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendPath("/execute", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateExecuteSparkJobDefinitionRequest(string sparkJobDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendPath("/execute", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Executes the spark job definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public async Task<Response> ExecuteSparkJobDefinitionAsync(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var message = CreateExecuteSparkJobDefinitionRequest(sparkJobDefinitionName);
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

        /// <summary> Executes the spark job definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public Response ExecuteSparkJobDefinition(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var message = CreateExecuteSparkJobDefinitionRequest(sparkJobDefinitionName);
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

        internal RequestUriBuilder CreateRenameSparkJobDefinitionRequestUri(string sparkJobDefinitionName, ArtifactRenameRequest request)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateRenameSparkJobDefinitionRequest(string sparkJobDefinitionName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkJobDefinitions/", false);
            uri.AppendPath(sparkJobDefinitionName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a sparkJobDefinition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameSparkJobDefinitionAsync(string sparkJobDefinitionName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameSparkJobDefinitionRequest(sparkJobDefinitionName, request);
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

        /// <summary> Renames a sparkJobDefinition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameSparkJobDefinition(string sparkJobDefinitionName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameSparkJobDefinitionRequest(sparkJobDefinitionName, request);
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

        internal RequestUriBuilder CreateDebugSparkJobDefinitionRequestUri(SparkJobDefinitionResource sparkJobDefinitionAzureResource)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/debugSparkJobDefinition", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            return uri;
        }

        internal HttpMessage CreateDebugSparkJobDefinitionRequest(SparkJobDefinitionResource sparkJobDefinitionAzureResource)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/debugSparkJobDefinition", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sparkJobDefinitionAzureResource);
            request.Content = content;
            return message;
        }

        /// <summary> Debug the spark job definition. </summary>
        /// <param name="sparkJobDefinitionAzureResource"> Spark Job Definition resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionAzureResource"/> is null. </exception>
        public async Task<Response> DebugSparkJobDefinitionAsync(SparkJobDefinitionResource sparkJobDefinitionAzureResource, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionAzureResource == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionAzureResource));
            }

            using var message = CreateDebugSparkJobDefinitionRequest(sparkJobDefinitionAzureResource);
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

        /// <summary> Debug the spark job definition. </summary>
        /// <param name="sparkJobDefinitionAzureResource"> Spark Job Definition resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionAzureResource"/> is null. </exception>
        public Response DebugSparkJobDefinition(SparkJobDefinitionResource sparkJobDefinitionAzureResource, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionAzureResource == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionAzureResource));
            }

            using var message = CreateDebugSparkJobDefinitionRequest(sparkJobDefinitionAzureResource);
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

        internal RequestUriBuilder CreateGetSparkJobDefinitionsByWorkspaceNextPageRequestUri(string nextLink)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateGetSparkJobDefinitionsByWorkspaceNextPageRequest(string nextLink)
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

        /// <summary> Lists spark job definitions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<SparkJobDefinitionsListResponse>> GetSparkJobDefinitionsByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetSparkJobDefinitionsByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobDefinitionsListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkJobDefinitionsListResponse.DeserializeSparkJobDefinitionsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists spark job definitions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<SparkJobDefinitionsListResponse> GetSparkJobDefinitionsByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetSparkJobDefinitionsByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobDefinitionsListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkJobDefinitionsListResponse.DeserializeSparkJobDefinitionsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
