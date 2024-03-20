// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntityLinkingTaskResult. </summary>
    internal partial class EntityLinkingTaskResult : AnalyzeTextTaskResult
    {
        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskResult"/>. </summary>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal EntityLinkingTaskResult(EntityLinkingResult results)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results;
            Kind = AnalyzeTextTaskResultsKind.EntityLinkingResults;
        }

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskResult"/>. </summary>
        /// <param name="kind"> Enumeration of supported Text Analysis task results. </param>
        /// <param name="results"></param>
        internal EntityLinkingTaskResult(AnalyzeTextTaskResultsKind kind, EntityLinkingResult results) : base(kind)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Gets the results. </summary>
        public EntityLinkingResult Results { get; }
    }
}
