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
    internal partial class KustoPoolDatabasePrincipalAssignmentsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of KustoPoolDatabasePrincipalAssignmentsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public KustoPoolDatabasePrincipalAssignmentsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCheckNameAvailabilityRequest(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, KustoPoolDatabasePrincipalAssignmentNameAvailabilityContent content)
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
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/kustoPools/", false);
            uri.AppendPath(kustoPoolName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/checkPrincipalAssignmentNameAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Checks that the database principal assignment is valid and is not already in use. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="content"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<KustoPoolNameAvailabilityResult>> CheckNameAvailabilityAsync(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, KustoPoolDatabasePrincipalAssignmentNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckNameAvailabilityRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KustoPoolNameAvailabilityResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = KustoPoolNameAvailabilityResult.DeserializeKustoPoolNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Checks that the database principal assignment is valid and is not already in use. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="content"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<KustoPoolNameAvailabilityResult> CheckNameAvailability(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, KustoPoolDatabasePrincipalAssignmentNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckNameAvailabilityRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KustoPoolNameAvailabilityResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = KustoPoolNameAvailabilityResult.DeserializeKustoPoolNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName)
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
            uri.AppendPath("/kustoPools/", false);
            uri.AppendPath(kustoPoolName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/principalAssignments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all Kusto pool database principalAssignments. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseDatabasePrincipalAssignmentListResult>> ListAsync(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseDatabasePrincipalAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SynapseDatabasePrincipalAssignmentListResult.DeserializeSynapseDatabasePrincipalAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Kusto pool database principalAssignments. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseDatabasePrincipalAssignmentListResult> List(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseDatabasePrincipalAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SynapseDatabasePrincipalAssignmentListResult.DeserializeSynapseDatabasePrincipalAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName)
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
            uri.AppendPath("/kustoPools/", false);
            uri.AppendPath(kustoPoolName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/principalAssignments/", false);
            uri.AppendPath(principalAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a Kusto pool database principalAssignment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseDatabasePrincipalAssignmentData>> GetAsync(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseDatabasePrincipalAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SynapseDatabasePrincipalAssignmentData.DeserializeSynapseDatabasePrincipalAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SynapseDatabasePrincipalAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a Kusto pool database principalAssignment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseDatabasePrincipalAssignmentData> Get(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseDatabasePrincipalAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SynapseDatabasePrincipalAssignmentData.DeserializeSynapseDatabasePrincipalAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SynapseDatabasePrincipalAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, SynapseDatabasePrincipalAssignmentData data)
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
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/kustoPools/", false);
            uri.AppendPath(kustoPoolName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/principalAssignments/", false);
            uri.AppendPath(principalAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a Kusto pool database principalAssignment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto principalAssignments parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/>, <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, SynapseDatabasePrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName, data);
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

        /// <summary> Creates a Kusto pool database principalAssignment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto principalAssignments parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/>, <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, SynapseDatabasePrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName, data);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/kustoPools/", false);
            uri.AppendPath(kustoPoolName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/principalAssignments/", false);
            uri.AppendPath(principalAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a Kusto pool principalAssignment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
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

        /// <summary> Deletes a Kusto pool principalAssignment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="kustoPoolName"> The name of the Kusto pool. </param>
        /// <param name="databaseName"> The name of the database in the Kusto pool. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="kustoPoolName"/>, <paramref name="databaseName"/> or <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(kustoPoolName, nameof(kustoPoolName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
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
    }
}
