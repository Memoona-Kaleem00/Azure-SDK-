// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Network ACLs for the resource. </summary>
    public partial class SignalRNetworkAcls
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

        /// <summary> Initializes a new instance of <see cref="SignalRNetworkAcls"/>. </summary>
        public SignalRNetworkAcls()
        {
            PrivateEndpoints = new ChangeTrackingList<SignalRPrivateEndpointAcl>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRNetworkAcls"/>. </summary>
        /// <param name="defaultAction"> Azure Networking ACL Action. </param>
        /// <param name="publicNetwork"> Network ACL. </param>
        /// <param name="privateEndpoints"> ACLs for requests from private endpoints. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRNetworkAcls(SignalRNetworkAclAction? defaultAction, SignalRNetworkAcl publicNetwork, IList<SignalRPrivateEndpointAcl> privateEndpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultAction = defaultAction;
            PublicNetwork = publicNetwork;
            PrivateEndpoints = privateEndpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Azure Networking ACL Action. </summary>
        [WirePath("defaultAction")]
        public SignalRNetworkAclAction? DefaultAction { get; set; }
        /// <summary> Network ACL. </summary>
        [WirePath("publicNetwork")]
        public SignalRNetworkAcl PublicNetwork { get; set; }
        /// <summary> ACLs for requests from private endpoints. </summary>
        [WirePath("privateEndpoints")]
        public IList<SignalRPrivateEndpointAcl> PrivateEndpoints { get; }
    }
}
