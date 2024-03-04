// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The settings for the long term backup. </summary>
    public partial class PostgreSqlFlexibleServerBackupSettings
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupSettings"/>. </summary>
        /// <param name="backupName"> Backup Name for the current backup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public PostgreSqlFlexibleServerBackupSettings(string backupName)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            BackupName = backupName;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupSettings"/>. </summary>
        /// <param name="backupName"> Backup Name for the current backup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerBackupSettings(string backupName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackupName = backupName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupSettings"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerBackupSettings()
        {
        }

        /// <summary> Backup Name for the current backup. </summary>
        [WirePath("backupName")]
        public string BackupName { get; }
    }
}
