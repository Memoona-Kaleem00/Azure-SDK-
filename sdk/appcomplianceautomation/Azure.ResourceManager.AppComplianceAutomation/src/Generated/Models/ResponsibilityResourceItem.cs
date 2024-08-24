// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the resource. </summary>
    public partial class ResponsibilityResourceItem
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

        /// <summary> Initializes a new instance of <see cref="ResponsibilityResourceItem"/>. </summary>
        internal ResponsibilityResourceItem()
        {
            RecommendationIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResponsibilityResourceItem"/>. </summary>
        /// <param name="resourceId"> The Id of the resource. </param>
        /// <param name="accountId"> Account Id. For example - AWS account Id. </param>
        /// <param name="resourceType"> The type of the resource. e.g. "Microsoft.SignalRService/SignalR". </param>
        /// <param name="resourceOrigin"> Resource origin. </param>
        /// <param name="resourceStatus"> Resource status. </param>
        /// <param name="resourceStatusChangedOn"> The status change date for the resource. </param>
        /// <param name="recommendationIds"> List of recommendation id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResponsibilityResourceItem(ResourceIdentifier resourceId, string accountId, ResourceType? resourceType, ReportResourceOrigin? resourceOrigin, ReportResourceStatus? resourceStatus, DateTimeOffset? resourceStatusChangedOn, IReadOnlyList<string> recommendationIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            AccountId = accountId;
            ResourceType = resourceType;
            ResourceOrigin = resourceOrigin;
            ResourceStatus = resourceStatus;
            ResourceStatusChangedOn = resourceStatusChangedOn;
            RecommendationIds = recommendationIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Id of the resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Account Id. For example - AWS account Id. </summary>
        public string AccountId { get; }
        /// <summary> The type of the resource. e.g. "Microsoft.SignalRService/SignalR". </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Resource origin. </summary>
        public ReportResourceOrigin? ResourceOrigin { get; }
        /// <summary> Resource status. </summary>
        public ReportResourceStatus? ResourceStatus { get; }
        /// <summary> The status change date for the resource. </summary>
        public DateTimeOffset? ResourceStatusChangedOn { get; }
        /// <summary> List of recommendation id. </summary>
        public IReadOnlyList<string> RecommendationIds { get; }
    }
}
