// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The configuration information for an embeddings request.
    /// Embeddings measure the relatedness of text strings and are commonly used for search, clustering,
    /// recommendations, and other similar scenarios.
    /// </summary>
    public partial class EmbeddingsOptions
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

        /// <summary> Initializes a new instance of <see cref="EmbeddingsOptions"/>. </summary>
        /// <param name="user">
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </param>
        /// <param name="deploymentName">
        /// The model name to provide as part of this embeddings request.
        /// Not applicable to Azure OpenAI, where deployment information should be included in the Azure
        /// resource URI that's connected to.
        /// </param>
        /// <param name="input">
        /// Input texts to get embeddings for, encoded as a an array of strings.
        /// Each input must not exceed 2048 tokens in length.
        ///
        /// Unless you are embedding code, we suggest replacing newlines (\n) in your input with a single space,
        /// as we have observed inferior results when newlines are present.
        /// </param>
        /// <param name="encodingFormat"> The response encoding format to use for embedding data. </param>
        /// <param name="dimensions"> The number of dimensions the resulting output embeddings should have. Only supported in `text-embedding-3` and later models. </param>
        /// <param name="inputType"> When using Azure OpenAI, specifies the input type to use for embedding search. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EmbeddingsOptions(string user, string deploymentName, IList<string> input, EmbeddingEncodingFormat? encodingFormat, int? dimensions, string inputType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            User = user;
            DeploymentName = deploymentName;
            Input = input;
            EncodingFormat = encodingFormat;
            Dimensions = dimensions;
            InputType = inputType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Input texts to get embeddings for, encoded as a an array of strings.
        /// Each input must not exceed 2048 tokens in length.
        ///
        /// Unless you are embedding code, we suggest replacing newlines (\n) in your input with a single space,
        /// as we have observed inferior results when newlines are present.
        /// </summary>
        public IList<string> Input { get; }
        /// <summary> The number of dimensions the resulting output embeddings should have. Only supported in `text-embedding-3` and later models. </summary>
        public int? Dimensions { get; set; }
        /// <summary> When using Azure OpenAI, specifies the input type to use for embedding search. </summary>
        public string InputType { get; set; }
    }
}
