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
using Azure.Management.EventHub.Models;

namespace Azure.Management.EventHub
{
    internal partial class ConfigurationRestClient
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ConfigurationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ConfigurationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePatchRequest(string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties parameters)
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
            uri.AppendPath("/providers/Microsoft.EventHub/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/quotaConfiguration/default", false);
            uri.AppendQuery("api-version", "2018-01-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Replace all specified Event Hubs Cluster settings with those contained in the request body. Leaves the settings not specified in the request body unmodified. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating an Event Hubs Cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ClusterQuotaConfigurationProperties>> PatchAsync(string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreatePatchRequest(resourceGroupName, clusterName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue<ClusterQuotaConfigurationProperties>(null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Replace all specified Event Hubs Cluster settings with those contained in the request body. Leaves the settings not specified in the request body unmodified. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating an Event Hubs Cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ClusterQuotaConfigurationProperties> Patch(string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreatePatchRequest(resourceGroupName, clusterName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue<ClusterQuotaConfigurationProperties>(null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string clusterName)
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
            uri.AppendPath("/providers/Microsoft.EventHub/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/quotaConfiguration/default", false);
            uri.AppendQuery("api-version", "2018-01-01-preview", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get all Event Hubs Cluster settings - a collection of key/value pairs which represent the quotas and settings imposed on the cluster. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ClusterQuotaConfigurationProperties>> GetAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var message = CreateGetRequest(resourceGroupName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get all Event Hubs Cluster settings - a collection of key/value pairs which represent the quotas and settings imposed on the cluster. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ClusterQuotaConfigurationProperties> Get(string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var message = CreateGetRequest(resourceGroupName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
