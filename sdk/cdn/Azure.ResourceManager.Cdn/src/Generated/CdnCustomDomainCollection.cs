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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of CdnCustomDomain and their operations over its parent. </summary>
    public partial class CdnCustomDomainCollection : ArmCollection, IEnumerable<CdnCustomDomain>, IAsyncEnumerable<CdnCustomDomain>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CdnCustomDomainsRestOperations _cdnCustomDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnCustomDomainCollection"/> class for mocking. </summary>
        protected CdnCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnCustomDomainCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CdnCustomDomainCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CdnCustomDomain.ResourceType, out string apiVersion);
            _cdnCustomDomainsRestClient = new CdnCustomDomainsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CdnEndpoint.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CdnEndpoint.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new custom domain within an endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="customDomainProperties"> Properties required to create a new custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="customDomainProperties"/> is null. </exception>
        public virtual CdnCustomDomainCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string customDomainName, CustomDomainOptions customDomainProperties, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }
            if (customDomainProperties == null)
            {
                throw new ArgumentNullException(nameof(customDomainProperties));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnCustomDomainsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, customDomainProperties, cancellationToken);
                var operation = new CdnCustomDomainCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnCustomDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, customDomainProperties).Request, response);
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

        /// <summary> Creates a new custom domain within an endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="customDomainProperties"> Properties required to create a new custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="customDomainProperties"/> is null. </exception>
        public async virtual Task<CdnCustomDomainCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string customDomainName, CustomDomainOptions customDomainProperties, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }
            if (customDomainProperties == null)
            {
                throw new ArgumentNullException(nameof(customDomainProperties));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnCustomDomainsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, customDomainProperties, cancellationToken).ConfigureAwait(false);
                var operation = new CdnCustomDomainCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnCustomDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, customDomainProperties).Request, response);
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

        /// <summary> Gets an existing custom domain within an endpoint. </summary>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<CdnCustomDomain> Get(string customDomainName, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing custom domain within an endpoint. </summary>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public async virtual Task<Response<CdnCustomDomain>> GetAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CdnCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<CdnCustomDomain> GetIfExists(string customDomainName, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CdnCustomDomain>(null, response.GetRawResponse());
                return Response.FromValue(new CdnCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public async virtual Task<Response<CdnCustomDomain>> GetIfExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cdnCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CdnCustomDomain>(null, response.GetRawResponse());
                return Response.FromValue(new CdnCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<bool> Exists(string customDomainName, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(customDomainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the custom domain within an endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing custom domains within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnCustomDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnCustomDomain> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CdnCustomDomain> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnCustomDomainsRestClient.ListByEndpoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CdnCustomDomain> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnCustomDomainsRestClient.ListByEndpointNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing custom domains within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnCustomDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnCustomDomain> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CdnCustomDomain>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnCustomDomainsRestClient.ListByEndpointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CdnCustomDomain>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnCustomDomainsRestClient.ListByEndpointNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CdnCustomDomain> IEnumerable<CdnCustomDomain>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnCustomDomain> IAsyncEnumerable<CdnCustomDomain>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CdnCustomDomain, CdnCustomDomainData> Construct() { }
    }
}
