// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningCompute;

namespace Azure.ResourceManager.MachineLearningCompute.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class MachineLearningComputeResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MachineLearningComputeResourceGroupMockingExtension"/> class for mocking. </summary>
        protected MachineLearningComputeResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningComputeResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningComputeResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of OperationalizationClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of OperationalizationClusterResources and their operations over a OperationalizationClusterResource. </returns>
        public virtual OperationalizationClusterCollection GetOperationalizationClusters()
        {
            return GetCachedClient(Client => new OperationalizationClusterCollection(Client, Id));
        }

        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the credentials are not returned by this call. Call ListKeys to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningCompute/operationalizationClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<OperationalizationClusterResource>> GetOperationalizationClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetOperationalizationClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the credentials are not returned by this call. Call ListKeys to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningCompute/operationalizationClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<OperationalizationClusterResource> GetOperationalizationCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetOperationalizationClusters().Get(clusterName, cancellationToken);
        }
    }
}
