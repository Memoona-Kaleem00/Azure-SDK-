// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Base class for all types of DMS command properties. If command is not supported by current client, this object is returned.
    /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
    /// </summary>
    public abstract partial class CommandProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommandProperties"/>. </summary>
        protected CommandProperties()
        {
            Errors = new ChangeTrackingList<ODataError>();
        }

        /// <summary> Initializes a new instance of <see cref="CommandProperties"/>. </summary>
        /// <param name="commandType"> Command type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the command. This is ignored if submitted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommandProperties(CommandType commandType, IReadOnlyList<ODataError> errors, CommandState? state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CommandType = commandType;
            Errors = errors;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Command type. </summary>
        internal CommandType CommandType { get; set; }
        /// <summary> Array of errors. This is ignored if submitted. </summary>
        public IReadOnlyList<ODataError> Errors { get; }
        /// <summary> The state of the command. This is ignored if submitted. </summary>
        public CommandState? State { get; }
    }
}
