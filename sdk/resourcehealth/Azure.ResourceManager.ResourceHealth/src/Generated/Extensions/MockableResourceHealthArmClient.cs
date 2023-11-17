// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceHealth;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableResourceHealthArmClient : ArmResource
    {
        private ClientDiagnostics _availabilityStatusesClientDiagnostics;
        private AvailabilityStatusesRestOperations _availabilityStatusesRestClient;
        private ClientDiagnostics _eventsClientDiagnostics;
        private EventsRestOperations _eventsRestClient;
        private ClientDiagnostics _childAvailabilityStatusesClientDiagnostics;
        private ChildAvailabilityStatusesRestOperations _childAvailabilityStatusesRestClient;
        private ClientDiagnostics _childResourcesClientDiagnostics;
        private ChildResourcesRestOperations _childResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableResourceHealthArmClient"/> class for mocking. </summary>
        protected MockableResourceHealthArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourceHealthArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourceHealthArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableResourceHealthArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private ClientDiagnostics AvailabilityStatusesClientDiagnostics => _availabilityStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailabilityStatusesRestOperations AvailabilityStatusesRestClient => _availabilityStatusesRestClient ??= new AvailabilityStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics EventsClientDiagnostics => _eventsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private EventsRestOperations EventsRestClient => _eventsRestClient ??= new EventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ChildAvailabilityStatusesClientDiagnostics => _childAvailabilityStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ChildAvailabilityStatusesRestOperations ChildAvailabilityStatusesRestClient => _childAvailabilityStatusesRestClient ??= new ChildAvailabilityStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ChildResourcesClientDiagnostics => _childResourcesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ChildResourcesRestOperations ChildResourcesRestClient => _childResourcesRestClient ??= new ChildResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets current availability status for a single resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/availabilityStatuses/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_GetByResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual async Task<Response<ResourceHealthAvailabilityStatus>> GetAvailabilityStatusAsync(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var scope0 = AvailabilityStatusesClientDiagnostics.CreateScope("MockableResourceHealthArmClient.GetAvailabilityStatus");
            scope0.Start();
            try
            {
                var response = await AvailabilityStatusesRestClient.GetByResourceAsync(scope, filter, expand, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets current availability status for a single resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/availabilityStatuses/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_GetByResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual Response<ResourceHealthAvailabilityStatus> GetAvailabilityStatus(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var scope0 = AvailabilityStatusesClientDiagnostics.CreateScope("MockableResourceHealthArmClient.GetAvailabilityStatus");
            scope0.Start();
            try
            {
                var response = AvailabilityStatusesRestClient.GetByResource(scope, filter, expand, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all historical availability transitions and impacting events for a single resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/availabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesAsync(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailabilityStatusesRestClient.CreateListRequest(scope, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailabilityStatusesRestClient.CreateListNextPageRequest(nextLink, scope, filter, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, AvailabilityStatusesClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetAvailabilityStatuses", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all historical availability transitions and impacting events for a single resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/availabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatuses(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailabilityStatusesRestClient.CreateListRequest(scope, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailabilityStatusesRestClient.CreateListNextPageRequest(nextLink, scope, filter, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, AvailabilityStatusesClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetAvailabilityStatuses", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists current service health events for given resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListBySingleResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceHealthEventData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthEventData> GetHealthEventsOfSingleResourceAsync(ResourceIdentifier scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => EventsRestClient.CreateListBySingleResourceRequest(scope, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EventsRestClient.CreateListBySingleResourceNextPageRequest(nextLink, scope, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthEventData.DeserializeResourceHealthEventData, EventsClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetHealthEventsOfSingleResource", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists current service health events for given resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListBySingleResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceHealthEventData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthEventData> GetHealthEventsOfSingleResource(ResourceIdentifier scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => EventsRestClient.CreateListBySingleResourceRequest(scope, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EventsRestClient.CreateListBySingleResourceNextPageRequest(nextLink, scope, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthEventData.DeserializeResourceHealthEventData, EventsClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetHealthEventsOfSingleResource", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets current availability status for a single resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/childAvailabilityStatuses/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChildAvailabilityStatuses_GetByResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual async Task<Response<ResourceHealthAvailabilityStatus>> GetAvailabilityStatusOfChildResourceAsync(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var scope0 = ChildAvailabilityStatusesClientDiagnostics.CreateScope("MockableResourceHealthArmClient.GetAvailabilityStatusOfChildResource");
            scope0.Start();
            try
            {
                var response = await ChildAvailabilityStatusesRestClient.GetByResourceAsync(scope, filter, expand, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets current availability status for a single resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/childAvailabilityStatuses/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChildAvailabilityStatuses_GetByResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual Response<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResource(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var scope0 = ChildAvailabilityStatusesClientDiagnostics.CreateScope("MockableResourceHealthArmClient.GetAvailabilityStatusOfChildResource");
            scope0.Start();
            try
            {
                var response = ChildAvailabilityStatusesRestClient.GetByResource(scope, filter, expand, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the historical availability statuses for a single child resource. Use the nextLink property in the response to get the next page of availability status
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/childAvailabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChildAvailabilityStatuses_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetHistoricalAvailabilityStatusesOfChildResourceAsync(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ChildAvailabilityStatusesRestClient.CreateListRequest(scope, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ChildAvailabilityStatusesRestClient.CreateListNextPageRequest(nextLink, scope, filter, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, ChildAvailabilityStatusesClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetHistoricalAvailabilityStatusesOfChildResource", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the historical availability statuses for a single child resource. Use the nextLink property in the response to get the next page of availability status
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/childAvailabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChildAvailabilityStatuses_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetHistoricalAvailabilityStatusesOfChildResource(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ChildAvailabilityStatusesRestClient.CreateListRequest(scope, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ChildAvailabilityStatusesRestClient.CreateListNextPageRequest(nextLink, scope, filter, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, ChildAvailabilityStatusesClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetHistoricalAvailabilityStatusesOfChildResource", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the all the children and its current health status for a parent resource. Use the nextLink property in the response to get the next page of children current health
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/childResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChildResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResourcesAsync(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ChildResourcesRestClient.CreateListRequest(scope, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ChildResourcesRestClient.CreateListNextPageRequest(nextLink, scope, filter, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, ChildResourcesClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetAvailabilityStatusOfChildResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the all the children and its current health status for a parent resource. Use the nextLink property in the response to get the next page of children current health
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ResourceHealth/childResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChildResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResources(ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ChildResourcesRestClient.CreateListRequest(scope, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ChildResourcesRestClient.CreateListNextPageRequest(nextLink, scope, filter, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, ChildResourcesClientDiagnostics, Pipeline, "MockableResourceHealthArmClient.GetAvailabilityStatusOfChildResources", "value", "nextLink", cancellationToken);
        }
        /// <summary>
        /// Gets an object representing a <see cref="ResourceHealthMetadataEntityResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceHealthMetadataEntityResource.CreateResourceIdentifier" /> to create a <see cref="ResourceHealthMetadataEntityResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceHealthMetadataEntityResource" /> object. </returns>
        public virtual ResourceHealthMetadataEntityResource GetResourceHealthMetadataEntityResource(ResourceIdentifier id)
        {
            ResourceHealthMetadataEntityResource.ValidateResourceId(id);
            return new ResourceHealthMetadataEntityResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceHealthEventImpactedResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceHealthEventImpactedResource.CreateResourceIdentifier" /> to create a <see cref="ResourceHealthEventImpactedResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceHealthEventImpactedResource" /> object. </returns>
        public virtual ResourceHealthEventImpactedResource GetResourceHealthEventImpactedResource(ResourceIdentifier id)
        {
            ResourceHealthEventImpactedResource.ValidateResourceId(id);
            return new ResourceHealthEventImpactedResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TenantResourceHealthEventImpactedResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantResourceHealthEventImpactedResource.CreateResourceIdentifier" /> to create a <see cref="TenantResourceHealthEventImpactedResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantResourceHealthEventImpactedResource" /> object. </returns>
        public virtual TenantResourceHealthEventImpactedResource GetTenantResourceHealthEventImpactedResource(ResourceIdentifier id)
        {
            TenantResourceHealthEventImpactedResource.ValidateResourceId(id);
            return new TenantResourceHealthEventImpactedResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceHealthEventResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceHealthEventResource.CreateResourceIdentifier" /> to create a <see cref="ResourceHealthEventResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceHealthEventResource" /> object. </returns>
        public virtual ResourceHealthEventResource GetResourceHealthEventResource(ResourceIdentifier id)
        {
            ResourceHealthEventResource.ValidateResourceId(id);
            return new ResourceHealthEventResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TenantResourceHealthEventResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantResourceHealthEventResource.CreateResourceIdentifier" /> to create a <see cref="TenantResourceHealthEventResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantResourceHealthEventResource" /> object. </returns>
        public virtual TenantResourceHealthEventResource GetTenantResourceHealthEventResource(ResourceIdentifier id)
        {
            TenantResourceHealthEventResource.ValidateResourceId(id);
            return new TenantResourceHealthEventResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceEmergingIssueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceEmergingIssueResource.CreateResourceIdentifier" /> to create a <see cref="ServiceEmergingIssueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceEmergingIssueResource" /> object. </returns>
        public virtual ServiceEmergingIssueResource GetServiceEmergingIssueResource(ResourceIdentifier id)
        {
            ServiceEmergingIssueResource.ValidateResourceId(id);
            return new ServiceEmergingIssueResource(Client, id);
        }
    }
}
