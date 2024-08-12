// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Security compliance properties of the resource. </summary>
    public partial class SecurityComplianceStatus
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

        /// <summary> Initializes a new instance of <see cref="SecurityComplianceStatus"/>. </summary>
        internal SecurityComplianceStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityComplianceStatus"/>. </summary>
        /// <param name="securedCoreCompliance"> Indicates whether HCI hosts meets secured-core server requirements. </param>
        /// <param name="wdacCompliance"> Indicates whether HCI hosts have enforced consistent Windows Defender Application Control. </param>
        /// <param name="dataAtRestEncrypted"> Indicates whether data at-rest encryption is enabled on Azure Stack HCI clustered volumes. </param>
        /// <param name="dataInTransitProtected"> Indicates whether HCI cluster has data in-transit protection. </param>
        /// <param name="lastUpdatedOn"> Time in UTC when compliance status was last updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityComplianceStatus(HciClusterComplianceStatus? securedCoreCompliance, HciClusterComplianceStatus? wdacCompliance, HciClusterComplianceStatus? dataAtRestEncrypted, HciClusterComplianceStatus? dataInTransitProtected, DateTimeOffset? lastUpdatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecuredCoreCompliance = securedCoreCompliance;
            WdacCompliance = wdacCompliance;
            DataAtRestEncrypted = dataAtRestEncrypted;
            DataInTransitProtected = dataInTransitProtected;
            LastUpdatedOn = lastUpdatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether HCI hosts meets secured-core server requirements. </summary>
        [WirePath("securedCoreCompliance")]
        public HciClusterComplianceStatus? SecuredCoreCompliance { get; }
        /// <summary> Indicates whether HCI hosts have enforced consistent Windows Defender Application Control. </summary>
        [WirePath("wdacCompliance")]
        public HciClusterComplianceStatus? WdacCompliance { get; }
        /// <summary> Indicates whether data at-rest encryption is enabled on Azure Stack HCI clustered volumes. </summary>
        [WirePath("dataAtRestEncrypted")]
        public HciClusterComplianceStatus? DataAtRestEncrypted { get; }
        /// <summary> Indicates whether HCI cluster has data in-transit protection. </summary>
        [WirePath("dataInTransitProtected")]
        public HciClusterComplianceStatus? DataInTransitProtected { get; }
        /// <summary> Time in UTC when compliance status was last updated. </summary>
        [WirePath("lastUpdated")]
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
