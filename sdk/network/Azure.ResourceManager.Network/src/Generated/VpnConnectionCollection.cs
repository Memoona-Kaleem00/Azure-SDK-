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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnConnection and their operations over its parent. </summary>
    public partial class VpnConnectionCollection : ArmCollection, IEnumerable<VpnConnectionResource>, IAsyncEnumerable<VpnConnectionResource>
    {
        private readonly ClientDiagnostics _vpnConnectionClientDiagnostics;
        private readonly VpnConnectionsRestOperations _vpnConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnConnectionCollection"/> class for mocking. </summary>
        protected VpnConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnConnectionResource.ResourceType, out string vpnConnectionApiVersion);
            _vpnConnectionRestClient = new VpnConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VpnGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VpnGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a vpn connection to a scalable vpn gateway if it doesn&apos;t exist else updates the existing connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="vpnConnectionParameters"> Parameters supplied to create or Update a VPN Connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="vpnConnectionParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, VpnConnectionData vpnConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(vpnConnectionParameters, nameof(vpnConnectionParameters));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, vpnConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnConnectionResource>(new VpnConnectionOperationSource(Client), _vpnConnectionClientDiagnostics, Pipeline, _vpnConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, vpnConnectionParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a vpn connection to a scalable vpn gateway if it doesn&apos;t exist else updates the existing connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="vpnConnectionParameters"> Parameters supplied to create or Update a VPN Connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="vpnConnectionParameters"/> is null. </exception>
        public virtual ArmOperation<VpnConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, VpnConnectionData vpnConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(vpnConnectionParameters, nameof(vpnConnectionParameters));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, vpnConnectionParameters, cancellationToken);
                var operation = new NetworkArmOperation<VpnConnectionResource>(new VpnConnectionOperationSource(Client), _vpnConnectionClientDiagnostics, Pipeline, _vpnConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, vpnConnectionParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a vpn connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<VpnConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a vpn connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<VpnConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all vpn connections for a particular virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections
        /// Operation Id: VpnConnections_ListByVpnGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnConnectionRestClient.ListByVpnGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnConnectionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnConnectionRestClient.ListByVpnGatewayNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieves all vpn connections for a particular virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections
        /// Operation Id: VpnConnections_ListByVpnGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnConnectionRestClient.ListByVpnGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnConnectionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnConnectionRestClient.ListByVpnGatewayNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<VpnConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VpnConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new VpnConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}
        /// Operation Id: VpnConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<VpnConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _vpnConnectionClientDiagnostics.CreateScope("VpnConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VpnConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new VpnConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnConnectionResource> IEnumerable<VpnConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnConnectionResource> IAsyncEnumerable<VpnConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
