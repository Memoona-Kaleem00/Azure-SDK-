// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkFunction.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkFunction
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NetworkFunction. </summary>
    public static partial class NetworkFunctionExtensions
    {
        private static NetworkFunctionArmClientMockingExtension GetNetworkFunctionArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client0 => new NetworkFunctionArmClientMockingExtension(client0));
        }

        private static NetworkFunctionResourceGroupMockingExtension GetNetworkFunctionResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new NetworkFunctionResourceGroupMockingExtension(client, resource.Id));
        }

        private static NetworkFunctionSubscriptionMockingExtension GetNetworkFunctionSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new NetworkFunctionSubscriptionMockingExtension(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureTrafficCollectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureTrafficCollectorResource.CreateResourceIdentifier" /> to create an <see cref="AzureTrafficCollectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionArmClientMockingExtension.GetAzureTrafficCollectorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureTrafficCollectorResource" /> object. </returns>
        public static AzureTrafficCollectorResource GetAzureTrafficCollectorResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetNetworkFunctionArmClientMockingExtension(client).GetAzureTrafficCollectorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CollectorPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CollectorPolicyResource.CreateResourceIdentifier" /> to create a <see cref="CollectorPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionArmClientMockingExtension.GetCollectorPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CollectorPolicyResource" /> object. </returns>
        public static CollectorPolicyResource GetCollectorPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetNetworkFunctionArmClientMockingExtension(client).GetCollectorPolicyResource(id);
        }

        /// <summary>
        /// Gets a collection of AzureTrafficCollectorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionResourceGroupMockingExtension.GetAzureTrafficCollectors()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AzureTrafficCollectorResources and their operations over a AzureTrafficCollectorResource. </returns>
        public static AzureTrafficCollectorCollection GetAzureTrafficCollectors(this ResourceGroupResource resourceGroupResource)
        {
            return GetNetworkFunctionResourceGroupMockingExtension(resourceGroupResource).GetAzureTrafficCollectors();
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionResourceGroupMockingExtension.GetAzureTrafficCollectorAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AzureTrafficCollectorResource>> GetAzureTrafficCollectorAsync(this ResourceGroupResource resourceGroupResource, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            return await GetNetworkFunctionResourceGroupMockingExtension(resourceGroupResource).GetAzureTrafficCollectorAsync(azureTrafficCollectorName, cancellationToken).ConfigureAwait(false);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionResourceGroupMockingExtension.GetAzureTrafficCollector(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AzureTrafficCollectorResource> GetAzureTrafficCollector(this ResourceGroupResource resourceGroupResource, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            return GetNetworkFunctionResourceGroupMockingExtension(resourceGroupResource).GetAzureTrafficCollector(azureTrafficCollectorName, cancellationToken);
        }

        /// <summary>
        /// Return list of Azure Traffic Collectors in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkFunction/azureTrafficCollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectorsBySubscription_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionSubscriptionMockingExtension.GetAzureTrafficCollectors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureTrafficCollectorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AzureTrafficCollectorResource> GetAzureTrafficCollectorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetNetworkFunctionSubscriptionMockingExtension(subscriptionResource).GetAzureTrafficCollectorsAsync(cancellationToken);
        }

        /// <summary>
        /// Return list of Azure Traffic Collectors in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkFunction/azureTrafficCollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTrafficCollectorsBySubscription_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="NetworkFunctionSubscriptionMockingExtension.GetAzureTrafficCollectors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureTrafficCollectorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AzureTrafficCollectorResource> GetAzureTrafficCollectors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetNetworkFunctionSubscriptionMockingExtension(subscriptionResource).GetAzureTrafficCollectors(cancellationToken);
        }
    }
}
