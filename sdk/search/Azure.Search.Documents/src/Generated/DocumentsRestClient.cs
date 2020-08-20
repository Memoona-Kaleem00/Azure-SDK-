// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    internal partial class DocumentsRestClient
    {
        private string endpoint;
        private string indexName;
        private Guid? xMsClientRequestId;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DocumentsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="indexName"> The name of the index. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="indexName"/>, or <paramref name="apiVersion"/> is null. </exception>
        public DocumentsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string indexName, Guid? xMsClientRequestId = null, string apiVersion = "2020-06-30")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.indexName = indexName;
            this.xMsClientRequestId = xMsClientRequestId;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCountRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/$count", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (xMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", xMsClientRequestId.Value);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=none");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Queries the number of documents in the index. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<long>> CountAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateCountRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        long value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetInt64();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Queries the number of documents in the index. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<long> Count(CancellationToken cancellationToken = default)
        {
            using var message = CreateCountRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        long value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetInt64();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSearchPostRequest(SearchOptions searchRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/search.post.search", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (xMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", xMsClientRequestId.Value);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=none");
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(searchRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Searches for documents in the index. </summary>
        /// <param name="searchRequest"> The definition of the Search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchRequest"/> is null. </exception>
        public async Task<Response<SearchDocumentsResult>> SearchPostAsync(SearchOptions searchRequest, CancellationToken cancellationToken = default)
        {
            if (searchRequest == null)
            {
                throw new ArgumentNullException(nameof(searchRequest));
            }

            using var message = CreateSearchPostRequest(searchRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchDocumentsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchDocumentsResult.DeserializeSearchDocumentsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Searches for documents in the index. </summary>
        /// <param name="searchRequest"> The definition of the Search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchRequest"/> is null. </exception>
        public Response<SearchDocumentsResult> SearchPost(SearchOptions searchRequest, CancellationToken cancellationToken = default)
        {
            if (searchRequest == null)
            {
                throw new ArgumentNullException(nameof(searchRequest));
            }

            using var message = CreateSearchPostRequest(searchRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchDocumentsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchDocumentsResult.DeserializeSearchDocumentsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string key, IEnumerable<string> selectedFields)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs('", false);
            uri.AppendPath(key, true);
            uri.AppendPath("')", false);
            if (selectedFields != null)
            {
                uri.AppendQueryDelimited("$select", selectedFields, ",", true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (xMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", xMsClientRequestId.Value);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=none");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves a document from the index. </summary>
        /// <param name="key"> The key of the document to retrieve. </param>
        /// <param name="selectedFields"> List of field names to retrieve for the document; Any field not retrieved will be missing from the returned document. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async Task<Response<IReadOnlyDictionary<string, object>>> GetAsync(string key, IEnumerable<string> selectedFields = null, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var message = CreateGetRequest(key, selectedFields);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, object> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        Dictionary<string, object> dictionary = new Dictionary<string, object>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, property.Value.GetObject());
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a document from the index. </summary>
        /// <param name="key"> The key of the document to retrieve. </param>
        /// <param name="selectedFields"> List of field names to retrieve for the document; Any field not retrieved will be missing from the returned document. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public Response<IReadOnlyDictionary<string, object>> Get(string key, IEnumerable<string> selectedFields = null, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var message = CreateGetRequest(key, selectedFields);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, object> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        Dictionary<string, object> dictionary = new Dictionary<string, object>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, property.Value.GetObject());
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSuggestPostRequest(SuggestOptions suggestRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/search.post.suggest", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (xMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", xMsClientRequestId.Value);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=none");
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(suggestRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Suggests documents in the index that match the given partial query text. </summary>
        /// <param name="suggestRequest"> The Suggest request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="suggestRequest"/> is null. </exception>
        public async Task<Response<SuggestDocumentsResult>> SuggestPostAsync(SuggestOptions suggestRequest, CancellationToken cancellationToken = default)
        {
            if (suggestRequest == null)
            {
                throw new ArgumentNullException(nameof(suggestRequest));
            }

            using var message = CreateSuggestPostRequest(suggestRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SuggestDocumentsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SuggestDocumentsResult.DeserializeSuggestDocumentsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Suggests documents in the index that match the given partial query text. </summary>
        /// <param name="suggestRequest"> The Suggest request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="suggestRequest"/> is null. </exception>
        public Response<SuggestDocumentsResult> SuggestPost(SuggestOptions suggestRequest, CancellationToken cancellationToken = default)
        {
            if (suggestRequest == null)
            {
                throw new ArgumentNullException(nameof(suggestRequest));
            }

            using var message = CreateSuggestPostRequest(suggestRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SuggestDocumentsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SuggestDocumentsResult.DeserializeSuggestDocumentsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateIndexRequest(IndexBatch batch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/search.index", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (xMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", xMsClientRequestId.Value);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=none");
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(batch);
            request.Content = content;
            return message;
        }

        /// <summary> Sends a batch of document write actions to the index. </summary>
        /// <param name="batch"> The batch of index actions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="batch"/> is null. </exception>
        public async Task<Response<IndexDocumentsResult>> IndexAsync(IndexBatch batch, CancellationToken cancellationToken = default)
        {
            if (batch == null)
            {
                throw new ArgumentNullException(nameof(batch));
            }

            using var message = CreateIndexRequest(batch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 207:
                    {
                        IndexDocumentsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IndexDocumentsResult.DeserializeIndexDocumentsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sends a batch of document write actions to the index. </summary>
        /// <param name="batch"> The batch of index actions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="batch"/> is null. </exception>
        public Response<IndexDocumentsResult> Index(IndexBatch batch, CancellationToken cancellationToken = default)
        {
            if (batch == null)
            {
                throw new ArgumentNullException(nameof(batch));
            }

            using var message = CreateIndexRequest(batch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 207:
                    {
                        IndexDocumentsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IndexDocumentsResult.DeserializeIndexDocumentsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAutocompletePostRequest(AutocompleteOptions autocompleteRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/search.post.autocomplete", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (xMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", xMsClientRequestId.Value);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=none");
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(autocompleteRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Autocompletes incomplete query terms based on input text and matching terms in the index. </summary>
        /// <param name="autocompleteRequest"> The definition of the Autocomplete request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autocompleteRequest"/> is null. </exception>
        public async Task<Response<AutocompleteResults>> AutocompletePostAsync(AutocompleteOptions autocompleteRequest, CancellationToken cancellationToken = default)
        {
            if (autocompleteRequest == null)
            {
                throw new ArgumentNullException(nameof(autocompleteRequest));
            }

            using var message = CreateAutocompletePostRequest(autocompleteRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutocompleteResults value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutocompleteResults.DeserializeAutocompleteResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Autocompletes incomplete query terms based on input text and matching terms in the index. </summary>
        /// <param name="autocompleteRequest"> The definition of the Autocomplete request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autocompleteRequest"/> is null. </exception>
        public Response<AutocompleteResults> AutocompletePost(AutocompleteOptions autocompleteRequest, CancellationToken cancellationToken = default)
        {
            if (autocompleteRequest == null)
            {
                throw new ArgumentNullException(nameof(autocompleteRequest));
            }

            using var message = CreateAutocompletePostRequest(autocompleteRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutocompleteResults value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutocompleteResults.DeserializeAutocompleteResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
