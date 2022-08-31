// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Entity insight Item. </summary>
    public partial class EntityInsightItem
    {
        /// <summary> Initializes a new instance of EntityInsightItem. </summary>
        internal EntityInsightItem()
        {
            ChartQueryResults = new ChangeTrackingList<InsightsTableResult>();
        }

        /// <summary> Initializes a new instance of EntityInsightItem. </summary>
        /// <param name="queryId"> The query id of the insight. </param>
        /// <param name="queryTimeInterval"> The Time interval that the query actually executed on. </param>
        /// <param name="tableQueryResults"> Query results for table insights query. </param>
        /// <param name="chartQueryResults"> Query results for table insights query. </param>
        internal EntityInsightItem(string queryId, EntityInsightItemQueryTimeInterval queryTimeInterval, InsightsTableResult tableQueryResults, IReadOnlyList<InsightsTableResult> chartQueryResults)
        {
            QueryId = queryId;
            QueryTimeInterval = queryTimeInterval;
            TableQueryResults = tableQueryResults;
            ChartQueryResults = chartQueryResults;
        }

        /// <summary> The query id of the insight. </summary>
        public string QueryId { get; }
        /// <summary> The Time interval that the query actually executed on. </summary>
        public EntityInsightItemQueryTimeInterval QueryTimeInterval { get; }
        /// <summary> Query results for table insights query. </summary>
        public InsightsTableResult TableQueryResults { get; }
        /// <summary> Query results for table insights query. </summary>
        public IReadOnlyList<InsightsTableResult> ChartQueryResults { get; }
    }
}
