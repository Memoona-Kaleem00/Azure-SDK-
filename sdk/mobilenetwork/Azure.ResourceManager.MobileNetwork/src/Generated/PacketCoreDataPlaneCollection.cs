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

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="PacketCoreDataPlaneResource" /> and their operations.
    /// Each <see cref="PacketCoreDataPlaneResource" /> in the collection will belong to the same instance of <see cref="PacketCoreControlPlaneResource" />.
    /// To get a <see cref="PacketCoreDataPlaneCollection" /> instance call the GetPacketCoreDataPlanes method from an instance of <see cref="PacketCoreControlPlaneResource" />.
    /// </summary>
    public partial class PacketCoreDataPlaneCollection : ArmCollection, IEnumerable<PacketCoreDataPlaneResource>, IAsyncEnumerable<PacketCoreDataPlaneResource>
    {
        private readonly ClientDiagnostics _packetCoreDataPlaneClientDiagnostics;
        private readonly PacketCoreDataPlanesRestOperations _packetCoreDataPlaneRestClient;

        /// <summary> Initializes a new instance of the <see cref="PacketCoreDataPlaneCollection"/> class for mocking. </summary>
        protected PacketCoreDataPlaneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCoreDataPlaneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PacketCoreDataPlaneCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _packetCoreDataPlaneClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", PacketCoreDataPlaneResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PacketCoreDataPlaneResource.ResourceType, out string packetCoreDataPlaneApiVersion);
            _packetCoreDataPlaneRestClient = new PacketCoreDataPlanesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, packetCoreDataPlaneApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PacketCoreControlPlaneResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PacketCoreControlPlaneResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a packet core data plane. Must be created in the same location as its parent packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="data"> Parameters supplied to the create or update packet core data plane operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreDataPlaneName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PacketCoreDataPlaneResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string packetCoreDataPlaneName, PacketCoreDataPlaneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _packetCoreDataPlaneClientDiagnostics.CreateScope("PacketCoreDataPlaneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _packetCoreDataPlaneRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<PacketCoreDataPlaneResource>(new PacketCoreDataPlaneOperationSource(Client), _packetCoreDataPlaneClientDiagnostics, Pipeline, _packetCoreDataPlaneRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a packet core data plane. Must be created in the same location as its parent packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="data"> Parameters supplied to the create or update packet core data plane operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreDataPlaneName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PacketCoreDataPlaneResource> CreateOrUpdate(WaitUntil waitUntil, string packetCoreDataPlaneName, PacketCoreDataPlaneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _packetCoreDataPlaneClientDiagnostics.CreateScope("PacketCoreDataPlaneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _packetCoreDataPlaneRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<PacketCoreDataPlaneResource>(new PacketCoreDataPlaneOperationSource(Client), _packetCoreDataPlaneClientDiagnostics, Pipeline, _packetCoreDataPlaneRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified packet core data plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        public virtual async Task<Response<PacketCoreDataPlaneResource>> GetAsync(string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var scope = _packetCoreDataPlaneClientDiagnostics.CreateScope("PacketCoreDataPlaneCollection.Get");
            scope.Start();
            try
            {
                var response = await _packetCoreDataPlaneRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCoreDataPlaneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified packet core data plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        public virtual Response<PacketCoreDataPlaneResource> Get(string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var scope = _packetCoreDataPlaneClientDiagnostics.CreateScope("PacketCoreDataPlaneCollection.Get");
            scope.Start();
            try
            {
                var response = _packetCoreDataPlaneRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCoreDataPlaneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the packet core data planes associated with a packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_ListByPacketCoreControlPlane</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCoreDataPlaneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PacketCoreDataPlaneResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _packetCoreDataPlaneRestClient.CreateListByPacketCoreControlPlaneRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _packetCoreDataPlaneRestClient.CreateListByPacketCoreControlPlaneNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PacketCoreDataPlaneResource(Client, PacketCoreDataPlaneData.DeserializePacketCoreDataPlaneData(e)), _packetCoreDataPlaneClientDiagnostics, Pipeline, "PacketCoreDataPlaneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the packet core data planes associated with a packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_ListByPacketCoreControlPlane</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCoreDataPlaneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PacketCoreDataPlaneResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _packetCoreDataPlaneRestClient.CreateListByPacketCoreControlPlaneRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _packetCoreDataPlaneRestClient.CreateListByPacketCoreControlPlaneNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PacketCoreDataPlaneResource(Client, PacketCoreDataPlaneData.DeserializePacketCoreDataPlaneData(e)), _packetCoreDataPlaneClientDiagnostics, Pipeline, "PacketCoreDataPlaneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var scope = _packetCoreDataPlaneClientDiagnostics.CreateScope("PacketCoreDataPlaneCollection.Exists");
            scope.Start();
            try
            {
                var response = await _packetCoreDataPlaneRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreDataPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        public virtual Response<bool> Exists(string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var scope = _packetCoreDataPlaneClientDiagnostics.CreateScope("PacketCoreDataPlaneCollection.Exists");
            scope.Start();
            try
            {
                var response = _packetCoreDataPlaneRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCoreDataPlaneName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PacketCoreDataPlaneResource> IEnumerable<PacketCoreDataPlaneResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PacketCoreDataPlaneResource> IAsyncEnumerable<PacketCoreDataPlaneResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
