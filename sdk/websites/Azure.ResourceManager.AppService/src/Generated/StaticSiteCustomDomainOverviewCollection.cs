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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteCustomDomainOverviewResource" /> and their operations.
    /// Each <see cref="StaticSiteCustomDomainOverviewResource" /> in the collection will belong to the same instance of <see cref="StaticSiteResource" />.
    /// To get a <see cref="StaticSiteCustomDomainOverviewCollection" /> instance call the GetStaticSiteCustomDomainOverviews method from an instance of <see cref="StaticSiteResource" />.
    /// </summary>
    public partial class StaticSiteCustomDomainOverviewCollection : ArmCollection, IEnumerable<StaticSiteCustomDomainOverviewResource>, IAsyncEnumerable<StaticSiteCustomDomainOverviewResource>
    {
        private readonly ClientDiagnostics _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteCustomDomainOverviewStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewCollection"/> class for mocking. </summary>
        protected StaticSiteCustomDomainOverviewCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteCustomDomainOverviewResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteCustomDomainOverviewResource.ResourceType, out string staticSiteCustomDomainOverviewStaticSitesApiVersion);
            _staticSiteCustomDomainOverviewStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteCustomDomainOverviewStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The custom domain to create. </param>
        /// <param name="content"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteCustomDomainOverviewResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, StaticSiteCustomDomainContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewResource>(new StaticSiteCustomDomainOverviewOperationSource(Client), _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The custom domain to create. </param>
        /// <param name="content"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StaticSiteCustomDomainOverviewResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, StaticSiteCustomDomainContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, content, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewResource>(new StaticSiteCustomDomainOverviewOperationSource(Client), _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets an existing custom domain for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteCustomDomainOverviewResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an existing custom domain for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<StaticSiteCustomDomainOverviewResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all static site custom domains for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteCustomDomains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteCustomDomainOverviewResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteCustomDomainOverviewResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateListStaticSiteCustomDomainsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateListStaticSiteCustomDomainsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new StaticSiteCustomDomainOverviewResource(Client, StaticSiteCustomDomainOverviewData.DeserializeStaticSiteCustomDomainOverviewData(e)), _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, "StaticSiteCustomDomainOverviewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets all static site custom domains for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteCustomDomains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteCustomDomainOverviewResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteCustomDomainOverviewResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateListStaticSiteCustomDomainsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateListStaticSiteCustomDomainsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new StaticSiteCustomDomainOverviewResource(Client, StaticSiteCustomDomainOverviewData.DeserializeStaticSiteCustomDomainOverviewData(e)), _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, "StaticSiteCustomDomainOverviewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<NullableResponse<StaticSiteCustomDomainOverviewResource>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteCustomDomainOverviewResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual NullableResponse<StaticSiteCustomDomainOverviewResource> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteCustomDomainOverviewResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteCustomDomainOverviewResource> IEnumerable<StaticSiteCustomDomainOverviewResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteCustomDomainOverviewResource> IAsyncEnumerable<StaticSiteCustomDomainOverviewResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
