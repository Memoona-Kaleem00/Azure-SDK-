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

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A Class representing an InventoryItem along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="InventoryItemResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetInventoryItemResource method.
    /// Otherwise you can get one from its parent resource <see cref="ScVmmServerResource"/> using the GetInventoryItem method.
    /// </summary>
    public partial class InventoryItemResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="InventoryItemResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="vmmServerName"> The vmmServerName. </param>
        /// <param name="inventoryItemName"> The inventoryItemName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmmServerName, string inventoryItemName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _inventoryItemClientDiagnostics;
        private readonly InventoryItemsRestOperations _inventoryItemRestClient;
        private readonly InventoryItemData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ScVmm/vmmServers/inventoryItems";

        /// <summary> Initializes a new instance of the <see cref="InventoryItemResource"/> class for mocking. </summary>
        protected InventoryItemResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InventoryItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal InventoryItemResource(ArmClient client, InventoryItemData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="InventoryItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal InventoryItemResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _inventoryItemClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string inventoryItemApiVersion);
            _inventoryItemRestClient = new InventoryItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, inventoryItemApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual InventoryItemData Data
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
        /// Shows an inventory item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<InventoryItemResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemResource.Get");
            scope.Start();
            try
            {
                var response = await _inventoryItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Shows an inventory item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<InventoryItemResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemResource.Get");
            scope.Start();
            try
            {
                var response = _inventoryItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an inventoryItem.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemResource.Delete");
            scope.Start();
            try
            {
                var response = await _inventoryItemRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _inventoryItemRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ArcScVmmArmOperation(response, rehydrationToken);
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
        /// Deletes an inventoryItem.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemResource.Delete");
            scope.Start();
            try
            {
                var response = _inventoryItemRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _inventoryItemRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ArcScVmmArmOperation(response, rehydrationToken);
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
        /// Create Or Update InventoryItem.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<InventoryItemResource>> UpdateAsync(WaitUntil waitUntil, InventoryItemData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemResource.Update");
            scope.Start();
            try
            {
                var response = await _inventoryItemRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _inventoryItemRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ArcScVmmArmOperation<InventoryItemResource>(Response.FromValue(new InventoryItemResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create Or Update InventoryItem.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<InventoryItemResource> Update(WaitUntil waitUntil, InventoryItemData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemResource.Update");
            scope.Start();
            try
            {
                var response = _inventoryItemRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _inventoryItemRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ArcScVmmArmOperation<InventoryItemResource>(Response.FromValue(new InventoryItemResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
