// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The Kusto SKU description of given resource type. </summary>
    public partial class KustoPoolSkuDescription
    {
        /// <summary> Initializes a new instance of KustoPoolSkuDescription. </summary>
        internal KustoPoolSkuDescription()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            LocationInfo = new ChangeTrackingList<KustoPoolSkuLocationInfoItem>();
            Restrictions = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of KustoPoolSkuDescription. </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="size"> The size of the SKU. </param>
        /// <param name="locations"> The set of locations that the SKU is available. </param>
        /// <param name="locationInfo"> Locations and zones. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. </param>
        internal KustoPoolSkuDescription(string resourceType, string name, string size, IReadOnlyList<AzureLocation> locations, IReadOnlyList<KustoPoolSkuLocationInfoItem> locationInfo, IReadOnlyList<BinaryData> restrictions)
        {
            ResourceType = resourceType;
            Name = name;
            Size = size;
            Locations = locations;
            LocationInfo = locationInfo;
            Restrictions = restrictions;
        }

        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The name of the SKU. </summary>
        public string Name { get; }
        /// <summary> The size of the SKU. </summary>
        public string Size { get; }
        /// <summary> The set of locations that the SKU is available. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Locations and zones. </summary>
        public IReadOnlyList<KustoPoolSkuLocationInfoItem> LocationInfo { get; }
        /// <summary>
        /// The restrictions because of which SKU cannot be used
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyList<BinaryData> Restrictions { get; }
    }
}
