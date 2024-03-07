// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A specific representation of configurable options for Azure Search when using it as an Azure OpenAI chat
    /// extension.
    /// </summary>
    public partial class AzureSearchChatExtensionConfiguration : AzureChatExtensionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="AzureSearchChatExtensionConfiguration"/>. </summary>
        /// <param name="type">
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> The parameters to use when configuring Azure Search. </param>
        internal AzureSearchChatExtensionConfiguration(AzureChatExtensionType type, IDictionary<string, BinaryData> serializedAdditionalRawData, AzureSearchChatExtensionParameters parameters) : base(type, serializedAdditionalRawData)
        {
            Parameters = parameters;
        }
    }
}
