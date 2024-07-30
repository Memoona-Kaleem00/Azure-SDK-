// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing the StorageAccountMigration data model.
    /// The parameters or status associated with an ongoing or enqueued storage account migration in order to update its current SKU or region.
    /// </summary>
    public partial class StorageAccountMigrationData
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountMigrationData"/>. </summary>
        /// <param name="targetSkuName"> Target sku name for the account. </param>
        public StorageAccountMigrationData(StorageSkuName targetSkuName)
        {
            TargetSkuName = targetSkuName;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountMigrationData"/>. </summary>
        /// <param name="id"> Migration Resource Id. </param>
        /// <param name="name"> current value is 'default' for customer initiated migration. </param>
        /// <param name="resourceType"> SrpAccountMigrationType in ARM contract which is 'accountMigrations'. </param>
        /// <param name="targetSkuName"> Target sku name for the account. </param>
        /// <param name="migrationStatus"> Current status of migration. </param>
        /// <param name="migrationFailedReason"> Error code for migration failure. </param>
        /// <param name="migrationFailedDetailedReason"> Reason for migration failure. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountMigrationData(string id, string name, ResourceType? resourceType, StorageSkuName targetSkuName, StorageAccountMigrationStatus? migrationStatus, string migrationFailedReason, string migrationFailedDetailedReason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            TargetSkuName = targetSkuName;
            MigrationStatus = migrationStatus;
            MigrationFailedReason = migrationFailedReason;
            MigrationFailedDetailedReason = migrationFailedDetailedReason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountMigrationData"/> for deserialization. </summary>
        internal StorageAccountMigrationData()
        {
        }

        /// <summary> Migration Resource Id. </summary>
        [WirePath("id")]
        public string Id { get; }
        /// <summary> current value is 'default' for customer initiated migration. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> SrpAccountMigrationType in ARM contract which is 'accountMigrations'. </summary>
        [WirePath("type")]
        public ResourceType? ResourceType { get; set; }
        /// <summary> Target sku name for the account. </summary>
        [WirePath("properties.targetSkuName")]
        public StorageSkuName TargetSkuName { get; set; }
        /// <summary> Current status of migration. </summary>
        [WirePath("properties.migrationStatus")]
        public StorageAccountMigrationStatus? MigrationStatus { get; }
        /// <summary> Error code for migration failure. </summary>
        [WirePath("properties.migrationFailedReason")]
        public string MigrationFailedReason { get; }
        /// <summary> Reason for migration failure. </summary>
        [WirePath("properties.migrationFailedDetailedReason")]
        public string MigrationFailedDetailedReason { get; }
    }
}
