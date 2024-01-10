// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Configuration values for periodic mode backup. </summary>
    public partial class PeriodicModeProperties
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

        /// <summary> Initializes a new instance of <see cref="PeriodicModeProperties"/>. </summary>
        public PeriodicModeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeriodicModeProperties"/>. </summary>
        /// <param name="backupIntervalInMinutes"> An integer representing the interval in minutes between two backups. </param>
        /// <param name="backupRetentionIntervalInHours"> An integer representing the time (in hours) that each backup is retained. </param>
        /// <param name="backupStorageRedundancy"> Enum to indicate type of backup residency. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeriodicModeProperties(int? backupIntervalInMinutes, int? backupRetentionIntervalInHours, CosmosDBBackupStorageRedundancy? backupStorageRedundancy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackupIntervalInMinutes = backupIntervalInMinutes;
            BackupRetentionIntervalInHours = backupRetentionIntervalInHours;
            BackupStorageRedundancy = backupStorageRedundancy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An integer representing the interval in minutes between two backups. </summary>
        public int? BackupIntervalInMinutes { get; set; }
        /// <summary> An integer representing the time (in hours) that each backup is retained. </summary>
        public int? BackupRetentionIntervalInHours { get; set; }
        /// <summary> Enum to indicate type of backup residency. </summary>
        public CosmosDBBackupStorageRedundancy? BackupStorageRedundancy { get; set; }
    }
}
