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
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="DatabaseSecurityAlertPolicyResource" /> and their operations.
    /// Each <see cref="DatabaseSecurityAlertPolicyResource" /> in the collection will belong to the same instance of <see cref="SqlDatabaseResource" />.
    /// To get a <see cref="DatabaseSecurityAlertPolicyCollection" /> instance call the GetDatabaseSecurityAlertPolicies method from an instance of <see cref="SqlDatabaseResource" />.
    /// </summary>
    public partial class DatabaseSecurityAlertPolicyCollection : ArmCollection, IEnumerable<DatabaseSecurityAlertPolicyResource>, IAsyncEnumerable<DatabaseSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _databaseSecurityAlertPolicyClientDiagnostics;
        private readonly DatabaseSecurityAlertPoliciesRestOperations _databaseSecurityAlertPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatabaseSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected DatabaseSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatabaseSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseSecurityAlertPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", DatabaseSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatabaseSecurityAlertPolicyResource.ResourceType, out string databaseSecurityAlertPolicyApiVersion);
            _databaseSecurityAlertPolicyRestClient = new DatabaseSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseSecurityAlertPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SecurityAlertPolicyName securityAlertPolicyName, DatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseSecurityAlertPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<DatabaseSecurityAlertPolicyResource>(Response.FromValue(new DatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SecurityAlertPolicyName securityAlertPolicyName, DatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseSecurityAlertPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var operation = new SqlArmOperation<DatabaseSecurityAlertPolicyResource>(Response.FromValue(new DatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatabaseSecurityAlertPolicyResource>> GetAsync(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseSecurityAlertPolicyResource> Get(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database&apos;s security alert policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies
        /// Operation Id: DatabaseSecurityAlertPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DatabaseSecurityAlertPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databaseSecurityAlertPolicyRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatabaseSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DatabaseSecurityAlertPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databaseSecurityAlertPolicyRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatabaseSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of database&apos;s security alert policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies
        /// Operation Id: DatabaseSecurityAlertPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DatabaseSecurityAlertPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databaseSecurityAlertPolicyRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatabaseSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DatabaseSecurityAlertPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databaseSecurityAlertPolicyRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatabaseSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _databaseSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _databaseSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DatabaseSecurityAlertPolicyResource> IEnumerable<DatabaseSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatabaseSecurityAlertPolicyResource> IAsyncEnumerable<DatabaseSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
