// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Data.SchemaRegistry.Models;

namespace Azure.Data.SchemaRegistry
{
    internal partial class SchemaRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SchemaRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The Schema Registry service endpoint, for example my-namespace.servicebus.windows.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public SchemaRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-10")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetByIdRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/$schemaGroups/$schemas/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; serialization=Avro");
            return message;
        }

        /// <summary> Gets a registered schema by its unique ID.  Azure Schema Registry guarantees that ID is unique within a namespace. Operation response type is based on serialization of schema requested. </summary>
        /// <param name="id"> References specific schema in registry namespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<ResponseWithHeaders<Stream, SchemaGetByIdHeaders>> GetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetByIdRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new SchemaGetByIdHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a registered schema by its unique ID.  Azure Schema Registry guarantees that ID is unique within a namespace. Operation response type is based on serialization of schema requested. </summary>
        /// <param name="id"> References specific schema in registry namespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public ResponseWithHeaders<Stream, SchemaGetByIdHeaders> GetById(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetByIdRequest(id);
            _pipeline.Send(message, cancellationToken);
            var headers = new SchemaGetByIdHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetVersionsRequest(string groupName, string schemaName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/$schemaGroups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of all versions of one schema. </summary>
        /// <param name="groupName"> Schema group under which schema is registered.  Group&apos;s serialization type should match the serialization type specified in the request. </param>
        /// <param name="schemaName"> Name of schema being registered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> or <paramref name="schemaName"/> is null. </exception>
        public async Task<Response<SchemaVersions>> GetVersionsAsync(string groupName, string schemaName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var message = CreateGetVersionsRequest(groupName, schemaName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SchemaVersions value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SchemaVersions.DeserializeSchemaVersions(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of all versions of one schema. </summary>
        /// <param name="groupName"> Schema group under which schema is registered.  Group&apos;s serialization type should match the serialization type specified in the request. </param>
        /// <param name="schemaName"> Name of schema being registered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> or <paramref name="schemaName"/> is null. </exception>
        public Response<SchemaVersions> GetVersions(string groupName, string schemaName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var message = CreateGetVersionsRequest(groupName, schemaName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SchemaVersions value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SchemaVersions.DeserializeSchemaVersions(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateQueryIdByContentRequest(string groupName, string schemaName, string contentType, Stream schemaContent)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/$schemaGroups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath(":get-id", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", contentType);
            request.Content = RequestContent.Create(schemaContent);
            return message;
        }

        /// <summary> Gets the ID referencing an existing schema within the specified schema group, as matched by schema content comparison. </summary>
        /// <param name="groupName"> Schema group under which schema is registered.  Group&apos;s serialization type should match the serialization type specified in the request. </param>
        /// <param name="schemaName"> Name of requested schema. </param>
        /// <param name="contentType"> Content type of the schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the registered schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/>, <paramref name="schemaName"/>, <paramref name="contentType"/> or <paramref name="schemaContent"/> is null. </exception>
        public async Task<ResponseWithHeaders<SchemaQueryIdByContentHeaders>> QueryIdByContentAsync(string groupName, string schemaName, string contentType, Stream schemaContent, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            if (schemaContent == null)
            {
                throw new ArgumentNullException(nameof(schemaContent));
            }

            using var message = CreateQueryIdByContentRequest(groupName, schemaName, contentType, schemaContent);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new SchemaQueryIdByContentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the ID referencing an existing schema within the specified schema group, as matched by schema content comparison. </summary>
        /// <param name="groupName"> Schema group under which schema is registered.  Group&apos;s serialization type should match the serialization type specified in the request. </param>
        /// <param name="schemaName"> Name of requested schema. </param>
        /// <param name="contentType"> Content type of the schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the registered schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/>, <paramref name="schemaName"/>, <paramref name="contentType"/> or <paramref name="schemaContent"/> is null. </exception>
        public ResponseWithHeaders<SchemaQueryIdByContentHeaders> QueryIdByContent(string groupName, string schemaName, string contentType, Stream schemaContent, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            if (schemaContent == null)
            {
                throw new ArgumentNullException(nameof(schemaContent));
            }

            using var message = CreateQueryIdByContentRequest(groupName, schemaName, contentType, schemaContent);
            _pipeline.Send(message, cancellationToken);
            var headers = new SchemaQueryIdByContentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRegisterRequest(string groupName, string schemaName, string contentType, Stream schemaContent)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/$schemaGroups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", contentType);
            request.Content = RequestContent.Create(schemaContent);
            return message;
        }

        /// <summary>
        /// Register new schema. If schema of specified name does not exist in specified group, schema is created at version 1. If schema of specified name exists already in specified group, schema is created at latest version + 1.
        /// 
        /// </summary>
        /// <param name="groupName"> Schema group under which schema should be registered.  Group&apos;s serialization type should match the serialization type specified in the request. </param>
        /// <param name="schemaName"> Name of schema being registered. </param>
        /// <param name="contentType"> Content type of the schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the schema being registered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/>, <paramref name="schemaName"/>, <paramref name="contentType"/> or <paramref name="schemaContent"/> is null. </exception>
        public async Task<ResponseWithHeaders<SchemaRegisterHeaders>> RegisterAsync(string groupName, string schemaName, string contentType, Stream schemaContent, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            if (schemaContent == null)
            {
                throw new ArgumentNullException(nameof(schemaContent));
            }

            using var message = CreateRegisterRequest(groupName, schemaName, contentType, schemaContent);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new SchemaRegisterHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Register new schema. If schema of specified name does not exist in specified group, schema is created at version 1. If schema of specified name exists already in specified group, schema is created at latest version + 1.
        /// 
        /// </summary>
        /// <param name="groupName"> Schema group under which schema should be registered.  Group&apos;s serialization type should match the serialization type specified in the request. </param>
        /// <param name="schemaName"> Name of schema being registered. </param>
        /// <param name="contentType"> Content type of the schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the schema being registered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/>, <paramref name="schemaName"/>, <paramref name="contentType"/> or <paramref name="schemaContent"/> is null. </exception>
        public ResponseWithHeaders<SchemaRegisterHeaders> Register(string groupName, string schemaName, string contentType, Stream schemaContent, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            if (schemaContent == null)
            {
                throw new ArgumentNullException(nameof(schemaContent));
            }

            using var message = CreateRegisterRequest(groupName, schemaName, contentType, schemaContent);
            _pipeline.Send(message, cancellationToken);
            var headers = new SchemaRegisterHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
