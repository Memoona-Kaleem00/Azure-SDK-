// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> network controller config for SDN Integration to deploy AzureStackHCI Cluster. </summary>
    public partial class HciClusterNetworkController
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

        /// <summary> Initializes a new instance of <see cref="HciClusterNetworkController"/>. </summary>
        public HciClusterNetworkController()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterNetworkController"/>. </summary>
        /// <param name="macAddressPoolStart"> macAddressPoolStart of network controller used for SDN Integration. </param>
        /// <param name="macAddressPoolStop"> macAddressPoolStop of network controller used for SDN Integration. </param>
        /// <param name="networkVirtualizationEnabled"> NetworkVirtualizationEnabled of network controller used for SDN Integration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterNetworkController(string macAddressPoolStart, string macAddressPoolStop, bool? networkVirtualizationEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MacAddressPoolStart = macAddressPoolStart;
            MacAddressPoolStop = macAddressPoolStop;
            NetworkVirtualizationEnabled = networkVirtualizationEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> macAddressPoolStart of network controller used for SDN Integration. </summary>
        [WirePath("macAddressPoolStart")]
        public string MacAddressPoolStart { get; set; }
        /// <summary> macAddressPoolStop of network controller used for SDN Integration. </summary>
        [WirePath("macAddressPoolStop")]
        public string MacAddressPoolStop { get; set; }
        /// <summary> NetworkVirtualizationEnabled of network controller used for SDN Integration. </summary>
        [WirePath("networkVirtualizationEnabled")]
        public bool? NetworkVirtualizationEnabled { get; set; }
    }
}
