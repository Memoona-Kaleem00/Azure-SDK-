// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of RestorableDroppedManagedDatabase and their operations over its parent. </summary>
    public partial class RestorableDroppedManagedDatabaseCollection : ArmCollection, IEnumerable<RestorableDroppedManagedDatabase>, IAsyncEnumerable<RestorableDroppedManagedDatabase>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RestorableDroppedManagedDatabasesRestOperations _restorableDroppedManagedDatabasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseCollection"/> class for mocking. </summary>
        protected RestorableDroppedManagedDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RestorableDroppedManagedDatabaseCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restorableDroppedManagedDatabasesRestClient = new RestorableDroppedManagedDatabasesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstance.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Gets a restorable dropped managed database. </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<RestorableDroppedManagedDatabase> Get(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            if (restorableDroppedDatabaseId == null)
            {
                throw new ArgumentNullException(nameof(restorableDroppedDatabaseId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabase(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Gets a restorable dropped managed database. </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public async virtual Task<Response<RestorableDroppedManagedDatabase>> GetAsync(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            if (restorableDroppedDatabaseId == null)
            {
                throw new ArgumentNullException(nameof(restorableDroppedDatabaseId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<RestorableDroppedManagedDatabase> GetIfExists(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            if (restorableDroppedDatabaseId == null)
            {
                throw new ArgumentNullException(nameof(restorableDroppedDatabaseId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RestorableDroppedManagedDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public async virtual Task<Response<RestorableDroppedManagedDatabase>> GetIfExistsAsync(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            if (restorableDroppedDatabaseId == null)
            {
                throw new ArgumentNullException(nameof(restorableDroppedDatabaseId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RestorableDroppedManagedDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<bool> Exists(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            if (restorableDroppedDatabaseId == null)
            {
                throw new ArgumentNullException(nameof(restorableDroppedDatabaseId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(restorableDroppedDatabaseId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            if (restorableDroppedDatabaseId == null)
            {
                throw new ArgumentNullException(nameof(restorableDroppedDatabaseId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(restorableDroppedDatabaseId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RestorableDroppedManagedDatabases_ListByInstance
        /// <summary> Gets a list of restorable dropped managed databases. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDroppedManagedDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDroppedManagedDatabase> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorableDroppedManagedDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorableDroppedManagedDatabasesRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDroppedManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RestorableDroppedManagedDatabase> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorableDroppedManagedDatabasesRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDroppedManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RestorableDroppedManagedDatabases_ListByInstance
        /// <summary> Gets a list of restorable dropped managed databases. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDroppedManagedDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDroppedManagedDatabase> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableDroppedManagedDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorableDroppedManagedDatabasesRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDroppedManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RestorableDroppedManagedDatabase>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorableDroppedManagedDatabasesRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDroppedManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<RestorableDroppedManagedDatabase> IEnumerable<RestorableDroppedManagedDatabase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableDroppedManagedDatabase> IAsyncEnumerable<RestorableDroppedManagedDatabase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RestorableDroppedManagedDatabase, RestorableDroppedManagedDatabaseData> Construct() { }
    }
}
