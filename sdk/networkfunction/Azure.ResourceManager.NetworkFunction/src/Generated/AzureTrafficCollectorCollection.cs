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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkFunction
{
    /// <summary>
    /// A class representing a collection of <see cref="AzureTrafficCollectorResource" /> and their operations.
    /// Each <see cref="AzureTrafficCollectorResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AzureTrafficCollectorCollection" /> instance call the GetAzureTrafficCollectors method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AzureTrafficCollectorCollection : ArmCollection, IEnumerable<AzureTrafficCollectorResource>, IAsyncEnumerable<AzureTrafficCollectorResource>
    {
        private readonly ClientDiagnostics _azureTrafficCollectorClientDiagnostics;
        private readonly AzureTrafficCollectorsRestOperations _azureTrafficCollectorRestClient;
        private readonly ClientDiagnostics _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupClientDiagnostics;
        private readonly AzureTrafficCollectorsByResourceGroupRestOperations _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureTrafficCollectorCollection"/> class for mocking. </summary>
        protected AzureTrafficCollectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureTrafficCollectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureTrafficCollectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureTrafficCollectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkFunction", AzureTrafficCollectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureTrafficCollectorResource.ResourceType, out string azureTrafficCollectorApiVersion);
            _azureTrafficCollectorRestClient = new AzureTrafficCollectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureTrafficCollectorApiVersion);
            _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkFunction", AzureTrafficCollectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureTrafficCollectorResource.ResourceType, out string azureTrafficCollectorAzureTrafficCollectorsByResourceGroupApiVersion);
            _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupRestClient = new AzureTrafficCollectorsByResourceGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureTrafficCollectorAzureTrafficCollectorsByResourceGroupApiVersion);
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
        /// Creates or updates a Azure Traffic Collector resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="data"> The parameters to provide for the created Azure Traffic Collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AzureTrafficCollectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string azureTrafficCollectorName, AzureTrafficCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureTrafficCollectorClientDiagnostics.CreateScope("AzureTrafficCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureTrafficCollectorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkFunctionArmOperation<AzureTrafficCollectorResource>(new AzureTrafficCollectorOperationSource(Client), _azureTrafficCollectorClientDiagnostics, Pipeline, _azureTrafficCollectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Azure Traffic Collector resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="data"> The parameters to provide for the created Azure Traffic Collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AzureTrafficCollectorResource> CreateOrUpdate(WaitUntil waitUntil, string azureTrafficCollectorName, AzureTrafficCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureTrafficCollectorClientDiagnostics.CreateScope("AzureTrafficCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureTrafficCollectorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, data, cancellationToken);
                var operation = new NetworkFunctionArmOperation<AzureTrafficCollectorResource>(new AzureTrafficCollectorOperationSource(Client), _azureTrafficCollectorClientDiagnostics, Pipeline, _azureTrafficCollectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified Azure Traffic Collector in a specified resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> is null. </exception>
        public virtual async Task<Response<AzureTrafficCollectorResource>> GetAsync(string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var scope = _azureTrafficCollectorClientDiagnostics.CreateScope("AzureTrafficCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureTrafficCollectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureTrafficCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Traffic Collector in a specified resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> is null. </exception>
        public virtual Response<AzureTrafficCollectorResource> Get(string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var scope = _azureTrafficCollectorClientDiagnostics.CreateScope("AzureTrafficCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = _azureTrafficCollectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureTrafficCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return list of Azure Traffic Collectors in a Resource Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectorsByResourceGroup_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureTrafficCollectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureTrafficCollectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AzureTrafficCollectorResource(Client, AzureTrafficCollectorData.DeserializeAzureTrafficCollectorData(e)), _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupClientDiagnostics, Pipeline, "AzureTrafficCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Return list of Azure Traffic Collectors in a Resource Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectorsByResourceGroup_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureTrafficCollectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureTrafficCollectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AzureTrafficCollectorResource(Client, AzureTrafficCollectorData.DeserializeAzureTrafficCollectorData(e)), _azureTrafficCollectorAzureTrafficCollectorsByResourceGroupClientDiagnostics, Pipeline, "AzureTrafficCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var scope = _azureTrafficCollectorClientDiagnostics.CreateScope("AzureTrafficCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _azureTrafficCollectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var scope = _azureTrafficCollectorClientDiagnostics.CreateScope("AzureTrafficCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _azureTrafficCollectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureTrafficCollectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureTrafficCollectorResource> IEnumerable<AzureTrafficCollectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureTrafficCollectorResource> IAsyncEnumerable<AzureTrafficCollectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
