// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster pool profile. </summary>
    internal partial class ClusterPoolProfile
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

        /// <summary> Initializes a new instance of <see cref="ClusterPoolProfile"/>. </summary>
        /// <param name="clusterPoolVersion"> Cluster pool version is a 2-part version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolVersion"/> is null. </exception>
        public ClusterPoolProfile(string clusterPoolVersion)
        {
            Argument.AssertNotNull(clusterPoolVersion, nameof(clusterPoolVersion));

            ClusterPoolVersion = clusterPoolVersion;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPoolProfile"/>. </summary>
        /// <param name="clusterPoolVersion"> Cluster pool version is a 2-part version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterPoolProfile(string clusterPoolVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterPoolVersion = clusterPoolVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPoolProfile"/> for deserialization. </summary>
        internal ClusterPoolProfile()
        {
        }

        /// <summary> Cluster pool version is a 2-part version. </summary>
        public string ClusterPoolVersion { get; set; }
    }
}
