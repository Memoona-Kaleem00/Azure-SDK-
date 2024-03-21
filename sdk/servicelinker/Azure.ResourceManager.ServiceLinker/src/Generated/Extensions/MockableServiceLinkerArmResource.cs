// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Mocking
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    public partial class MockableServiceLinkerArmResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableServiceLinkerArmResource"/> class for mocking. </summary>
        protected MockableServiceLinkerArmResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceLinkerArmResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceLinkerArmResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of LinkerResources in the ArmResource. </summary>
        /// <returns> An object representing collection of LinkerResources and their operations over a LinkerResource. </returns>
        public virtual LinkerResourceCollection GetLinkerResources()
        {
            return GetCachedClient(client => new LinkerResourceCollection(client, Id));
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LinkerResource>> GetLinkerResourceAsync(string linkerName, CancellationToken cancellationToken = default)
        {
            return await GetLinkerResources().GetAsync(linkerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LinkerResource> GetLinkerResource(string linkerName, CancellationToken cancellationToken = default)
        {
            return GetLinkerResources().Get(linkerName, cancellationToken);
        }
    }
}
