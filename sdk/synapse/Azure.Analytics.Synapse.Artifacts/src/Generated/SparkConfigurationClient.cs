// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The SparkConfiguration service client. </summary>
    public partial class SparkConfigurationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SparkConfigurationRestClient RestClient { get; }

        /// <summary> Initializes a new instance of SparkConfigurationClient for mocking. </summary>
        protected SparkConfigurationClient()
        {
        }

        /// <summary> Initializes a new instance of SparkConfigurationClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public SparkConfigurationClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new SparkConfigurationRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of SparkConfigurationClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal SparkConfigurationClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new SparkConfigurationRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="ifNoneMatch"> ETag of the sparkConfiguration entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SparkConfigurationResource>> GetSparkConfigurationAsync(string sparkConfigurationName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.GetSparkConfiguration");
            scope.Start();
            try
            {
                return await RestClient.GetSparkConfigurationAsync(sparkConfigurationName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="ifNoneMatch"> ETag of the sparkConfiguration entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SparkConfigurationResource> GetSparkConfiguration(string sparkConfigurationName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.GetSparkConfiguration");
            scope.Start();
            try
            {
                return RestClient.GetSparkConfiguration(sparkConfigurationName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists sparkconfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SparkConfigurationResource> GetSparkConfigurationsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetSparkConfigurationsByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetSparkConfigurationsByWorkspaceNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SparkConfigurationResource.DeserializeSparkConfigurationResource, _clientDiagnostics, _pipeline, "SparkConfigurationClient.GetSparkConfigurationsByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Lists sparkconfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SparkConfigurationResource> GetSparkConfigurationsByWorkspace(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetSparkConfigurationsByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetSparkConfigurationsByWorkspaceNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SparkConfigurationResource.DeserializeSparkConfigurationResource, _clientDiagnostics, _pipeline, "SparkConfigurationClient.GetSparkConfigurationsByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Creates or updates a sparkconfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="sparkConfiguration"> SparkConfiguration resource definition. </param>
        /// <param name="ifMatch"> ETag of the sparkConfiguration entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="sparkConfiguration"/> is null. </exception>
        public virtual async Task<SparkConfigurationCreateOrUpdateSparkConfigurationOperation> StartCreateOrUpdateSparkConfigurationAsync(string sparkConfigurationName, SparkConfigurationResource sparkConfiguration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (sparkConfiguration == null)
            {
                throw new ArgumentNullException(nameof(sparkConfiguration));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.StartCreateOrUpdateSparkConfiguration");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateSparkConfigurationAsync(sparkConfigurationName, sparkConfiguration, ifMatch, cancellationToken).ConfigureAwait(false);
                return new SparkConfigurationCreateOrUpdateSparkConfigurationOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateSparkConfigurationRequest(sparkConfigurationName, sparkConfiguration, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a sparkconfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="sparkConfiguration"> SparkConfiguration resource definition. </param>
        /// <param name="ifMatch"> ETag of the sparkConfiguration entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="sparkConfiguration"/> is null. </exception>
        public virtual SparkConfigurationCreateOrUpdateSparkConfigurationOperation StartCreateOrUpdateSparkConfiguration(string sparkConfigurationName, SparkConfigurationResource sparkConfiguration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (sparkConfiguration == null)
            {
                throw new ArgumentNullException(nameof(sparkConfiguration));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.StartCreateOrUpdateSparkConfiguration");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateSparkConfiguration(sparkConfigurationName, sparkConfiguration, ifMatch, cancellationToken);
                return new SparkConfigurationCreateOrUpdateSparkConfigurationOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateSparkConfigurationRequest(sparkConfigurationName, sparkConfiguration, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual async Task<SparkConfigurationDeleteSparkConfigurationOperation> StartDeleteSparkConfigurationAsync(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.StartDeleteSparkConfiguration");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteSparkConfigurationAsync(sparkConfigurationName, cancellationToken).ConfigureAwait(false);
                return new SparkConfigurationDeleteSparkConfigurationOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteSparkConfigurationRequest(sparkConfigurationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual SparkConfigurationDeleteSparkConfigurationOperation StartDeleteSparkConfiguration(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.StartDeleteSparkConfiguration");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteSparkConfiguration(sparkConfigurationName, cancellationToken);
                return new SparkConfigurationDeleteSparkConfigurationOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteSparkConfigurationRequest(sparkConfigurationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="request"/> is null. </exception>
        public virtual async Task<SparkConfigurationRenameSparkConfigurationOperation> StartRenameSparkConfigurationAsync(string sparkConfigurationName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.StartRenameSparkConfiguration");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenameSparkConfigurationAsync(sparkConfigurationName, request, cancellationToken).ConfigureAwait(false);
                return new SparkConfigurationRenameSparkConfigurationOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameSparkConfigurationRequest(sparkConfigurationName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="request"/> is null. </exception>
        public virtual SparkConfigurationRenameSparkConfigurationOperation StartRenameSparkConfiguration(string sparkConfigurationName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkConfigurationClient.StartRenameSparkConfiguration");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RenameSparkConfiguration(sparkConfigurationName, request, cancellationToken);
                return new SparkConfigurationRenameSparkConfigurationOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameSparkConfigurationRequest(sparkConfigurationName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
