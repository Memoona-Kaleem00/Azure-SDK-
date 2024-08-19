// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Inference
{
    /// <summary>
    /// Represents a response update to a chat completions request, when the service is streaming updates
    /// using Server Sent Events (SSE).
    /// Completions support a wide variety of tasks and generate text that continues from or "completes"
    /// provided prompt data.
    /// </summary>
    public partial class StreamingChatCompletionsUpdate
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

        /// <summary> Initializes a new instance of <see cref="StreamingChatCompletionsUpdate"/>. </summary>
        /// <param name="id"> A unique identifier associated with this chat completions response. </param>
        /// <param name="created">
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </param>
        /// <param name="model"> The model used for the chat completion. </param>
        /// <param name="usage"> Usage information for tokens processed and generated as part of this completions operation. </param>
        /// <param name="choices">
        /// An update to the collection of completion choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="model"/>, <paramref name="usage"/> or <paramref name="choices"/> is null. </exception>
        internal StreamingChatCompletionsUpdate(string id, DateTimeOffset created, string model, CompletionsUsage usage, IEnumerable<StreamingChatChoiceUpdate> choices)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(usage, nameof(usage));
            Argument.AssertNotNull(choices, nameof(choices));

            Id = id;
            Created = created;
            Model = model;
            Usage = usage;
            Choices = choices.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingChatCompletionsUpdate"/>. </summary>
        /// <param name="id"> A unique identifier associated with this chat completions response. </param>
        /// <param name="created">
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </param>
        /// <param name="model"> The model used for the chat completion. </param>
        /// <param name="usage"> Usage information for tokens processed and generated as part of this completions operation. </param>
        /// <param name="choices">
        /// An update to the collection of completion choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingChatCompletionsUpdate(string id, DateTimeOffset created, string model, CompletionsUsage usage, IReadOnlyList<StreamingChatChoiceUpdate> choices, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Created = created;
            Model = model;
            Usage = usage;
            Choices = choices;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamingChatCompletionsUpdate"/> for deserialization. </summary>
        internal StreamingChatCompletionsUpdate()
        {
        }
        /// <summary> Usage information for tokens processed and generated as part of this completions operation. </summary>
        public CompletionsUsage Usage { get; }
        /// <summary>
        /// An update to the collection of completion choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </summary>
        public IReadOnlyList<StreamingChatChoiceUpdate> Choices { get; }
    }
}
