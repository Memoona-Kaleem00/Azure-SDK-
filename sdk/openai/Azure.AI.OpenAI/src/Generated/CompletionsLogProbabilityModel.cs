// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    /// <summary> Representation of a log probabilities model for a completions generation. </summary>
    public partial class CompletionsLogProbabilityModel
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CompletionsLogProbabilityModel"/>. </summary>
        /// <param name="tokens"> The textual forms of tokens evaluated in this probability model. </param>
        /// <param name="tokenLogProbabilities"> A collection of log probability values for the tokens in this completions data. </param>
        /// <param name="topLogProbabilities"> A mapping of tokens to maximum log probability values in this completions data. </param>
        /// <param name="textOffsets"> The text offsets associated with tokens in this completions data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tokens"/>, <paramref name="tokenLogProbabilities"/>, <paramref name="topLogProbabilities"/> or <paramref name="textOffsets"/> is null. </exception>
        internal CompletionsLogProbabilityModel(IEnumerable<string> tokens, IEnumerable<float?> tokenLogProbabilities, IEnumerable<IDictionary<string, float?>> topLogProbabilities, IEnumerable<int> textOffsets)
        {
            Argument.AssertNotNull(tokens, nameof(tokens));
            Argument.AssertNotNull(tokenLogProbabilities, nameof(tokenLogProbabilities));
            Argument.AssertNotNull(topLogProbabilities, nameof(topLogProbabilities));
            Argument.AssertNotNull(textOffsets, nameof(textOffsets));

            Tokens = tokens.ToList();
            TokenLogProbabilities = tokenLogProbabilities.ToList();
            TopLogProbabilities = topLogProbabilities.ToList();
            TextOffsets = textOffsets.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CompletionsLogProbabilityModel"/>. </summary>
        /// <param name="tokens"> The textual forms of tokens evaluated in this probability model. </param>
        /// <param name="tokenLogProbabilities"> A collection of log probability values for the tokens in this completions data. </param>
        /// <param name="topLogProbabilities"> A mapping of tokens to maximum log probability values in this completions data. </param>
        /// <param name="textOffsets"> The text offsets associated with tokens in this completions data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CompletionsLogProbabilityModel(IReadOnlyList<string> tokens, IReadOnlyList<float?> tokenLogProbabilities, IReadOnlyList<IDictionary<string, float?>> topLogProbabilities, IReadOnlyList<int> textOffsets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tokens = tokens;
            TokenLogProbabilities = tokenLogProbabilities;
            TopLogProbabilities = topLogProbabilities;
            TextOffsets = textOffsets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CompletionsLogProbabilityModel"/> for deserialization. </summary>
        internal CompletionsLogProbabilityModel()
        {
        }

        /// <summary> The textual forms of tokens evaluated in this probability model. </summary>
        public IReadOnlyList<string> Tokens { get; }
        /// <summary> A collection of log probability values for the tokens in this completions data. </summary>
        public IReadOnlyList<float?> TokenLogProbabilities { get; }
        /// <summary> A mapping of tokens to maximum log probability values in this completions data. </summary>
        public IReadOnlyList<IDictionary<string, float?>> TopLogProbabilities { get; }
        /// <summary> The text offsets associated with tokens in this completions data. </summary>
        public IReadOnlyList<int> TextOffsets { get; }
    }
}
