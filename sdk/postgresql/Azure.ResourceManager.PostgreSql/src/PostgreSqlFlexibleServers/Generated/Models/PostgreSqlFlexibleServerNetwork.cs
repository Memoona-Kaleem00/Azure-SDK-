// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Network properties of a server. </summary>
    public partial class PostgreSqlFlexibleServerNetwork
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerNetwork"/>. </summary>
        public PostgreSqlFlexibleServerNetwork()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerNetwork"/>. </summary>
        /// <param name="publicNetworkAccess"> public network access is enabled or not. </param>
        /// <param name="delegatedSubnetResourceId"> Delegated subnet arm resource id. This is required to be passed during create, in case we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update the value for Private DNS zone. </param>
        /// <param name="privateDnsZoneArmResourceId"> Private dns zone arm resource id. This is required to be passed during create, in case we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update the value for Private DNS zone. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerNetwork(PostgreSqlFlexibleServerPublicNetworkAccessState? publicNetworkAccess, ResourceIdentifier delegatedSubnetResourceId, ResourceIdentifier privateDnsZoneArmResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicNetworkAccess = publicNetworkAccess;
            DelegatedSubnetResourceId = delegatedSubnetResourceId;
            PrivateDnsZoneArmResourceId = privateDnsZoneArmResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> public network access is enabled or not. </summary>
        [WirePath("publicNetworkAccess")]
        public PostgreSqlFlexibleServerPublicNetworkAccessState? PublicNetworkAccess { get; }
        /// <summary> Delegated subnet arm resource id. This is required to be passed during create, in case we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update the value for Private DNS zone. </summary>
        [WirePath("delegatedSubnetResourceId")]
        public ResourceIdentifier DelegatedSubnetResourceId { get; set; }
        /// <summary> Private dns zone arm resource id. This is required to be passed during create, in case we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update the value for Private DNS zone. </summary>
        [WirePath("privateDnsZoneArmResourceId")]
        public ResourceIdentifier PrivateDnsZoneArmResourceId { get; set; }
    }
}
