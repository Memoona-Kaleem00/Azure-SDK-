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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="HubVirtualNetworkConnectionResource" /> and their operations.
    /// Each <see cref="HubVirtualNetworkConnectionResource" /> in the collection will belong to the same instance of <see cref="VirtualHubResource" />.
    /// To get a <see cref="HubVirtualNetworkConnectionCollection" /> instance call the GetHubVirtualNetworkConnections method from an instance of <see cref="VirtualHubResource" />.
    /// </summary>
    public partial class HubVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<HubVirtualNetworkConnectionResource>, IAsyncEnumerable<HubVirtualNetworkConnectionResource>
    {
        private readonly ClientDiagnostics _hubVirtualNetworkConnectionClientDiagnostics;
        private readonly HubVirtualNetworkConnectionsRestOperations _hubVirtualNetworkConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="HubVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected HubVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HubVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HubVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hubVirtualNetworkConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", HubVirtualNetworkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HubVirtualNetworkConnectionResource.ResourceType, out string hubVirtualNetworkConnectionApiVersion);
            _hubVirtualNetworkConnectionRestClient = new HubVirtualNetworkConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hubVirtualNetworkConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a hub virtual network connection if it doesn't exist else updates the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="data"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HubVirtualNetworkConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, HubVirtualNetworkConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<HubVirtualNetworkConnectionResource>(new HubVirtualNetworkConnectionOperationSource(Client), _hubVirtualNetworkConnectionClientDiagnostics, Pipeline, _hubVirtualNetworkConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a hub virtual network connection if it doesn't exist else updates the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="data"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HubVirtualNetworkConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, HubVirtualNetworkConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<HubVirtualNetworkConnectionResource>(new HubVirtualNetworkConnectionOperationSource(Client), _hubVirtualNetworkConnectionClientDiagnostics, Pipeline, _hubVirtualNetworkConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a HubVirtualNetworkConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<HubVirtualNetworkConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a HubVirtualNetworkConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<HubVirtualNetworkConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all HubVirtualNetworkConnections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubVirtualNetworkConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hubVirtualNetworkConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hubVirtualNetworkConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HubVirtualNetworkConnectionResource(Client, HubVirtualNetworkConnectionData.DeserializeHubVirtualNetworkConnectionData(e)), _hubVirtualNetworkConnectionClientDiagnostics, Pipeline, "HubVirtualNetworkConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of all HubVirtualNetworkConnections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubVirtualNetworkConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hubVirtualNetworkConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hubVirtualNetworkConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HubVirtualNetworkConnectionResource(Client, HubVirtualNetworkConnectionData.DeserializeHubVirtualNetworkConnectionData(e)), _hubVirtualNetworkConnectionClientDiagnostics, Pipeline, "HubVirtualNetworkConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubVirtualNetworkConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HubVirtualNetworkConnectionResource> IEnumerable<HubVirtualNetworkConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HubVirtualNetworkConnectionResource> IAsyncEnumerable<HubVirtualNetworkConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
