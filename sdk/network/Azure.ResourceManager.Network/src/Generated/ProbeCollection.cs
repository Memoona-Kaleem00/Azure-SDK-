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
    /// <summary> A class representing collection of Probe and their operations over its parent. </summary>
    public partial class ProbeCollection : ArmCollection, IEnumerable<Probe>, IAsyncEnumerable<Probe>
    {
        private readonly ClientDiagnostics _probeLoadBalancerProbesClientDiagnostics;
        private readonly LoadBalancerProbesRestOperations _probeLoadBalancerProbesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProbeCollection"/> class for mocking. </summary>
        protected ProbeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProbeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProbeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _probeLoadBalancerProbesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", Probe.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(Probe.ResourceType, out string probeLoadBalancerProbesApiVersion);
            _probeLoadBalancerProbesRestClient = new LoadBalancerProbesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, probeLoadBalancerProbesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets load balancer probe.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}
        /// Operation Id: LoadBalancerProbes_Get
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual async Task<Response<Probe>> GetAsync(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Get");
            scope.Start();
            try
            {
                var response = await _probeLoadBalancerProbesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Probe(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer probe.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}
        /// Operation Id: LoadBalancerProbes_Get
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual Response<Probe> Get(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Get");
            scope.Start();
            try
            {
                var response = _probeLoadBalancerProbesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Probe(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancer probes.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes
        /// Operation Id: LoadBalancerProbes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Probe" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Probe> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Probe>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _probeLoadBalancerProbesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Probe(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Probe>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _probeLoadBalancerProbesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Probe(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all the load balancer probes.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes
        /// Operation Id: LoadBalancerProbes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Probe" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Probe> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Probe> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _probeLoadBalancerProbesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Probe(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Probe> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _probeLoadBalancerProbesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Probe(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}
        /// Operation Id: LoadBalancerProbes_Get
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(probeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}
        /// Operation Id: LoadBalancerProbes_Get
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual Response<bool> Exists(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(probeName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}
        /// Operation Id: LoadBalancerProbes_Get
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual async Task<Response<Probe>> GetIfExistsAsync(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _probeLoadBalancerProbesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Probe>(null, response.GetRawResponse());
                return Response.FromValue(new Probe(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}
        /// Operation Id: LoadBalancerProbes_Get
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual Response<Probe> GetIfExists(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _probeLoadBalancerProbesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Probe>(null, response.GetRawResponse());
                return Response.FromValue(new Probe(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Probe> IEnumerable<Probe>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Probe> IAsyncEnumerable<Probe>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
