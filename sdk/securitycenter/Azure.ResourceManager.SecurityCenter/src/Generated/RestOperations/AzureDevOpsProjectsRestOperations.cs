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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class AzureDevOpsProjectsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AzureDevOpsProjectsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AzureDevOpsProjectsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName)
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
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/azureDevOpsOrgs/", false);
            uri.AppendPath(orgName, true);
            uri.AppendPath("/projects", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a list of Azure DevOps projects onboarded to the connector. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureDevOpsProjectListResponse>> ListAsync(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of Azure DevOps projects onboarded to the connector. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureDevOpsProjectListResponse> List(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName)
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
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/azureDevOpsOrgs/", false);
            uri.AppendPath(orgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a monitored Azure DevOps project resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DevOpsProjectData>> GetAsync(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevOpsProjectData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DevOpsProjectData.DeserializeDevOpsProjectData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DevOpsProjectData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a monitored Azure DevOps project resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DevOpsProjectData> Get(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevOpsProjectData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DevOpsProjectData.DeserializeDevOpsProjectData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DevOpsProjectData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, DevOpsProjectData data)
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
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/azureDevOpsOrgs/", false);
            uri.AppendPath(orgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(projectName, true);
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

        /// <summary> Creates or updates a monitored Azure DevOps project resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="data"> The Azure DevOps project resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/>, <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, DevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName, data);
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

        /// <summary> Creates or updates a monitored Azure DevOps project resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="data"> The Azure DevOps project resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/>, <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, DevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName, data);
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

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, DevOpsProjectData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/azureDevOpsOrgs/", false);
            uri.AppendPath(orgName, true);
            uri.AppendPath("/projects/", false);
            uri.AppendPath(projectName, true);
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

        /// <summary> Updates a monitored Azure DevOps project resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="data"> The Azure DevOps project resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/>, <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, DevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName, data);
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

        /// <summary> Updates a monitored Azure DevOps project resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="data"> The Azure DevOps project resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/>, <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="orgName"/> or <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, string projectName, DevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName, data);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName)
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

        /// <summary> Returns a list of Azure DevOps projects onboarded to the connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureDevOpsProjectListResponse>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, securityConnectorName, orgName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of Azure DevOps projects onboarded to the connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="orgName"> The Azure DevOps organization name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="orgName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureDevOpsProjectListResponse> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string orgName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNullOrEmpty(orgName, nameof(orgName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, securityConnectorName, orgName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureDevOpsProjectListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureDevOpsProjectListResponse.DeserializeAzureDevOpsProjectListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
