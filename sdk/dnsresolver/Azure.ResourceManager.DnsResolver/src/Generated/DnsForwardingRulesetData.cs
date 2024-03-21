// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing the DnsForwardingRuleset data model.
    /// Describes a DNS forwarding ruleset.
    /// </summary>
    public partial class DnsForwardingRulesetData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulesetData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="dnsResolverOutboundEndpoints"> The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverOutboundEndpoints"/> is null. </exception>
        public DnsForwardingRulesetData(AzureLocation location, IEnumerable<WritableSubResource> dnsResolverOutboundEndpoints) : base(location)
        {
            Argument.AssertNotNull(dnsResolverOutboundEndpoints, nameof(dnsResolverOutboundEndpoints));

            DnsResolverOutboundEndpoints = dnsResolverOutboundEndpoints.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulesetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> ETag of the DNS forwarding ruleset. </param>
        /// <param name="dnsResolverOutboundEndpoints"> The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers. </param>
        /// <param name="provisioningState"> The current provisioning state of the DNS forwarding ruleset. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="resourceGuid"> The resourceGuid for the DNS forwarding ruleset. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsForwardingRulesetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, IList<WritableSubResource> dnsResolverOutboundEndpoints, DnsResolverProvisioningState? provisioningState, Guid? resourceGuid, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            DnsResolverOutboundEndpoints = dnsResolverOutboundEndpoints;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulesetData"/> for deserialization. </summary>
        internal DnsForwardingRulesetData()
        {
        }

        /// <summary> ETag of the DNS forwarding ruleset. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers. </summary>
        public IList<WritableSubResource> DnsResolverOutboundEndpoints { get; }
        /// <summary> The current provisioning state of the DNS forwarding ruleset. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverProvisioningState? ProvisioningState { get; }
        /// <summary> The resourceGuid for the DNS forwarding ruleset. </summary>
        public Guid? ResourceGuid { get; }
    }
}
