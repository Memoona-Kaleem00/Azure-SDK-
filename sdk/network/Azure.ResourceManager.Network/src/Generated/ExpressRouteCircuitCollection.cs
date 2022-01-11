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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCircuit and their operations over its parent. </summary>
    public partial class ExpressRouteCircuitCollection : ArmCollection, IEnumerable<ExpressRouteCircuit>, IAsyncEnumerable<ExpressRouteCircuit>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExpressRouteCircuitsRestOperations _expressRouteCircuitsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitCollection()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteCircuitCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _expressRouteCircuitsRestClient = new ExpressRouteCircuitsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates an express route circuit. </summary>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="parameters"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ExpressRouteCircuitCreateOrUpdateOperation CreateOrUpdate(string circuitName, ExpressRouteCircuitData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters, cancellationToken);
                var operation = new ExpressRouteCircuitCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters).Request, response);
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

        /// <summary> Creates or updates an express route circuit. </summary>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="parameters"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ExpressRouteCircuitCreateOrUpdateOperation> CreateOrUpdateAsync(string circuitName, ExpressRouteCircuitData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters).Request, response);
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

        /// <summary> Gets information about the specified express route circuit. </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuit> Get(string circuitName, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuit(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified express route circuit. </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuit>> GetAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuit(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuit> GetIfExists(string circuitName, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCircuit>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCircuit(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuit>> GetIfExistsAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCircuit>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCircuit(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<bool> Exists(string circuitName, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(circuitName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(circuitName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the express route circuits in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuit" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuit> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuit> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuit> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the express route circuits in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuit" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuit> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuit>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuit>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ExpressRouteCircuit" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteCircuit.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExpressRouteCircuit" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteCircuit.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuit> IEnumerable<ExpressRouteCircuit>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuit> IAsyncEnumerable<ExpressRouteCircuit>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ExpressRouteCircuit, ExpressRouteCircuitData> Construct() { }
    }
}
