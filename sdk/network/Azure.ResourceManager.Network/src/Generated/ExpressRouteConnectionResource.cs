// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// A Class representing an ExpressRouteConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ExpressRouteConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetExpressRouteConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ExpressRouteGatewayResource" /> using the GetExpressRouteConnection method.
    /// </summary>
    public partial class ExpressRouteConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string expressRouteGatewayName, string connectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRouteConnectionClientDiagnostics;
        private readonly ExpressRouteConnectionsRestOperations _expressRouteConnectionRestClient;
        private readonly ExpressRouteConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionResource"/> class for mocking. </summary>
        protected ExpressRouteConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteConnectionResource(ArmClient client, ExpressRouteConnectionData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string expressRouteConnectionApiVersion);
            _expressRouteConnectionRestClient = new ExpressRouteConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteGateways/expressRouteConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified ExpressRouteConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified ExpressRouteConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a connection to a ExpressRoute circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_expressRouteConnectionClientDiagnostics, Pipeline, _expressRouteConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a connection to a ExpressRoute circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_expressRouteConnectionClientDiagnostics, Pipeline, _expressRouteConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
