﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary>
    /// QueueServiceStatistics.
    /// </summary>
    [CodeGenModel("Logging")]
    public partial class QueueAnalyticsLogging
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public QueueAnalyticsLogging() { }

        internal QueueAnalyticsLogging(
            string version,
            bool delete,
            bool read,
            bool write,
            QueueRetentionPolicy retentionPolicy)
        {
            Version = version;
            Delete = delete;
            Read = read;
            Write = write;
            RetentionPolicy = retentionPolicy;
        }
    }
}
