// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The DataBoxCopyStartedEventData. </summary>
    public partial class DataBoxCopyStartedEventData
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

        /// <summary> Initializes a new instance of <see cref="DataBoxCopyStartedEventData"/>. </summary>
        /// <param name="stageName"></param>
        /// <param name="stageTime"></param>
        internal DataBoxCopyStartedEventData(DataBoxStageName stageName, DateTimeOffset stageTime)
        {
            StageName = stageName;
            StageTime = stageTime;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxCopyStartedEventData"/>. </summary>
        /// <param name="serialNumber"></param>
        /// <param name="stageName"></param>
        /// <param name="stageTime"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxCopyStartedEventData(string serialNumber, DataBoxStageName stageName, DateTimeOffset stageTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SerialNumber = serialNumber;
            StageName = stageName;
            StageTime = stageTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxCopyStartedEventData"/> for deserialization. </summary>
        internal DataBoxCopyStartedEventData()
        {
        }

        /// <summary> Gets the serial number. </summary>
        public string SerialNumber { get; }
        /// <summary> Gets the stage name. </summary>
        public DataBoxStageName StageName { get; }
        /// <summary> Gets the stage time. </summary>
        public DateTimeOffset StageTime { get; }
    }
}
