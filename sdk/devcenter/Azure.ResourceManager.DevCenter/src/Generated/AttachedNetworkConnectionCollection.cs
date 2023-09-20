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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="AttachedNetworkConnectionResource" /> and their operations.
    /// Each <see cref="AttachedNetworkConnectionResource" /> in the collection will belong to the same instance of <see cref="DevCenterResource" />.
    /// To get an <see cref="AttachedNetworkConnectionCollection" /> instance call the GetAttachedNetworkConnections method from an instance of <see cref="DevCenterResource" />.
    /// </summary>
    public partial class AttachedNetworkConnectionCollection : ArmCollection, IEnumerable<AttachedNetworkConnectionResource>, IAsyncEnumerable<AttachedNetworkConnectionResource>
    {
        private readonly ClientDiagnostics _attachedNetworkConnectionAttachedNetworksClientDiagnostics;
        private readonly AttachedNetworksRestOperations _attachedNetworkConnectionAttachedNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="AttachedNetworkConnectionCollection"/> class for mocking. </summary>
        protected AttachedNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AttachedNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AttachedNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _attachedNetworkConnectionAttachedNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", AttachedNetworkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AttachedNetworkConnectionResource.ResourceType, out string attachedNetworkConnectionAttachedNetworksApiVersion);
            _attachedNetworkConnectionAttachedNetworksRestClient = new AttachedNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, attachedNetworkConnectionAttachedNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an attached NetworkConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedNetworkConnectionName"> The name of the attached NetworkConnection. </param>
        /// <param name="data"> Represents an attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedNetworkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AttachedNetworkConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string attachedNetworkConnectionName, AttachedNetworkConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedNetworkConnectionName, nameof(attachedNetworkConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _attachedNetworkConnectionAttachedNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<AttachedNetworkConnectionResource>(new AttachedNetworkConnectionOperationSource(Client), _attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, _attachedNetworkConnectionAttachedNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an attached NetworkConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedNetworkConnectionName"> The name of the attached NetworkConnection. </param>
        /// <param name="data"> Represents an attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedNetworkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AttachedNetworkConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string attachedNetworkConnectionName, AttachedNetworkConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedNetworkConnectionName, nameof(attachedNetworkConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _attachedNetworkConnectionAttachedNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, data, cancellationToken);
                var operation = new DevCenterArmOperation<AttachedNetworkConnectionResource>(new AttachedNetworkConnectionOperationSource(Client), _attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, _attachedNetworkConnectionAttachedNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an attached NetworkConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_GetByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedNetworkConnectionName"> The name of the attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedNetworkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkConnectionName"/> is null. </exception>
        public virtual async Task<Response<AttachedNetworkConnectionResource>> GetAsync(string attachedNetworkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedNetworkConnectionName, nameof(attachedNetworkConnectionName));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _attachedNetworkConnectionAttachedNetworksRestClient.GetByDevCenterAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttachedNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an attached NetworkConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_GetByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedNetworkConnectionName"> The name of the attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedNetworkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkConnectionName"/> is null. </exception>
        public virtual Response<AttachedNetworkConnectionResource> Get(string attachedNetworkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedNetworkConnectionName, nameof(attachedNetworkConnectionName));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _attachedNetworkConnectionAttachedNetworksRestClient.GetByDevCenter(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttachedNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the attached NetworkConnections for a DevCenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttachedNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AttachedNetworkConnectionResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _attachedNetworkConnectionAttachedNetworksRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _attachedNetworkConnectionAttachedNetworksRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AttachedNetworkConnectionResource(Client, AttachedNetworkConnectionData.DeserializeAttachedNetworkConnectionData(e)), _attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, "AttachedNetworkConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the attached NetworkConnections for a DevCenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttachedNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AttachedNetworkConnectionResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _attachedNetworkConnectionAttachedNetworksRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _attachedNetworkConnectionAttachedNetworksRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AttachedNetworkConnectionResource(Client, AttachedNetworkConnectionData.DeserializeAttachedNetworkConnectionData(e)), _attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, "AttachedNetworkConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_GetByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedNetworkConnectionName"> The name of the attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedNetworkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string attachedNetworkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedNetworkConnectionName, nameof(attachedNetworkConnectionName));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _attachedNetworkConnectionAttachedNetworksRestClient.GetByDevCenterAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedNetworks_GetByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedNetworkConnectionName"> The name of the attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedNetworkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string attachedNetworkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedNetworkConnectionName, nameof(attachedNetworkConnectionName));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _attachedNetworkConnectionAttachedNetworksRestClient.GetByDevCenter(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedNetworkConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AttachedNetworkConnectionResource> IEnumerable<AttachedNetworkConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AttachedNetworkConnectionResource> IAsyncEnumerable<AttachedNetworkConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
