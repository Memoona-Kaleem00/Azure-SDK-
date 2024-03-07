// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The CreateMessageRequest. </summary>
    internal partial class CreateMessageRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateMessageRequest"/>. </summary>
        /// <param name="role"> The role to associate with the new message. </param>
        /// <param name="content"> The textual content for the new message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public CreateMessageRequest(MessageRole role, string content)
        {
            Argument.AssertNotNull(content, nameof(content));

            Role = role;
            Content = content;
            FileIds = new ChangeTrackingList<string>();
            Metadata = new OptionalDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateMessageRequest"/>. </summary>
        /// <param name="role"> The role to associate with the new message. </param>
        /// <param name="content"> The textual content for the new message. </param>
        /// <param name="fileIds"> A list of up to 10 file IDs to associate with the message, as used by tools like 'code_interpreter' or 'retrieval' that can read files. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateMessageRequest(MessageRole role, string content, IList<string> fileIds, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            FileIds = fileIds;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateMessageRequest"/> for deserialization. </summary>
        internal CreateMessageRequest()
        {
        }

        /// <summary> The role to associate with the new message. </summary>
        public MessageRole Role { get; }
        /// <summary> The textual content for the new message. </summary>
        public string Content { get; }
        /// <summary> A list of up to 10 file IDs to associate with the message, as used by tools like 'code_interpreter' or 'retrieval' that can read files. </summary>
        public IList<string> FileIds { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
