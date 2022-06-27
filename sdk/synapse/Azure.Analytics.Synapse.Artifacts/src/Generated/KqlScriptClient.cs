// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The KqlScript service client. </summary>
    public partial class KqlScriptClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal KqlScriptRestClient RestClient { get; }

        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of KqlScriptClient for mocking. </summary>
        protected KqlScriptClient()
        {
        }

        /// <summary> Initializes a new instance of KqlScriptClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public KqlScriptClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
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
            RestClient = new KqlScriptRestClient(_clientDiagnostics, _pipeline, endpoint);
            Endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of KqlScriptClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal KqlScriptClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new KqlScriptRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            Endpoint = endpoint;
        }

        /// <summary> Get KQL script by name. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KqlScriptResource>> GetByNameAsync(string kqlScriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.GetByName");
            scope.Start();
            try
            {
                return await RestClient.GetByNameAsync(kqlScriptName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get KQL script by name. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KqlScriptResource> GetByName(string kqlScriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.GetByName");
            scope.Start();
            try
            {
                return RestClient.GetByName(kqlScriptName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a KQL Script. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="kqlScript"> KQL script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kqlScriptName"/> or <paramref name="kqlScript"/> is null. </exception>
        public virtual async Task<KqlScriptCreateOrUpdateOperation> StartCreateOrUpdateAsync(string kqlScriptName, KqlScriptResource kqlScript, CancellationToken cancellationToken = default)
        {
            if (kqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(kqlScriptName));
            }
            if (kqlScript == null)
            {
                throw new ArgumentNullException(nameof(kqlScript));
            }

            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(kqlScriptName, kqlScript, cancellationToken).ConfigureAwait(false);
                return new KqlScriptCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(kqlScriptName, kqlScript).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a KQL Script. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="kqlScript"> KQL script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kqlScriptName"/> or <paramref name="kqlScript"/> is null. </exception>
        public virtual KqlScriptCreateOrUpdateOperation StartCreateOrUpdate(string kqlScriptName, KqlScriptResource kqlScript, CancellationToken cancellationToken = default)
        {
            if (kqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(kqlScriptName));
            }
            if (kqlScript == null)
            {
                throw new ArgumentNullException(nameof(kqlScript));
            }

            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(kqlScriptName, kqlScript, cancellationToken);
                return new KqlScriptCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(kqlScriptName, kqlScript).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete KQL script by name. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kqlScriptName"/> is null. </exception>
        public virtual async Task<KqlScriptDeleteByNameOperation> StartDeleteByNameAsync(string kqlScriptName, CancellationToken cancellationToken = default)
        {
            if (kqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(kqlScriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.StartDeleteByName");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteByNameAsync(kqlScriptName, cancellationToken).ConfigureAwait(false);
                return new KqlScriptDeleteByNameOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteByNameRequest(kqlScriptName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete KQL script by name. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kqlScriptName"/> is null. </exception>
        public virtual KqlScriptDeleteByNameOperation StartDeleteByName(string kqlScriptName, CancellationToken cancellationToken = default)
        {
            if (kqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(kqlScriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.StartDeleteByName");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteByName(kqlScriptName, cancellationToken);
                return new KqlScriptDeleteByNameOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteByNameRequest(kqlScriptName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Rename KQL script. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="renameRequest"> Rename request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kqlScriptName"/> or <paramref name="renameRequest"/> is null. </exception>
        public virtual async Task<KqlScriptRenameOperation> StartRenameAsync(string kqlScriptName, ArtifactRenameRequest renameRequest, CancellationToken cancellationToken = default)
        {
            if (kqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(kqlScriptName));
            }
            if (renameRequest == null)
            {
                throw new ArgumentNullException(nameof(renameRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.StartRename");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenameAsync(kqlScriptName, renameRequest, cancellationToken).ConfigureAwait(false);
                return new KqlScriptRenameOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameRequest(kqlScriptName, renameRequest).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Rename KQL script. </summary>
        /// <param name="kqlScriptName"> KQL script name. </param>
        /// <param name="renameRequest"> Rename request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kqlScriptName"/> or <paramref name="renameRequest"/> is null. </exception>
        public virtual KqlScriptRenameOperation StartRename(string kqlScriptName, ArtifactRenameRequest renameRequest, CancellationToken cancellationToken = default)
        {
            if (kqlScriptName == null)
            {
                throw new ArgumentNullException(nameof(kqlScriptName));
            }
            if (renameRequest == null)
            {
                throw new ArgumentNullException(nameof(renameRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("KqlScriptClient.StartRename");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Rename(kqlScriptName, renameRequest, cancellationToken);
                return new KqlScriptRenameOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameRequest(kqlScriptName, renameRequest).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
