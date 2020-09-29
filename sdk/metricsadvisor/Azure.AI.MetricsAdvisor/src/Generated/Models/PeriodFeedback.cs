// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The PeriodFeedback. </summary>
    internal partial class PeriodFeedback : MetricFeedback
    {
        /// <summary> Initializes a new instance of PeriodFeedback. </summary>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dimensionFilter"/> or <paramref name="value"/> is null. </exception>
        public PeriodFeedback(Guid metricId, FeedbackDimensionFilter dimensionFilter, PeriodFeedbackValue value) : base(metricId, dimensionFilter)
        {
            if (dimensionFilter == null)
            {
                throw new ArgumentNullException(nameof(dimensionFilter));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            FeedbackType = FeedbackType.Period;
        }

        /// <summary> Initializes a new instance of PeriodFeedback. </summary>
        /// <param name="feedbackType"> feedback type. </param>
        /// <param name="feedbackId"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="value"> . </param>
        internal PeriodFeedback(FeedbackType feedbackType, Guid? feedbackId, DateTimeOffset? createdTime, string userPrincipal, Guid metricId, FeedbackDimensionFilter dimensionFilter, PeriodFeedbackValue value) : base(feedbackType, feedbackId, createdTime, userPrincipal, metricId, dimensionFilter)
        {
            Value = value;
            FeedbackType = feedbackType;
        }

        public PeriodFeedbackValue Value { get; set; }
    }
}
