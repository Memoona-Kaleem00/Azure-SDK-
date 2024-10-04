// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The LivenessSessionItem. </summary>
    public partial class LivenessSessionItem
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

        /// <summary> Initializes a new instance of <see cref="LivenessSessionItem"/>. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="sessionExpired"></param>
        internal LivenessSessionItem(DateTimeOffset createdDateTime, bool sessionExpired)
        {
            CreatedDateTime = createdDateTime;
            SessionExpired = sessionExpired;
        }

        /// <summary> Initializes a new instance of <see cref="LivenessSessionItem"/>. </summary>
        /// <param name="id"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="sessionStartDateTime"></param>
        /// <param name="sessionExpired"></param>
        /// <param name="deviceCorrelationId"></param>
        /// <param name="authTokenTimeToLiveInSeconds"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LivenessSessionItem(string id, DateTimeOffset createdDateTime, DateTimeOffset? sessionStartDateTime, bool sessionExpired, string deviceCorrelationId, int? authTokenTimeToLiveInSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            SessionStartDateTime = sessionStartDateTime;
            SessionExpired = sessionExpired;
            DeviceCorrelationId = deviceCorrelationId;
            AuthTokenTimeToLiveInSeconds = authTokenTimeToLiveInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LivenessSessionItem"/> for deserialization. </summary>
        internal LivenessSessionItem()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the created date time. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Gets the session start date time. </summary>
        public DateTimeOffset? SessionStartDateTime { get; }
        /// <summary> Gets the session expired. </summary>
        public bool SessionExpired { get; }
        /// <summary> Gets the device correlation id. </summary>
        public string DeviceCorrelationId { get; }
        /// <summary> Gets the auth token time to live in seconds. </summary>
        public int? AuthTokenTimeToLiveInSeconds { get; }
    }
}
