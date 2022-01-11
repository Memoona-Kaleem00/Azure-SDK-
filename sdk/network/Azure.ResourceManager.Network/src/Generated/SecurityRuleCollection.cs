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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of SecurityRule and their operations over its parent. </summary>
    public partial class SecurityRuleCollection : ArmCollection, IEnumerable<SecurityRule>, IAsyncEnumerable<SecurityRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SecurityRulesRestOperations _securityRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityRuleCollection"/> class for mocking. </summary>
        protected SecurityRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of SecurityRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SecurityRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _securityRulesRestClient = new SecurityRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => NetworkSecurityGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a security rule in the specified network security group. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="securityRuleParameters"> Parameters supplied to the create or update network security rule operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> or <paramref name="securityRuleParameters"/> is null. </exception>
        public virtual SecurityRuleCreateOrUpdateOperation CreateOrUpdate(string securityRuleName, SecurityRuleData securityRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }
            if (securityRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(securityRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, securityRuleParameters, cancellationToken);
                var operation = new SecurityRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _securityRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, securityRuleParameters).Request, response);
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

        /// <summary> Creates or updates a security rule in the specified network security group. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="securityRuleParameters"> Parameters supplied to the create or update network security rule operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> or <paramref name="securityRuleParameters"/> is null. </exception>
        public async virtual Task<SecurityRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string securityRuleName, SecurityRuleData securityRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }
            if (securityRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(securityRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, securityRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _securityRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, securityRuleParameters).Request, response);
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

        /// <summary> Get the specified network security rule. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual Response<SecurityRule> Get(string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _securityRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified network security rule. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public async virtual Task<Response<SecurityRule>> GetAsync(string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SecurityRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual Response<SecurityRule> GetIfExists(string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SecurityRule>(null, response.GetRawResponse())
                    : Response.FromValue(new SecurityRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public async virtual Task<Response<SecurityRule>> GetIfExistsAsync(string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _securityRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SecurityRule>(null, response.GetRawResponse())
                    : Response.FromValue(new SecurityRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(securityRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(securityRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all security rules in a network security group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SecurityRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _securityRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _securityRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all security rules in a network security group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SecurityRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _securityRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _securityRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SecurityRule> IEnumerable<SecurityRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityRule> IAsyncEnumerable<SecurityRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SecurityRule, SecurityRuleData> Construct() { }
    }
}
