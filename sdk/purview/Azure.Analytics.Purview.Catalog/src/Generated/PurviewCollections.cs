// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    // Data plane generated sub-client.
    /// <summary> The PurviewCollections sub-client. </summary>
    public partial class PurviewCollections
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewCollections for mocking. </summary>
        protected PurviewCollections()
        {
        }

        /// <summary> Initializes a new instance of PurviewCollections. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PurviewCollections(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Creates or updates an entity to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/PurviewCollections.xml" path="doc/members/member[@name='CreateOrUpdateEntityAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateEntityAsync(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntity");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityRequest(collection, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates an entity to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/PurviewCollections.xml" path="doc/members/member[@name='CreateOrUpdateEntity(string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdateEntity(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntity");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityRequest(collection, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates entities in bulk to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/PurviewCollections.xml" path="doc/members/member[@name='CreateOrUpdateEntityInBulkAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateEntityInBulkAsync(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntityInBulk");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityInBulkRequest(collection, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates entities in bulk to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/PurviewCollections.xml" path="doc/members/member[@name='CreateOrUpdateEntityInBulk(string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdateEntityInBulk(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntityInBulk");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityInBulkRequest(collection, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Move existing entities to the target collection.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/PurviewCollections.xml" path="doc/members/member[@name='MoveEntitiesToCollectionAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> MoveEntitiesToCollectionAsync(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.MoveEntitiesToCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMoveEntitiesToCollectionRequest(collection, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Move existing entities to the target collection.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/PurviewCollections.xml" path="doc/members/member[@name='MoveEntitiesToCollection(string,RequestContent,RequestContext)']/*" />
        public virtual Response MoveEntitiesToCollection(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.MoveEntitiesToCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMoveEntitiesToCollectionRequest(collection, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateOrUpdateEntityRequest(string collection, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collection, true);
            uri.AppendPath("/entity", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateEntityInBulkRequest(string collection, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collection, true);
            uri.AppendPath("/entity/bulk", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateMoveEntitiesToCollectionRequest(string collection, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collection, true);
            uri.AppendPath("/entity/moveHere", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
