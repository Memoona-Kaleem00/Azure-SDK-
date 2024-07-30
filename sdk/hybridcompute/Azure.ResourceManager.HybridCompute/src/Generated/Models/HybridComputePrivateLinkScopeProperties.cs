// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Properties that define a Azure Arc PrivateLinkScope resource. </summary>
    public partial class HybridComputePrivateLinkScopeProperties
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

        /// <summary> Initializes a new instance of <see cref="HybridComputePrivateLinkScopeProperties"/>. </summary>
        public HybridComputePrivateLinkScopeProperties()
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionDataModel>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputePrivateLinkScopeProperties"/>. </summary>
        /// <param name="publicNetworkAccess"> Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints. </param>
        /// <param name="provisioningState"> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </param>
        /// <param name="privateLinkScopeId"> The Guid id of the private link scope. </param>
        /// <param name="privateEndpointConnections"> The collection of associated Private Endpoint Connections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridComputePrivateLinkScopeProperties(HybridComputePublicNetworkAccessType? publicNetworkAccess, string provisioningState, string privateLinkScopeId, IReadOnlyList<PrivateEndpointConnectionDataModel> privateEndpointConnections, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicNetworkAccess = publicNetworkAccess;
            ProvisioningState = provisioningState;
            PrivateLinkScopeId = privateLinkScopeId;
            PrivateEndpointConnections = privateEndpointConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints. </summary>
        [WirePath("publicNetworkAccess")]
        public HybridComputePublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </summary>
        [WirePath("provisioningState")]
        public string ProvisioningState { get; }
        /// <summary> The Guid id of the private link scope. </summary>
        [WirePath("privateLinkScopeId")]
        public string PrivateLinkScopeId { get; }
        /// <summary> The collection of associated Private Endpoint Connections. </summary>
        [WirePath("privateEndpointConnections")]
        public IReadOnlyList<PrivateEndpointConnectionDataModel> PrivateEndpointConnections { get; }
    }
}
