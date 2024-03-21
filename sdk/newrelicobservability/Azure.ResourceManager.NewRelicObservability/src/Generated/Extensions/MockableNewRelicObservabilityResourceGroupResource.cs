// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableNewRelicObservabilityResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableNewRelicObservabilityResourceGroupResource"/> class for mocking. </summary>
        protected MockableNewRelicObservabilityResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNewRelicObservabilityResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNewRelicObservabilityResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of NewRelicMonitorResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NewRelicMonitorResources and their operations over a NewRelicMonitorResource. </returns>
        public virtual NewRelicMonitorResourceCollection GetNewRelicMonitorResources()
        {
            return GetCachedClient(client => new NewRelicMonitorResourceCollection(client, Id));
        }

        /// <summary>
        /// Get a NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Name of the Monitors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NewRelicMonitorResource>> GetNewRelicMonitorResourceAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            return await GetNewRelicMonitorResources().GetAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Name of the Monitors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NewRelicMonitorResource> GetNewRelicMonitorResource(string monitorName, CancellationToken cancellationToken = default)
        {
            return GetNewRelicMonitorResources().Get(monitorName, cancellationToken);
        }
    }
}
