// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> (Deprecated. Please use LogSettings) Log storage settings. </summary>
    public partial class LogStorageSettings
    {
        /// <summary> Initializes a new instance of <see cref="LogStorageSettings"/>. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public LogStorageSettings(LinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="LogStorageSettings"/>. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <param name="path"> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </param>
        /// <param name="logLevel"> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </param>
        /// <param name="enableReliableLogging"> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LogStorageSettings(LinkedServiceReference linkedServiceName, object path, object logLevel, object enableReliableLogging, IDictionary<string, object> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            LogLevel = logLevel;
            EnableReliableLogging = enableReliableLogging;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Log storage linked service reference. </summary>
        public LinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
        /// <summary> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </summary>
        public object LogLevel { get; set; }
        /// <summary> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableReliableLogging { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
