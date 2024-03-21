// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes role compute resource. </summary>
    public partial class EdgeKubernetesRoleCompute
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

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleCompute"/>. </summary>
        /// <param name="vmProfile"> VM profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmProfile"/> is null. </exception>
        public EdgeKubernetesRoleCompute(string vmProfile)
        {
            Argument.AssertNotNull(vmProfile, nameof(vmProfile));

            VmProfile = vmProfile;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleCompute"/>. </summary>
        /// <param name="vmProfile"> VM profile. </param>
        /// <param name="memoryInBytes"> Memory in bytes. </param>
        /// <param name="processorCount"> Processor count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeKubernetesRoleCompute(string vmProfile, long? memoryInBytes, int? processorCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmProfile = vmProfile;
            MemoryInBytes = memoryInBytes;
            ProcessorCount = processorCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleCompute"/> for deserialization. </summary>
        internal EdgeKubernetesRoleCompute()
        {
        }

        /// <summary> VM profile. </summary>
        public string VmProfile { get; set; }
        /// <summary> Memory in bytes. </summary>
        public long? MemoryInBytes { get; }
        /// <summary> Processor count. </summary>
        public int? ProcessorCount { get; }
    }
}
