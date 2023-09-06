// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentenceSentiment. </summary>
    internal readonly partial struct SentenceSentimentInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private readonly Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SentenceSentimentInternal"/>. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="targets"> The array of sentence targets for the sentence. </param>
        /// <param name="assessments"> The array of assessments for the sentence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/>, <paramref name="sentiment"/>, <paramref name="confidenceScores"/>, <paramref name="targets"/> or <paramref name="assessments"/> is null. </exception>
        public SentenceSentimentInternal(string text, string sentiment, SentimentConfidenceScores confidenceScores, int offset, int length, IEnumerable<SentenceTarget> targets, IEnumerable<SentenceAssessment> assessments)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(sentiment, nameof(sentiment));
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));
            Argument.AssertNotNull(targets, nameof(targets));
            Argument.AssertNotNull(assessments, nameof(assessments));

            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Targets = targets.ToList();
            Assessments = assessments.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SentenceSentimentInternal"/>. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="targets"> The array of sentence targets for the sentence. </param>
        /// <param name="assessments"> The array of assessments for the sentence. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SentenceSentimentInternal(string text, string sentiment, SentimentConfidenceScores confidenceScores, int offset, int length, IReadOnlyList<SentenceTarget> targets, IReadOnlyList<SentenceAssessment> assessments, Dictionary<string, BinaryData> rawData)
        {
            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Targets = targets;
            Assessments = assessments;
            _rawData = rawData;
        }
    }
}
