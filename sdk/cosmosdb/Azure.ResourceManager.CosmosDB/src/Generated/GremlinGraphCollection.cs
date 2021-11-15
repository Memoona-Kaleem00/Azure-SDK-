// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of GremlinGraph and their operations over its parent. </summary>
    public partial class GremlinGraphCollection : ArmCollection, IEnumerable<GremlinGraph>, IAsyncEnumerable<GremlinGraph>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GremlinResourcesRestOperations _gremlinResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GremlinGraphCollection"/> class for mocking. </summary>
        protected GremlinGraphCollection()
        {
        }

        /// <summary> Initializes a new instance of GremlinGraphCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GremlinGraphCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _gremlinResourcesRestClient = new GremlinResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => GremlinDatabase.ResourceType;

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB Gremlin graph. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="createUpdateGremlinGraphParameters"> The parameters to provide for the current Gremlin graph. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> or <paramref name="createUpdateGremlinGraphParameters"/> is null. </exception>
        public virtual GremlinResourceCreateUpdateGremlinGraphOperation CreateOrUpdate(string graphName, GremlinGraphCreateUpdateParameters createUpdateGremlinGraphParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }
            if (createUpdateGremlinGraphParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateGremlinGraphParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gremlinResourcesRestClient.CreateUpdateGremlinGraph(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, createUpdateGremlinGraphParameters, cancellationToken);
                var operation = new GremlinResourceCreateUpdateGremlinGraphOperation(Parent, _clientDiagnostics, Pipeline, _gremlinResourcesRestClient.CreateCreateUpdateGremlinGraphRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, createUpdateGremlinGraphParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an Azure Cosmos DB Gremlin graph. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="createUpdateGremlinGraphParameters"> The parameters to provide for the current Gremlin graph. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> or <paramref name="createUpdateGremlinGraphParameters"/> is null. </exception>
        public async virtual Task<GremlinResourceCreateUpdateGremlinGraphOperation> CreateOrUpdateAsync(string graphName, GremlinGraphCreateUpdateParameters createUpdateGremlinGraphParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }
            if (createUpdateGremlinGraphParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateGremlinGraphParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gremlinResourcesRestClient.CreateUpdateGremlinGraphAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, createUpdateGremlinGraphParameters, cancellationToken).ConfigureAwait(false);
                var operation = new GremlinResourceCreateUpdateGremlinGraphOperation(Parent, _clientDiagnostics, Pipeline, _gremlinResourcesRestClient.CreateCreateUpdateGremlinGraphRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, createUpdateGremlinGraphParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Gremlin graph under an existing Azure Cosmos DB database account. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual Response<GremlinGraph> Get(string graphName, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.Get");
            scope.Start();
            try
            {
                var response = _gremlinResourcesRestClient.GetGremlinGraph(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GremlinGraph(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Gremlin graph under an existing Azure Cosmos DB database account. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public async virtual Task<Response<GremlinGraph>> GetAsync(string graphName, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.Get");
            scope.Start();
            try
            {
                var response = await _gremlinResourcesRestClient.GetGremlinGraphAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GremlinGraph(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual Response<GremlinGraph> GetIfExists(string graphName, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _gremlinResourcesRestClient.GetGremlinGraph(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GremlinGraph>(null, response.GetRawResponse())
                    : Response.FromValue(new GremlinGraph(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public async virtual Task<Response<GremlinGraph>> GetIfExistsAsync(string graphName, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _gremlinResourcesRestClient.GetGremlinGraphAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, graphName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GremlinGraph>(null, response.GetRawResponse())
                    : Response.FromValue(new GremlinGraph(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string graphName, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(graphName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="graphName"> Cosmos DB graph name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string graphName, CancellationToken cancellationToken = default)
        {
            if (graphName == null)
            {
                throw new ArgumentNullException(nameof(graphName));
            }

            using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(graphName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the Gremlin graph under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GremlinGraph" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GremlinGraph> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GremlinGraph> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _gremlinResourcesRestClient.ListGremlinGraphs(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GremlinGraph(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the Gremlin graph under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GremlinGraph" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GremlinGraph> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GremlinGraph>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GremlinGraphCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _gremlinResourcesRestClient.ListGremlinGraphsAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GremlinGraph(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<GremlinGraph> IEnumerable<GremlinGraph>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GremlinGraph> IAsyncEnumerable<GremlinGraph>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, GremlinGraph, GremlinGraphData> Construct() { }
    }
}
