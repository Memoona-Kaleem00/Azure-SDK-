// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the WorkspaceManagerAssignment data model.
    /// The workspace manager assignment
    /// </summary>
    public partial class WorkspaceManagerAssignmentData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerAssignmentData"/>. </summary>
        public WorkspaceManagerAssignmentData()
        {
            Items = new ChangeTrackingList<AssignmentItem>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="targetResourceName"> The resource name of the workspace manager group targeted by the workspace manager assignment. </param>
        /// <param name="lastJobEndOn"> The time the last job associated to this assignment ended at. </param>
        /// <param name="lastJobProvisioningState"> State of the last job associated to this assignment. </param>
        /// <param name="items"> List of resources included in this workspace manager assignment. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceManagerAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string targetResourceName, DateTimeOffset? lastJobEndOn, ProvisioningState? lastJobProvisioningState, IList<AssignmentItem> items, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TargetResourceName = targetResourceName;
            LastJobEndOn = lastJobEndOn;
            LastJobProvisioningState = lastJobProvisioningState;
            Items = items;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource name of the workspace manager group targeted by the workspace manager assignment. </summary>
        [WirePath("properties.targetResourceName")]
        public string TargetResourceName { get; set; }
        /// <summary> The time the last job associated to this assignment ended at. </summary>
        [WirePath("properties.lastJobEndTime")]
        public DateTimeOffset? LastJobEndOn { get; }
        /// <summary> State of the last job associated to this assignment. </summary>
        [WirePath("properties.lastJobProvisioningState")]
        public ProvisioningState? LastJobProvisioningState { get; }
        /// <summary> List of resources included in this workspace manager assignment. </summary>
        [WirePath("properties.items")]
        public IList<AssignmentItem> Items { get; }
        /// <summary> Resource Etag. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; }
    }
}
