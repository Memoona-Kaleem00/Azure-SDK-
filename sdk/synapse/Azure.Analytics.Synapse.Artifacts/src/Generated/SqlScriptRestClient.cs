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
    internal partial class SqlScriptRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of SqlScriptRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public SqlScriptRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-06-01-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetSqlScriptsByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/sqlScripts", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists sql scripts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SqlScriptsListResponse>> GetSqlScriptsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSqlScriptsByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlScriptsListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlScriptsListResponse.DeserializeSqlScriptsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists sql scripts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SqlScriptsListResponse> GetSqlScriptsByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSqlScriptsByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlScriptsListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlScriptsListResponse.DeserializeSqlScriptsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateSqlScriptRequest(string sqlScriptName, SqlScriptResource sqlScript, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/sqlScripts/", false);
            uri.AppendPath(sqlScriptName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sqlScript);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a Sql Script. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="sqlScript"> Sql Script resource definition. </param>
        /// <param name="ifMatch"> ETag of the SQL script entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> or <paramref name="sqlScript"/> is null. </exception>
        public async Task<Response> CreateOrUpdateSqlScriptAsync(string sqlScriptName, SqlScriptResource sqlScript, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }
            if (sqlScript == null)
            {
                throw new ArgumentNullException(nameof(sqlScript));
            }

            using var message = CreateCreateOrUpdateSqlScriptRequest(sqlScriptName, sqlScript, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a Sql Script. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="sqlScript"> Sql Script resource definition. </param>
        /// <param name="ifMatch"> ETag of the SQL script entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> or <paramref name="sqlScript"/> is null. </exception>
        public Response CreateOrUpdateSqlScript(string sqlScriptName, SqlScriptResource sqlScript, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }
            if (sqlScript == null)
            {
                throw new ArgumentNullException(nameof(sqlScript));
            }

            using var message = CreateCreateOrUpdateSqlScriptRequest(sqlScriptName, sqlScript, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSqlScriptRequest(string sqlScriptName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/sqlScripts/", false);
            uri.AppendPath(sqlScriptName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a sql script. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="ifNoneMatch"> ETag of the sql compute entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> is null. </exception>
        public async Task<Response<SqlScriptResource>> GetSqlScriptAsync(string sqlScriptName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }

            using var message = CreateGetSqlScriptRequest(sqlScriptName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlScriptResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlScriptResource.DeserializeSqlScriptResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue<SqlScriptResource>(null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a sql script. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="ifNoneMatch"> ETag of the sql compute entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> is null. </exception>
        public Response<SqlScriptResource> GetSqlScript(string sqlScriptName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }

            using var message = CreateGetSqlScriptRequest(sqlScriptName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlScriptResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlScriptResource.DeserializeSqlScriptResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue<SqlScriptResource>(null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteSqlScriptRequest(string sqlScriptName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/sqlScripts/", false);
            uri.AppendPath(sqlScriptName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a Sql Script. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> is null. </exception>
        public async Task<Response> DeleteSqlScriptAsync(string sqlScriptName, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }

            using var message = CreateDeleteSqlScriptRequest(sqlScriptName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a Sql Script. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> is null. </exception>
        public Response DeleteSqlScript(string sqlScriptName, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }

            using var message = CreateDeleteSqlScriptRequest(sqlScriptName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRenameSqlScriptRequest(string sqlScriptName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/sqlScripts/", false);
            uri.AppendPath(sqlScriptName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a sqlScript. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameSqlScriptAsync(string sqlScriptName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameSqlScriptRequest(sqlScriptName, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Renames a sqlScript. </summary>
        /// <param name="sqlScriptName"> The sql script name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlScriptName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameSqlScript(string sqlScriptName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(sqlScriptName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameSqlScriptRequest(sqlScriptName, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSqlScriptsByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists sql scripts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<SqlScriptsListResponse>> GetSqlScriptsByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetSqlScriptsByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlScriptsListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlScriptsListResponse.DeserializeSqlScriptsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists sql scripts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<SqlScriptsListResponse> GetSqlScriptsByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetSqlScriptsByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlScriptsListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlScriptsListResponse.DeserializeSqlScriptsListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
