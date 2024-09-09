// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the control record synchronized from app compliance. </summary>
    public partial class ControlSyncRecord
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

        /// <summary> Initializes a new instance of <see cref="ControlSyncRecord"/>. </summary>
        public ControlSyncRecord()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ControlSyncRecord"/>. </summary>
        /// <param name="controlId"> The Id of the control. e.g. "Operational_Security_10". </param>
        /// <param name="controlStatus"> Control status synchronized from app compliance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ControlSyncRecord(string controlId, string controlStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ControlId = controlId;
            ControlStatus = controlStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Id of the control. e.g. "Operational_Security_10". </summary>
        public string ControlId { get; set; }
        /// <summary> Control status synchronized from app compliance. </summary>
        public string ControlStatus { get; set; }
    }
}
