// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Parameters to query a knowledge base. </summary>
    public partial class AnswersOptions
    {
        /// <summary> Initializes a new instance of <see cref="AnswersOptions"/>. </summary>
        public AnswersOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnswersOptions"/>. </summary>
        /// <param name="qnaId"> Exact QnA ID to fetch from the knowledge base, this field takes priority over question. </param>
        /// <param name="question"> User question to query against the knowledge base. </param>
        /// <param name="size"> Max number of answers to be returned for the question. </param>
        /// <param name="userId"> Unique identifier for the user. </param>
        /// <param name="confidenceThreshold"> Minimum threshold score for answers, value ranges from 0 to 1. </param>
        /// <param name="answerContext"> Context object with previous QnA's information. </param>
        /// <param name="rankerKind"> Type of ranker to be used. </param>
        /// <param name="filters"> Filter QnAs based on given metadata list and knowledge base sources. </param>
        /// <param name="shortAnswerOptions"> To configure Answer span prediction feature. </param>
        /// <param name="includeUnstructuredSources"> (Optional) Flag to enable Query over Unstructured Sources. </param>
        internal AnswersOptions(int qnaId, string question, int size, string userId, double? confidenceThreshold, KnowledgeBaseAnswerContext answerContext, RankerKind? rankerKind, QueryFilters filters, ShortAnswerOptions shortAnswerOptions, bool? includeUnstructuredSources)
        {
            QnaId = qnaId;
            Question = question;
            Size = size;
            UserId = userId;
            ConfidenceThreshold = confidenceThreshold;
            AnswerContext = answerContext;
            RankerKind = rankerKind;
            Filters = filters;
            ShortAnswerOptions = shortAnswerOptions;
            IncludeUnstructuredSources = includeUnstructuredSources;
        }
        /// <summary> Unique identifier for the user. </summary>
        public string UserId { get; set; }
        /// <summary> Minimum threshold score for answers, value ranges from 0 to 1. </summary>
        public double? ConfidenceThreshold { get; set; }
        /// <summary> Context object with previous QnA's information. </summary>
        public KnowledgeBaseAnswerContext AnswerContext { get; set; }
        /// <summary> Type of ranker to be used. </summary>
        public RankerKind? RankerKind { get; set; }
        /// <summary> Filter QnAs based on given metadata list and knowledge base sources. </summary>
        public QueryFilters Filters { get; set; }
        /// <summary> To configure Answer span prediction feature. </summary>
        public ShortAnswerOptions ShortAnswerOptions { get; set; }
        /// <summary> (Optional) Flag to enable Query over Unstructured Sources. </summary>
        public bool? IncludeUnstructuredSources { get; set; }
    }
}
