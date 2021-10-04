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
    /// <summary> A class representing collection of SBSubscription and their operations over a SBTopic. </summary>
    public partial class SBSubscriptionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubscriptionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionContainer"/> class for mocking. </summary>
        protected SBSubscriptionContainer()
        {
        }

        /// <summary> Initializes a new instance of SBSubscriptionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SBSubscriptionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SubscriptionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SBTopic.ResourceType;

        // Container level operations.

        /// <summary> Creates a topic subscription. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SubscriptionCreateOrUpdateOperation CreateOrUpdate(string subscriptionName, SBSubscriptionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, parameters, cancellationToken);
                var operation = new SubscriptionCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates a topic subscription. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SubscriptionCreateOrUpdateOperation> CreateOrUpdateAsync(string subscriptionName, SBSubscriptionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionCreateOrUpdateOperation(Parent, response);
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
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SBSubscription> Get(string subscriptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.Get");
            scope.Start();
            try
            {
                if (subscriptionName == null)
                {
                    throw new ArgumentNullException(nameof(subscriptionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SBSubscription>> GetAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.Get");
            scope.Start();
            try
            {
                if (subscriptionName == null)
                {
                    throw new ArgumentNullException(nameof(subscriptionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SBSubscription(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SBSubscription> GetIfExists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (subscriptionName == null)
                {
                    throw new ArgumentNullException(nameof(subscriptionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SBSubscription>(null, response.GetRawResponse())
                    : Response.FromValue(new SBSubscription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SBSubscription>> GetIfExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (subscriptionName == null)
                {
                    throw new ArgumentNullException(nameof(subscriptionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SBSubscription>(null, response.GetRawResponse())
                    : Response.FromValue(new SBSubscription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (subscriptionName == null)
                {
                    throw new ArgumentNullException(nameof(subscriptionName));
                }

                var response = GetIfExists(subscriptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (subscriptionName == null)
                {
                    throw new ArgumentNullException(nameof(subscriptionName));
                }

                var response = await GetIfExistsAsync(subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SBSubscription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SBSubscription> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<SBSubscription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByTopic(Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SBSubscription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByTopicNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SBSubscription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SBSubscription> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SBSubscription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByTopicAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SBSubscription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByTopicNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
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
        // public ArmBuilder<ResourceIdentifier, SBSubscription, SBSubscriptionData> Construct() { }
    }
}
