// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotFirmwareDefense.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary>
    /// A class representing the SummaryResource data model.
    /// The object representing a firmware analysis summary resource.
    /// </summary>
    public partial class SummaryResourceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SummaryResourceData"/>. </summary>
        public SummaryResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SummaryResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of an analysis summary.
        /// Please note <see cref="SummaryResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BinaryHardeningSummaryResourceInfo"/>, <see cref="CveSummary"/>, <see cref="FirmwareCryptoCertificateSummaryResource"/>, <see cref="FirmwareCryptoKeySummaryResource"/> and <see cref="FirmwareSummary"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SummaryResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SummaryResourceProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Properties of an analysis summary.
        /// Please note <see cref="SummaryResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BinaryHardeningSummaryResourceInfo"/>, <see cref="CveSummary"/>, <see cref="FirmwareCryptoCertificateSummaryResource"/>, <see cref="FirmwareCryptoKeySummaryResource"/> and <see cref="FirmwareSummary"/>.
        /// </summary>
        public SummaryResourceProperties Properties { get; }
    }
}
