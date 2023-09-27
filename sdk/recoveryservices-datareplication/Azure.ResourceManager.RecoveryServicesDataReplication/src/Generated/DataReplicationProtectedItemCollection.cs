// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationProtectedItemResource" /> and their operations.
    /// Each <see cref="DataReplicationProtectedItemResource" /> in the collection will belong to the same instance of <see cref="DataReplicationVaultResource" />.
    /// To get a <see cref="DataReplicationProtectedItemCollection" /> instance call the GetDataReplicationProtectedItems method from an instance of <see cref="DataReplicationVaultResource" />.
    /// </summary>
    public partial class DataReplicationProtectedItemCollection : ArmCollection, IEnumerable<DataReplicationProtectedItemResource>, IAsyncEnumerable<DataReplicationProtectedItemResource>
    {
        private readonly ClientDiagnostics _dataReplicationProtectedItemProtectedItemClientDiagnostics;
        private readonly ProtectedItemRestOperations _dataReplicationProtectedItemProtectedItemRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationProtectedItemCollection"/> class for mocking. </summary>
        protected DataReplicationProtectedItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationProtectedItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationProtectedItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationProtectedItemProtectedItemClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationProtectedItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationProtectedItemResource.ResourceType, out string dataReplicationProtectedItemProtectedItemApiVersion);
            _dataReplicationProtectedItemProtectedItemRestClient = new ProtectedItemRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationProtectedItemProtectedItemApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataReplicationVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataReplicationVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="data"> Protected item model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataReplicationProtectedItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string protectedItemName, DataReplicationProtectedItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataReplicationProtectedItemProtectedItemRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationProtectedItemResource>(new DataReplicationProtectedItemOperationSource(Client), _dataReplicationProtectedItemProtectedItemClientDiagnostics, Pipeline, _dataReplicationProtectedItemProtectedItemRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates the protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="data"> Protected item model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataReplicationProtectedItemResource> CreateOrUpdate(WaitUntil waitUntil, string protectedItemName, DataReplicationProtectedItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataReplicationProtectedItemProtectedItemRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationProtectedItemResource>(new DataReplicationProtectedItemOperationSource(Client), _dataReplicationProtectedItemProtectedItemClientDiagnostics, Pipeline, _dataReplicationProtectedItemProtectedItemRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationProtectedItemResource>> GetAsync(string protectedItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationProtectedItemProtectedItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual Response<DataReplicationProtectedItemResource> Get(string protectedItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationProtectedItemProtectedItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of protected items in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationProtectedItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationProtectedItemResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationProtectedItemProtectedItemRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationProtectedItemProtectedItemRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataReplicationProtectedItemResource(Client, DataReplicationProtectedItemData.DeserializeDataReplicationProtectedItemData(e)), _dataReplicationProtectedItemProtectedItemClientDiagnostics, Pipeline, "DataReplicationProtectedItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of protected items in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationProtectedItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationProtectedItemResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationProtectedItemProtectedItemRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationProtectedItemProtectedItemRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataReplicationProtectedItemResource(Client, DataReplicationProtectedItemData.DeserializeDataReplicationProtectedItemData(e)), _dataReplicationProtectedItemProtectedItemClientDiagnostics, Pipeline, "DataReplicationProtectedItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string protectedItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationProtectedItemProtectedItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string protectedItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationProtectedItemProtectedItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataReplicationProtectedItemResource>> GetIfExistsAsync(string protectedItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataReplicationProtectedItemProtectedItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationProtectedItemResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItem_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual NullableResponse<DataReplicationProtectedItemResource> GetIfExists(string protectedItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _dataReplicationProtectedItemProtectedItemClientDiagnostics.CreateScope("DataReplicationProtectedItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataReplicationProtectedItemProtectedItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, protectedItemName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationProtectedItemResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationProtectedItemResource> IEnumerable<DataReplicationProtectedItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationProtectedItemResource> IAsyncEnumerable<DataReplicationProtectedItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
