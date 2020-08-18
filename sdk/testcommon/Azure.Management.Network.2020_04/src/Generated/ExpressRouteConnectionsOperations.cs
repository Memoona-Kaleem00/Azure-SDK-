// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The ExpressRouteConnections service client. </summary>
    public partial class ExpressRouteConnectionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExpressRouteConnectionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRouteConnectionsOperations for mocking. </summary>
        protected ExpressRouteConnectionsOperations()
        {
        }
        /// <summary> Initializes a new instance of ExpressRouteConnectionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ExpressRouteConnectionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ExpressRouteConnectionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified ExpressRouteConnection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteConnection>> GetAsync(string resourceGroupName, string expressRouteGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, expressRouteGatewayName, connectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified ExpressRouteConnection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteConnection> Get(string resourceGroupName, string expressRouteGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, expressRouteGatewayName, connectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteConnectionList>> ListAsync(string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(resourceGroupName, expressRouteGatewayName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteConnectionList> List(string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.List");
            scope.Start();
            try
            {
                return RestClient.List(resourceGroupName, expressRouteGatewayName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRouteGatewayName"/>, <paramref name="connectionName"/>, or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public virtual async Task<ExpressRouteConnectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string expressRouteGatewayName, string connectionName, ExpressRouteConnection putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, expressRouteGatewayName, connectionName, putExpressRouteConnectionParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, expressRouteGatewayName, connectionName, putExpressRouteConnectionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRouteGatewayName"/>, <paramref name="connectionName"/>, or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public virtual ExpressRouteConnectionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string expressRouteGatewayName, string connectionName, ExpressRouteConnection putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, expressRouteGatewayName, connectionName, putExpressRouteConnectionParameters, cancellationToken);
                return new ExpressRouteConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, expressRouteGatewayName, connectionName, putExpressRouteConnectionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a connection to a ExpressRoute circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRouteGatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<ExpressRouteConnectionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string expressRouteGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, expressRouteGatewayName, connectionName, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, expressRouteGatewayName, connectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a connection to a ExpressRoute circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRouteGatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public virtual ExpressRouteConnectionsDeleteOperation StartDelete(string resourceGroupName, string expressRouteGatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, expressRouteGatewayName, connectionName, cancellationToken);
                return new ExpressRouteConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, expressRouteGatewayName, connectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
