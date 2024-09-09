// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The status of an Azure resource at the time the operation was called. </summary>
    public partial class ContainerRegistryResourceStatus
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryResourceStatus"/>. </summary>
        internal ContainerRegistryResourceStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryResourceStatus"/>. </summary>
        /// <param name="displayStatus"> The short label for the status. </param>
        /// <param name="message"> The detailed message for the status, including alerts and error messages. </param>
        /// <param name="timestamp"> The timestamp when the status was changed to the current value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryResourceStatus(string displayStatus, string message, DateTimeOffset? timestamp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayStatus = displayStatus;
            Message = message;
            Timestamp = timestamp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The short label for the status. </summary>
        [WirePath("displayStatus")]
        public string DisplayStatus { get; }
        /// <summary> The detailed message for the status, including alerts and error messages. </summary>
        [WirePath("message")]
        public string Message { get; }
        /// <summary> The timestamp when the status was changed to the current value. </summary>
        [WirePath("timestamp")]
        public DateTimeOffset? Timestamp { get; }
    }
}
