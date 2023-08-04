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
using Azure.ResourceManager.HybridConnectivity;

namespace Azure.ResourceManager.HybridConnectivity.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class HybridConnectivityArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityArmClientMockingExtension"/> class for mocking. </summary>
        protected HybridConnectivityArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HybridConnectivityArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal HybridConnectivityArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of EndpointResources in the ArmClient. </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <returns> An object representing collection of EndpointResources and their operations over a EndpointResource. </returns>
        public virtual EndpointResourceCollection GetEndpointResources(ResourceIdentifier scope)
        {
            return new EndpointResourceCollection(Client, scope);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EndpointResource>> GetEndpointResourceAsync(ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            return await GetEndpointResources(scope).GetAsync(endpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<EndpointResource> GetEndpointResource(ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            return GetEndpointResources(scope).Get(endpointName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EndpointResource.CreateResourceIdentifier" /> to create an <see cref="EndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EndpointResource" /> object. </returns>
        public virtual EndpointResource GetEndpointResource(ResourceIdentifier id)
        {
            EndpointResource.ValidateResourceId(id);
            return new EndpointResource(Client, id);
        }
    }
}
