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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of OSVersion and their operations over its parent. </summary>
    public partial class OSVersionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _cloudServiceOperatingSystemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="OSVersionContainer"/> class for mocking. </summary>
        protected OSVersionContainer()
        {
        }

        /// <summary> Initializes a new instance of OSVersionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OSVersionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Container level operations.

        /// <summary> Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="location"> Name of the location that the OS version pertains to. </param>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<OSVersion> Get(string location, string osVersionName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osVersionName == null)
            {
                throw new ArgumentNullException(nameof(osVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSVersion(location, osVersionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="location"> Name of the location that the OS version pertains to. </param>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osVersionName"/> is null. </exception>
        public async virtual Task<Response<OSVersion>> GetAsync(string location, string osVersionName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osVersionName == null)
            {
                throw new ArgumentNullException(nameof(osVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSVersionAsync(location, osVersionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OSVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS version pertains to. </param>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<OSVersion> GetIfExists(string location, string osVersionName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osVersionName == null)
            {
                throw new ArgumentNullException(nameof(osVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSVersion(location, osVersionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<OSVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new OSVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS version pertains to. </param>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osVersionName"/> is null. </exception>
        public async virtual Task<Response<OSVersion>> GetIfExistsAsync(string location, string osVersionName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osVersionName == null)
            {
                throw new ArgumentNullException(nameof(osVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSVersionAsync(location, osVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<OSVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new OSVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS version pertains to. </param>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string location, string osVersionName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osVersionName == null)
            {
                throw new ArgumentNullException(nameof(osVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, osVersionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS version pertains to. </param>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osVersionName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string location, string osVersionName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osVersionName == null)
            {
                throw new ArgumentNullException(nameof(osVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, osVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all guest operating system versions available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS versions. Do this till nextLink is null to fetch all the OS versions. </summary>
        /// <param name="location"> Name of the location that the OS versions pertain to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OSVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OSVersion> GetAll(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<OSVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.GetOSVersions(location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OSVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.GetOSVersionsNextPage(nextLink, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all guest operating system versions available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS versions. Do this till nextLink is null to fetch all the OS versions. </summary>
        /// <param name="location"> Name of the location that the OS versions pertain to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OSVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OSVersion> GetAllAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<OSVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.GetOSVersionsAsync(location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OSVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.GetOSVersionsNextPageAsync(nextLink, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="OSVersion" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OSVersion.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OSVersion" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OSVersionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OSVersion.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, OSVersion, OSVersionData> Construct() { }
    }
}
