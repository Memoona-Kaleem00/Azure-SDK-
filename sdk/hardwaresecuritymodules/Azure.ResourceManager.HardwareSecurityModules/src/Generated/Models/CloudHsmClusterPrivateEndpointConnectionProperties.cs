// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Properties of the private endpoint connection. </summary>
    public partial class CloudHsmClusterPrivateEndpointConnectionProperties
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

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionState"/> is null. </exception>
        public CloudHsmClusterPrivateEndpointConnectionProperties(CloudHsmClusterPrivateLinkServiceConnectionState connectionState)
        {
            Argument.AssertNotNull(connectionState, nameof(connectionState));

            ConnectionState = connectionState;
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="privateEndpoint"> The private endpoint resource. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="groupIds"> The group ids for the private endpoint resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudHsmClusterPrivateEndpointConnectionProperties(SubResource privateEndpoint, CloudHsmClusterPrivateLinkServiceConnectionState connectionState, CloudHsmClusterPrivateEndpointConnectionProvisioningState? provisioningState, IReadOnlyList<string> groupIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            GroupIds = groupIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterPrivateEndpointConnectionProperties"/> for deserialization. </summary>
        internal CloudHsmClusterPrivateEndpointConnectionProperties()
        {
        }

        /// <summary> The private endpoint resource. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        [WirePath("privateEndpoint.id")]
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        [WirePath("privateLinkServiceConnectionState")]
        public CloudHsmClusterPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        [WirePath("provisioningState")]
        public CloudHsmClusterPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> The group ids for the private endpoint resource. </summary>
        [WirePath("groupIds")]
        public IReadOnlyList<string> GroupIds { get; }
    }
}
