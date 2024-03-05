// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The locations and zones info for SKU. </summary>
    public partial class KustoPoolSkuLocationInfoItem
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

        /// <summary> Initializes a new instance of <see cref="KustoPoolSkuLocationInfoItem"/>. </summary>
        /// <param name="location"> The available location of the SKU. </param>
        internal KustoPoolSkuLocationInfoItem(AzureLocation location)
        {
            Location = location;
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolSkuLocationInfoItem"/>. </summary>
        /// <param name="location"> The available location of the SKU. </param>
        /// <param name="zones"> The available zone of the SKU. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoPoolSkuLocationInfoItem(AzureLocation location, IReadOnlyList<string> zones, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolSkuLocationInfoItem"/> for deserialization. </summary>
        internal KustoPoolSkuLocationInfoItem()
        {
        }

        /// <summary> The available location of the SKU. </summary>
        public AzureLocation Location { get; }
        /// <summary> The available zone of the SKU. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
