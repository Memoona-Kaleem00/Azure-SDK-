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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal partial class PrivateEndpointConnectionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateEndpointConnectionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateEndpointConnectionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string workspaceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workspaceName)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Called by end-users to get all PE connections. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MachineLearningPrivateEndpointConnectionListResult>> ListAsync(string subscriptionId, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningPrivateEndpointConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MachineLearningPrivateEndpointConnectionListResult.DeserializeMachineLearningPrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Called by end-users to get all PE connections. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MachineLearningPrivateEndpointConnectionListResult> List(string subscriptionId, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningPrivateEndpointConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MachineLearningPrivateEndpointConnectionListResult.DeserializeMachineLearningPrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Called by end-users to delete a PE connection. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="privateEndpointConnectionName"> NRP Private Endpoint Connection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Called by end-users to delete a PE connection. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="privateEndpointConnectionName"> NRP Private Endpoint Connection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Called by end-users to get a PE connection. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="privateEndpointConnectionName"> NRP Private Endpoint Connection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MachineLearningPrivateEndpointConnectionData>> GetAsync(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningPrivateEndpointConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MachineLearningPrivateEndpointConnectionData.DeserializeMachineLearningPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MachineLearningPrivateEndpointConnectionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Called by end-users to get a PE connection. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="privateEndpointConnectionName"> NRP Private Endpoint Connection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MachineLearningPrivateEndpointConnectionData> Get(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningPrivateEndpointConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MachineLearningPrivateEndpointConnectionData.DeserializeMachineLearningPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MachineLearningPrivateEndpointConnectionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, MachineLearningPrivateEndpointConnectionData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, MachineLearningPrivateEndpointConnectionData data)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
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

        /// <summary>
        /// Called by end-users to approve or reject a PE connection.
        /// This method must validate and forward the call to NRP.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="privateEndpointConnectionName"> NRP Private Endpoint Connection Name. </param>
        /// <param name="data"> PrivateEndpointConnection object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MachineLearningPrivateEndpointConnectionData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, MachineLearningPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningPrivateEndpointConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MachineLearningPrivateEndpointConnectionData.DeserializeMachineLearningPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Called by end-users to approve or reject a PE connection.
        /// This method must validate and forward the call to NRP.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="privateEndpointConnectionName"> NRP Private Endpoint Connection Name. </param>
        /// <param name="data"> PrivateEndpointConnection object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MachineLearningPrivateEndpointConnectionData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName, MachineLearningPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningPrivateEndpointConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MachineLearningPrivateEndpointConnectionData.DeserializeMachineLearningPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
