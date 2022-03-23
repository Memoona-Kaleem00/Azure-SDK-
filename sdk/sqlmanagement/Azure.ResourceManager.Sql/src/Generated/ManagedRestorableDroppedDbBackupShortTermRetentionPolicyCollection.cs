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
    /// <summary> A class representing collection of ManagedRestorableDroppedDbBackupShortTermRetentionPolicy and their operations over its parent. </summary>
    public partial class ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection : ArmCollection, IEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>, IAsyncEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>
    {
        private readonly ClientDiagnostics _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.ResourceType, out string managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RestorableDroppedManagedDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RestorableDroppedManagedDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> CreateOrUpdate(WaitUntil waitUntil, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> GetAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> Get(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a dropped database&apos;s short term retention policy list.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_ListByRestorableDroppedDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a dropped database&apos;s short term retention policy list.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_ListByRestorableDroppedDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> GetIfExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> GetIfExists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> IEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> IAsyncEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
