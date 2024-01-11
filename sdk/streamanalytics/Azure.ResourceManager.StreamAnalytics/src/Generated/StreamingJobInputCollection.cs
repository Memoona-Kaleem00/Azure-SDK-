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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingJobInputResource"/> and their operations.
    /// Each <see cref="StreamingJobInputResource"/> in the collection will belong to the same instance of <see cref="StreamingJobResource"/>.
    /// To get a <see cref="StreamingJobInputCollection"/> instance call the GetStreamingJobInputs method from an instance of <see cref="StreamingJobResource"/>.
    /// </summary>
    public partial class StreamingJobInputCollection : ArmCollection, IEnumerable<StreamingJobInputResource>, IAsyncEnumerable<StreamingJobInputResource>
    {
        private readonly ClientDiagnostics _streamingJobInputInputsClientDiagnostics;
        private readonly InputsRestOperations _streamingJobInputInputsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingJobInputCollection"/> class for mocking. </summary>
        protected StreamingJobInputCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobInputCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingJobInputCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobInputInputsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", StreamingJobInputResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingJobInputResource.ResourceType, out string streamingJobInputInputsApiVersion);
            _streamingJobInputInputsRestClient = new InputsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobInputInputsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StreamingJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StreamingJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an input or replaces an already existing input under an existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="input"> The definition of the input that will be used to create a new input or replace the existing one under the streaming job. </param>
        /// <param name="ifMatch"> The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new input to be created, but to prevent updating an existing input. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> or <paramref name="input"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingJobInputResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inputName, StreamingJobInputData input, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, input, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var uri = _streamingJobInputInputsRestClient.CreateCreateOrReplaceRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, input, ifMatch, ifNoneMatch);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new StreamAnalyticsArmOperation<StreamingJobInputResource>(Response.FromValue(new StreamingJobInputResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Creates an input or replaces an already existing input under an existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="input"> The definition of the input that will be used to create a new input or replace the existing one under the streaming job. </param>
        /// <param name="ifMatch"> The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new input to be created, but to prevent updating an existing input. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> or <paramref name="input"/> is null. </exception>
        public virtual ArmOperation<StreamingJobInputResource> CreateOrUpdate(WaitUntil waitUntil, string inputName, StreamingJobInputData input, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, input, ifMatch, ifNoneMatch, cancellationToken);
                var uri = _streamingJobInputInputsRestClient.CreateCreateOrReplaceRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, input, ifMatch, ifNoneMatch);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new StreamAnalyticsArmOperation<StreamingJobInputResource>(Response.FromValue(new StreamingJobInputResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Gets details about the specified input.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> is null. </exception>
        public virtual async Task<Response<StreamingJobInputResource>> GetAsync(string inputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified input.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> is null. </exception>
        public virtual Response<StreamingJobInputResource> Get(string inputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the inputs under the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_ListByStreamingJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="select"> The $select OData query parameter. This is a comma-separated list of structural properties to include in the response, or "*" to include all properties. By default, all properties are returned except diagnostics. Currently only accepts '*' as a valid value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingJobInputResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingJobInputResource> GetAllAsync(string select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobInputInputsRestClient.CreateListByStreamingJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobInputInputsRestClient.CreateListByStreamingJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamingJobInputResource(Client, StreamingJobInputData.DeserializeStreamingJobInputData(e)), _streamingJobInputInputsClientDiagnostics, Pipeline, "StreamingJobInputCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the inputs under the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_ListByStreamingJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="select"> The $select OData query parameter. This is a comma-separated list of structural properties to include in the response, or "*" to include all properties. By default, all properties are returned except diagnostics. Currently only accepts '*' as a valid value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingJobInputResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingJobInputResource> GetAll(string select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobInputInputsRestClient.CreateListByStreamingJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobInputInputsRestClient.CreateListByStreamingJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamingJobInputResource(Client, StreamingJobInputData.DeserializeStreamingJobInputData(e)), _streamingJobInputInputsClientDiagnostics, Pipeline, "StreamingJobInputCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> is null. </exception>
        public virtual Response<bool> Exists(string inputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> is null. </exception>
        public virtual async Task<NullableResponse<StreamingJobInputResource>> GetIfExistsAsync(string inputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StreamingJobInputResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inputName"> The name of the input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inputName"/> is null. </exception>
        public virtual NullableResponse<StreamingJobInputResource> GetIfExists(string inputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputName, nameof(inputName));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inputName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StreamingJobInputResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingJobInputResource> IEnumerable<StreamingJobInputResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingJobInputResource> IAsyncEnumerable<StreamingJobInputResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
