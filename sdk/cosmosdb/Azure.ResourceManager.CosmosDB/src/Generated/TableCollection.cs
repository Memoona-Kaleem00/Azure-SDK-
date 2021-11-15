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
    /// <summary> A class representing collection of Table and their operations over its parent. </summary>
    public partial class TableCollection : ArmCollection, IEnumerable<Table>, IAsyncEnumerable<Table>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TableResourcesRestOperations _tableResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="TableCollection"/> class for mocking. </summary>
        protected TableCollection()
        {
        }

        /// <summary> Initializes a new instance of TableCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TableCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _tableResourcesRestClient = new TableResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => DatabaseAccount.ResourceType;

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB Table. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateTableParameters"> The parameters to provide for the current Table. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateTableParameters"/> is null. </exception>
        public virtual TableResourceCreateUpdateTableOperation CreateOrUpdate(string tableName, TableCreateUpdateParameters createUpdateTableParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
            if (createUpdateTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateTableParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tableResourcesRestClient.CreateUpdateTable(Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters, cancellationToken);
                var operation = new TableResourceCreateUpdateTableOperation(Parent, _clientDiagnostics, Pipeline, _tableResourcesRestClient.CreateCreateUpdateTableRequest(Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB Table. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateTableParameters"> The parameters to provide for the current Table. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateTableParameters"/> is null. </exception>
        public async virtual Task<TableResourceCreateUpdateTableOperation> CreateOrUpdateAsync(string tableName, TableCreateUpdateParameters createUpdateTableParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
            if (createUpdateTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateTableParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tableResourcesRestClient.CreateUpdateTableAsync(Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters, cancellationToken).ConfigureAwait(false);
                var operation = new TableResourceCreateUpdateTableOperation(Parent, _clientDiagnostics, Pipeline, _tableResourcesRestClient.CreateCreateUpdateTableRequest(Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters).Request, response);
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

        /// <summary> Gets the Tables under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<Table> Get(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.Get");
            scope.Start();
            try
            {
                var response = _tableResourcesRestClient.GetTable(Id.ResourceGroupName, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Table(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Tables under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<Table>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.Get");
            scope.Start();
            try
            {
                var response = await _tableResourcesRestClient.GetTableAsync(Id.ResourceGroupName, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Table(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<Table> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tableResourcesRestClient.GetTable(Id.ResourceGroupName, Id.Name, tableName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Table>(null, response.GetRawResponse())
                    : Response.FromValue(new Table(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<Table>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _tableResourcesRestClient.GetTableAsync(Id.ResourceGroupName, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Table>(null, response.GetRawResponse())
                    : Response.FromValue(new Table(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            using var scope = _clientDiagnostics.CreateScope("TableCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the Tables under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Table" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Table> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Table> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tableResourcesRestClient.ListTables(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Table(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the Tables under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Table" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Table> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Table>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tableResourcesRestClient.ListTablesAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Table(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<Table> IEnumerable<Table>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Table> IAsyncEnumerable<Table>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Table, TableData> Construct() { }
    }
}
