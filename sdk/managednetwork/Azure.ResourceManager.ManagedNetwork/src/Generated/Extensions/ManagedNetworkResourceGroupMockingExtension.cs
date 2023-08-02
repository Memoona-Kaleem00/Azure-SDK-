// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagedNetwork;

namespace Azure.ResourceManager.ManagedNetwork.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ManagedNetworkResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ManagedNetworkResourceGroupMockingExtension"/> class for mocking. </summary>
        protected ManagedNetworkResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedNetworkResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedNetworkResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ManagedNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedNetworkResources and their operations over a ManagedNetworkResource. </returns>
        public virtual ManagedNetworkCollection GetManagedNetworks()
        {
            return GetCachedClient(Client => new ManagedNetworkCollection(Client, Id));
        }

        /// <summary>
        /// The Get ManagedNetworks operation gets a Managed Network Resource, specified by the resource group and Managed Network name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkName"> The name of the Managed Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedNetworkResource>> GetManagedNetworkAsync(string managedNetworkName, CancellationToken cancellationToken = default)
        {
            return await GetManagedNetworks().GetAsync(managedNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The Get ManagedNetworks operation gets a Managed Network Resource, specified by the resource group and Managed Network name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkName"> The name of the Managed Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ManagedNetworkResource> GetManagedNetwork(string managedNetworkName, CancellationToken cancellationToken = default)
        {
            return GetManagedNetworks().Get(managedNetworkName, cancellationToken);
        }
    }
}
