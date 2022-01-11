// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of CloudService and their operations over its parent. </summary>
    public partial class CloudServiceCollection : ArmCollection, IEnumerable<CloudService>, IAsyncEnumerable<CloudService>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServicesRestOperations _cloudServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceCollection"/> class for mocking. </summary>
        protected CloudServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CloudServiceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServicesRestClient = new CloudServicesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Create or update a cloud service. Please note some properties can be set only during cloud service creation. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual CloudServiceCreateOrUpdateOperation CreateOrUpdate(string cloudServiceName, CloudServiceData parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters, cancellationToken);
                var operation = new CloudServiceCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _cloudServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters).Request, response);
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

        /// <summary> Create or update a cloud service. Please note some properties can be set only during cloud service creation. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public async virtual Task<CloudServiceCreateOrUpdateOperation> CreateOrUpdateAsync(string cloudServiceName, CloudServiceData parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CloudServiceCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _cloudServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters).Request, response);
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

        /// <summary> Display information about a cloud service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<CloudService> Get(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Display information about a cloud service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public async virtual Task<Response<CloudService>> GetAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CloudService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<CloudService> GetIfExists(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CloudService>(null, response.GetRawResponse())
                    : Response.FromValue(new CloudService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public async virtual Task<Response<CloudService>> GetIfExistsAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _cloudServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CloudService>(null, response.GetRawResponse())
                    : Response.FromValue(new CloudService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(cloudServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CloudService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServicesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CloudService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServicesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CloudService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServicesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CloudService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServicesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="CloudService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CloudService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="CloudService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CloudService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudService> IEnumerable<CloudService>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudService> IAsyncEnumerable<CloudService>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CloudService, CloudServiceData> Construct() { }
    }
}
