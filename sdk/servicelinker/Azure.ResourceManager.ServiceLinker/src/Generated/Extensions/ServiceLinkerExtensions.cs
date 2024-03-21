// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ServiceLinker.Mocking;

namespace Azure.ResourceManager.ServiceLinker
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceLinker. </summary>
    public static partial class ServiceLinkerExtensions
    {
        private static MockableServiceLinkerArmClient GetMockableServiceLinkerArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableServiceLinkerArmClient(client0));
        }

        private static MockableServiceLinkerArmResource GetMockableServiceLinkerArmResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceLinkerArmResource(client, resource.Id));
        }

        /// <summary>
        /// Gets a collection of LinkerResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmClient.GetLinkerResources(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of LinkerResources and their operations over a LinkerResource. </returns>
        public static LinkerResourceCollection GetLinkerResources(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceLinkerArmClient(client).GetLinkerResources(scope);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmClient.GetLinkerResourceAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LinkerResource>> GetLinkerResourceAsync(this ArmClient client, ResourceIdentifier scope, string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableServiceLinkerArmClient(client).GetLinkerResourceAsync(scope, linkerName, cancellationToken).ConfigureAwait(false);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmClient.GetLinkerResource(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LinkerResource> GetLinkerResource(this ArmClient client, ResourceIdentifier scope, string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceLinkerArmClient(client).GetLinkerResource(scope, linkerName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LinkerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LinkerResource.CreateResourceIdentifier" /> to create a <see cref="LinkerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmClient.GetLinkerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LinkerResource"/> object. </returns>
        public static LinkerResource GetLinkerResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceLinkerArmClient(client).GetLinkerResource(id);
        }

        /// <summary>
        /// Gets a collection of LinkerResources in the ArmResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmResource.GetLinkerResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="armResource"/> is null. </exception>
        /// <returns> An object representing collection of LinkerResources and their operations over a LinkerResource. </returns>
        public static LinkerResourceCollection GetLinkerResources(this ArmResource armResource)
        {
            Argument.AssertNotNull(armResource, nameof(armResource));

            return GetMockableServiceLinkerArmResource(armResource).GetLinkerResources();
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmResource.GetLinkerResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="armResource"/> or <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LinkerResource>> GetLinkerResourceAsync(this ArmResource armResource, string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(armResource, nameof(armResource));

            return await GetMockableServiceLinkerArmResource(armResource).GetLinkerResourceAsync(linkerName, cancellationToken).ConfigureAwait(false);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceLinkerArmResource.GetLinkerResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="armResource"/> or <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LinkerResource> GetLinkerResource(this ArmResource armResource, string linkerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(armResource, nameof(armResource));

            return GetMockableServiceLinkerArmResource(armResource).GetLinkerResource(linkerName, cancellationToken);
        }
    }
}
