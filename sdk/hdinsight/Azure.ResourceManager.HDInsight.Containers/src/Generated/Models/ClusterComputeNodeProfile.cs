// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The node profile. </summary>
    public partial class ClusterComputeNodeProfile
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

        /// <summary> Initializes a new instance of <see cref="ClusterComputeNodeProfile"/>. </summary>
        /// <param name="nodeProfileType"> The node type. </param>
        /// <param name="vmSize"> The virtual machine SKU. </param>
        /// <param name="count"> The number of virtual machines. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeProfileType"/> or <paramref name="vmSize"/> is null. </exception>
        public ClusterComputeNodeProfile(string nodeProfileType, string vmSize, int count)
        {
            Argument.AssertNotNull(nodeProfileType, nameof(nodeProfileType));
            Argument.AssertNotNull(vmSize, nameof(vmSize));

            NodeProfileType = nodeProfileType;
            VmSize = vmSize;
            Count = count;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterComputeNodeProfile"/>. </summary>
        /// <param name="nodeProfileType"> The node type. </param>
        /// <param name="vmSize"> The virtual machine SKU. </param>
        /// <param name="count"> The number of virtual machines. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterComputeNodeProfile(string nodeProfileType, string vmSize, int count, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NodeProfileType = nodeProfileType;
            VmSize = vmSize;
            Count = count;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterComputeNodeProfile"/> for deserialization. </summary>
        internal ClusterComputeNodeProfile()
        {
        }

        /// <summary> The node type. </summary>
        public string NodeProfileType { get; set; }
        /// <summary> The virtual machine SKU. </summary>
        public string VmSize { get; set; }
        /// <summary> The number of virtual machines. </summary>
        public int Count { get; set; }
    }
}
