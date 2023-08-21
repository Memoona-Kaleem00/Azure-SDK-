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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkGroupResource" /> and their operations.
    /// Each <see cref="NetworkGroupResource" /> in the collection will belong to the same instance of <see cref="NetworkManagerResource" />.
    /// To get a <see cref="NetworkGroupCollection" /> instance call the GetNetworkGroups method from an instance of <see cref="NetworkManagerResource" />.
    /// </summary>
    public partial class NetworkGroupCollection : ArmCollection, IEnumerable<NetworkGroupResource>, IAsyncEnumerable<NetworkGroupResource>
    {
        private readonly ClientDiagnostics _networkGroupClientDiagnostics;
        private readonly NetworkGroupsRestOperations _networkGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkGroupCollection"/> class for mocking. </summary>
        protected NetworkGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkGroupResource.ResourceType, out string networkGroupApiVersion);
            _networkGroupRestClient = new NetworkGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkManagerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkManagerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkGroupName"> The name of the network group. </param>
        /// <param name="data"> Parameters supplied to the specify which network group need to create. </param>
        /// <param name="ifMatch"> The ETag of the transformation. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkGroupName, NetworkGroupData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkGroupName, nameof(networkGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkGroupClientDiagnostics.CreateScope("NetworkGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkGroupName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkGroupResource>(Response.FromValue(new NetworkGroupResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a network group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkGroupName"> The name of the network group. </param>
        /// <param name="data"> Parameters supplied to the specify which network group need to create. </param>
        /// <param name="ifMatch"> The ETag of the transformation. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkGroupResource> CreateOrUpdate(WaitUntil waitUntil, string networkGroupName, NetworkGroupData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkGroupName, nameof(networkGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkGroupClientDiagnostics.CreateScope("NetworkGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkGroupName, data, ifMatch, cancellationToken);
                var operation = new NetworkArmOperation<NetworkGroupResource>(Response.FromValue(new NetworkGroupResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified network group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkGroupName"> The name of the network group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkGroupName"/> is null. </exception>
        public virtual async Task<Response<NetworkGroupResource>> GetAsync(string networkGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkGroupName, nameof(networkGroupName));

            using var scope = _networkGroupClientDiagnostics.CreateScope("NetworkGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkGroupName"> The name of the network group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkGroupName"/> is null. </exception>
        public virtual Response<NetworkGroupResource> Get(string networkGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkGroupName, nameof(networkGroupName));

            using var scope = _networkGroupClientDiagnostics.CreateScope("NetworkGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _networkGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the specified network group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkGroupResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkGroupResource(Client, NetworkGroupData.DeserializeNetworkGroupData(e)), _networkGroupClientDiagnostics, Pipeline, "NetworkGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the specified network group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkGroupResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkGroupResource(Client, NetworkGroupData.DeserializeNetworkGroupData(e)), _networkGroupClientDiagnostics, Pipeline, "NetworkGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkGroupName"> The name of the network group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkGroupName, nameof(networkGroupName));

            using var scope = _networkGroupClientDiagnostics.CreateScope("NetworkGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkGroupName"> The name of the network group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkGroupName, nameof(networkGroupName));

            using var scope = _networkGroupClientDiagnostics.CreateScope("NetworkGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkGroupResource> IEnumerable<NetworkGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkGroupResource> IAsyncEnumerable<NetworkGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
