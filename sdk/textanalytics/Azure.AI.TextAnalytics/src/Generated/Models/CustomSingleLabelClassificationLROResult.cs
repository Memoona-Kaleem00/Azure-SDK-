// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The CustomSingleLabelClassificationLROResult. </summary>
    internal partial class CustomSingleLabelClassificationLROResult : AnalyzeTextLROResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        public CustomSingleLabelClassificationLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, CustomLabelClassificationResult results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results;
            Kind = AnalyzeTextLROResultsKind.CustomSingleLabelClassificationLROResults;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="kind"> Enumeration of supported Text Analysis long-running operation task results. </param>
        /// <param name="taskName"></param>
        /// <param name="results"></param>
        internal CustomSingleLabelClassificationLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, AnalyzeTextLROResultsKind kind, string taskName, CustomLabelClassificationResult results) : base(lastUpdateDateTime, status, kind, taskName)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Gets or sets the results. </summary>
        public CustomLabelClassificationResult Results { get; set; }
    }
}
