// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServiceIdentities.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableManagedServiceIdentitiesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableManagedServiceIdentitiesResourceGroupResource"/> class for mocking. </summary>
        protected MockableManagedServiceIdentitiesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableManagedServiceIdentitiesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableManagedServiceIdentitiesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of UserAssignedIdentityResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of UserAssignedIdentityResources and their operations over a UserAssignedIdentityResource. </returns>
        public virtual UserAssignedIdentityCollection GetUserAssignedIdentities()
        {
            return GetCachedClient(client => new UserAssignedIdentityCollection(client, Id));
        }

        /// <summary>
        /// Gets the identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<UserAssignedIdentityResource>> GetUserAssignedIdentityAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetUserAssignedIdentities().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the identity resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<UserAssignedIdentityResource> GetUserAssignedIdentity(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetUserAssignedIdentities().Get(resourceName, cancellationToken);
        }
    }
}
