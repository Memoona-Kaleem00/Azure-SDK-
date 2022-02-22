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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of IpAllocation and their operations over its parent. </summary>
    public partial class IpAllocationCollection : ArmCollection, IEnumerable<IpAllocation>, IAsyncEnumerable<IpAllocation>
    {
        private readonly ClientDiagnostics _ipAllocationClientDiagnostics;
        private readonly IpAllocationsRestOperations _ipAllocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="IpAllocationCollection"/> class for mocking. </summary>
        protected IpAllocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IpAllocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IpAllocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ipAllocationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", IpAllocation.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(IpAllocation.ResourceType, out string ipAllocationApiVersion);
            _ipAllocationRestClient = new IpAllocationsRestOperations(_ipAllocationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, ipAllocationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an IpAllocation in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<IpAllocation>> CreateOrUpdateAsync(bool waitForCompletion, string ipAllocationName, IpAllocationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipAllocationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<IpAllocation>(new IpAllocationOperationSource(Client), _ipAllocationClientDiagnostics, Pipeline, _ipAllocationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Creates or updates an IpAllocation in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<IpAllocation> CreateOrUpdate(bool waitForCompletion, string ipAllocationName, IpAllocationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipAllocationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<IpAllocation>(new IpAllocationOperationSource(Client), _ipAllocationClientDiagnostics, Pipeline, _ipAllocationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Gets the specified IpAllocation by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_Get
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public async virtual Task<Response<IpAllocation>> GetAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipAllocationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _ipAllocationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new IpAllocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified IpAllocation by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_Get
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<IpAllocation> Get(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.Get");
            scope.Start();
            try
            {
                var response = _ipAllocationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken);
                if (response.Value == null)
                    throw _ipAllocationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IpAllocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all IpAllocations in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations
        /// Operation Id: IpAllocations_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IpAllocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IpAllocation> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IpAllocation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipAllocationRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IpAllocation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipAllocationRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all IpAllocations in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations
        /// Operation Id: IpAllocations_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IpAllocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IpAllocation> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IpAllocation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipAllocationRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IpAllocation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipAllocationRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_Get
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ipAllocationName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_Get
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ipAllocationName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_Get
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public async virtual Task<Response<IpAllocation>> GetIfExistsAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ipAllocationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<IpAllocation>(null, response.GetRawResponse());
                return Response.FromValue(new IpAllocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}
        /// Operation Id: IpAllocations_Get
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<IpAllocation> GetIfExists(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationClientDiagnostics.CreateScope("IpAllocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ipAllocationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<IpAllocation>(null, response.GetRawResponse());
                return Response.FromValue(new IpAllocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IpAllocation> IEnumerable<IpAllocation>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IpAllocation> IAsyncEnumerable<IpAllocation>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
