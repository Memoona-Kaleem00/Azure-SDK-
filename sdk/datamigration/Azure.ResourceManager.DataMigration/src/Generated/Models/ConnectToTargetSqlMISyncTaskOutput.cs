// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure SQL Database Managed Instance. </summary>
    public partial class ConnectToTargetSqlMISyncTaskOutput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMISyncTaskOutput"/>. </summary>
        internal ConnectToTargetSqlMISyncTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMISyncTaskOutput"/>. </summary>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetSqlMISyncTaskOutput(string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<ReportableException> validationErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ValidationErrors = validationErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
