// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The private IP addresses/IP ranges to which traffic will not be SNAT. </summary>
    public partial class FirewallPolicySnat
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

        /// <summary> Initializes a new instance of <see cref="FirewallPolicySnat"/>. </summary>
        public FirewallPolicySnat()
        {
            PrivateRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicySnat"/>. </summary>
        /// <param name="privateRanges"> List of private IP addresses/IP address ranges to not be SNAT. </param>
        /// <param name="autoLearnPrivateRanges"> The operation mode for automatically learning private ranges to not be SNAT. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicySnat(IList<string> privateRanges, AutoLearnPrivateRangesMode? autoLearnPrivateRanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrivateRanges = privateRanges;
            AutoLearnPrivateRanges = autoLearnPrivateRanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of private IP addresses/IP address ranges to not be SNAT. </summary>
        public IList<string> PrivateRanges { get; }
        /// <summary> The operation mode for automatically learning private ranges to not be SNAT. </summary>
        public AutoLearnPrivateRangesMode? AutoLearnPrivateRanges { get; set; }
    }
}
