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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of RemotePrivateEndpointConnectionARMResource and their operations over its parent. </summary>
    public partial class SiteSlotPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<SiteSlotPrivateEndpointConnection>, IAsyncEnumerable<SiteSlotPrivateEndpointConnection>
    {
        private readonly ClientDiagnostics _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotPrivateEndpointConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected SiteSlotPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotPrivateEndpointConnection.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteSlotPrivateEndpointConnection.ResourceType, out string siteSlotPrivateEndpointConnectionWebAppsApiVersion);
            _siteSlotPrivateEndpointConnectionWebAppsRestClient = new WebAppsRestOperations(_siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotPrivateEndpointConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ApproveOrRejectPrivateEndpointConnectionSlot
        /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="privateEndpointWrapper"/> is null. </exception>
        public async virtual Task<ArmOperation<SiteSlotPrivateEndpointConnection>> CreateOrUpdateAsync(bool waitForCompletion, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            if (privateEndpointWrapper == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointWrapper));
            }

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.ApproveOrRejectPrivateEndpointConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, privateEndpointWrapper, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotPrivateEndpointConnection>(new SiteSlotPrivateEndpointConnectionOperationSource(Client), _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _siteSlotPrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, privateEndpointWrapper).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ApproveOrRejectPrivateEndpointConnectionSlot
        /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="privateEndpointWrapper"/> is null. </exception>
        public virtual ArmOperation<SiteSlotPrivateEndpointConnection> CreateOrUpdate(bool waitForCompletion, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            if (privateEndpointWrapper == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointWrapper));
            }

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.ApproveOrRejectPrivateEndpointConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, privateEndpointWrapper, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotPrivateEndpointConnection>(new SiteSlotPrivateEndpointConnectionOperationSource(Client), _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _siteSlotPrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, privateEndpointWrapper).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionSlot
        /// <summary> Description for Gets a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotPrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionSlot
        /// <summary> Description for Gets a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<SiteSlotPrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionListSlot
        /// <summary> Description for Gets the list of private endpoint connections associated with a site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotPrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotPrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionListSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotPrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionListSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionListSlot
        /// <summary> Description for Gets the list of private endpoint connections associated with a site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotPrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotPrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionListSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotPrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionListSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionSlot
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionSlot
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionSlot
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotPrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotPrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPrivateEndpointConnectionSlot
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<SiteSlotPrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotPrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotPrivateEndpointConnection> IEnumerable<SiteSlotPrivateEndpointConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotPrivateEndpointConnection> IAsyncEnumerable<SiteSlotPrivateEndpointConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
