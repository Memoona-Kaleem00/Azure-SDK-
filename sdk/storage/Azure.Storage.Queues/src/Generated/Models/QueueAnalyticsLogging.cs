// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> Azure Analytics Logging settings. </summary>
    public partial class QueueAnalyticsLogging
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueueAnalyticsLogging"/>. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="delete"> Indicates whether all delete requests should be logged. </param>
        /// <param name="read"> Indicates whether all read requests should be logged. </param>
        /// <param name="write"> Indicates whether all write requests should be logged. </param>
        /// <param name="retentionPolicy"> the retention policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueAnalyticsLogging(string version, bool delete, bool read, bool write, QueueRetentionPolicy retentionPolicy, Dictionary<string, BinaryData> rawData)
        {
            Version = version;
            Delete = delete;
            Read = read;
            Write = write;
            RetentionPolicy = retentionPolicy;
            _rawData = rawData;
        }

        /// <summary> The version of Storage Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether all delete requests should be logged. </summary>
        public bool Delete { get; set; }
        /// <summary> Indicates whether all read requests should be logged. </summary>
        public bool Read { get; set; }
        /// <summary> Indicates whether all write requests should be logged. </summary>
        public bool Write { get; set; }
        /// <summary> the retention policy. </summary>
        public QueueRetentionPolicy RetentionPolicy { get; set; }
    }
}
