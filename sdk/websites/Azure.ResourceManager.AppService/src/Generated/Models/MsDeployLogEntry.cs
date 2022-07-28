// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> MSDeploy log entry. </summary>
    public partial class MsDeployLogEntry
    {
        /// <summary> Initializes a new instance of MsDeployLogEntry. </summary>
        internal MsDeployLogEntry()
        {
        }

        /// <summary> Initializes a new instance of MsDeployLogEntry. </summary>
        /// <param name="time"> Timestamp of log entry. </param>
        /// <param name="msDeployLogEntryType"> Log entry type. </param>
        /// <param name="message"> Log entry message. </param>
        internal MsDeployLogEntry(DateTimeOffset? time, MSDeployLogEntryType? msDeployLogEntryType, string message)
        {
            Time = time;
            MSDeployLogEntryType = msDeployLogEntryType;
            Message = message;
        }

        /// <summary> Timestamp of log entry. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> Log entry type. </summary>
        public MSDeployLogEntryType? MSDeployLogEntryType { get; }
        /// <summary> Log entry message. </summary>
        public string Message { get; }
    }
}
