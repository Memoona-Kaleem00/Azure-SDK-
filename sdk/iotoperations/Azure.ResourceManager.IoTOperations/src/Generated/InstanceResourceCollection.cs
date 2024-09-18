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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IoTOperations
{
    /// <summary>
    /// A class representing a collection of <see cref="InstanceResource"/> and their operations.
    /// Each <see cref="InstanceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="InstanceResourceCollection"/> instance call the GetInstanceResources method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class InstanceResourceCollection : ArmCollection, IEnumerable<InstanceResource>, IAsyncEnumerable<InstanceResource>
    {
        private readonly ClientDiagnostics _instanceResourceInstanceClientDiagnostics;
        private readonly InstanceRestOperations _instanceResourceInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="InstanceResourceCollection"/> class for mocking. </summary>
        protected InstanceResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InstanceResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal InstanceResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _instanceResourceInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IoTOperations", InstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(InstanceResource.ResourceType, out string instanceResourceInstanceApiVersion);
            _instanceResourceInstanceRestClient = new InstanceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, instanceResourceInstanceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<InstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string instanceName, InstanceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _instanceResourceInstanceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, instanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IoTOperationsArmOperation<InstanceResource>(new InstanceResourceOperationSource(Client), _instanceResourceInstanceClientDiagnostics, Pipeline, _instanceResourceInstanceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, instanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<InstanceResource> CreateOrUpdate(WaitUntil waitUntil, string instanceName, InstanceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _instanceResourceInstanceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, instanceName, data, cancellationToken);
                var operation = new IoTOperationsArmOperation<InstanceResource>(new InstanceResourceOperationSource(Client), _instanceResourceInstanceClientDiagnostics, Pipeline, _instanceResourceInstanceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, instanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual async Task<Response<InstanceResource>> GetAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _instanceResourceInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, instanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<InstanceResource> Get(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _instanceResourceInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, instanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List InstanceResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _instanceResourceInstanceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _instanceResourceInstanceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new InstanceResource(Client, InstanceResourceData.DeserializeInstanceResourceData(e)), _instanceResourceInstanceClientDiagnostics, Pipeline, "InstanceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List InstanceResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _instanceResourceInstanceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _instanceResourceInstanceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new InstanceResource(Client, InstanceResourceData.DeserializeInstanceResourceData(e)), _instanceResourceInstanceClientDiagnostics, Pipeline, "InstanceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _instanceResourceInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, instanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _instanceResourceInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, instanceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<InstanceResource>> GetIfExistsAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _instanceResourceInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, instanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<InstanceResource>(response.GetRawResponse());
                return Response.FromValue(new InstanceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual NullableResponse<InstanceResource> GetIfExists(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _instanceResourceInstanceClientDiagnostics.CreateScope("InstanceResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _instanceResourceInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, instanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<InstanceResource>(response.GetRawResponse());
                return Response.FromValue(new InstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InstanceResource> IEnumerable<InstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InstanceResource> IAsyncEnumerable<InstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
