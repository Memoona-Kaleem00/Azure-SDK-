// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The response to a metrics query. </summary>
    public partial class PredictiveResponse
    {
        /// <summary> Initializes a new instance of PredictiveResponse. </summary>
        internal PredictiveResponse()
        {
            Data = new ChangeTrackingList<PredictiveValue>();
        }

        /// <summary> Initializes a new instance of PredictiveResponse. </summary>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="metricName"> The metrics being queried. </param>
        /// <param name="targetResourceId"> resource of the predictive metric. </param>
        /// <param name="data"> the value of the collection. </param>
        internal PredictiveResponse(string timespan, TimeSpan? interval, string metricName, ResourceIdentifier targetResourceId, IReadOnlyList<PredictiveValue> data)
        {
            Timespan = timespan;
            Interval = interval;
            MetricName = metricName;
            TargetResourceId = targetResourceId;
            Data = data;
        }

        /// <summary> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </summary>
        public string Timespan { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan? Interval { get; }
        /// <summary> The metrics being queried. </summary>
        public string MetricName { get; }
        /// <summary> resource of the predictive metric. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary> the value of the collection. </summary>
        public IReadOnlyList<PredictiveValue> Data { get; }
    }
}
