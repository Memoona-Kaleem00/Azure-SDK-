// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> Storage Service Properties. </summary>
    public partial class QueueServiceProperties
    {
        /// <summary> Initializes a new instance of QueueServiceProperties. </summary>
        public QueueServiceProperties()
        {
            Cors = new ChangeTrackingList<QueueCorsRule>();
        }

        /// <summary> Initializes a new instance of QueueServiceProperties. </summary>
        /// <param name="logging"> Azure Analytics Logging settings. </param>
        /// <param name="hourMetrics"> A summary of request statistics grouped by API in hourly aggregates for queues. </param>
        /// <param name="minuteMetrics"> a summary of request statistics grouped by API in minute aggregates for queues. </param>
        /// <param name="cors"> The set of CORS rules. </param>
        internal QueueServiceProperties(QueueAnalyticsLogging logging, QueueMetrics hourMetrics, QueueMetrics minuteMetrics, IList<QueueCorsRule> cors)
        {
            Logging = logging;
            HourMetrics = hourMetrics;
            MinuteMetrics = minuteMetrics;
            Cors = cors;
        }

        /// <summary> Azure Analytics Logging settings. </summary>
        public QueueAnalyticsLogging Logging { get; set; }
        /// <summary> A summary of request statistics grouped by API in hourly aggregates for queues. </summary>
        public QueueMetrics HourMetrics { get; set; }
        /// <summary> a summary of request statistics grouped by API in minute aggregates for queues. </summary>
        public QueueMetrics MinuteMetrics { get; set; }
    }
}
