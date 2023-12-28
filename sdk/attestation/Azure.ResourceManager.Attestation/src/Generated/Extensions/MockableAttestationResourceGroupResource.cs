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
using Azure.ResourceManager.Attestation;

namespace Azure.ResourceManager.Attestation.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAttestationResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAttestationResourceGroupResource"/> class for mocking. </summary>
        protected MockableAttestationResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAttestationResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAttestationResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AttestationProviderResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AttestationProviderResources and their operations over a AttestationProviderResource. </returns>
        public virtual AttestationProviderCollection GetAttestationProviders()
        {
            return GetCachedClient(client => new AttestationProviderCollection(client, Id));
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AttestationProviderResource>> GetAttestationProviderAsync(string providerName, CancellationToken cancellationToken = default)
        {
            return await GetAttestationProviders().GetAsync(providerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AttestationProviderResource> GetAttestationProvider(string providerName, CancellationToken cancellationToken = default)
        {
            return GetAttestationProviders().Get(providerName, cancellationToken);
        }
    }
}
