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
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    internal partial class PostgreSQLManagementRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PostgreSQLManagementRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PostgreSQLManagementRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCheckMigrationNameAvailabilityRequest(string subscriptionId, string resourceGroupName, string targetDbServerName, PostgreSqlCheckMigrationNameAvailabilityContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DBforPostgreSQL/flexibleServers/", false);
            uri.AppendPath(targetDbServerName, true);
            uri.AppendPath("/checkMigrationNameAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Core.Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This method checks whether a proposed migration name is valid and available. </summary>
        /// <param name="subscriptionId"> The subscription ID of the target database server. </param>
        /// <param name="resourceGroupName"> The resource group name of the target database server. </param>
        /// <param name="targetDbServerName"> The name of the target database server. </param>
        /// <param name="content"> The required parameters for checking if a migration name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="targetDbServerName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="targetDbServerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PostgreSqlCheckMigrationNameAvailabilityContent>> CheckMigrationNameAvailabilityAsync(string subscriptionId, string resourceGroupName, string targetDbServerName, PostgreSqlCheckMigrationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(targetDbServerName, nameof(targetDbServerName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckMigrationNameAvailabilityRequest(subscriptionId, resourceGroupName, targetDbServerName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PostgreSqlCheckMigrationNameAvailabilityContent value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PostgreSqlCheckMigrationNameAvailabilityContent.DeserializePostgreSqlCheckMigrationNameAvailabilityContent(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method checks whether a proposed migration name is valid and available. </summary>
        /// <param name="subscriptionId"> The subscription ID of the target database server. </param>
        /// <param name="resourceGroupName"> The resource group name of the target database server. </param>
        /// <param name="targetDbServerName"> The name of the target database server. </param>
        /// <param name="content"> The required parameters for checking if a migration name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="targetDbServerName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="targetDbServerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PostgreSqlCheckMigrationNameAvailabilityContent> CheckMigrationNameAvailability(string subscriptionId, string resourceGroupName, string targetDbServerName, PostgreSqlCheckMigrationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(targetDbServerName, nameof(targetDbServerName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckMigrationNameAvailabilityRequest(subscriptionId, resourceGroupName, targetDbServerName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PostgreSqlCheckMigrationNameAvailabilityContent value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PostgreSqlCheckMigrationNameAvailabilityContent.DeserializePostgreSqlCheckMigrationNameAvailabilityContent(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
