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
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    internal partial class SolutionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SolutionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SolutionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string scope, string solutionResourceName, SolutionResourceData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/solutions/", false);
            uri.AppendPath(solutionResourceName, true);
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

        /// <summary> Creates a solution for the specific Azure resource or subscription using the triggering criteria ‘solutionId and requiredInputs’ from discovery solutions.&lt;br/&gt; Solutions are a rich, insightful and a centralized self help experience that brings all the relevant content to troubleshoot an Azure issue into a unified experience. Solutions include the following components : Text, Diagnostics , Troubleshooters, Images , Video tutorials, Tables , custom charts, images , AzureKB, etc, with capabilities to support new solutions types in the future. Each solution type may require one or more ‘requiredParameters’ that are required to execute the individual solution component. In the absence of the ‘requiredParameters’ it is likely that some of the solutions might fail execution, and you might see an empty response. &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note:&lt;/b&gt;  &lt;br/&gt;1. ‘requiredInputs’ from Discovery solutions response must be passed via ‘parameters’ in the request body of Solutions API. &lt;br/&gt;2. ‘requiredParameters’ from the Solutions response is the same as ‘ additionalParameters’ in the request for diagnostics &lt;br/&gt;3. ‘requiredParameters’ from the Solutions response is the same as ‘properties.parameters’ in the request for Troubleshooters. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="data"> The required request body for this solution resource creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="solutionResourceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string scope, string solutionResourceName, SolutionResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(solutionResourceName, nameof(solutionResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(scope, solutionResourceName, data);
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

        /// <summary> Creates a solution for the specific Azure resource or subscription using the triggering criteria ‘solutionId and requiredInputs’ from discovery solutions.&lt;br/&gt; Solutions are a rich, insightful and a centralized self help experience that brings all the relevant content to troubleshoot an Azure issue into a unified experience. Solutions include the following components : Text, Diagnostics , Troubleshooters, Images , Video tutorials, Tables , custom charts, images , AzureKB, etc, with capabilities to support new solutions types in the future. Each solution type may require one or more ‘requiredParameters’ that are required to execute the individual solution component. In the absence of the ‘requiredParameters’ it is likely that some of the solutions might fail execution, and you might see an empty response. &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note:&lt;/b&gt;  &lt;br/&gt;1. ‘requiredInputs’ from Discovery solutions response must be passed via ‘parameters’ in the request body of Solutions API. &lt;br/&gt;2. ‘requiredParameters’ from the Solutions response is the same as ‘ additionalParameters’ in the request for diagnostics &lt;br/&gt;3. ‘requiredParameters’ from the Solutions response is the same as ‘properties.parameters’ in the request for Troubleshooters. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="data"> The required request body for this solution resource creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="solutionResourceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string scope, string solutionResourceName, SolutionResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(solutionResourceName, nameof(solutionResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(scope, solutionResourceName, data);
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

        internal HttpMessage CreateGetRequest(string scope, string solutionResourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/solutions/", false);
            uri.AppendPath(solutionResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the solution using the applicable solutionResourceName while creating the solution. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="solutionResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SolutionResourceData>> GetAsync(string scope, string solutionResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(solutionResourceName, nameof(solutionResourceName));

            using var message = CreateGetRequest(scope, solutionResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SolutionResourceData.DeserializeSolutionResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SolutionResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the solution using the applicable solutionResourceName while creating the solution. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="solutionResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SolutionResourceData> Get(string scope, string solutionResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(solutionResourceName, nameof(solutionResourceName));

            using var message = CreateGetRequest(scope, solutionResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SolutionResourceData.DeserializeSolutionResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SolutionResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string scope, string solutionResourceName, SolutionResourcePatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/solutions/", false);
            uri.AppendPath(solutionResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update the requiredInputs or additional information needed to execute the solution. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="patch"> The required request body for updating a solution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="solutionResourceName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string scope, string solutionResourceName, SolutionResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(solutionResourceName, nameof(solutionResourceName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(scope, solutionResourceName, patch);
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

        /// <summary> Update the requiredInputs or additional information needed to execute the solution. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="patch"> The required request body for updating a solution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="solutionResourceName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string scope, string solutionResourceName, SolutionResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(solutionResourceName, nameof(solutionResourceName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(scope, solutionResourceName, patch);
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
