// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of a workload network. </summary>
    internal partial class WorkloadNetworkProperties
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

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkProperties"/>. </summary>
        internal WorkloadNetworkProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkProperties(WorkloadNetworkProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the resource. </summary>
        public WorkloadNetworkProvisioningState? ProvisioningState { get; }
    }
}
