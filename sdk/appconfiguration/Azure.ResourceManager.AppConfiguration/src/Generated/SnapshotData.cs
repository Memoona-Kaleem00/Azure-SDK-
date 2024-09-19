// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing the Snapshot data model.
    /// The snapshot resource.
    /// </summary>
    public partial class SnapshotData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SnapshotData"/>. </summary>
        public SnapshotData()
        {
            Filters = new ChangeTrackingList<KeyValueFilter>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="snapshotType"> The type of the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the snapshot. </param>
        /// <param name="status"> The current status of the snapshot. </param>
        /// <param name="filters"> A list of filters used to filter the key-values included in the snapshot. </param>
        /// <param name="compositionType"> The composition type describes how the key-values within the snapshot are composed. The 'key' composition type ensures there are no two key-values containing the same key. The 'key_label' composition type ensures there are no two key-values containing the same key and label. </param>
        /// <param name="created"> The time that the snapshot was created. </param>
        /// <param name="expires"> The time that the snapshot will expire. </param>
        /// <param name="retentionPeriod"> The amount of time, in seconds, that a snapshot will remain in the archived state before expiring. This property is only writable during the creation of a snapshot. If not specified, the default lifetime of key-value revisions will be used. </param>
        /// <param name="size"> The size in bytes of the snapshot. </param>
        /// <param name="itemsCount"> The amount of key-values in the snapshot. </param>
        /// <param name="tags"> The tags of the snapshot. NOTE: These are data plane tags, not Azure Resource Manager (ARM) tags. </param>
        /// <param name="eTag"> A value representing the current state of the snapshot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string snapshotType, AppConfigurationProvisioningState? provisioningState, SnapshotStatus? status, IList<KeyValueFilter> filters, CompositionType? compositionType, DateTimeOffset? created, DateTimeOffset? expires, long? retentionPeriod, long? size, long? itemsCount, IDictionary<string, string> tags, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SnapshotType = snapshotType;
            ProvisioningState = provisioningState;
            Status = status;
            Filters = filters;
            CompositionType = compositionType;
            Created = created;
            Expires = expires;
            RetentionPeriod = retentionPeriod;
            Size = size;
            ItemsCount = itemsCount;
            Tags = tags;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the resource. </summary>
        [WirePath("type")]
        public string SnapshotType { get; }
        /// <summary> The provisioning state of the snapshot. </summary>
        [WirePath("properties.provisioningState")]
        public AppConfigurationProvisioningState? ProvisioningState { get; }
        /// <summary> The current status of the snapshot. </summary>
        [WirePath("properties.status")]
        public SnapshotStatus? Status { get; }
        /// <summary> A list of filters used to filter the key-values included in the snapshot. </summary>
        [WirePath("properties.filters")]
        public IList<KeyValueFilter> Filters { get; }
        /// <summary> The composition type describes how the key-values within the snapshot are composed. The 'key' composition type ensures there are no two key-values containing the same key. The 'key_label' composition type ensures there are no two key-values containing the same key and label. </summary>
        [WirePath("properties.compositionType")]
        public CompositionType? CompositionType { get; set; }
        /// <summary> The time that the snapshot was created. </summary>
        [WirePath("properties.created")]
        public DateTimeOffset? Created { get; }
        /// <summary> The time that the snapshot will expire. </summary>
        [WirePath("properties.expires")]
        public DateTimeOffset? Expires { get; }
        /// <summary> The amount of time, in seconds, that a snapshot will remain in the archived state before expiring. This property is only writable during the creation of a snapshot. If not specified, the default lifetime of key-value revisions will be used. </summary>
        [WirePath("properties.retentionPeriod")]
        public long? RetentionPeriod { get; set; }
        /// <summary> The size in bytes of the snapshot. </summary>
        [WirePath("properties.size")]
        public long? Size { get; }
        /// <summary> The amount of key-values in the snapshot. </summary>
        [WirePath("properties.itemsCount")]
        public long? ItemsCount { get; }
        /// <summary> The tags of the snapshot. NOTE: These are data plane tags, not Azure Resource Manager (ARM) tags. </summary>
        [WirePath("properties.tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> A value representing the current state of the snapshot. </summary>
        [WirePath("properties.etag")]
        public ETag? ETag { get; }
    }
}
