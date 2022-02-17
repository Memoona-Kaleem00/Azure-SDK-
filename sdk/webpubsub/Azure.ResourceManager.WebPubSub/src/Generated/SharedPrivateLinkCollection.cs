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

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing collection of SharedPrivateLink and their operations over its parent. </summary>
    public partial class SharedPrivateLinkCollection : ArmCollection, IEnumerable<SharedPrivateLink>, IAsyncEnumerable<SharedPrivateLink>
    {
        private readonly ClientDiagnostics _sharedPrivateLinkClientDiagnostics;
        private readonly SharedPrivateLinksRestOperations _sharedPrivateLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkCollection"/> class for mocking. </summary>
        protected SharedPrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedPrivateLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedPrivateLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WebPubSub", SharedPrivateLink.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SharedPrivateLink.ResourceType, out string sharedPrivateLinkApiVersion);
            _sharedPrivateLinkRestClient = new SharedPrivateLinksRestOperations(_sharedPrivateLinkClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sharedPrivateLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebPubSub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebPubSub.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="parameters"> The shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SharedPrivateLink>> CreateOrUpdateAsync(bool waitForCompletion, string sharedPrivateLinkName, SharedPrivateLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubArmOperation<SharedPrivateLink>(new SharedPrivateLinkOperationSource(Client), _sharedPrivateLinkClientDiagnostics, Pipeline, _sharedPrivateLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Create or update a shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="parameters"> The shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SharedPrivateLink> CreateOrUpdate(bool waitForCompletion, string sharedPrivateLinkName, SharedPrivateLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters, cancellationToken);
                var operation = new WebPubSubArmOperation<SharedPrivateLink>(new SharedPrivateLinkOperationSource(Client), _sharedPrivateLinkClientDiagnostics, Pipeline, _sharedPrivateLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Get the specified shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_Get
        /// </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> is null. </exception>
        public async virtual Task<Response<SharedPrivateLink>> GetAsync(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sharedPrivateLinkClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SharedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_Get
        /// </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> is null. </exception>
        public virtual Response<SharedPrivateLink> Get(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken);
                if (response.Value == null)
                    throw _sharedPrivateLinkClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared private link resources
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources
        /// Operation Id: SharedPrivateLinks_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedPrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedPrivateLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedPrivateLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedPrivateLinkRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedPrivateLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedPrivateLinkRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List shared private link resources
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources
        /// Operation Id: SharedPrivateLinks_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedPrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedPrivateLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SharedPrivateLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedPrivateLinkRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedPrivateLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedPrivateLinkRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_Get
        /// </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sharedPrivateLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_Get
        /// </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sharedPrivateLinkName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_Get
        /// </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> is null. </exception>
        public async virtual Task<Response<SharedPrivateLink>> GetIfExistsAsync(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SharedPrivateLink>(null, response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkName}
        /// Operation Id: SharedPrivateLinks_Get
        /// </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkName"/> is null. </exception>
        public virtual Response<SharedPrivateLink> GetIfExists(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkName, nameof(sharedPrivateLinkName));

            using var scope = _sharedPrivateLinkClientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SharedPrivateLink>(null, response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedPrivateLink> IEnumerable<SharedPrivateLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedPrivateLink> IAsyncEnumerable<SharedPrivateLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
