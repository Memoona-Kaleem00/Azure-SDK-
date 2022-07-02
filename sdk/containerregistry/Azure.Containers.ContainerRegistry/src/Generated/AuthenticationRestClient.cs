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

namespace Azure.Containers.ContainerRegistry
{
    internal partial class AuthenticationRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AuthenticationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="url"/> is null. </exception>
        public AuthenticationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string apiVersion = "2021-07-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _apiVersion = apiVersion;
        }

        internal HttpMessage CreateExchangeAadAccessTokenForAcrRefreshTokenRequest(PostContentSchemaGrantType grantType, string service, string tenant, string refreshToken, string accessToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/oauth2/exchange", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var content = new FormUrlEncodedContent();
            content.Add("grant_type", grantType.ToString());
            content.Add("service", service);
            if (tenant != null)
            {
                content.Add("tenant", tenant);
            }
            if (refreshToken != null)
            {
                content.Add("refresh_token", refreshToken);
            }
            if (accessToken != null)
            {
                content.Add("access_token", accessToken);
            }
            request.Content = content;
            return message;
        }

        /// <summary> Exchange AAD tokens for an ACR refresh Token. </summary>
        /// <param name="grantType"> Can take a value of access_token_refresh_token, or access_token, or refresh_token. </param>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="tenant"> AAD tenant associated to the AAD credentials. </param>
        /// <param name="refreshToken"> AAD refresh token, mandatory when grant_type is access_token_refresh_token or refresh_token. </param>
        /// <param name="accessToken"> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/> is null. </exception>
        public async Task<Response<AcrRefreshToken>> ExchangeAadAccessTokenForAcrRefreshTokenAsync(PostContentSchemaGrantType grantType, string service, string tenant = null, string refreshToken = null, string accessToken = null, CancellationToken cancellationToken = default)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            using var message = CreateExchangeAadAccessTokenForAcrRefreshTokenRequest(grantType, service, tenant, refreshToken, accessToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcrRefreshToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AcrRefreshToken.DeserializeAcrRefreshToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Exchange AAD tokens for an ACR refresh Token. </summary>
        /// <param name="grantType"> Can take a value of access_token_refresh_token, or access_token, or refresh_token. </param>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="tenant"> AAD tenant associated to the AAD credentials. </param>
        /// <param name="refreshToken"> AAD refresh token, mandatory when grant_type is access_token_refresh_token or refresh_token. </param>
        /// <param name="accessToken"> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/> is null. </exception>
        public Response<AcrRefreshToken> ExchangeAadAccessTokenForAcrRefreshToken(PostContentSchemaGrantType grantType, string service, string tenant = null, string refreshToken = null, string accessToken = null, CancellationToken cancellationToken = default)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            using var message = CreateExchangeAadAccessTokenForAcrRefreshTokenRequest(grantType, service, tenant, refreshToken, accessToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcrRefreshToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AcrRefreshToken.DeserializeAcrRefreshToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExchangeAcrRefreshTokenForAcrAccessTokenRequest(string service, string scope, string refreshToken, TokenGrantType grantType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/oauth2/token", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var content = new FormUrlEncodedContent();
            content.Add("service", service);
            content.Add("scope", scope);
            content.Add("refresh_token", refreshToken);
            content.Add("grant_type", grantType.ToSerialString());
            request.Content = content;
            return message;
        }

        /// <summary> Exchange ACR Refresh token for an ACR Access Token. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="scope"> Which is expected to be a valid scope, and can be specified more than once for multiple scope requests. You obtained this from the Www-Authenticate response header from the challenge. </param>
        /// <param name="refreshToken"> Must be a valid ACR refresh token. </param>
        /// <param name="grantType"> Grant type is expected to be refresh_token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/>, <paramref name="scope"/> or <paramref name="refreshToken"/> is null. </exception>
        public async Task<Response<AcrAccessToken>> ExchangeAcrRefreshTokenForAcrAccessTokenAsync(string service, string scope, string refreshToken, TokenGrantType grantType = TokenGrantType.RefreshToken, CancellationToken cancellationToken = default)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (refreshToken == null)
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            using var message = CreateExchangeAcrRefreshTokenForAcrAccessTokenRequest(service, scope, refreshToken, grantType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcrAccessToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AcrAccessToken.DeserializeAcrAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Exchange ACR Refresh token for an ACR Access Token. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="scope"> Which is expected to be a valid scope, and can be specified more than once for multiple scope requests. You obtained this from the Www-Authenticate response header from the challenge. </param>
        /// <param name="refreshToken"> Must be a valid ACR refresh token. </param>
        /// <param name="grantType"> Grant type is expected to be refresh_token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/>, <paramref name="scope"/> or <paramref name="refreshToken"/> is null. </exception>
        public Response<AcrAccessToken> ExchangeAcrRefreshTokenForAcrAccessToken(string service, string scope, string refreshToken, TokenGrantType grantType = TokenGrantType.RefreshToken, CancellationToken cancellationToken = default)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (refreshToken == null)
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            using var message = CreateExchangeAcrRefreshTokenForAcrAccessTokenRequest(service, scope, refreshToken, grantType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcrAccessToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AcrAccessToken.DeserializeAcrAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
