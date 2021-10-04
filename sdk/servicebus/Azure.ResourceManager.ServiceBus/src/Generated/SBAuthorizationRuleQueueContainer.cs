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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of SBAuthorizationRuleQueue and their operations over a SBQueue. </summary>
    public partial class SBAuthorizationRuleQueueContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly QueueAuthorizationRulesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="SBAuthorizationRuleQueueContainer"/> class for mocking. </summary>
        protected SBAuthorizationRuleQueueContainer()
        {
        }

        /// <summary> Initializes a new instance of SBAuthorizationRuleQueueContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SBAuthorizationRuleQueueContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new QueueAuthorizationRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SBQueue.ResourceType;

        // Container level operations.

        /// <summary> Creates an authorization rule for a queue. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access authorization rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual QueueAuthorizationRuleCreateOrUpdateOperation CreateOrUpdate(string authorizationRuleName, SBAuthorizationRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, parameters, cancellationToken);
                var operation = new QueueAuthorizationRuleCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates an authorization rule for a queue. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access authorization rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<QueueAuthorizationRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string authorizationRuleName, SBAuthorizationRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new QueueAuthorizationRuleCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SBAuthorizationRuleQueue> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.Get");
            scope.Start();
            try
            {
                if (authorizationRuleName == null)
                {
                    throw new ArgumentNullException(nameof(authorizationRuleName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBAuthorizationRuleQueue(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SBAuthorizationRuleQueue>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.Get");
            scope.Start();
            try
            {
                if (authorizationRuleName == null)
                {
                    throw new ArgumentNullException(nameof(authorizationRuleName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SBAuthorizationRuleQueue(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SBAuthorizationRuleQueue> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.GetIfExists");
            scope.Start();
            try
            {
                if (authorizationRuleName == null)
                {
                    throw new ArgumentNullException(nameof(authorizationRuleName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SBAuthorizationRuleQueue>(null, response.GetRawResponse())
                    : Response.FromValue(new SBAuthorizationRuleQueue(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SBAuthorizationRuleQueue>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.GetIfExists");
            scope.Start();
            try
            {
                if (authorizationRuleName == null)
                {
                    throw new ArgumentNullException(nameof(authorizationRuleName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SBAuthorizationRuleQueue>(null, response.GetRawResponse())
                    : Response.FromValue(new SBAuthorizationRuleQueue(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (authorizationRuleName == null)
                {
                    throw new ArgumentNullException(nameof(authorizationRuleName));
                }

                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (authorizationRuleName == null)
                {
                    throw new ArgumentNullException(nameof(authorizationRuleName));
                }

                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all authorization rules for a queue. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SBAuthorizationRuleQueue" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SBAuthorizationRuleQueue> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SBAuthorizationRuleQueue> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBAuthorizationRuleQueue(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SBAuthorizationRuleQueue> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBAuthorizationRuleQueue(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all authorization rules for a queue. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SBAuthorizationRuleQueue" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SBAuthorizationRuleQueue> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SBAuthorizationRuleQueue>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBAuthorizationRuleQueue(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SBAuthorizationRuleQueue>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBAuthorizationRuleQueueContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBAuthorizationRuleQueue(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, SBAuthorizationRuleQueue, SBAuthorizationRuleData> Construct() { }
    }
}
