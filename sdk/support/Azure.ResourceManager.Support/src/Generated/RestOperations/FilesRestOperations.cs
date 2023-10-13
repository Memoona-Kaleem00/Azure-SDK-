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
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    internal partial class FilesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FilesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FilesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string fileWorkspaceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Support/fileWorkspaces/", false);
            uri.AppendPath(fileWorkspaceName, true);
            uri.AppendPath("/files", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the Files information under a workspace for an Azure subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FilesListResult>> ListAsync(string subscriptionId, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateListRequest(subscriptionId, fileWorkspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FilesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FilesListResult.DeserializeFilesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the Files information under a workspace for an Azure subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FilesListResult> List(string subscriptionId, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateListRequest(subscriptionId, fileWorkspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FilesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FilesListResult.DeserializeFilesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string fileWorkspaceName, string fileName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Support/fileWorkspaces/", false);
            uri.AppendPath(fileWorkspaceName, true);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns details of a specific file in a work space. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FileDetailData>> GetAsync(string subscriptionId, string fileWorkspaceName, string fileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));
            Argument.AssertNotNullOrEmpty(fileName, nameof(fileName));

            using var message = CreateGetRequest(subscriptionId, fileWorkspaceName, fileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileDetailData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileDetailData.DeserializeFileDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FileDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns details of a specific file in a work space. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FileDetailData> Get(string subscriptionId, string fileWorkspaceName, string fileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));
            Argument.AssertNotNullOrEmpty(fileName, nameof(fileName));

            using var message = CreateGetRequest(subscriptionId, fileWorkspaceName, fileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileDetailData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileDetailData.DeserializeFileDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FileDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string fileWorkspaceName, string fileName, FileDetailData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Support/fileWorkspaces/", false);
            uri.AppendPath(fileWorkspaceName, true);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileName, true);
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

        /// <summary> Creates a new file under a workspace for the specified subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="fileName"> File name. </param>
        /// <param name="data"> Create file object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/>, <paramref name="fileName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FileDetailData>> CreateAsync(string subscriptionId, string fileWorkspaceName, string fileName, FileDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));
            Argument.AssertNotNullOrEmpty(fileName, nameof(fileName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, fileWorkspaceName, fileName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        FileDetailData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileDetailData.DeserializeFileDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new file under a workspace for the specified subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="fileName"> File name. </param>
        /// <param name="data"> Create file object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/>, <paramref name="fileName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FileDetailData> Create(string subscriptionId, string fileWorkspaceName, string fileName, FileDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));
            Argument.AssertNotNullOrEmpty(fileName, nameof(fileName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, fileWorkspaceName, fileName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        FileDetailData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileDetailData.DeserializeFileDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUploadRequest(string subscriptionId, string fileWorkspaceName, string fileName, UploadFile uploadFile)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Support/fileWorkspaces/", false);
            uri.AppendPath(fileWorkspaceName, true);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileName, true);
            uri.AppendPath("/upload", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(uploadFile);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This API allows you to upload content to a file. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File WorkspaceName. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="uploadFile"> UploadFile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/>, <paramref name="fileName"/> or <paramref name="uploadFile"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UploadAsync(string subscriptionId, string fileWorkspaceName, string fileName, UploadFile uploadFile, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));
            Argument.AssertNotNullOrEmpty(fileName, nameof(fileName));
            Argument.AssertNotNull(uploadFile, nameof(uploadFile));

            using var message = CreateUploadRequest(subscriptionId, fileWorkspaceName, fileName, uploadFile);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This API allows you to upload content to a file. </summary>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File WorkspaceName. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="uploadFile"> UploadFile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/>, <paramref name="fileName"/> or <paramref name="uploadFile"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="fileWorkspaceName"/> or <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Upload(string subscriptionId, string fileWorkspaceName, string fileName, UploadFile uploadFile, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));
            Argument.AssertNotNullOrEmpty(fileName, nameof(fileName));
            Argument.AssertNotNull(uploadFile, nameof(uploadFile));

            using var message = CreateUploadRequest(subscriptionId, fileWorkspaceName, fileName, uploadFile);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string fileWorkspaceName)
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

        /// <summary> Lists all the Files information under a workspace for an Azure subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FilesListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, fileWorkspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FilesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FilesListResult.DeserializeFilesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the Files information under a workspace for an Azure subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription Id. </param>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FilesListResult> ListNextPage(string nextLink, string subscriptionId, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, fileWorkspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FilesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FilesListResult.DeserializeFilesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
