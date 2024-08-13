// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.ProgrammableConnectivity
{
    // Data plane generated sub-client.
    /// <summary> SIM Swap API provides the customer the ability to obtain information on any recent SIM pairing change related to the User's mobile account. </summary>
    public partial class SimSwap
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://management.azure.com//.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SimSwap for mocking. </summary>
        protected SimSwap()
        {
        }

        /// <summary> Initializes a new instance of SimSwap. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> An Azure Programmable Connectivity Endpoint providing access to Network APIs, for example https://{region}.apcgatewayapi.azure.com. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        internal SimSwap(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary> Provides timestamp of latest SIM swap. </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="body"> Body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Retrieve. </remarks>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='RetrieveAsync(string,SimSwapRetrievalContent,CancellationToken)']/*" />
        public virtual async Task<Response<SimSwapRetrievalResult>> RetrieveAsync(string apcGatewayId, SimSwapRetrievalContent body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await RetrieveAsync(apcGatewayId, content, context).ConfigureAwait(false);
            return Response.FromValue(SimSwapRetrievalResult.FromResponse(response), response);
        }

        /// <summary> Provides timestamp of latest SIM swap. </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="body"> Body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Retrieve. </remarks>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='Retrieve(string,SimSwapRetrievalContent,CancellationToken)']/*" />
        public virtual Response<SimSwapRetrievalResult> Retrieve(string apcGatewayId, SimSwapRetrievalContent body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Retrieve(apcGatewayId, content, context);
            return Response.FromValue(SimSwapRetrievalResult.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Provides timestamp of latest SIM swap
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="RetrieveAsync(string,SimSwapRetrievalContent,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='RetrieveAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> RetrieveAsync(string apcGatewayId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("SimSwap.Retrieve");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRetrieveRequest(apcGatewayId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Provides timestamp of latest SIM swap
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Retrieve(string,SimSwapRetrievalContent,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='Retrieve(string,RequestContent,RequestContext)']/*" />
        public virtual Response Retrieve(string apcGatewayId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("SimSwap.Retrieve");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRetrieveRequest(apcGatewayId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Verifies if a SIM swap has been performed during a past period (defined in the request with 'maxAgeHours' attribute). Returns 'True' if a SIM swap has occured. </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="body"> Body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Verify. </remarks>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='VerifyAsync(string,SimSwapVerificationContent,CancellationToken)']/*" />
        public virtual async Task<Response<SimSwapVerificationResult>> VerifyAsync(string apcGatewayId, SimSwapVerificationContent body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await VerifyAsync(apcGatewayId, content, context).ConfigureAwait(false);
            return Response.FromValue(SimSwapVerificationResult.FromResponse(response), response);
        }

        /// <summary> Verifies if a SIM swap has been performed during a past period (defined in the request with 'maxAgeHours' attribute). Returns 'True' if a SIM swap has occured. </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="body"> Body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Verify. </remarks>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='Verify(string,SimSwapVerificationContent,CancellationToken)']/*" />
        public virtual Response<SimSwapVerificationResult> Verify(string apcGatewayId, SimSwapVerificationContent body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Verify(apcGatewayId, content, context);
            return Response.FromValue(SimSwapVerificationResult.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Verifies if a SIM swap has been performed during a past period (defined in the request with 'maxAgeHours' attribute). Returns 'True' if a SIM swap has occured.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="VerifyAsync(string,SimSwapVerificationContent,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='VerifyAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> VerifyAsync(string apcGatewayId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("SimSwap.Verify");
            scope.Start();
            try
            {
                using HttpMessage message = CreateVerifyRequest(apcGatewayId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Verifies if a SIM swap has been performed during a past period (defined in the request with 'maxAgeHours' attribute). Returns 'True' if a SIM swap has occured.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Verify(string,SimSwapVerificationContent,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apcGatewayId"> The identifier of the APC Gateway resource which should handle this request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SimSwap.xml" path="doc/members/member[@name='Verify(string,RequestContent,RequestContext)']/*" />
        public virtual Response Verify(string apcGatewayId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("SimSwap.Verify");
            scope.Start();
            try
            {
                using HttpMessage message = CreateVerifyRequest(apcGatewayId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateRetrieveRequest(string apcGatewayId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sim-swap/sim-swap:retrieve", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("apc-gateway-id", apcGatewayId);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateVerifyRequest(string apcGatewayId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sim-swap/sim-swap:verify", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("apc-gateway-id", apcGatewayId);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
