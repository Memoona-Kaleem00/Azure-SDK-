// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableWebPubSubResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableWebPubSubResourceGroupResource"/> class for mocking. </summary>
        protected MockableWebPubSubResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableWebPubSubResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableWebPubSubResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of WebPubSubResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WebPubSubResources and their operations over a WebPubSubResource. </returns>
        public virtual WebPubSubCollection GetWebPubSubs()
        {
            return GetCachedClient(client => new WebPubSubCollection(client, Id));
        }

        /// <summary>
        /// Get the resource and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSub_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebPubSubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WebPubSubResource>> GetWebPubSubAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetWebPubSubs().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the resource and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSub_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebPubSubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WebPubSubResource> GetWebPubSub(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetWebPubSubs().Get(resourceName, cancellationToken);
        }
    }
}
