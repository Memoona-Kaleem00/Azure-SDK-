// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A list of AzureVMSS instances which can be included or excluded to run packet capture. If both included and excluded are empty, then the packet capture will run on all instances of AzureVMSS. </summary>
    public partial class PacketCaptureMachineScope
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

        /// <summary> Initializes a new instance of <see cref="PacketCaptureMachineScope"/>. </summary>
        public PacketCaptureMachineScope()
        {
            Include = new ChangeTrackingList<string>();
            Exclude = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PacketCaptureMachineScope"/>. </summary>
        /// <param name="include"> List of AzureVMSS instances to run packet capture on. </param>
        /// <param name="exclude"> List of AzureVMSS instances which has to be excluded from the AzureVMSS from running packet capture. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCaptureMachineScope(IList<string> include, IList<string> exclude, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Include = include;
            Exclude = exclude;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of AzureVMSS instances to run packet capture on. </summary>
        public IList<string> Include { get; }
        /// <summary> List of AzureVMSS instances which has to be excluded from the AzureVMSS from running packet capture. </summary>
        public IList<string> Exclude { get; }
    }
}
