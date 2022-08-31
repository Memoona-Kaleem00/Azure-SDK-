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

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlPrivateLinkResource" /> and their operations.
    /// Each <see cref="MySqlPrivateLinkResource" /> in the collection will belong to the same instance of <see cref="MySqlServerResource" />.
    /// To get a <see cref="MySqlPrivateLinkResourceCollection" /> instance call the GetMySqlPrivateLinkResources method from an instance of <see cref="MySqlServerResource" />.
    /// </summary>
    public partial class MySqlPrivateLinkResourceCollection : ArmCollection, IEnumerable<MySqlPrivateLinkResource>, IAsyncEnumerable<MySqlPrivateLinkResource>
    {
        private readonly ClientDiagnostics _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected MySqlPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlPrivateLinkResource.ResourceType, out string mySqlPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private link resource for MySQL server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<MySqlPrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource for MySQL server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<MySqlPrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources for MySQL server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlPrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MySqlPrivateLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the private link resources for MySQL server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MySqlPrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MySqlPrivateLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _mySqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MySqlPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlPrivateLinkResource> IEnumerable<MySqlPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlPrivateLinkResource> IAsyncEnumerable<MySqlPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
