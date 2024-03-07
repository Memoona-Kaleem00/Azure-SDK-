// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The details of a a vectorization source, used by Azure OpenAI On Your Data when applying vector search, that is based
    /// on a search service model ID. Currently only supported by Elasticsearch®.
    /// </summary>
    public partial class OnYourDataModelIdVectorizationSource : OnYourDataVectorizationSource
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataModelIdVectorizationSource"/>. </summary>
        /// <param name="modelId"> The embedding model ID build inside the search service. Currently only supported by Elasticsearch®. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public OnYourDataModelIdVectorizationSource(string modelId)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            Type = OnYourDataVectorizationSourceType.ModelId;
            ModelId = modelId;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataModelIdVectorizationSource"/>. </summary>
        /// <param name="type"> The type of vectorization source to use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="modelId"> The embedding model ID build inside the search service. Currently only supported by Elasticsearch®. </param>
        internal OnYourDataModelIdVectorizationSource(OnYourDataVectorizationSourceType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string modelId) : base(type, serializedAdditionalRawData)
        {
            ModelId = modelId;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataModelIdVectorizationSource"/> for deserialization. </summary>
        internal OnYourDataModelIdVectorizationSource()
        {
        }

        /// <summary> The embedding model ID build inside the search service. Currently only supported by Elasticsearch®. </summary>
        public string ModelId { get; }
    }
}
