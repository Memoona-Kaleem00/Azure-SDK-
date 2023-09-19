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

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridContainerServiceAgentPoolResource" /> and their operations.
    /// Each <see cref="HybridContainerServiceAgentPoolResource" /> in the collection will belong to the same instance of <see cref="ProvisionedClusterResource" />.
    /// To get a <see cref="HybridContainerServiceAgentPoolCollection" /> instance call the GetHybridContainerServiceAgentPools method from an instance of <see cref="ProvisionedClusterResource" />.
    /// </summary>
    public partial class HybridContainerServiceAgentPoolCollection : ArmCollection, IEnumerable<HybridContainerServiceAgentPoolResource>, IAsyncEnumerable<HybridContainerServiceAgentPoolResource>
    {
        private readonly ClientDiagnostics _hybridContainerServiceAgentPoolagentPoolClientDiagnostics;
        private readonly AgentPoolRestOperations _hybridContainerServiceAgentPoolagentPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceAgentPoolCollection"/> class for mocking. </summary>
        protected HybridContainerServiceAgentPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceAgentPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridContainerServiceAgentPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridContainerServiceAgentPoolagentPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", HybridContainerServiceAgentPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridContainerServiceAgentPoolResource.ResourceType, out string hybridContainerServiceAgentPoolagentPoolApiVersion);
            _hybridContainerServiceAgentPoolagentPoolRestClient = new AgentPoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridContainerServiceAgentPoolagentPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProvisionedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProvisionedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the agent pool in the Hybrid AKS provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="data"> The HybridContainerServiceAgentPool to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridContainerServiceAgentPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string agentPoolName, HybridContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceAgentPoolResource>(new HybridContainerServiceAgentPoolOperationSource(Client), _hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, _hybridContainerServiceAgentPoolagentPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates the agent pool in the Hybrid AKS provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="data"> The HybridContainerServiceAgentPool to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridContainerServiceAgentPoolResource> CreateOrUpdate(WaitUntil waitUntil, string agentPoolName, HybridContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceAgentPoolResource>(new HybridContainerServiceAgentPoolOperationSource(Client), _hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, _hybridContainerServiceAgentPoolagentPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the agent pool in the Hybrid AKS provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<HybridContainerServiceAgentPoolResource>> GetAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the agent pool in the Hybrid AKS provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<HybridContainerServiceAgentPoolResource> Get(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the agent pools in the Hybrid AKS provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_ListByProvisionedCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridContainerServiceAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridContainerServiceAgentPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridContainerServiceAgentPoolagentPoolRestClient.CreateListByProvisionedClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new HybridContainerServiceAgentPoolResource(Client, HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(e)), _hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, "HybridContainerServiceAgentPoolCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the agent pools in the Hybrid AKS provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_ListByProvisionedCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridContainerServiceAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridContainerServiceAgentPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridContainerServiceAgentPoolagentPoolRestClient.CreateListByProvisionedClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new HybridContainerServiceAgentPoolResource(Client, HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(e)), _hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, "HybridContainerServiceAgentPoolCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridContainerServiceAgentPoolResource>> GetIfExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridContainerServiceAgentPoolResource>(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{resourceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual NullableResponse<HybridContainerServiceAgentPoolResource> GetIfExists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridContainerServiceAgentPoolResource>(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridContainerServiceAgentPoolResource> IEnumerable<HybridContainerServiceAgentPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridContainerServiceAgentPoolResource> IAsyncEnumerable<HybridContainerServiceAgentPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
