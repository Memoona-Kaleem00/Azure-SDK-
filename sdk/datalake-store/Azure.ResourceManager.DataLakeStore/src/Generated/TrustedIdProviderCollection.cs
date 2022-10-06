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
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A class representing a collection of <see cref="TrustedIdProviderResource" /> and their operations.
    /// Each <see cref="TrustedIdProviderResource" /> in the collection will belong to the same instance of <see cref="DataLakeStoreAccountResource" />.
    /// To get a <see cref="TrustedIdProviderCollection" /> instance call the GetTrustedIdProviders method from an instance of <see cref="DataLakeStoreAccountResource" />.
    /// </summary>
    public partial class TrustedIdProviderCollection : ArmCollection, IEnumerable<TrustedIdProviderResource>, IAsyncEnumerable<TrustedIdProviderResource>
    {
        private readonly ClientDiagnostics _trustedIdProviderClientDiagnostics;
        private readonly TrustedIdProvidersRestOperations _trustedIdProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="TrustedIdProviderCollection"/> class for mocking. </summary>
        protected TrustedIdProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TrustedIdProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TrustedIdProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _trustedIdProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", TrustedIdProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TrustedIdProviderResource.ResourceType, out string trustedIdProviderApiVersion);
            _trustedIdProviderRestClient = new TrustedIdProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, trustedIdProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeStoreAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeStoreAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified trusted identity provider. During update, the trusted identity provider with the specified name will be replaced with this new provider
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="content"> Parameters supplied to create or replace the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<TrustedIdProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string trustedIdProviderName, TrustedIdProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _trustedIdProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeStoreArmOperation<TrustedIdProviderResource>(Response.FromValue(new TrustedIdProviderResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
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
        /// Creates or updates the specified trusted identity provider. During update, the trusted identity provider with the specified name will be replaced with this new provider
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="content"> Parameters supplied to create or replace the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<TrustedIdProviderResource> CreateOrUpdate(WaitUntil waitUntil, string trustedIdProviderName, TrustedIdProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _trustedIdProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, content, cancellationToken);
                var operation = new DataLakeStoreArmOperation<TrustedIdProviderResource>(Response.FromValue(new TrustedIdProviderResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
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
        /// Gets the specified Data Lake Store trusted identity provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_Get
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual async Task<Response<TrustedIdProviderResource>> GetAsync(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _trustedIdProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrustedIdProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store trusted identity provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_Get
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual Response<TrustedIdProviderResource> Get(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _trustedIdProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrustedIdProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders
        /// Operation Id: TrustedIdProviders_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TrustedIdProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TrustedIdProviderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TrustedIdProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _trustedIdProviderRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TrustedIdProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TrustedIdProviderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _trustedIdProviderRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TrustedIdProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders
        /// Operation Id: TrustedIdProviders_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TrustedIdProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TrustedIdProviderResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TrustedIdProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _trustedIdProviderRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TrustedIdProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TrustedIdProviderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _trustedIdProviderRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TrustedIdProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_Get
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _trustedIdProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_Get
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual Response<bool> Exists(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _trustedIdProviderClientDiagnostics.CreateScope("TrustedIdProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _trustedIdProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TrustedIdProviderResource> IEnumerable<TrustedIdProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TrustedIdProviderResource> IAsyncEnumerable<TrustedIdProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
