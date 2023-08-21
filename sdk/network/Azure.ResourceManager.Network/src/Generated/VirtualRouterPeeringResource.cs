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
    /// A Class representing a VirtualRouterPeering along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="VirtualRouterPeeringResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetVirtualRouterPeeringResource method.
    /// Otherwise you can get one from its parent resource <see cref="VirtualRouterResource" /> using the GetVirtualRouterPeering method.
    /// </summary>
    public partial class VirtualRouterPeeringResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualRouterPeeringResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualRouterName, string peeringName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualRouterPeeringClientDiagnostics;
        private readonly VirtualRouterPeeringsRestOperations _virtualRouterPeeringRestClient;
        private readonly VirtualRouterPeeringData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterPeeringResource"/> class for mocking. </summary>
        protected VirtualRouterPeeringResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualRouterPeeringResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualRouterPeeringResource(ArmClient client, VirtualRouterPeeringData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterPeeringResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualRouterPeeringResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualRouterPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string virtualRouterPeeringApiVersion);
            _virtualRouterPeeringRestClient = new VirtualRouterPeeringsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualRouterPeeringApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualRouters/peerings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualRouterPeeringData Data
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
        /// Gets the specified Virtual Router Peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouterPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualRouterPeeringResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualRouterPeeringClientDiagnostics.CreateScope("VirtualRouterPeeringResource.Get");
            scope.Start();
            try
            {
                var response = await _virtualRouterPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Virtual Router Peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouterPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualRouterPeeringResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualRouterPeeringClientDiagnostics.CreateScope("VirtualRouterPeeringResource.Get");
            scope.Start();
            try
            {
                var response = _virtualRouterPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified peering from a Virtual Router.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouterPeerings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualRouterPeeringClientDiagnostics.CreateScope("VirtualRouterPeeringResource.Delete");
            scope.Start();
            try
            {
                var response = await _virtualRouterPeeringRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_virtualRouterPeeringClientDiagnostics, Pipeline, _virtualRouterPeeringRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Deletes the specified peering from a Virtual Router.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouterPeerings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualRouterPeeringClientDiagnostics.CreateScope("VirtualRouterPeeringResource.Delete");
            scope.Start();
            try
            {
                var response = _virtualRouterPeeringRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_virtualRouterPeeringClientDiagnostics, Pipeline, _virtualRouterPeeringRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, Core.OperationFinalStateVia.Location);
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

        /// <summary>
        /// Creates or updates the specified Virtual Router Peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouterPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualRouterPeeringResource>> UpdateAsync(WaitUntil waitUntil, VirtualRouterPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualRouterPeeringClientDiagnostics.CreateScope("VirtualRouterPeeringResource.Update");
            scope.Start();
            try
            {
                var response = await _virtualRouterPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualRouterPeeringResource>(new VirtualRouterPeeringOperationSource(Client), _virtualRouterPeeringClientDiagnostics, Pipeline, _virtualRouterPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the specified Virtual Router Peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouterPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualRouterPeeringResource> Update(WaitUntil waitUntil, VirtualRouterPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualRouterPeeringClientDiagnostics.CreateScope("VirtualRouterPeeringResource.Update");
            scope.Start();
            try
            {
                var response = _virtualRouterPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualRouterPeeringResource>(new VirtualRouterPeeringOperationSource(Client), _virtualRouterPeeringClientDiagnostics, Pipeline, _virtualRouterPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
