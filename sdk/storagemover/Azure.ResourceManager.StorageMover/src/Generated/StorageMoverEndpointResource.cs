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
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A Class representing a StorageMoverEndpoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StorageMoverEndpointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStorageMoverEndpointResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageMoverResource"/> using the GetStorageMoverEndpoint method.
    /// </summary>
    public partial class StorageMoverEndpointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageMoverEndpointResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="storageMoverName"> The storageMoverName. </param>
        /// <param name="endpointName"> The endpointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageMoverName, string endpointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageMoverEndpointEndpointsClientDiagnostics;
        private readonly EndpointsRestOperations _storageMoverEndpointEndpointsRestClient;
        private readonly StorageMoverEndpointData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageMover/storageMovers/endpoints";

        /// <summary> Initializes a new instance of the <see cref="StorageMoverEndpointResource"/> class for mocking. </summary>
        protected StorageMoverEndpointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageMoverEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageMoverEndpointResource(ArmClient client, StorageMoverEndpointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageMoverEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageMoverEndpointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageMoverEndpointEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageMoverEndpointEndpointsApiVersion);
            _storageMoverEndpointEndpointsRestClient = new EndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageMoverEndpointEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageMoverEndpointData Data
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
        /// Gets an Endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageMoverEndpointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointResource.Get");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageMoverEndpointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointResource.Get");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointResource.Delete");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StorageMoverArmOperation(_storageMoverEndpointEndpointsClientDiagnostics, Pipeline, _storageMoverEndpointEndpointsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes an Endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointResource.Delete");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StorageMoverArmOperation(_storageMoverEndpointEndpointsClientDiagnostics, Pipeline, _storageMoverEndpointEndpointsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates properties for an Endpoint resource. Properties not specified in the request body will be unchanged.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The <see cref="StorageMoverEndpointPatch"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<StorageMoverEndpointResource>> UpdateAsync(StorageMoverEndpointPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointResource.Update");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates properties for an Endpoint resource. Properties not specified in the request body will be unchanged.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The <see cref="StorageMoverEndpointPatch"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<StorageMoverEndpointResource> Update(StorageMoverEndpointPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointResource.Update");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
