// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The elastic pool edition capability. </summary>
    public partial class ElasticPoolEditionCapability
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

        /// <summary> Initializes a new instance of <see cref="ElasticPoolEditionCapability"/>. </summary>
        internal ElasticPoolEditionCapability()
        {
            SupportedElasticPoolPerformanceLevels = new ChangeTrackingList<ElasticPoolPerformanceLevelCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ElasticPoolEditionCapability"/>. </summary>
        /// <param name="name"> The elastic pool edition name. </param>
        /// <param name="supportedElasticPoolPerformanceLevels"> The list of supported elastic pool DTU levels for the edition. </param>
        /// <param name="isZoneRedundant"> Whether or not zone redundancy is supported for the edition. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticPoolEditionCapability(string name, IReadOnlyList<ElasticPoolPerformanceLevelCapability> supportedElasticPoolPerformanceLevels, bool? isZoneRedundant, SqlCapabilityStatus? status, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SupportedElasticPoolPerformanceLevels = supportedElasticPoolPerformanceLevels;
            IsZoneRedundant = isZoneRedundant;
            Status = status;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The elastic pool edition name. </summary>
        public string Name { get; }
        /// <summary> The list of supported elastic pool DTU levels for the edition. </summary>
        public IReadOnlyList<ElasticPoolPerformanceLevelCapability> SupportedElasticPoolPerformanceLevels { get; }
        /// <summary> Whether or not zone redundancy is supported for the edition. </summary>
        public bool? IsZoneRedundant { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
