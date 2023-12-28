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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformApiPortalCustomDomainResource"/> and their operations.
    /// Each <see cref="AppPlatformApiPortalCustomDomainResource"/> in the collection will belong to the same instance of <see cref="AppPlatformApiPortalResource"/>.
    /// To get an <see cref="AppPlatformApiPortalCustomDomainCollection"/> instance call the GetAppPlatformApiPortalCustomDomains method from an instance of <see cref="AppPlatformApiPortalResource"/>.
    /// </summary>
    public partial class AppPlatformApiPortalCustomDomainCollection : ArmCollection, IEnumerable<AppPlatformApiPortalCustomDomainResource>, IAsyncEnumerable<AppPlatformApiPortalCustomDomainResource>
    {
        private readonly ClientDiagnostics _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics;
        private readonly ApiPortalCustomDomainsRestOperations _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformApiPortalCustomDomainCollection"/> class for mocking. </summary>
        protected AppPlatformApiPortalCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformApiPortalCustomDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformApiPortalCustomDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformApiPortalCustomDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformApiPortalCustomDomainResource.ResourceType, out string appPlatformApiPortalCustomDomainApiPortalCustomDomainsApiVersion);
            _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient = new ApiPortalCustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformApiPortalCustomDomainApiPortalCustomDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformApiPortalResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformApiPortalResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the API portal custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="data"> The API portal custom domain for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformApiPortalCustomDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, AppPlatformApiPortalCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformApiPortalCustomDomainResource>(new AppPlatformApiPortalCustomDomainOperationSource(Client), _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics, Pipeline, _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the API portal custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="data"> The API portal custom domain for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformApiPortalCustomDomainResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, AppPlatformApiPortalCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformApiPortalCustomDomainResource>(new AppPlatformApiPortalCustomDomainOperationSource(Client), _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics, Pipeline, _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the API portal custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformApiPortalCustomDomainResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the API portal custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppPlatformApiPortalCustomDomainResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handle requests to list all API portal custom domains.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformApiPortalCustomDomainResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformApiPortalCustomDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformApiPortalCustomDomainResource(Client, AppPlatformApiPortalCustomDomainData.DeserializeAppPlatformApiPortalCustomDomainData(e)), _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics, Pipeline, "AppPlatformApiPortalCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handle requests to list all API portal custom domains.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformApiPortalCustomDomainResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformApiPortalCustomDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformApiPortalCustomDomainResource(Client, AppPlatformApiPortalCustomDomainData.DeserializeAppPlatformApiPortalCustomDomainData(e)), _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics, Pipeline, "AppPlatformApiPortalCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppPlatformApiPortalCustomDomainResource>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformApiPortalCustomDomainResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalCustomDomainResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortalCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/apiPortals/domains</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the API portal custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual NullableResponse<AppPlatformApiPortalCustomDomainResource> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsClientDiagnostics.CreateScope("AppPlatformApiPortalCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalCustomDomainApiPortalCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformApiPortalCustomDomainResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformApiPortalCustomDomainResource> IEnumerable<AppPlatformApiPortalCustomDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformApiPortalCustomDomainResource> IAsyncEnumerable<AppPlatformApiPortalCustomDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
