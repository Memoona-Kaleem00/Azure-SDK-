// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchApplicationResource"/> and their operations.
    /// Each <see cref="BatchApplicationResource"/> in the collection will belong to the same instance of <see cref="BatchAccountResource"/>.
    /// To get a <see cref="BatchApplicationCollection"/> instance call the GetBatchApplications method from an instance of <see cref="BatchAccountResource"/>.
    /// </summary>
    public partial class BatchApplicationCollection : ArmCollection, IEnumerable<BatchApplicationResource>, IAsyncEnumerable<BatchApplicationResource>
    {
        private readonly ClientDiagnostics _batchApplicationApplicationClientDiagnostics;
        private readonly ApplicationRestOperations _batchApplicationApplicationRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchApplicationCollection"/> class for mocking. </summary>
        protected BatchApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchApplicationApplicationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchApplicationResource.ResourceType, out string batchApplicationApplicationApiVersion);
            _batchApplicationApplicationRestClient = new ApplicationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchApplicationApplicationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds an application to the specified Batch account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="data"> The parameters for the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationName, BatchApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken).ConfigureAwait(false);
                var uri = _batchApplicationApplicationRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BatchArmOperation<BatchApplicationResource>(Response.FromValue(new BatchApplicationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Adds an application to the specified Batch account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="data"> The parameters for the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BatchApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string applicationName, BatchApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken);
                var uri = _batchApplicationApplicationRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BatchArmOperation<BatchApplicationResource>(Response.FromValue(new BatchApplicationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets information about the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<BatchApplicationResource>> GetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<BatchApplicationResource> Get(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the applications in the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchApplicationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchApplicationResource> GetAllAsync(int? maxresults = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchApplicationApplicationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchApplicationApplicationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchApplicationResource(Client, BatchApplicationData.DeserializeBatchApplicationData(e)), _batchApplicationApplicationClientDiagnostics, Pipeline, "BatchApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the applications in the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchApplicationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchApplicationResource> GetAll(int? maxresults = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchApplicationApplicationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchApplicationApplicationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchApplicationResource(Client, BatchApplicationData.DeserializeBatchApplicationData(e)), _batchApplicationApplicationClientDiagnostics, Pipeline, "BatchApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<NullableResponse<BatchApplicationResource>> GetIfExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BatchApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual NullableResponse<BatchApplicationResource> GetIfExists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BatchApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchApplicationResource> IEnumerable<BatchApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchApplicationResource> IAsyncEnumerable<BatchApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
