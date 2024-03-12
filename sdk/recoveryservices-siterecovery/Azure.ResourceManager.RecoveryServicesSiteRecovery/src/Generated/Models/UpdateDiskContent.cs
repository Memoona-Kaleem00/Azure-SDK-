// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk input for update. </summary>
    public partial class UpdateDiskContent
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

        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> is null. </exception>
        public UpdateDiskContent(string diskId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));

            DiskId = diskId;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="targetDiskName"> The target disk name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateDiskContent(string diskId, string targetDiskName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            TargetDiskName = targetDiskName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/> for deserialization. </summary>
        internal UpdateDiskContent()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The target disk name. </summary>
        public string TargetDiskName { get; set; }
    }
}
