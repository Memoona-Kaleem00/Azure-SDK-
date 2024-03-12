// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Istio egress gateway configuration. </summary>
    public partial class IstioEgressGateway
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

        /// <summary> Initializes a new instance of <see cref="IstioEgressGateway"/>. </summary>
        /// <param name="isEnabled"> Whether to enable the egress gateway. </param>
        public IstioEgressGateway(bool isEnabled)
        {
            IsEnabled = isEnabled;
            NodeSelector = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="IstioEgressGateway"/>. </summary>
        /// <param name="isEnabled"> Whether to enable the egress gateway. </param>
        /// <param name="nodeSelector"> NodeSelector for scheduling the egress gateway. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IstioEgressGateway(bool isEnabled, IDictionary<string, string> nodeSelector, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            NodeSelector = nodeSelector;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IstioEgressGateway"/> for deserialization. </summary>
        internal IstioEgressGateway()
        {
        }

        /// <summary> Whether to enable the egress gateway. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> NodeSelector for scheduling the egress gateway. </summary>
        public IDictionary<string, string> NodeSelector { get; }
    }
}
