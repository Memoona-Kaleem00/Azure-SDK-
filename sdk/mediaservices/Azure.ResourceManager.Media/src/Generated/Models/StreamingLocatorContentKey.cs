// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for content key in Streaming Locator. </summary>
    public partial class StreamingLocatorContentKey
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

        /// <summary> Initializes a new instance of <see cref="StreamingLocatorContentKey"/>. </summary>
        /// <param name="id"> ID of Content Key. </param>
        public StreamingLocatorContentKey(Guid id)
        {
            Id = id;
            Tracks = new ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingLocatorContentKey"/>. </summary>
        /// <param name="id"> ID of Content Key. </param>
        /// <param name="keyType"> Encryption type of Content Key. </param>
        /// <param name="labelReferenceInStreamingPolicy"> Label of Content Key as specified in the Streaming Policy. </param>
        /// <param name="value"> Value of Content Key. </param>
        /// <param name="policyName"> ContentKeyPolicy used by Content Key. </param>
        /// <param name="tracks"> Tracks which use this Content Key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingLocatorContentKey(Guid id, StreamingLocatorContentKeyType? keyType, string labelReferenceInStreamingPolicy, string value, string policyName, IReadOnlyList<MediaTrackSelection> tracks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            KeyType = keyType;
            LabelReferenceInStreamingPolicy = labelReferenceInStreamingPolicy;
            Value = value;
            PolicyName = policyName;
            Tracks = tracks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamingLocatorContentKey"/> for deserialization. </summary>
        internal StreamingLocatorContentKey()
        {
        }

        /// <summary> ID of Content Key. </summary>
        public Guid Id { get; set; }
        /// <summary> Encryption type of Content Key. </summary>
        public StreamingLocatorContentKeyType? KeyType { get; }
        /// <summary> Label of Content Key as specified in the Streaming Policy. </summary>
        public string LabelReferenceInStreamingPolicy { get; set; }
        /// <summary> Value of Content Key. </summary>
        public string Value { get; set; }
        /// <summary> ContentKeyPolicy used by Content Key. </summary>
        public string PolicyName { get; }
        /// <summary> Tracks which use this Content Key. </summary>
        public IReadOnlyList<MediaTrackSelection> Tracks { get; }
    }
}
