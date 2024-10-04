// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> The DocumentParagraph. </summary>
    public partial class DocumentParagraph
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

        /// <summary> Initializes a new instance of <see cref="DocumentParagraph"/>. </summary>
        /// <param name="content"></param>
        /// <param name="spans"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentParagraph(string content, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(spans, nameof(spans));

            Content = content;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentParagraph"/>. </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentParagraph(ParagraphRole? role, string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentParagraph"/> for deserialization. </summary>
        internal DocumentParagraph()
        {
        }

        /// <summary> Gets the role. </summary>
        public ParagraphRole? Role { get; }
        /// <summary> Gets the content. </summary>
        public string Content { get; }
        /// <summary> Gets the bounding regions. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Gets the spans. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
