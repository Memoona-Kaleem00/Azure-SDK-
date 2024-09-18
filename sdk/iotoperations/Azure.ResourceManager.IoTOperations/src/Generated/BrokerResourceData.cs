// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IoTOperations.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IoTOperations
{
    /// <summary>
    /// A class representing the BrokerResource data model.
    /// Instance broker resource
    /// </summary>
    public partial class BrokerResourceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="BrokerResourceData"/>. </summary>
        /// <param name="extendedLocation"> Edge location of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public BrokerResourceData(ExtendedLocation extendedLocation)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));

            ExtendedLocation = extendedLocation;
        }

        /// <summary> Initializes a new instance of <see cref="BrokerResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="extendedLocation"> Edge location of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BrokerResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BrokerProperties properties, ExtendedLocation extendedLocation, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ExtendedLocation = extendedLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BrokerResourceData"/> for deserialization. </summary>
        internal BrokerResourceData()
        {
        }

        /// <summary> The resource-specific properties for this resource. </summary>
        public BrokerProperties Properties { get; set; }
        /// <summary> Edge location of the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
    }
}
