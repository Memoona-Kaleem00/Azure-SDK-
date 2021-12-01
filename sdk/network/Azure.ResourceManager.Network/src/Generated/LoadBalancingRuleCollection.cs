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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of LoadBalancingRule and their operations over its parent. </summary>
    public partial class LoadBalancingRuleCollection : ArmCollection, IEnumerable<LoadBalancingRule>, IAsyncEnumerable<LoadBalancingRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LoadBalancerLoadBalancingRulesRestOperations _loadBalancerLoadBalancingRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleCollection"/> class for mocking. </summary>
        protected LoadBalancingRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of LoadBalancingRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal LoadBalancingRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancerLoadBalancingRulesRestClient = new LoadBalancerLoadBalancingRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => LoadBalancer.ResourceType;

        // Collection level operations.

        /// <summary> Gets the specified load balancer load balancing rule. </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<LoadBalancingRule> Get(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            if (loadBalancingRuleName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancingRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer load balancing rule. </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public async virtual Task<Response<LoadBalancingRule>> GetAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            if (loadBalancingRuleName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancingRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancingRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<LoadBalancingRule> GetIfExists(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            if (loadBalancingRuleName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancingRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<LoadBalancingRule>(null, response.GetRawResponse())
                    : Response.FromValue(new LoadBalancingRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public async virtual Task<Response<LoadBalancingRule>> GetIfExistsAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            if (loadBalancingRuleName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancingRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _loadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<LoadBalancingRule>(null, response.GetRawResponse())
                    : Response.FromValue(new LoadBalancingRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            if (loadBalancingRuleName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancingRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(loadBalancingRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            if (loadBalancingRuleName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancingRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(loadBalancingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancing rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancingRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadBalancingRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LoadBalancingRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerLoadBalancingRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancingRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerLoadBalancingRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the load balancing rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancingRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadBalancingRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LoadBalancingRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerLoadBalancingRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancingRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerLoadBalancingRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<LoadBalancingRule> IEnumerable<LoadBalancingRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadBalancingRule> IAsyncEnumerable<LoadBalancingRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, LoadBalancingRule, LoadBalancingRuleData> Construct() { }
    }
}
