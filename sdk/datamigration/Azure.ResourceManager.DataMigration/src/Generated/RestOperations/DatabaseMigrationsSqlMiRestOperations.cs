// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration
{
    internal partial class DatabaseMigrationsSqlMiRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DatabaseMigrationsSqlMiRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatabaseMigrationsSqlMiRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-30-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, Guid? migrationOperationId, string expand)
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
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            if (migrationOperationId != null)
            {
                uri.AppendQuery("migrationOperationId", migrationOperationId.Value, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve the specified database migration for a given SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseMigrationSqlMIData>> GetAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, migrationOperationId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseMigrationSqlMIData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseMigrationSqlMIData.DeserializeDatabaseMigrationSqlMIData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseMigrationSqlMIData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve the specified database migration for a given SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseMigrationSqlMIData> Get(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, migrationOperationId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseMigrationSqlMIData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseMigrationSqlMIData.DeserializeDatabaseMigrationSqlMIData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseMigrationSqlMIData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, DatabaseMigrationSqlMIData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
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

        /// <summary> Create a new database migration to a given SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, DatabaseMigrationSqlMIData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a new database migration to a given SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, DatabaseMigrationSqlMIData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, MigrationOperationInput input)
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
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Stop in-progress database migration to SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> Required migration operation ID for which cancel will be initiated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CancelAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, input);
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

        /// <summary> Stop in-progress database migration to SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> Required migration operation ID for which cancel will be initiated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cancel(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, input);
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

        internal HttpMessage CreateCutoverRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, MigrationOperationInput input)
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
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendPath("/cutover", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Initiate cutover for in-progress online database migration to SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> Required migration operation ID for which cutover will be initiated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CutoverAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCutoverRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, input);
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

        /// <summary> Initiate cutover for in-progress online database migration to SQL Managed Instance. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> Required migration operation ID for which cutover will be initiated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cutover(string subscriptionId, string resourceGroupName, string managedInstanceName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCutoverRequest(subscriptionId, resourceGroupName, managedInstanceName, targetDBName, input);
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
    }
}
