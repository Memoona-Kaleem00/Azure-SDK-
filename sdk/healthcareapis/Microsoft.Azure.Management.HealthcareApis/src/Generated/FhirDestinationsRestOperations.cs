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
    internal partial class FhirDestinationsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of FhirDestinationsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public FhirDestinationsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-11-01")
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

        internal HttpMessage CreateListByIotConnectorRequest(string resourceGroupName, string workspaceName, string iotConnectorName)
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
            uri.AppendPath("/iotconnectors/", false);
            uri.AppendPath(iotConnectorName, true);
            uri.AppendPath("/fhirdestinations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all FHIR destinations for the given IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="iotConnectorName"/> is null. </exception>
        public async Task<Response<IotFhirDestinationCollection>> ListByIotConnectorAsync(string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }

            using var message = CreateListByIotConnectorRequest(resourceGroupName, workspaceName, iotConnectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotFhirDestinationCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IotFhirDestinationCollection.DeserializeIotFhirDestinationCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all FHIR destinations for the given IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="iotConnectorName"/> is null. </exception>
        public Response<IotFhirDestinationCollection> ListByIotConnector(string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }

            using var message = CreateListByIotConnectorRequest(resourceGroupName, workspaceName, iotConnectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotFhirDestinationCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IotFhirDestinationCollection.DeserializeIotFhirDestinationCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByIotConnectorNextPageRequest(string nextLink, string resourceGroupName, string workspaceName, string iotConnectorName)
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

        /// <summary> Lists all FHIR destinations for the given IoT Connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="iotConnectorName"/> is null. </exception>
        public async Task<Response<IotFhirDestinationCollection>> ListByIotConnectorNextPageAsync(string nextLink, string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default)
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
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }

            using var message = CreateListByIotConnectorNextPageRequest(nextLink, resourceGroupName, workspaceName, iotConnectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotFhirDestinationCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IotFhirDestinationCollection.DeserializeIotFhirDestinationCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all FHIR destinations for the given IoT Connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, or <paramref name="iotConnectorName"/> is null. </exception>
        public Response<IotFhirDestinationCollection> ListByIotConnectorNextPage(string nextLink, string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default)
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
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }

            using var message = CreateListByIotConnectorNextPageRequest(nextLink, resourceGroupName, workspaceName, iotConnectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotFhirDestinationCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IotFhirDestinationCollection.DeserializeIotFhirDestinationCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
