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
using Azure.ResourceManager.Advisor;

namespace Azure.ResourceManager.Advisor.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAdvisorArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAdvisorArmClient"/> class for mocking. </summary>
        protected MockableAdvisorArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAdvisorArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAdvisorArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAdvisorArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ResourceRecommendationBaseResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ResourceRecommendationBaseResources and their operations over a ResourceRecommendationBaseResource. </returns>
        public virtual ResourceRecommendationBaseCollection GetResourceRecommendationBases(ResourceIdentifier scope)
        {
            return new ResourceRecommendationBaseCollection(Client, scope);
        }

        /// <summary>
        /// Obtains details of a cached recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Advisor/recommendations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="recommendationId"> The recommendation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="recommendationId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourceRecommendationBaseResource>> GetResourceRecommendationBaseAsync(ResourceIdentifier scope, string recommendationId, CancellationToken cancellationToken = default)
        {
            return await GetResourceRecommendationBases(scope).GetAsync(recommendationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Obtains details of a cached recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Advisor/recommendations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="recommendationId"> The recommendation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="recommendationId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourceRecommendationBaseResource> GetResourceRecommendationBase(ResourceIdentifier scope, string recommendationId, CancellationToken cancellationToken = default)
        {
            return GetResourceRecommendationBases(scope).Get(recommendationId, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MetadataEntityResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MetadataEntityResource.CreateResourceIdentifier" /> to create a <see cref="MetadataEntityResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MetadataEntityResource"/> object. </returns>
        public virtual MetadataEntityResource GetMetadataEntityResource(ResourceIdentifier id)
        {
            MetadataEntityResource.ValidateResourceId(id);
            return new MetadataEntityResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceRecommendationBaseResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceRecommendationBaseResource.CreateResourceIdentifier" /> to create a <see cref="ResourceRecommendationBaseResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceRecommendationBaseResource"/> object. </returns>
        public virtual ResourceRecommendationBaseResource GetResourceRecommendationBaseResource(ResourceIdentifier id)
        {
            ResourceRecommendationBaseResource.ValidateResourceId(id);
            return new ResourceRecommendationBaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SuppressionContractResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SuppressionContractResource.CreateResourceIdentifier" /> to create a <see cref="SuppressionContractResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SuppressionContractResource"/> object. </returns>
        public virtual SuppressionContractResource GetSuppressionContractResource(ResourceIdentifier id)
        {
            SuppressionContractResource.ValidateResourceId(id);
            return new SuppressionContractResource(Client, id);
        }
    }
}
