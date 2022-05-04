// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentimentResponseDocumentsItem. </summary>
    internal partial class SentimentResponseDocumentsItem : SentimentDocumentResult
    {
        /// <summary> Initializes a new instance of SentimentResponseDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="confidenceScores"/> or <paramref name="sentences"/> is null. </exception>
        public SentimentResponseDocumentsItem(string id, IEnumerable<DocumentWarning> warnings, TextSentiment sentiment, SentimentConfidenceScores confidenceScores, IEnumerable<SentenceSentimentInternal> sentences) : base(id, warnings, sentiment, confidenceScores, sentences)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }
            if (confidenceScores == null)
            {
                throw new ArgumentNullException(nameof(confidenceScores));
            }
            if (sentences == null)
            {
                throw new ArgumentNullException(nameof(sentences));
            }
        }

        /// <summary> Initializes a new instance of SentimentResponseDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        internal SentimentResponseDocumentsItem(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, TextSentiment sentiment, SentimentConfidenceScores confidenceScores, IList<SentenceSentimentInternal> sentences) : base(id, warnings, statistics, sentiment, confidenceScores, sentences)
        {
        }
    }
}
