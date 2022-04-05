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
using Microsoft.Azure.Management.HealthcareApis.Models;

namespace Microsoft.Azure.Management.HealthcareApis
{
    internal partial class FhirServicesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of FhirServicesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public FhirServicesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-11-01")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListByWorkspaceRequest(string resourceGroupName, string workspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HealthcareApis/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/fhirservices", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all FHIR Services for the given workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<FhirServiceCollection>> ListByWorkspaceAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListByWorkspaceRequest(resourceGroupName, workspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FhirServiceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FhirServiceCollection.DeserializeFhirServiceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all FHIR Services for the given workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public Response<FhirServiceCollection> ListByWorkspace(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListByWorkspaceRequest(resourceGroupName, workspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FhirServiceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FhirServiceCollection.DeserializeFhirServiceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string workspaceName, string fhirServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HealthcareApis/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/fhirservices/", false);
            uri.AppendPath(fhirServiceName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the properties of the specified FHIR Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="fhirServiceName"/> is null. </exception>
        public async Task<Response<FhirService>> GetAsync(string resourceGroupName, string workspaceName, string fhirServiceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }

            using var message = CreateGetRequest(resourceGroupName, workspaceName, fhirServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FhirService value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FhirService.DeserializeFhirService(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the properties of the specified FHIR Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="fhirServiceName"/> is null. </exception>
        public Response<FhirService> Get(string resourceGroupName, string workspaceName, string fhirServiceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }

            using var message = CreateGetRequest(resourceGroupName, workspaceName, fhirServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FhirService value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FhirService.DeserializeFhirService(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string workspaceName, string fhirServiceName, FhirService fhirservice)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HealthcareApis/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/fhirservices/", false);
            uri.AppendPath(fhirServiceName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(fhirservice);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a FHIR Service resource with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="fhirservice"> The parameters for creating or updating a Fhir Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="fhirServiceName"/>, or <paramref name="fhirservice"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string workspaceName, string fhirServiceName, FhirService fhirservice, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }
            if (fhirservice == null)
            {
                throw new ArgumentNullException(nameof(fhirservice));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, fhirServiceName, fhirservice);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a FHIR Service resource with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="fhirservice"> The parameters for creating or updating a Fhir Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="fhirServiceName"/>, or <paramref name="fhirservice"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string workspaceName, string fhirServiceName, FhirService fhirservice, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }
            if (fhirservice == null)
            {
                throw new ArgumentNullException(nameof(fhirservice));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, fhirServiceName, fhirservice);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string fhirServiceName, string workspaceName, FhirServicePatchResource fhirservicePatchResource)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HealthcareApis/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/fhirservices/", false);
            uri.AppendPath(fhirServiceName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(fhirservicePatchResource);
            request.Content = content;
            return message;
        }

        /// <summary> Patch FHIR Service details. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="fhirservicePatchResource"> The parameters for updating a Fhir Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fhirServiceName"/>, <paramref name="workspaceName"/>, or <paramref name="fhirservicePatchResource"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string fhirServiceName, string workspaceName, FhirServicePatchResource fhirservicePatchResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (fhirservicePatchResource == null)
            {
                throw new ArgumentNullException(nameof(fhirservicePatchResource));
            }

            using var message = CreateUpdateRequest(resourceGroupName, fhirServiceName, workspaceName, fhirservicePatchResource);
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

        /// <summary> Patch FHIR Service details. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="fhirservicePatchResource"> The parameters for updating a Fhir Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fhirServiceName"/>, <paramref name="workspaceName"/>, or <paramref name="fhirservicePatchResource"/> is null. </exception>
        public Response Update(string resourceGroupName, string fhirServiceName, string workspaceName, FhirServicePatchResource fhirservicePatchResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (fhirservicePatchResource == null)
            {
                throw new ArgumentNullException(nameof(fhirservicePatchResource));
            }

            using var message = CreateUpdateRequest(resourceGroupName, fhirServiceName, workspaceName, fhirservicePatchResource);
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

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string fhirServiceName, string workspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HealthcareApis/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/fhirservices/", false);
            uri.AppendPath(fhirServiceName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a FHIR Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fhirServiceName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string fhirServiceName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, fhirServiceName, workspaceName);
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

        /// <summary> Deletes a FHIR Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fhirServiceName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string fhirServiceName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (fhirServiceName == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, fhirServiceName, workspaceName);
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

        internal HttpMessage CreateListByWorkspaceNextPageRequest(string nextLink, string resourceGroupName, string workspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all FHIR Services for the given workspace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<FhirServiceCollection>> ListByWorkspaceNextPageAsync(string nextLink, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListByWorkspaceNextPageRequest(nextLink, resourceGroupName, workspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FhirServiceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FhirServiceCollection.DeserializeFhirServiceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all FHIR Services for the given workspace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response<FhirServiceCollection> ListByWorkspaceNextPage(string nextLink, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListByWorkspaceNextPageRequest(nextLink, resourceGroupName, workspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FhirServiceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FhirServiceCollection.DeserializeFhirServiceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
