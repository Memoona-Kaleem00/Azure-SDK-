// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private EdgeOrderManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private EdgeOrderManagementRestOperations DefaultRestClient => _defaultRestClient ??= new EdgeOrderManagementRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AddressResources in the AddressResource. </summary>
        /// <returns> An object representing collection of AddressResources and their operations over a AddressResource. </returns>
        public virtual AddressResourceCollection GetAddressResources()
        {
            return GetCachedClient(Client => new AddressResourceCollection(Client, Id));
        }

        /// <summary> Gets a collection of OrderResources in the OrderResource. </summary>
        /// <returns> An object representing collection of OrderResources and their operations over a OrderResource. </returns>
        public virtual OrderResourceCollection GetOrderResources()
        {
            return GetCachedClient(Client => new OrderResourceCollection(Client, Id));
        }

        /// <summary> Gets a collection of OrderItemResources in the OrderItemResource. </summary>
        /// <returns> An object representing collection of OrderItemResources and their operations over a OrderItemResource. </returns>
        public virtual OrderItemResourceCollection GetOrderItemResources()
        {
            return GetCachedClient(Client => new OrderItemResourceCollection(Client, Id));
        }

        /// <summary>
        /// Lists order at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtResourceGroupLevel
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrderResource> GetOrderResourcesAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OrderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListOrderAtResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OrderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListOrderAtResourceGroupLevelNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists order at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtResourceGroupLevel
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrderResource> GetOrderResources(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<OrderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListOrderAtResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OrderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListOrderAtResourceGroupLevelNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
