// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Files.Shares.Models;

namespace Azure.Storage.Files.Shares
{
    internal partial class ServiceRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _version;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, share, directory or file that is the target of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. The default value is "2024-02-04". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _version = version ?? throw new ArgumentNullException(nameof(version));
        }

        internal RequestUriBuilder CreateSetPropertiesRequestUri(ShareServiceProperties storageServiceProperties, int? timeout)
        {
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateSetPropertiesRequest(ShareServiceProperties storageServiceProperties, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            request.Headers.Add("Content-Type", "application/xml");
            var content = new XmlWriterContent();
            content.XmlWriter.WriteObjectValue(storageServiceProperties, "StorageServiceProperties");
            request.Content = content;
            return message;
        }

        /// <summary> Sets properties for a storage account's File service endpoint, including properties for Storage Analytics metrics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="storageServiceProperties"> The StorageService properties. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageServiceProperties"/> is null. </exception>
        public async Task<ResponseWithHeaders<ServiceSetPropertiesHeaders>> SetPropertiesAsync(ShareServiceProperties storageServiceProperties, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (storageServiceProperties == null)
            {
                throw new ArgumentNullException(nameof(storageServiceProperties));
            }

            using var message = CreateSetPropertiesRequest(storageServiceProperties, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceSetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Sets properties for a storage account's File service endpoint, including properties for Storage Analytics metrics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="storageServiceProperties"> The StorageService properties. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageServiceProperties"/> is null. </exception>
        public ResponseWithHeaders<ServiceSetPropertiesHeaders> SetProperties(ShareServiceProperties storageServiceProperties, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (storageServiceProperties == null)
            {
                throw new ArgumentNullException(nameof(storageServiceProperties));
            }

            using var message = CreateSetPropertiesRequest(storageServiceProperties, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceSetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetPropertiesRequestUri(int? timeout)
        {
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateGetPropertiesRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> Gets the properties of a storage account's File service, including properties for Storage Analytics metrics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<ShareServiceProperties, ServiceGetPropertiesHeaders>> GetPropertiesAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ShareServiceProperties value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceProperties") is XElement storageServicePropertiesElement)
                        {
                            value = ShareServiceProperties.DeserializeShareServiceProperties(storageServicePropertiesElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the properties of a storage account's File service, including properties for Storage Analytics metrics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<ShareServiceProperties, ServiceGetPropertiesHeaders> GetProperties(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ShareServiceProperties value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceProperties") is XElement storageServicePropertiesElement)
                        {
                            value = ShareServiceProperties.DeserializeShareServiceProperties(storageServicePropertiesElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListSharesSegmentRequestUri(string prefix, string marker, int? maxresults, IEnumerable<ListSharesIncludeType> include, int? timeout)
        {
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("comp", "list", true);
            if (prefix != null)
            {
                uri.AppendQuery("prefix", prefix, true);
            }
            if (marker != null)
            {
                uri.AppendQuery("marker", marker, true);
            }
            if (maxresults != null)
            {
                uri.AppendQuery("maxresults", maxresults.Value, true);
            }
            if (include != null && Optional.IsCollectionDefined(include))
            {
                uri.AppendQueryDelimited("include", include, ",", true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListSharesSegmentRequest(string prefix, string marker, int? maxresults, IEnumerable<ListSharesIncludeType> include, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("comp", "list", true);
            if (prefix != null)
            {
                uri.AppendQuery("prefix", prefix, true);
            }
            if (marker != null)
            {
                uri.AppendQuery("marker", marker, true);
            }
            if (maxresults != null)
            {
                uri.AppendQuery("maxresults", maxresults.Value, true);
            }
            if (include != null && Optional.IsCollectionDefined(include))
            {
                uri.AppendQueryDelimited("include", include, ",", true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The List Shares Segment operation returns a list of the shares and share snapshots under the specified account. </summary>
        /// <param name="prefix"> Filters the results to return only entries whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items. </param>
        /// <param name="include"> Include this parameter to specify one or more datasets to include in the response. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<ListSharesResponse, ServiceListSharesSegmentHeaders>> ListSharesSegmentAsync(string prefix = null, string marker = null, int? maxresults = null, IEnumerable<ListSharesIncludeType> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListSharesSegmentRequest(prefix, marker, maxresults, include, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceListSharesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSharesResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListSharesResponse.DeserializeListSharesResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The List Shares Segment operation returns a list of the shares and share snapshots under the specified account. </summary>
        /// <param name="prefix"> Filters the results to return only entries whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items. </param>
        /// <param name="include"> Include this parameter to specify one or more datasets to include in the response. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<ListSharesResponse, ServiceListSharesSegmentHeaders> ListSharesSegment(string prefix = null, string marker = null, int? maxresults = null, IEnumerable<ListSharesIncludeType> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListSharesSegmentRequest(prefix, marker, maxresults, include, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceListSharesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSharesResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListSharesResponse.DeserializeListSharesResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListSharesSegmentNextPageRequestUri(string nextLink, string prefix, string marker, int? maxresults, IEnumerable<ListSharesIncludeType> include, int? timeout)
        {
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListSharesSegmentNextPageRequest(string nextLink, string prefix, string marker, int? maxresults, IEnumerable<ListSharesIncludeType> include, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The List Shares Segment operation returns a list of the shares and share snapshots under the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="prefix"> Filters the results to return only entries whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items. </param>
        /// <param name="include"> Include this parameter to specify one or more datasets to include in the response. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<ResponseWithHeaders<ListSharesResponse, ServiceListSharesSegmentHeaders>> ListSharesSegmentNextPageAsync(string nextLink, string prefix = null, string marker = null, int? maxresults = null, IEnumerable<ListSharesIncludeType> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListSharesSegmentNextPageRequest(nextLink, prefix, marker, maxresults, include, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceListSharesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSharesResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListSharesResponse.DeserializeListSharesResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The List Shares Segment operation returns a list of the shares and share snapshots under the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="prefix"> Filters the results to return only entries whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items. </param>
        /// <param name="include"> Include this parameter to specify one or more datasets to include in the response. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN"&gt;Setting Timeouts for File Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public ResponseWithHeaders<ListSharesResponse, ServiceListSharesSegmentHeaders> ListSharesSegmentNextPage(string nextLink, string prefix = null, string marker = null, int? maxresults = null, IEnumerable<ListSharesIncludeType> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListSharesSegmentNextPageRequest(nextLink, prefix, marker, maxresults, include, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceListSharesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSharesResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListSharesResponse.DeserializeListSharesResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
