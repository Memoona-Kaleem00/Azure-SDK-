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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of HubIpConfiguration and their operations over a VirtualHub. </summary>
    public partial class HubIpConfigurationContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="HubIpConfigurationContainer"/> class for mocking. </summary>
        protected HubIpConfigurationContainer()
        {
        }

        /// <summary> Initializes a new instance of HubIpConfigurationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal HubIpConfigurationContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualHubIpConfigurationRestOperations _restClient => new VirtualHubIpConfigurationRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualHubOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<HubIpConfiguration> CreateOrUpdate(string ipConfigName, HubIpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(ipConfigName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<HubIpConfiguration>> CreateOrUpdateAsync(string ipConfigName, HubIpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(ipConfigName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualHubIpConfigurationCreateOrUpdateOperation StartCreateOrUpdate(string ipConfigName, HubIpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, ipConfigName, parameters, cancellationToken);
                return new VirtualHubIpConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, ipConfigName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualHubIpConfigurationCreateOrUpdateOperation> StartCreateOrUpdateAsync(string ipConfigName, HubIpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, ipConfigName, parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualHubIpConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, ipConfigName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<HubIpConfiguration> Get(string ipConfigName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.Get");
            scope.Start();
            try
            {
                if (ipConfigName == null)
                {
                    throw new ArgumentNullException(nameof(ipConfigName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubIpConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<HubIpConfiguration>> GetAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.Get");
            scope.Start();
            try
            {
                if (ipConfigName == null)
                {
                    throw new ArgumentNullException(nameof(ipConfigName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HubIpConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<HubIpConfiguration> GetIfExists(string ipConfigName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (ipConfigName == null)
                {
                    throw new ArgumentNullException(nameof(ipConfigName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<HubIpConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new HubIpConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<HubIpConfiguration>> GetIfExistsAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (ipConfigName == null)
                {
                    throw new ArgumentNullException(nameof(ipConfigName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<HubIpConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new HubIpConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string ipConfigName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (ipConfigName == null)
                {
                    throw new ArgumentNullException(nameof(ipConfigName));
                }

                var response = GetIfExists(ipConfigName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (ipConfigName == null)
                {
                    throw new ArgumentNullException(nameof(ipConfigName));
                }

                var response = await GetIfExistsAsync(ipConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all VirtualHubIpConfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubIpConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<HubIpConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HubIpConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubIpConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all VirtualHubIpConfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubIpConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<HubIpConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HubIpConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubIpConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="HubIpConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(HubIpConfigurationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="HubIpConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubIpConfigurationContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(HubIpConfigurationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, HubIpConfiguration, HubIpConfigurationData> Construct() { }
    }
}
