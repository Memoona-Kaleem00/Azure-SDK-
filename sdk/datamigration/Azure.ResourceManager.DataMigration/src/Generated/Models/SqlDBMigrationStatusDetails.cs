// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Detailed status of current Sql Db migration. </summary>
    public partial class SqlDBMigrationStatusDetails
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

        /// <summary> Initializes a new instance of <see cref="SqlDBMigrationStatusDetails"/>. </summary>
        internal SqlDBMigrationStatusDetails()
        {
            SqlDataCopyErrors = new ChangeTrackingList<string>();
            ListOfCopyProgressDetails = new ChangeTrackingList<CopyProgressDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlDBMigrationStatusDetails"/>. </summary>
        /// <param name="migrationState"> Current State of Migration. </param>
        /// <param name="sqlDataCopyErrors"> Sql Data Copy errors, if any. </param>
        /// <param name="listOfCopyProgressDetails"> Details on progress of ADF copy activities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlDBMigrationStatusDetails(string migrationState, IReadOnlyList<string> sqlDataCopyErrors, IReadOnlyList<CopyProgressDetails> listOfCopyProgressDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MigrationState = migrationState;
            SqlDataCopyErrors = sqlDataCopyErrors;
            ListOfCopyProgressDetails = listOfCopyProgressDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Current State of Migration. </summary>
        public string MigrationState { get; }
        /// <summary> Sql Data Copy errors, if any. </summary>
        public IReadOnlyList<string> SqlDataCopyErrors { get; }
        /// <summary> Details on progress of ADF copy activities. </summary>
        public IReadOnlyList<CopyProgressDetails> ListOfCopyProgressDetails { get; }
    }
}
