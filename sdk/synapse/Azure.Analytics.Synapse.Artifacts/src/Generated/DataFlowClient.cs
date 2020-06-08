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
    /// <summary> The DataFlow service client. </summary>
    public partial class DataFlowClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DataFlowRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DataFlowClient for mocking. </summary>
        protected DataFlowClient()
        {
        }
        /// <summary> Initializes a new instance of DataFlowClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DataFlowClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new DataFlowRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates or updates a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="dataFlow"> Data flow resource definition. </param>
        /// <param name="ifMatch"> ETag of the data flow entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFlowResource>> CreateOrUpdateDataFlowAsync(string dataFlowName, DataFlowResource dataFlow, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.CreateOrUpdateDataFlow");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateDataFlowAsync(dataFlowName, dataFlow, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="dataFlow"> Data flow resource definition. </param>
        /// <param name="ifMatch"> ETag of the data flow entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFlowResource> CreateOrUpdateDataFlow(string dataFlowName, DataFlowResource dataFlow, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.CreateOrUpdateDataFlow");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdateDataFlow(dataFlowName, dataFlow, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="ifNoneMatch"> ETag of the data flow entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFlowResource>> GetDataFlowAsync(string dataFlowName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlow");
            scope.Start();
            try
            {
                return await RestClient.GetDataFlowAsync(dataFlowName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="ifNoneMatch"> ETag of the data flow entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFlowResource> GetDataFlow(string dataFlowName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlow");
            scope.Start();
            try
            {
                return RestClient.GetDataFlow(dataFlowName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteDataFlowAsync(string dataFlowName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.DeleteDataFlow");
            scope.Start();
            try
            {
                return await RestClient.DeleteDataFlowAsync(dataFlowName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteDataFlow(string dataFlowName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.DeleteDataFlow");
            scope.Start();
            try
            {
                return RestClient.DeleteDataFlow(dataFlowName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DataFlowResource> GetDataFlowsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataFlowResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetDataFlowsByWorkspaceAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataFlowResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetDataFlowsByWorkspaceNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DataFlowResource> GetDataFlowsByWorkspace(CancellationToken cancellationToken = default)
        {
            Page<DataFlowResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetDataFlowsByWorkspace(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataFlowResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetDataFlowsByWorkspaceNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
