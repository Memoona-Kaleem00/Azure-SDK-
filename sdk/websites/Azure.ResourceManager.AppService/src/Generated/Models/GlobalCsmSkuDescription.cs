// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A Global SKU Description. </summary>
    public partial class GlobalCsmSkuDescription
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

        /// <summary> Initializes a new instance of <see cref="GlobalCsmSkuDescription"/>. </summary>
        internal GlobalCsmSkuDescription()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            Capabilities = new ChangeTrackingList<AppServiceSkuCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="GlobalCsmSkuDescription"/>. </summary>
        /// <param name="name"> Name of the resource SKU. </param>
        /// <param name="tier"> Service Tier of the resource SKU. </param>
        /// <param name="size"> Size specifier of the resource SKU. </param>
        /// <param name="family"> Family code of the resource SKU. </param>
        /// <param name="capacity"> Min, max, and default scale values of the SKU. </param>
        /// <param name="locations"> Locations of the SKU. </param>
        /// <param name="capabilities"> Capabilities of the SKU, e.g., is traffic manager enabled?. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GlobalCsmSkuDescription(string name, string tier, string size, string family, AppServiceSkuCapacity capacity, IReadOnlyList<AzureLocation> locations, IReadOnlyList<AppServiceSkuCapability> capabilities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            Locations = locations;
            Capabilities = capabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the resource SKU. </summary>
        public string Name { get; }
        /// <summary> Service Tier of the resource SKU. </summary>
        public string Tier { get; }
        /// <summary> Size specifier of the resource SKU. </summary>
        public string Size { get; }
        /// <summary> Family code of the resource SKU. </summary>
        public string Family { get; }
        /// <summary> Min, max, and default scale values of the SKU. </summary>
        public AppServiceSkuCapacity Capacity { get; }
        /// <summary> Locations of the SKU. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Capabilities of the SKU, e.g., is traffic manager enabled?. </summary>
        public IReadOnlyList<AppServiceSkuCapability> Capabilities { get; }
    }
}
