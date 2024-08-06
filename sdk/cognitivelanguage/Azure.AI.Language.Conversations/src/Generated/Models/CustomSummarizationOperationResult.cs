// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Result for the custom summarization task on the conversation. </summary>
    public partial class CustomSummarizationOperationResult : AnalyzeConversationOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomSummarizationOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="results"> Custom Summary Result. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal CustomSummarizationOperationResult(DateTimeOffset lastUpdateDateTime, ConversationActionState status, CustomSummaryResult results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Kind = AnalyzeConversationOperationResultsKind.CustomSummarizationOperationResults;
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSummarizationOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> discriminator kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="results"> Custom Summary Result. </param>
        internal CustomSummarizationOperationResult(DateTimeOffset lastUpdateDateTime, ConversationActionState status, string name, AnalyzeConversationOperationResultsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, CustomSummaryResult results) : base(lastUpdateDateTime, status, name, kind, serializedAdditionalRawData)
        {
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSummarizationOperationResult"/> for deserialization. </summary>
        internal CustomSummarizationOperationResult()
        {
        }

        /// <summary> Custom Summary Result. </summary>
        public CustomSummaryResult Results { get; }
    }
}
