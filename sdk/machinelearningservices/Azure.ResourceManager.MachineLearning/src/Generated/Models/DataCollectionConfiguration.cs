// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DataCollectionConfiguration. </summary>
    public partial class DataCollectionConfiguration
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

        /// <summary> Initializes a new instance of <see cref="DataCollectionConfiguration"/>. </summary>
        public DataCollectionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionConfiguration"/>. </summary>
        /// <param name="samplingRate"> The sampling rate for collection. Sampling rate 1.0 means we collect 100% of data by default. </param>
        /// <param name="dataCollectionMode"> Enable or disable data collection. </param>
        /// <param name="dataId"> The data asset arm resource id. Client side will ensure data asset is pointing to the blob storage, and backend will collect data to the blob storage. </param>
        /// <param name="clientId"> The msi client id used to collect logging to blob storage. If it's null,backend will pick a registered endpoint identity to auth. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionConfiguration(double? samplingRate, DataCollectionMode? dataCollectionMode, string dataId, string clientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SamplingRate = samplingRate;
            DataCollectionMode = dataCollectionMode;
            DataId = dataId;
            ClientId = clientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The sampling rate for collection. Sampling rate 1.0 means we collect 100% of data by default. </summary>
        public double? SamplingRate { get; set; }
        /// <summary> Enable or disable data collection. </summary>
        public DataCollectionMode? DataCollectionMode { get; set; }
        /// <summary> The data asset arm resource id. Client side will ensure data asset is pointing to the blob storage, and backend will collect data to the blob storage. </summary>
        public string DataId { get; set; }
        /// <summary> The msi client id used to collect logging to blob storage. If it's null,backend will pick a registered endpoint identity to auth. </summary>
        public string ClientId { get; set; }
    }
}
