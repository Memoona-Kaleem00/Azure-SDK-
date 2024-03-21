// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> The environment to which cluster belongs. </summary>
    public partial class ClusterEnvironmentEntity
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

        /// <summary> Initializes a new instance of <see cref="ClusterEnvironmentEntity"/>. </summary>
        internal ClusterEnvironmentEntity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClusterEnvironmentEntity"/>. </summary>
        /// <param name="id"> ID of the referred resource. </param>
        /// <param name="environment"> Environment of the referred resource. </param>
        /// <param name="related"> API URL for accessing or modifying the referred object. </param>
        /// <param name="resourceName"> CRN reference to the referred resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterEnvironmentEntity(string id, string environment, string related, string resourceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Environment = environment;
            Related = related;
            ResourceName = resourceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID of the referred resource. </summary>
        public string Id { get; }
        /// <summary> Environment of the referred resource. </summary>
        public string Environment { get; }
        /// <summary> API URL for accessing or modifying the referred object. </summary>
        public string Related { get; }
        /// <summary> CRN reference to the referred resource. </summary>
        public string ResourceName { get; }
    }
}
