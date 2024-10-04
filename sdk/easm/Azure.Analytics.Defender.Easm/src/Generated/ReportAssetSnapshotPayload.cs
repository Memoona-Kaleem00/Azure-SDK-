// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The ReportAssetSnapshotPayload. </summary>
    public partial class ReportAssetSnapshotPayload
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

        /// <summary> Initializes a new instance of <see cref="ReportAssetSnapshotPayload"/>. </summary>
        public ReportAssetSnapshotPayload()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReportAssetSnapshotPayload"/>. </summary>
        /// <param name="metric"></param>
        /// <param name="labelName"></param>
        /// <param name="size"></param>
        /// <param name="page"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportAssetSnapshotPayload(string metric, string labelName, int? size, int? page, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metric = metric;
            LabelName = labelName;
            Size = size;
            Page = page;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the metric. </summary>
        public string Metric { get; set; }
        /// <summary> Gets or sets the label name. </summary>
        public string LabelName { get; set; }
        /// <summary> Gets or sets the size. </summary>
        public int? Size { get; set; }
        /// <summary> Gets or sets the page. </summary>
        public int? Page { get; set; }
    }
}
