// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of an iSCSI path resource. </summary>
    public partial class IscsiPathProperties
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

        /// <summary> Initializes a new instance of <see cref="IscsiPathProperties"/>. </summary>
        /// <param name="networkBlock"> CIDR Block for iSCSI path. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkBlock"/> is null. </exception>
        public IscsiPathProperties(string networkBlock)
        {
            Argument.AssertNotNull(networkBlock, nameof(networkBlock));

            NetworkBlock = networkBlock;
        }

        /// <summary> Initializes a new instance of <see cref="IscsiPathProperties"/>. </summary>
        /// <param name="provisioningState"> The state of the iSCSI path provisioning. </param>
        /// <param name="networkBlock"> CIDR Block for iSCSI path. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IscsiPathProperties(IscsiPathProvisioningState? provisioningState, string networkBlock, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            NetworkBlock = networkBlock;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IscsiPathProperties"/> for deserialization. </summary>
        internal IscsiPathProperties()
        {
        }

        /// <summary> The state of the iSCSI path provisioning. </summary>
        public IscsiPathProvisioningState? ProvisioningState { get; }
        /// <summary> CIDR Block for iSCSI path. </summary>
        public string NetworkBlock { get; set; }
    }
}
