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

namespace Azure.ResourceManager.IoTOperations
{
    /// <summary>
    /// A class representing a collection of <see cref="DataflowEndpointResource"/> and their operations.
    /// Each <see cref="DataflowEndpointResource"/> in the collection will belong to the same instance of <see cref="InstanceResource"/>.
    /// To get a <see cref="DataflowEndpointResourceCollection"/> instance call the GetDataflowEndpointResources method from an instance of <see cref="InstanceResource"/>.
    /// </summary>
    public partial class DataflowEndpointResourceCollection : ArmCollection, IEnumerable<DataflowEndpointResource>, IAsyncEnumerable<DataflowEndpointResource>
    {
        private readonly ClientDiagnostics _dataflowEndpointResourceDataflowEndpointClientDiagnostics;
        private readonly DataflowEndpointRestOperations _dataflowEndpointResourceDataflowEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataflowEndpointResourceCollection"/> class for mocking. </summary>
        protected DataflowEndpointResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataflowEndpointResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataflowEndpointResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataflowEndpointResourceDataflowEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IoTOperations", DataflowEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataflowEndpointResource.ResourceType, out string dataflowEndpointResourceDataflowEndpointApiVersion);
            _dataflowEndpointResourceDataflowEndpointRestClient = new DataflowEndpointRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataflowEndpointResourceDataflowEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != InstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, InstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataflowEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataflowEndpointName, DataflowEndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataflowEndpointResourceDataflowEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IoTOperationsArmOperation<DataflowEndpointResource>(new DataflowEndpointResourceOperationSource(Client), _dataflowEndpointResourceDataflowEndpointClientDiagnostics, Pipeline, _dataflowEndpointResourceDataflowEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataflowEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string dataflowEndpointName, DataflowEndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataflowEndpointResourceDataflowEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data, cancellationToken);
                var operation = new IoTOperationsArmOperation<DataflowEndpointResource>(new DataflowEndpointResourceOperationSource(Client), _dataflowEndpointResourceDataflowEndpointClientDiagnostics, Pipeline, _dataflowEndpointResourceDataflowEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual async Task<Response<DataflowEndpointResource>> GetAsync(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataflowEndpointResourceDataflowEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataflowEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual Response<DataflowEndpointResource> Get(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _dataflowEndpointResourceDataflowEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataflowEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DataflowEndpointResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataflowEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataflowEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataflowEndpointResourceDataflowEndpointRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataflowEndpointResourceDataflowEndpointRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataflowEndpointResource(Client, DataflowEndpointResourceData.DeserializeDataflowEndpointResourceData(e)), _dataflowEndpointResourceDataflowEndpointClientDiagnostics, Pipeline, "DataflowEndpointResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DataflowEndpointResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataflowEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataflowEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataflowEndpointResourceDataflowEndpointRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataflowEndpointResourceDataflowEndpointRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataflowEndpointResource(Client, DataflowEndpointResourceData.DeserializeDataflowEndpointResourceData(e)), _dataflowEndpointResourceDataflowEndpointClientDiagnostics, Pipeline, "DataflowEndpointResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataflowEndpointResourceDataflowEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataflowEndpointResourceDataflowEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataflowEndpointResource>> GetIfExistsAsync(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataflowEndpointResourceDataflowEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataflowEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DataflowEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual NullableResponse<DataflowEndpointResource> GetIfExists(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _dataflowEndpointResourceDataflowEndpointClientDiagnostics.CreateScope("DataflowEndpointResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataflowEndpointResourceDataflowEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataflowEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DataflowEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataflowEndpointResource> IEnumerable<DataflowEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataflowEndpointResource> IAsyncEnumerable<DataflowEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
