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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of Route and their operations over its parent. </summary>
    public partial class RouteCollection : ArmCollection, IEnumerable<Route>, IAsyncEnumerable<Route>
    {
        private readonly ClientDiagnostics _routeClientDiagnostics;
        private readonly RoutesRestOperations _routeRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteCollection"/> class for mocking. </summary>
        protected RouteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RouteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RouteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", Route.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(Route.ResourceType, out string routeApiVersion);
            _routeRestClient = new RoutesRestOperations(_routeClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, routeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RouteTable.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RouteTable.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="routeParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<Route>> CreateOrUpdateAsync(bool waitForCompletion, string routeName, RouteData routeParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<Route>(new RouteOperationSource(Client), _routeClientDiagnostics, Pipeline, _routeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="routeParameters"/> is null. </exception>
        public virtual ArmOperation<Route> CreateOrUpdate(bool waitForCompletion, string routeName, RouteData routeParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters, cancellationToken);
                var operation = new NetworkArmOperation<Route>(new RouteOperationSource(Client), _routeClientDiagnostics, Pipeline, _routeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<Route>> GetAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _routeClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Route(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<Route> Get(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.Get");
            scope.Start();
            try
            {
                var response = _routeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken);
                if (response.Value == null)
                    throw _routeClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Route(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Route> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Route>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Route>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Route> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Route> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Route> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<Route>> GetIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Route>(null, response.GetRawResponse());
                return Response.FromValue(new Route(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<Route> GetIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _routeClientDiagnostics.CreateScope("RouteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Route>(null, response.GetRawResponse());
                return Response.FromValue(new Route(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Route> IEnumerable<Route>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Route> IAsyncEnumerable<Route>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
