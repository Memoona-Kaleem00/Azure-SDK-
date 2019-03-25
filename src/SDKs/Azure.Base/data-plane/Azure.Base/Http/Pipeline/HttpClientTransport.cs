﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Base.Http.Pipeline
{
    public class HttpClientTransport : HttpPipelineTransport
    {
        static readonly HttpClient s_defaultClient = new HttpClient();

        readonly HttpClient _client;

        public HttpClientTransport(HttpClient client = null)
            => _client = client == null ? s_defaultClient : client;

        public readonly static HttpClientTransport Shared = new HttpClientTransport();

        public sealed override HttpPipelineRequest CreateRequest(IServiceProvider services)
            => new PipelineRequest();

        public sealed override async Task ProcessAsync(HttpPipelineMessage message)
        {
            var pipelineRequest = message.Request as PipelineRequest;
            if (pipelineRequest == null) throw new InvalidOperationException("the request is not compatible with the transport");

            using (HttpRequestMessage httpRequest = pipelineRequest.BuildRequestMessage(message.Cancellation))
            {
                HttpResponseMessage responseMessage = await ProcessCoreAsync(message.Cancellation, httpRequest).ConfigureAwait(false);
                message.Response = new PipelineResponse(responseMessage);
            }
        }

        protected virtual async Task<HttpResponseMessage> ProcessCoreAsync(CancellationToken cancellation, HttpRequestMessage httpRequest)
            => await _client.SendAsync(httpRequest, cancellation).ConfigureAwait(false);

        private static string JoinHeaderValues(IEnumerable<string> values)
        {
            return string.Join(",", values);
        }

        sealed class PipelineRequest : HttpPipelineRequest
        {
            string _contentTypeHeaderValue;
            string _contentLengthHeaderValue;
            readonly HttpRequestMessage _requestMessage;

            public PipelineRequest()
            {
                _requestMessage = new HttpRequestMessage();
            }

            public override Uri Uri
            {
                get => _requestMessage.RequestUri;
                set => _requestMessage.RequestUri = value;
            }

            public override HttpVerb Method
            {
                get => ToPipelineMethod(_requestMessage.Method);
                set => _requestMessage.Method = ToHttpClientMethod(value);
            }

            public override HttpPipelineRequestContent Content { get; set; }

            public override void AddHeader(HttpHeader header)
            {
                AddHeader(header.Name, header.Value);
            }

            public override void AddHeader(string name, string value)
            {
                // TODO (pri 1): any other headers must be added to content?
                if (name.Equals("Content-Type", StringComparison.InvariantCultureIgnoreCase)) {
                    _contentTypeHeaderValue = value;
                }
                else if (name.Equals("Content-Length", StringComparison.InvariantCultureIgnoreCase)) {
                    _contentLengthHeaderValue = value;
                }
                else {
                    if (!_requestMessage.Headers.TryAddWithoutValidation(name, value)) {
                        throw new InvalidOperationException();
                    }
                }
            }

            public override bool TryGetHeader(string name, out string value)
            {
                if (name.Equals("Content-Type", StringComparison.InvariantCultureIgnoreCase))
                {
                    value = _contentTypeHeaderValue;
                    return true;
                }

                if (name.Equals("Content-Length", StringComparison.InvariantCultureIgnoreCase))
                {
                    value = _contentLengthHeaderValue;
                    return true;
                }

                if (_requestMessage.Headers.TryGetValues(name, out var values))
                {
                    value = JoinHeaderValues(values);
                    return true;
                }

                value = null;
                return false;
            }

            public override IEnumerable<HttpHeader> GetHeaders()
            {
                foreach (var header in _requestMessage.Headers)
                {
                    yield return new HttpHeader(header.Key, JoinHeaderValues(header.Value));
                }

                if (_contentTypeHeaderValue != null) {
                    yield return new HttpHeader("Content-Type", _contentTypeHeaderValue);
                }

                if (_contentLengthHeaderValue != null)
                {
                    yield return new HttpHeader("Content-Length", _contentLengthHeaderValue);
                }
            }

            public HttpRequestMessage BuildRequestMessage(CancellationToken cancellation)
            {
                // A copy of a message needs to be made because HttpClient does not allow sending the same message twice,
                // and so the retry logic fails.
                var request = new HttpRequestMessage(_requestMessage.Method, _requestMessage.RequestUri);
                foreach (var header in _requestMessage.Headers) {
                    if (!request.Headers.TryAddWithoutValidation(header.Key, header.Value)) {
                        throw new Exception("could not add header " + header.ToString());
                    }
                }

                if (Content != null) {
                    request.Content = new PipelineContentAdapter(Content, cancellation);
                    if (_contentTypeHeaderValue != null) request.Content.Headers.Add("Content-Type", _contentTypeHeaderValue);
                    if (_contentLengthHeaderValue != null) request.Content.Headers.Add("Content-Length", _contentLengthHeaderValue);
                }

                return request;
            }

            public override void Dispose()
            {
                Content?.Dispose();
                _requestMessage.Dispose();
            }


            public override string ToString() =>  _requestMessage.ToString();

            readonly static HttpMethod s_patch = new HttpMethod("PATCH");
            public static HttpMethod ToHttpClientMethod(HttpVerb method)
            {
                switch (method) {
                    case HttpVerb.Get: return HttpMethod.Get;
                    case HttpVerb.Post: return HttpMethod.Post;
                    case HttpVerb.Put: return HttpMethod.Put;
                    case HttpVerb.Delete: return HttpMethod.Delete;
                    case HttpVerb.Patch: return s_patch;

                    default: throw new NotImplementedException();
                }
            }

            public static HttpVerb ToPipelineMethod(HttpMethod method)
            {
                switch (method.Method) {
                    case "GET": return HttpVerb.Get;
                    case "POST": return HttpVerb.Post;
                    case "PUT": return HttpVerb.Put;
                    case "DELETE": return HttpVerb.Delete;
                    case "PATCH": return HttpVerb.Patch;

                    // method argument is not a REST verb
                    default: throw new ArgumentOutOfRangeException(nameof(method));
                }
            }

            sealed class PipelineContentAdapter : HttpContent
            {
                HttpPipelineRequestContent _content;
                CancellationToken _cancellation;

                public PipelineContentAdapter(HttpPipelineRequestContent content, CancellationToken cancellation)
                {
                    Debug.Assert(content != null);

                    _content = content;
                    _cancellation = cancellation;
                }

                protected async override Task SerializeToStreamAsync(Stream stream, TransportContext context)
                    => await _content.WriteTo(stream, _cancellation).ConfigureAwait(false);

                protected override bool TryComputeLength(out long length)
                    => _content.TryComputeLength(out length);

                protected override void Dispose(bool disposing)
                {
                    _content.Dispose();
                    base.Dispose(disposing);
                }
            }
        }

        sealed class PipelineResponse : HttpPipelineResponse
        {
            readonly HttpResponseMessage _responseMessage;

            public PipelineResponse(HttpResponseMessage responseMessage)
            {
                _responseMessage = responseMessage;
            }

            #region Response

            public override int Status => (int)_responseMessage.StatusCode;

            public override bool TryGetHeader(string name, out string value)
            {
                if (!_responseMessage.Headers.TryGetValues(name, out var values)) {
                    if (!_responseMessage.Content.Headers.TryGetValues(name, out values)) {
                        value = default;
                        return false;
                    }
                }

                value = JoinHeaderValues(values);
                return true;
            }

            // TODO (pri 1): is it ok to just call GetResult here?
            public override Stream ResponseContentStream
                => _responseMessage?.Content?.ReadAsStreamAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            #endregion

            public override IEnumerable<HttpHeader> GetHeaders()
            {
                foreach (var header in _responseMessage.Headers)
                {
                    yield return new HttpHeader(header.Key, JoinHeaderValues(header.Value));
                }

                if (_responseMessage.Content != null)
                {
                    foreach (var header in _responseMessage.Content.Headers)
                    {
                        yield return new HttpHeader(header.Key, JoinHeaderValues(header.Value));
                    }
                }
            }

            public override void Dispose()
            {
                _responseMessage?.Dispose();
            }

            public override string ToString() => _responseMessage.ToString();
        }
    }
}
