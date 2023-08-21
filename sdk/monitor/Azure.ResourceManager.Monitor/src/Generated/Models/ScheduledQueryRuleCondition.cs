// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A condition of the scheduled query rule. </summary>
    public partial class ScheduledQueryRuleCondition
    {
        /// <summary> Initializes a new instance of ScheduledQueryRuleCondition. </summary>
        public ScheduledQueryRuleCondition()
        {
            Dimensions = new Core.ChangeTrackingList<MonitorDimension>();
        }

        /// <summary> Initializes a new instance of ScheduledQueryRuleCondition. </summary>
        /// <param name="query"> Log query alert. </param>
        /// <param name="timeAggregation"> Aggregation type. Relevant and required only for rules of the kind LogAlert. </param>
        /// <param name="metricMeasureColumn"> The column containing the metric measure number. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="resourceIdColumn"> The column containing the resource id. The content of the column must be a uri formatted as resource id. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="dimensions"> List of Dimensions conditions. </param>
        /// <param name="operator"> The criteria operator. Relevant and required only for rules of the kind LogAlert. </param>
        /// <param name="threshold"> the criteria threshold value that activates the alert. Relevant and required only for rules of the kind LogAlert. </param>
        /// <param name="failingPeriods"> The minimum number of violations required within the selected lookback time window required to raise an alert. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="metricName"> The name of the metric to be sent. Relevant and required only for rules of the kind LogToMetric. </param>
        internal ScheduledQueryRuleCondition(string query, ScheduledQueryRuleTimeAggregationType? timeAggregation, string metricMeasureColumn, string resourceIdColumn, IList<MonitorDimension> dimensions, MonitorConditionOperator? @operator, double? threshold, ConditionFailingPeriods failingPeriods, string metricName)
        {
            Query = query;
            TimeAggregation = timeAggregation;
            MetricMeasureColumn = metricMeasureColumn;
            ResourceIdColumn = resourceIdColumn;
            Dimensions = dimensions;
            Operator = @operator;
            Threshold = threshold;
            FailingPeriods = failingPeriods;
            MetricName = metricName;
        }

        /// <summary> Log query alert. </summary>
        public string Query { get; set; }
        /// <summary> Aggregation type. Relevant and required only for rules of the kind LogAlert. </summary>
        public ScheduledQueryRuleTimeAggregationType? TimeAggregation { get; set; }
        /// <summary> The column containing the metric measure number. Relevant only for rules of the kind LogAlert. </summary>
        public string MetricMeasureColumn { get; set; }
        /// <summary> The column containing the resource id. The content of the column must be a uri formatted as resource id. Relevant only for rules of the kind LogAlert. </summary>
        public string ResourceIdColumn { get; set; }
        /// <summary> List of Dimensions conditions. </summary>
        public IList<MonitorDimension> Dimensions { get; }
        /// <summary> The criteria operator. Relevant and required only for rules of the kind LogAlert. </summary>
        public MonitorConditionOperator? Operator { get; set; }
        /// <summary> the criteria threshold value that activates the alert. Relevant and required only for rules of the kind LogAlert. </summary>
        public double? Threshold { get; set; }
        /// <summary> The minimum number of violations required within the selected lookback time window required to raise an alert. Relevant only for rules of the kind LogAlert. </summary>
        public ConditionFailingPeriods FailingPeriods { get; set; }
        /// <summary> The name of the metric to be sent. Relevant and required only for rules of the kind LogToMetric. </summary>
        public string MetricName { get; set; }
    }
}
