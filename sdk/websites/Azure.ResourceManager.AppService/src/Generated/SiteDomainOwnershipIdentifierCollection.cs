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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of Identifier and their operations over its parent. </summary>
    public partial class SiteDomainOwnershipIdentifierCollection : ArmCollection, IEnumerable<SiteDomainOwnershipIdentifier>, IAsyncEnumerable<SiteDomainOwnershipIdentifier>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDomainOwnershipIdentifierCollection"/> class for mocking. </summary>
        protected SiteDomainOwnershipIdentifierCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDomainOwnershipIdentifierCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteDomainOwnershipIdentifierCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteDomainOwnershipIdentifier.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdateDomainOwnershipIdentifier
        /// <summary> Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual SiteDomainOwnershipIdentifierCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string domainOwnershipIdentifierName, IdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, domainOwnershipIdentifier, cancellationToken);
                var operation = new SiteDomainOwnershipIdentifierCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdateDomainOwnershipIdentifier
        /// <summary> Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public async virtual Task<SiteDomainOwnershipIdentifierCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string domainOwnershipIdentifierName, IdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, domainOwnershipIdentifier, cancellationToken).ConfigureAwait(false);
                var operation = new SiteDomainOwnershipIdentifierCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetDomainOwnershipIdentifier
        /// <summary> Description for Get domain ownership identifier for web app. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteDomainOwnershipIdentifier> Get(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetDomainOwnershipIdentifier
        /// <summary> Description for Get domain ownership identifier for web app. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public async virtual Task<Response<SiteDomainOwnershipIdentifier>> GetAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteDomainOwnershipIdentifier> GetIfExists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteDomainOwnershipIdentifier>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public async virtual Task<Response<SiteDomainOwnershipIdentifier>> GetIfExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteDomainOwnershipIdentifier>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListDomainOwnershipIdentifiers
        /// <summary> Description for Lists ownership identifiers for domain associated with web app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDomainOwnershipIdentifier" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDomainOwnershipIdentifier> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDomainOwnershipIdentifier> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListDomainOwnershipIdentifiers(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDomainOwnershipIdentifier(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDomainOwnershipIdentifier> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListDomainOwnershipIdentifiersNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDomainOwnershipIdentifier(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListDomainOwnershipIdentifiers
        /// <summary> Description for Lists ownership identifiers for domain associated with web app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDomainOwnershipIdentifier" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDomainOwnershipIdentifier> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDomainOwnershipIdentifier>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListDomainOwnershipIdentifiersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDomainOwnershipIdentifier(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDomainOwnershipIdentifier>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListDomainOwnershipIdentifiersNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDomainOwnershipIdentifier(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteDomainOwnershipIdentifier> IEnumerable<SiteDomainOwnershipIdentifier>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDomainOwnershipIdentifier> IAsyncEnumerable<SiteDomainOwnershipIdentifier>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteDomainOwnershipIdentifier, IdentifierData> Construct() { }
    }
}
