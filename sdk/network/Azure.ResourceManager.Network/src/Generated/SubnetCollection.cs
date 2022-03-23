// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of Subnet and their operations over its parent. </summary>
    public partial class SubnetCollection : ArmCollection, IEnumerable<SubnetResource>, IAsyncEnumerable<SubnetResource>
    {
        private readonly ClientDiagnostics _subnetClientDiagnostics;
        private readonly SubnetsRestOperations _subnetRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubnetCollection"/> class for mocking. </summary>
        protected SubnetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubnetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubnetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subnetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", SubnetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubnetResource.ResourceType, out string subnetApiVersion);
            _subnetRestClient = new SubnetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subnetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a subnet in the specified virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> or <paramref name="subnetParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<SubnetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string subnetName, SubnetData subnetParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));
            Argument.AssertNotNull(subnetParameters, nameof(subnetParameters));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subnetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<SubnetResource>(new SubnetOperationSource(Client), _subnetClientDiagnostics, Pipeline, _subnetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a subnet in the specified virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> or <paramref name="subnetParameters"/> is null. </exception>
        public virtual ArmOperation<SubnetResource> CreateOrUpdate(WaitUntil waitUntil, string subnetName, SubnetData subnetParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));
            Argument.AssertNotNull(subnetParameters, nameof(subnetParameters));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subnetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters, cancellationToken);
                var operation = new NetworkArmOperation<SubnetResource>(new SubnetOperationSource(Client), _subnetClientDiagnostics, Pipeline, _subnetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified subnet by virtual network and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual async Task<Response<SubnetResource>> GetAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Get");
            scope.Start();
            try
            {
                var response = await _subnetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubnetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified subnet by virtual network and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<SubnetResource> Get(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Get");
            scope.Start();
            try
            {
                var response = _subnetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubnetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all subnets in a virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets
        /// Operation Id: Subnets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubnetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubnetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubnetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subnetRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubnetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubnetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subnetRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubnetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all subnets in a virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets
        /// Operation Id: Subnets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubnetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubnetResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubnetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subnetRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubnetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubnetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subnetRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubnetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subnetName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subnetName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual async Task<Response<SubnetResource>> GetIfExistsAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subnetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubnetResource>(null, response.GetRawResponse());
                return Response.FromValue(new SubnetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<SubnetResource> GetIfExists(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subnetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubnetResource>(null, response.GetRawResponse());
                return Response.FromValue(new SubnetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubnetResource> IEnumerable<SubnetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubnetResource> IAsyncEnumerable<SubnetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
