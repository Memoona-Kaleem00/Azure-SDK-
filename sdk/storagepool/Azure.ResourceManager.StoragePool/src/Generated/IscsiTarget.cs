// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A Class representing a IscsiTarget along with the instance operations that can be performed on it. </summary>
    public partial class IscsiTarget : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IscsiTarget"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string diskPoolName, string iscsiTargetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iscsiTargetClientDiagnostics;
        private readonly IscsiTargetsRestOperations _iscsiTargetRestClient;
        private readonly IscsiTargetData _data;

        /// <summary> Initializes a new instance of the <see cref="IscsiTarget"/> class for mocking. </summary>
        protected IscsiTarget()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IscsiTarget"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IscsiTarget(ArmClient armClient, IscsiTargetData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IscsiTarget"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IscsiTarget(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _iscsiTargetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StoragePool", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string iscsiTargetApiVersion);
            _iscsiTargetRestClient = new IscsiTargetsRestOperations(_iscsiTargetClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, iscsiTargetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StoragePool/diskPools/iscsiTargets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IscsiTargetData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// OperationId: IscsiTargets_Get
        /// <summary> Get an iSCSI Target. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IscsiTarget>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.Get");
            scope.Start();
            try
            {
                var response = await _iscsiTargetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _iscsiTargetClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new IscsiTarget(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// OperationId: IscsiTargets_Get
        /// <summary> Get an iSCSI Target. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IscsiTarget> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.Get");
            scope.Start();
            try
            {
                var response = _iscsiTargetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _iscsiTargetClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IscsiTarget(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// OperationId: IscsiTargets_Delete
        /// <summary> Delete an iSCSI Target. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<IscsiTargetDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.Delete");
            scope.Start();
            try
            {
                var response = await _iscsiTargetRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new IscsiTargetDeleteOperation(_iscsiTargetClientDiagnostics, Pipeline, _iscsiTargetRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// OperationId: IscsiTargets_Delete
        /// <summary> Delete an iSCSI Target. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual IscsiTargetDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.Delete");
            scope.Start();
            try
            {
                var response = _iscsiTargetRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new IscsiTargetDeleteOperation(_iscsiTargetClientDiagnostics, Pipeline, _iscsiTargetRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// OperationId: IscsiTargets_Update
        /// <summary> Update an iSCSI Target. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="iscsiTargetUpdatePayload"> Request payload for iSCSI Target update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetUpdatePayload"/> is null. </exception>
        public async virtual Task<IscsiTargetUpdateOperation> UpdateAsync(bool waitForCompletion, IscsiTargetUpdate iscsiTargetUpdatePayload, CancellationToken cancellationToken = default)
        {
            if (iscsiTargetUpdatePayload == null)
            {
                throw new ArgumentNullException(nameof(iscsiTargetUpdatePayload));
            }

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.Update");
            scope.Start();
            try
            {
                var response = await _iscsiTargetRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, iscsiTargetUpdatePayload, cancellationToken).ConfigureAwait(false);
                var operation = new IscsiTargetUpdateOperation(ArmClient, _iscsiTargetClientDiagnostics, Pipeline, _iscsiTargetRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, iscsiTargetUpdatePayload).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// OperationId: IscsiTargets_Update
        /// <summary> Update an iSCSI Target. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="iscsiTargetUpdatePayload"> Request payload for iSCSI Target update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetUpdatePayload"/> is null. </exception>
        public virtual IscsiTargetUpdateOperation Update(bool waitForCompletion, IscsiTargetUpdate iscsiTargetUpdatePayload, CancellationToken cancellationToken = default)
        {
            if (iscsiTargetUpdatePayload == null)
            {
                throw new ArgumentNullException(nameof(iscsiTargetUpdatePayload));
            }

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTarget.Update");
            scope.Start();
            try
            {
                var response = _iscsiTargetRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, iscsiTargetUpdatePayload, cancellationToken);
                var operation = new IscsiTargetUpdateOperation(ArmClient, _iscsiTargetClientDiagnostics, Pipeline, _iscsiTargetRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, iscsiTargetUpdatePayload).Request, response);
                if (waitForCompletion)
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
