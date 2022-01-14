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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of VirtualCluster and their operations over its parent. </summary>
    public partial class VirtualClusterCollection : ArmCollection, IEnumerable<VirtualCluster>, IAsyncEnumerable<VirtualCluster>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualClustersRestOperations _virtualClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualClusterCollection"/> class for mocking. </summary>
        protected VirtualClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualClusterCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualClusterCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualClustersRestClient = new VirtualClustersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualClusters_Get
        /// <summary> Gets a virtual cluster. </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual Response<VirtualCluster> Get(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            if (virtualClusterName == null)
            {
                throw new ArgumentNullException(nameof(virtualClusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualCluster(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualClusters_Get
        /// <summary> Gets a virtual cluster. </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public async virtual Task<Response<VirtualCluster>> GetAsync(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            if (virtualClusterName == null)
            {
                throw new ArgumentNullException(nameof(virtualClusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualCluster(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual Response<VirtualCluster> GetIfExists(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            if (virtualClusterName == null)
            {
                throw new ArgumentNullException(nameof(virtualClusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualCluster>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public async virtual Task<Response<VirtualCluster>> GetIfExistsAsync(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            if (virtualClusterName == null)
            {
                throw new ArgumentNullException(nameof(virtualClusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualCluster>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            if (virtualClusterName == null)
            {
                throw new ArgumentNullException(nameof(virtualClusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualClusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            if (virtualClusterName == null)
            {
                throw new ArgumentNullException(nameof(virtualClusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualClusters_ListByResourceGroup
        /// <summary> Gets a list of virtual clusters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualCluster> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualCluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualClustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualCluster> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualClustersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualClusters_ListByResourceGroup
        /// <summary> Gets a list of virtual clusters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualCluster> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualCluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualClustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualCluster>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualClustersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualCluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualCluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualCluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualClusterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualCluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualCluster> IEnumerable<VirtualCluster>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualCluster> IAsyncEnumerable<VirtualCluster>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualCluster, VirtualClusterData> Construct() { }
    }
}
