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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    internal partial class SqlPoolTableColumnsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SqlPoolTableColumnsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SqlPoolTableColumnsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByTableNameRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendPath("/columns", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByTableNameRequest(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendPath("/columns", false);
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

        /// <summary> Gets columns in a given table in a SQL pool. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SqlPoolColumnListResult>> ListByTableNameAsync(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableNameRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlPoolColumnListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlPoolColumnListResult.DeserializeSqlPoolColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets columns in a given table in a SQL pool. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SqlPoolColumnListResult> ListByTableName(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableNameRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlPoolColumnListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlPoolColumnListResult.DeserializeSqlPoolColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByTableNameNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByTableNameNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter)
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

        /// <summary> Gets columns in a given table in a SQL pool. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SqlPoolColumnListResult>> ListByTableNameNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableNameNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlPoolColumnListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlPoolColumnListResult.DeserializeSqlPoolColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets columns in a given table in a SQL pool. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SqlPoolColumnListResult> ListByTableNameNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableNameNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlPoolColumnListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlPoolColumnListResult.DeserializeSqlPoolColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
