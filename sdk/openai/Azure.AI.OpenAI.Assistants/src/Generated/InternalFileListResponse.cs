// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The response data from a file list operation. </summary>
    internal partial class InternalFileListResponse
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

        /// <summary> Initializes a new instance of <see cref="InternalFileListResponse"/>. </summary>
        /// <param name="data"> The files returned for the request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal InternalFileListResponse(IEnumerable<OpenAIFile> data)
        {
            Argument.AssertNotNull(data, nameof(data));

            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InternalFileListResponse"/>. </summary>
        /// <param name="object"> The object type, which is always 'list'. </param>
        /// <param name="data"> The files returned for the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalFileListResponse(InternalFileListResponseObject @object, IReadOnlyList<OpenAIFile> data, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Object = @object;
            Data = data;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalFileListResponse"/> for deserialization. </summary>
        internal InternalFileListResponse()
        {
        }

        /// <summary> The object type, which is always 'list'. </summary>
        public InternalFileListResponseObject Object { get; } = InternalFileListResponseObject.List;

        /// <summary> The files returned for the request. </summary>
        public IReadOnlyList<OpenAIFile> Data { get; }
    }
}
