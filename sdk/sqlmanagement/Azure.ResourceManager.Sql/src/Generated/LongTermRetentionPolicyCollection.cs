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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of LongTermRetentionPolicy and their operations over its parent. </summary>
    public partial class LongTermRetentionPolicyCollection : ArmCollection, IEnumerable<LongTermRetentionPolicy>, IAsyncEnumerable<LongTermRetentionPolicy>
    {
        private readonly ClientDiagnostics _longTermRetentionPolicyClientDiagnostics;
        private readonly LongTermRetentionPoliciesRestOperations _longTermRetentionPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="LongTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected LongTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LongTermRetentionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LongTermRetentionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _longTermRetentionPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", LongTermRetentionPolicy.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(LongTermRetentionPolicy.ResourceType, out string longTermRetentionPolicyApiVersion);
            _longTermRetentionPolicyRestClient = new LongTermRetentionPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, longTermRetentionPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// <summary>
        /// Sets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="parameters"> The long term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionPolicy>> CreateOrUpdateAsync(WaitUntil waitUntil, LongTermRetentionPolicyName policyName, LongTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _longTermRetentionPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionPolicy>(new LongTermRetentionPolicyOperationSource(Client), _longTermRetentionPolicyClientDiagnostics, Pipeline, _longTermRetentionPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Sets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="parameters"> The long term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionPolicy> CreateOrUpdate(WaitUntil waitUntil, LongTermRetentionPolicyName policyName, LongTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _longTermRetentionPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionPolicy>(new LongTermRetentionPolicyOperationSource(Client), _longTermRetentionPolicyClientDiagnostics, Pipeline, _longTermRetentionPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LongTermRetentionPolicy>> GetAsync(LongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _longTermRetentionPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LongTermRetentionPolicy> Get(LongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _longTermRetentionPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies
        /// Operation Id: LongTermRetentionPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LongTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LongTermRetentionPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LongTermRetentionPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionPolicyRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LongTermRetentionPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionPolicyRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies
        /// Operation Id: LongTermRetentionPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LongTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LongTermRetentionPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LongTermRetentionPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionPolicyRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LongTermRetentionPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionPolicyRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(LongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.Exists");
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(LongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.Exists");
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LongTermRetentionPolicy>> GetIfExistsAsync(LongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _longTermRetentionPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<LongTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new LongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: LongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LongTermRetentionPolicy> GetIfExists(LongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _longTermRetentionPolicyClientDiagnostics.CreateScope("LongTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _longTermRetentionPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<LongTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new LongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LongTermRetentionPolicy> IEnumerable<LongTermRetentionPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LongTermRetentionPolicy> IAsyncEnumerable<LongTermRetentionPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
