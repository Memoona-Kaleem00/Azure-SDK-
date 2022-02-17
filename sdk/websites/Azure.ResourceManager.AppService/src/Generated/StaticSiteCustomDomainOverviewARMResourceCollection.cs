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
    /// <summary> A class representing collection of StaticSiteCustomDomainOverviewARMResource and their operations over its parent. </summary>
    public partial class StaticSiteCustomDomainOverviewARMResourceCollection : ArmCollection, IEnumerable<StaticSiteCustomDomainOverviewARMResource>, IAsyncEnumerable<StaticSiteCustomDomainOverviewARMResource>
    {
        private readonly ClientDiagnostics _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMResourceCollection"/> class for mocking. </summary>
        protected StaticSiteCustomDomainOverviewARMResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewARMResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteCustomDomainOverviewARMResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(StaticSiteCustomDomainOverviewARMResource.ResourceType, out string staticSiteCustomDomainOverviewARMResourceStaticSitesApiVersion);
            _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient = new StaticSitesRestOperations(_staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, staticSiteCustomDomainOverviewARMResourceStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteARMResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteARMResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteCustomDomain
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainName"> The custom domain to create. </param>
        /// <param name="staticSiteCustomDomainRequestPropertiesEnvelope"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="staticSiteCustomDomainRequestPropertiesEnvelope"/> is null. </exception>
        public async virtual Task<ArmOperation<StaticSiteCustomDomainOverviewARMResource>> CreateOrUpdateAsync(bool waitForCompletion, string domainName, StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(staticSiteCustomDomainRequestPropertiesEnvelope, nameof(staticSiteCustomDomainRequestPropertiesEnvelope));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewARMResource>(new StaticSiteCustomDomainOverviewARMResourceOperationSource(Client), _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteCustomDomain
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainName"> The custom domain to create. </param>
        /// <param name="staticSiteCustomDomainRequestPropertiesEnvelope"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="staticSiteCustomDomainRequestPropertiesEnvelope"/> is null. </exception>
        public virtual ArmOperation<StaticSiteCustomDomainOverviewARMResource> CreateOrUpdate(bool waitForCompletion, string domainName, StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(staticSiteCustomDomainRequestPropertiesEnvelope, nameof(staticSiteCustomDomainRequestPropertiesEnvelope));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewARMResource>(new StaticSiteCustomDomainOverviewARMResourceOperationSource(Client), _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets an existing custom domain for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<StaticSiteCustomDomainOverviewARMResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an existing custom domain for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<StaticSiteCustomDomainOverviewARMResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all static site custom domains for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains
        /// Operation Id: StaticSites_ListStaticSiteCustomDomains
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteCustomDomainOverviewARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteCustomDomainOverviewARMResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteCustomDomainOverviewARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.ListStaticSiteCustomDomainsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteCustomDomainOverviewARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.ListStaticSiteCustomDomainsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets all static site custom domains for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains
        /// Operation Id: StaticSites_ListStaticSiteCustomDomains
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteCustomDomainOverviewARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteCustomDomainOverviewARMResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteCustomDomainOverviewARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.ListStaticSiteCustomDomains(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteCustomDomainOverviewARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.ListStaticSiteCustomDomainsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(domainName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<StaticSiteCustomDomainOverviewARMResource>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteCustomDomainOverviewARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<StaticSiteCustomDomainOverviewARMResource> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewARMResourceStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteCustomDomainOverviewARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteCustomDomainOverviewARMResource> IEnumerable<StaticSiteCustomDomainOverviewARMResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteCustomDomainOverviewARMResource> IAsyncEnumerable<StaticSiteCustomDomainOverviewARMResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
