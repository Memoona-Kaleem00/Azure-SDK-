// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The standard Chat Completions response format that can freely generate text and is not guaranteed to produce response
    /// content that adheres to a specific schema.
    /// </summary>
    internal partial class ChatCompletionsTextResponseFormat : ChatCompletionsResponseFormat
    {
        /// <summary> Initializes a new instance of <see cref="ChatCompletionsTextResponseFormat"/>. </summary>
        public ChatCompletionsTextResponseFormat()
        {
            Type = "text";
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsTextResponseFormat"/>. </summary>
        /// <param name="type"> The discriminated type for the response format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionsTextResponseFormat(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
