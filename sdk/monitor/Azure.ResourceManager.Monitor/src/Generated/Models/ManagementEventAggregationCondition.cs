// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> How the data that is collected should be combined over time. </summary>
    public partial class ManagementEventAggregationCondition
    {
        /// <summary> Initializes a new instance of ManagementEventAggregationCondition. </summary>
        public ManagementEventAggregationCondition()
        {
        }

        /// <summary> Initializes a new instance of ManagementEventAggregationCondition. </summary>
        /// <param name="operator"> the condition operator. </param>
        /// <param name="threshold"> The threshold value that activates the alert. </param>
        /// <param name="windowSize"> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. If specified then it must be between 5 minutes and 1 day. </param>
        internal ManagementEventAggregationCondition(ConditionOperator? @operator, double? threshold, TimeSpan? windowSize)
        {
            Operator = @operator;
            Threshold = threshold;
            WindowSize = windowSize;
        }

        /// <summary> the condition operator. </summary>
        public ConditionOperator? Operator { get; set; }
        /// <summary> The threshold value that activates the alert. </summary>
        public double? Threshold { get; set; }
        /// <summary> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. If specified then it must be between 5 minutes and 1 day. </summary>
        public TimeSpan? WindowSize { get; set; }
    }
}
