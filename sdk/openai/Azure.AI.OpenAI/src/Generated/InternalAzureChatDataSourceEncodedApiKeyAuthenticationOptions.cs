// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureChatDataSourceEncodedApiKeyAuthenticationOptions. </summary>
    internal partial class InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions : DataSourceAuthentication
    {
        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions"/>. </summary>
        /// <param name="encodedApiKey"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="encodedApiKey"/> is null. </exception>
        internal InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions(string encodedApiKey)
        {
            Argument.AssertNotNull(encodedApiKey, nameof(encodedApiKey));

            Type = "encoded_api_key";
            EncodedApiKey = encodedApiKey;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions"/>. </summary>
        /// <param name="type"> Discriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="encodedApiKey"></param>
        internal InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string encodedApiKey) : base(type, serializedAdditionalRawData)
        {
            EncodedApiKey = encodedApiKey;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions"/> for deserialization. </summary>
        internal InternalAzureChatDataSourceEncodedApiKeyAuthenticationOptions()
        {
        }

        /// <summary> Gets the encoded api key. </summary>
        internal string EncodedApiKey { get; set; }
    }
}

