// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains bgp community information offered in Service Community resources. </summary>
    public partial class BgpCommunity
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

        /// <summary> Initializes a new instance of <see cref="BgpCommunity"/>. </summary>
        public BgpCommunity()
        {
            CommunityPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BgpCommunity"/>. </summary>
        /// <param name="serviceSupportedRegion"> The region which the service support. e.g. For O365, region is Global. </param>
        /// <param name="communityName"> The name of the bgp community. e.g. Skype. </param>
        /// <param name="communityValue"> The value of the bgp community. For more information: https://docs.microsoft.com/en-us/azure/expressroute/expressroute-routing. </param>
        /// <param name="communityPrefixes"> The prefixes that the bgp community contains. </param>
        /// <param name="isAuthorizedToUse"> Customer is authorized to use bgp community or not. </param>
        /// <param name="serviceGroup"> The service group of the bgp community contains. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BgpCommunity(string serviceSupportedRegion, string communityName, string communityValue, IList<string> communityPrefixes, bool? isAuthorizedToUse, string serviceGroup, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceSupportedRegion = serviceSupportedRegion;
            CommunityName = communityName;
            CommunityValue = communityValue;
            CommunityPrefixes = communityPrefixes;
            IsAuthorizedToUse = isAuthorizedToUse;
            ServiceGroup = serviceGroup;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The region which the service support. e.g. For O365, region is Global. </summary>
        public string ServiceSupportedRegion { get; set; }
        /// <summary> The name of the bgp community. e.g. Skype. </summary>
        public string CommunityName { get; set; }
        /// <summary> The value of the bgp community. For more information: https://docs.microsoft.com/en-us/azure/expressroute/expressroute-routing. </summary>
        public string CommunityValue { get; set; }
        /// <summary> The prefixes that the bgp community contains. </summary>
        public IList<string> CommunityPrefixes { get; }
        /// <summary> Customer is authorized to use bgp community or not. </summary>
        public bool? IsAuthorizedToUse { get; set; }
        /// <summary> The service group of the bgp community contains. </summary>
        public string ServiceGroup { get; set; }
    }
}
