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
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Avs
{
    internal partial class VirtualMachinesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of VirtualMachinesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualMachinesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-12-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetAllRequest(string resourceGroupName, string privateCloudName, string clusterName)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List of virtual machines in a private cloud cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="clusterName"/> is null. </exception>
        public async Task<Response<VirtualMachinesList>> GetAllAsync(string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, privateCloudName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List of virtual machines in a private cloud cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="clusterName"/> is null. </exception>
        public Response<VirtualMachinesList> GetAll(string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, privateCloudName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(virtualMachineId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get a virtual machine by id in a private cloud cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/>, or <paramref name="virtualMachineId"/> is null. </exception>
        public async Task<Response<VirtualMachine>> GetAsync(string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var message = CreateGetRequest(resourceGroupName, privateCloudName, clusterName, virtualMachineId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachine value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachine.DeserializeVirtualMachine(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a virtual machine by id in a private cloud cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/>, or <paramref name="virtualMachineId"/> is null. </exception>
        public Response<VirtualMachine> Get(string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var message = CreateGetRequest(resourceGroupName, privateCloudName, clusterName, virtualMachineId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachine value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachine.DeserializeVirtualMachine(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRestrictMovementRequest(string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(virtualMachineId, true);
            uri.AppendPath("/restrictMovement", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(restrictMovement);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Enable or disable DRS-driven VM movement restriction. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="restrictMovement"> Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/>, <paramref name="virtualMachineId"/>, or <paramref name="restrictMovement"/> is null. </exception>
        public async Task<Response> RestrictMovementAsync(string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }
            if (restrictMovement == null)
            {
                throw new ArgumentNullException(nameof(restrictMovement));
            }

            using var message = CreateRestrictMovementRequest(resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Enable or disable DRS-driven VM movement restriction. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="restrictMovement"> Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/>, <paramref name="virtualMachineId"/>, or <paramref name="restrictMovement"/> is null. </exception>
        public Response RestrictMovement(string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }
            if (restrictMovement == null)
            {
                throw new ArgumentNullException(nameof(restrictMovement));
            }

            using var message = CreateRestrictMovementRequest(resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string resourceGroupName, string privateCloudName, string clusterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List of virtual machines in a private cloud cluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="clusterName"/> is null. </exception>
        public async Task<Response<VirtualMachinesList>> GetAllNextPageAsync(string nextLink, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, privateCloudName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List of virtual machines in a private cloud cluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, or <paramref name="clusterName"/> is null. </exception>
        public Response<VirtualMachinesList> GetAllNextPage(string nextLink, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateCloudName == null)
            {
                throw new ArgumentNullException(nameof(privateCloudName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, privateCloudName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
