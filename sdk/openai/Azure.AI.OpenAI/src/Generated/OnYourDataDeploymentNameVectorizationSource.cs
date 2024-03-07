// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The details of a a vectorization source, used by Azure OpenAI On Your Data when applying vector search, that is based
    /// on an internal embeddings model deployment name in the same Azure OpenAI resource.
    /// </summary>
    public partial class OnYourDataDeploymentNameVectorizationSource : OnYourDataVectorizationSource
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataDeploymentNameVectorizationSource"/>. </summary>
        /// <param name="deploymentName"> The embedding model deployment name within the same Azure OpenAI resource. This enables you to use vector search without Azure OpenAI api-key and without Azure OpenAI public network access. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public OnYourDataDeploymentNameVectorizationSource(string deploymentName)
        {
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            Type = OnYourDataVectorizationSourceType.DeploymentName;
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataDeploymentNameVectorizationSource"/>. </summary>
        /// <param name="type"> The type of vectorization source to use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="deploymentName"> The embedding model deployment name within the same Azure OpenAI resource. This enables you to use vector search without Azure OpenAI api-key and without Azure OpenAI public network access. </param>
        internal OnYourDataDeploymentNameVectorizationSource(OnYourDataVectorizationSourceType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string deploymentName) : base(type, serializedAdditionalRawData)
        {
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataDeploymentNameVectorizationSource"/> for deserialization. </summary>
        internal OnYourDataDeploymentNameVectorizationSource()
        {
        }

        /// <summary> The embedding model deployment name within the same Azure OpenAI resource. This enables you to use vector search without Azure OpenAI api-key and without Azure OpenAI public network access. </summary>
        public string DeploymentName { get; }
    }
}
