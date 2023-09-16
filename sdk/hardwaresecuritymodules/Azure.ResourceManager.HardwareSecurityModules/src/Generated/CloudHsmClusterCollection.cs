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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudHsmClusterResource" /> and their operations.
    /// Each <see cref="CloudHsmClusterResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CloudHsmClusterCollection" /> instance call the GetCloudHsmClusters method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CloudHsmClusterCollection : ArmCollection, IEnumerable<CloudHsmClusterResource>, IAsyncEnumerable<CloudHsmClusterResource>
    {
        private readonly ClientDiagnostics _cloudHsmClusterClientDiagnostics;
        private readonly CloudHsmClustersRestOperations _cloudHsmClusterRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudHsmClusterCollection"/> class for mocking. </summary>
        protected CloudHsmClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudHsmClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudHsmClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudHsmClusterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HardwareSecurityModules", CloudHsmClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudHsmClusterResource.ResourceType, out string cloudHsmClusterApiVersion);
            _cloudHsmClusterRestClient = new CloudHsmClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudHsmClusterApiVersion);
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
        /// Create or Update a Cloud HSM Cluster in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="data"> Parameters to create Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudHsmClusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CloudHsmClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudHsmClusterName, CloudHsmClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudHsmClusterClientDiagnostics.CreateScope("CloudHsmClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudHsmClusterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HardwareSecurityModulesArmOperation<CloudHsmClusterResource>(new CloudHsmClusterOperationSource(Client), _cloudHsmClusterClientDiagnostics, Pipeline, _cloudHsmClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or Update a Cloud HSM Cluster in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="data"> Parameters to create Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudHsmClusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CloudHsmClusterResource> CreateOrUpdate(WaitUntil waitUntil, string cloudHsmClusterName, CloudHsmClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudHsmClusterClientDiagnostics.CreateScope("CloudHsmClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudHsmClusterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, data, cancellationToken);
                var operation = new HardwareSecurityModulesArmOperation<CloudHsmClusterResource>(new CloudHsmClusterOperationSource(Client), _cloudHsmClusterClientDiagnostics, Pipeline, _cloudHsmClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Gets the specified Cloud HSM Cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudHsmClusterName"/> is null. </exception>
        public virtual async Task<Response<CloudHsmClusterResource>> GetAsync(string cloudHsmClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));

            using var scope = _cloudHsmClusterClientDiagnostics.CreateScope("CloudHsmClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudHsmClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudHsmClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Cloud HSM Cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudHsmClusterName"/> is null. </exception>
        public virtual Response<CloudHsmClusterResource> Get(string cloudHsmClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));

            using var scope = _cloudHsmClusterClientDiagnostics.CreateScope("CloudHsmClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudHsmClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudHsmClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription and within the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudHsmClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudHsmClusterResource> GetAllAsync(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudHsmClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudHsmClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudHsmClusterResource(Client, CloudHsmClusterData.DeserializeCloudHsmClusterData(e)), _cloudHsmClusterClientDiagnostics, Pipeline, "CloudHsmClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription and within the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudHsmClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudHsmClusterResource> GetAll(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudHsmClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudHsmClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudHsmClusterResource(Client, CloudHsmClusterData.DeserializeCloudHsmClusterData(e)), _cloudHsmClusterClientDiagnostics, Pipeline, "CloudHsmClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudHsmClusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudHsmClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));

            using var scope = _cloudHsmClusterClientDiagnostics.CreateScope("CloudHsmClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudHsmClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudHsmClusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudHsmClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));

            using var scope = _cloudHsmClusterClientDiagnostics.CreateScope("CloudHsmClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudHsmClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudHsmClusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudHsmClusterResource> IEnumerable<CloudHsmClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudHsmClusterResource> IAsyncEnumerable<CloudHsmClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
