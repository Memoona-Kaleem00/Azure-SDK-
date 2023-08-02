// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.IotCentral;

namespace Azure.ResourceManager.IotCentral.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class IotCentralResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="IotCentralResourceGroupMockingExtension"/> class for mocking. </summary>
        protected IotCentralResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotCentralResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotCentralResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of IotCentralAppResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of IotCentralAppResources and their operations over a IotCentralAppResource. </returns>
        public virtual IotCentralAppCollection GetIotCentralApps()
        {
            return GetCachedClient(Client => new IotCentralAppCollection(Client, Id));
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<IotCentralAppResource>> GetIotCentralAppAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetIotCentralApps().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<IotCentralAppResource> GetIotCentralApp(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetIotCentralApps().Get(resourceName, cancellationToken);
        }
    }
}
