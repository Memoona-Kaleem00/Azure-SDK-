// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Desktop properties that can be patched. </summary>
    public partial class VirtualDesktopPatch
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

        /// <summary> Initializes a new instance of <see cref="VirtualDesktopPatch"/>. </summary>
        public VirtualDesktopPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualDesktopPatch"/>. </summary>
        /// <param name="tags"> tags to be updated. </param>
        /// <param name="description"> Description of Desktop. </param>
        /// <param name="friendlyName"> Friendly name of Desktop. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualDesktopPatch(IDictionary<string, string> tags, string description, string friendlyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Description = description;
            FriendlyName = friendlyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> Description of Desktop. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Desktop. </summary>
        public string FriendlyName { get; set; }
    }
}
