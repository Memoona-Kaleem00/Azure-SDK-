// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TopQueries
    {
        /// <summary>
        /// Initializes a new instance of the TopQueries class.
        /// </summary>
        public TopQueries()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopQueries class.
        /// </summary>
        /// <param name="numberOfQueries">Requested number of top
        /// queries.</param>
        /// <param name="aggregationFunction">Aggregation function used to
        /// calculate query metrics.</param>
        /// <param name="observationMetric">Metric used to rank
        /// queries.</param>
        /// <param name="intervalType">Interval type (length). Possible values
        /// include: 'PT1H', 'P1D'</param>
        /// <param name="startTime">The start time for the metric (ISO-8601
        /// format).</param>
        /// <param name="endTime">The end time for the metric (ISO-8601
        /// format).</param>
        /// <param name="queries">List of top resource consuming queries with
        /// appropriate metric data</param>
        public TopQueries(int? numberOfQueries = default(int?), string aggregationFunction = default(string), string observationMetric = default(string), QueryTimeGrainType? intervalType = default(QueryTimeGrainType?), string startTime = default(string), string endTime = default(string), IList<QueryStatisticsProperties> queries = default(IList<QueryStatisticsProperties>))
        {
            NumberOfQueries = numberOfQueries;
            AggregationFunction = aggregationFunction;
            ObservationMetric = observationMetric;
            IntervalType = intervalType;
            StartTime = startTime;
            EndTime = endTime;
            Queries = queries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets requested number of top queries.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfQueries")]
        public int? NumberOfQueries { get; private set; }

        /// <summary>
        /// Gets aggregation function used to calculate query metrics.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationFunction")]
        public string AggregationFunction { get; private set; }

        /// <summary>
        /// Gets metric used to rank queries.
        /// </summary>
        [JsonProperty(PropertyName = "observationMetric")]
        public string ObservationMetric { get; private set; }

        /// <summary>
        /// Gets interval type (length). Possible values include: 'PT1H', 'P1D'
        /// </summary>
        [JsonProperty(PropertyName = "intervalType")]
        public QueryTimeGrainType? IntervalType { get; private set; }

        /// <summary>
        /// Gets the start time for the metric (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; private set; }

        /// <summary>
        /// Gets the end time for the metric (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; private set; }

        /// <summary>
        /// Gets or sets list of top resource consuming queries with
        /// appropriate metric data
        /// </summary>
        [JsonProperty(PropertyName = "queries")]
        public IList<QueryStatisticsProperties> Queries { get; set; }

    }
}
