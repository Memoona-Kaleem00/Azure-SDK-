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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ExpressRouteCircuitConnection along with the instance operations that can be performed on it. </summary>
    public partial class ExpressRouteCircuitConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteCircuitConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string circuitName, string peeringName, string connectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRouteCircuitConnectionClientDiagnostics;
        private readonly ExpressRouteCircuitConnectionsRestOperations _expressRouteCircuitConnectionRestClient;
        private readonly ExpressRouteCircuitConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnection"/> class for mocking. </summary>
        protected ExpressRouteCircuitConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteCircuitConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteCircuitConnection(ArmClient client, ExpressRouteCircuitConnectionData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteCircuitConnection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string expressRouteCircuitConnectionApiVersion);
            _expressRouteCircuitConnectionRestClient = new ExpressRouteCircuitConnectionsRestOperations(_expressRouteCircuitConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCircuitConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCircuits/peerings/connections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteCircuitConnectionData Data
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
        /// Gets the specified Express Route Circuit Connection from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}
        /// Operation Id: ExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuitConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRouteCircuitConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuitConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Express Route Circuit Connection from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}
        /// Operation Id: ExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _expressRouteCircuitConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Express Route Circuit Connection from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}
        /// Operation Id: ExpressRouteCircuitConnections_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnection.Delete");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Deletes the specified Express Route Circuit Connection from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}
        /// Operation Id: ExpressRouteCircuitConnections_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnection.Delete");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
