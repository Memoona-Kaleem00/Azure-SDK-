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
using Azure.ResourceManager.MobileNetwork.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    internal partial class SimPoliciesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SimPoliciesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SimPoliciesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/mobileNetworks/", false);
            uri.AppendPath(mobileNetworkName, true);
            uri.AppendPath("/simPolicies/", false);
            uri.AppendPath(simPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the specified SIM policy. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName);
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

        /// <summary> Deletes the specified SIM policy. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName);
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

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/mobileNetworks/", false);
            uri.AppendPath(mobileNetworkName, true);
            uri.AppendPath("/simPolicies/", false);
            uri.AppendPath(simPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about the specified SIM policy. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MobileNetworkSimPolicyData>> GetAsync(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MobileNetworkSimPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MobileNetworkSimPolicyData.DeserializeMobileNetworkSimPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MobileNetworkSimPolicyData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about the specified SIM policy. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MobileNetworkSimPolicyData> Get(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MobileNetworkSimPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MobileNetworkSimPolicyData.DeserializeMobileNetworkSimPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MobileNetworkSimPolicyData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, MobileNetworkSimPolicyData data)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/mobileNetworks/", false);
            uri.AppendPath(mobileNetworkName, true);
            uri.AppendPath("/simPolicies/", false);
            uri.AppendPath(simPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a SIM policy. Must be created in the same location as its parent mobile network. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/>, <paramref name="simPolicyName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, MobileNetworkSimPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName, data);
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

        /// <summary> Creates or updates a SIM policy. Must be created in the same location as its parent mobile network. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="data"> Parameters supplied to the create or update SIM policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/>, <paramref name="simPolicyName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, MobileNetworkSimPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName, data);
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

        internal HttpMessage CreateUpdateTagsRequest(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, MobileNetworkTagsPatch patch)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/mobileNetworks/", false);
            uri.AppendPath(mobileNetworkName, true);
            uri.AppendPath("/simPolicies/", false);
            uri.AppendPath(simPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates SIM policy tags. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="patch"> Parameters supplied to update SIM policy tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/>, <paramref name="simPolicyName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MobileNetworkSimPolicyData>> UpdateTagsAsync(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, MobileNetworkTagsPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateTagsRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MobileNetworkSimPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MobileNetworkSimPolicyData.DeserializeMobileNetworkSimPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates SIM policy tags. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="simPolicyName"> The name of the SIM policy. </param>
        /// <param name="patch"> Parameters supplied to update SIM policy tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/>, <paramref name="simPolicyName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="mobileNetworkName"/> or <paramref name="simPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MobileNetworkSimPolicyData> UpdateTags(string subscriptionId, string resourceGroupName, string mobileNetworkName, string simPolicyName, MobileNetworkTagsPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNullOrEmpty(simPolicyName, nameof(simPolicyName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateTagsRequest(subscriptionId, resourceGroupName, mobileNetworkName, simPolicyName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MobileNetworkSimPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MobileNetworkSimPolicyData.DeserializeMobileNetworkSimPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByMobileNetworkRequest(string subscriptionId, string resourceGroupName, string mobileNetworkName)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/mobileNetworks/", false);
            uri.AppendPath(mobileNetworkName, true);
            uri.AppendPath("/simPolicies", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all the SIM policies in a mobile network. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SimPolicyListResult>> ListByMobileNetworkAsync(string subscriptionId, string resourceGroupName, string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var message = CreateListByMobileNetworkRequest(subscriptionId, resourceGroupName, mobileNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimPolicyListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SimPolicyListResult.DeserializeSimPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all the SIM policies in a mobile network. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SimPolicyListResult> ListByMobileNetwork(string subscriptionId, string resourceGroupName, string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var message = CreateListByMobileNetworkRequest(subscriptionId, resourceGroupName, mobileNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimPolicyListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SimPolicyListResult.DeserializeSimPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByMobileNetworkNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string mobileNetworkName)
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

        /// <summary> Gets all the SIM policies in a mobile network. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SimPolicyListResult>> ListByMobileNetworkNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var message = CreateListByMobileNetworkNextPageRequest(nextLink, subscriptionId, resourceGroupName, mobileNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimPolicyListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SimPolicyListResult.DeserializeSimPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all the SIM policies in a mobile network. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SimPolicyListResult> ListByMobileNetworkNextPage(string nextLink, string subscriptionId, string resourceGroupName, string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var message = CreateListByMobileNetworkNextPageRequest(nextLink, subscriptionId, resourceGroupName, mobileNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimPolicyListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SimPolicyListResult.DeserializeSimPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
