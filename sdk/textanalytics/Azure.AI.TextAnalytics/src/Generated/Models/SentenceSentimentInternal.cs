// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentenceSentiment. </summary>
    internal readonly partial struct SentenceSentimentInternal
    {
        /// <summary> Initializes a new instance of SentenceSentimentInternal. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="aspects"> The array of aspect object for the sentence. </param>
        /// <param name="opinions"> The array of opinion object for the sentence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/>, <paramref name="sentiment"/>, <paramref name="confidenceScores"/>, <paramref name="aspects"/>, or <paramref name="opinions"/> is null. </exception>
        internal SentenceSentimentInternal(string text, string sentiment, SentimentConfidenceScores confidenceScores, int offset, int length, IEnumerable<SentenceAspect> aspects, IEnumerable<SentenceOpinion> opinions)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (sentiment == null)
            {
                throw new ArgumentNullException(nameof(sentiment));
            }
            if (confidenceScores == null)
            {
                throw new ArgumentNullException(nameof(confidenceScores));
            }
            if (aspects == null)
            {
                throw new ArgumentNullException(nameof(aspects));
            }
            if (opinions == null)
            {
                throw new ArgumentNullException(nameof(opinions));
            }

            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Aspects = aspects.ToList();
            Opinions = opinions.ToList();
        }

        /// <summary> Initializes a new instance of SentenceSentimentInternal. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="aspects"> The array of aspect object for the sentence. </param>
        /// <param name="opinions"> The array of opinion object for the sentence. </param>
        internal SentenceSentimentInternal(string text, string sentiment, SentimentConfidenceScores confidenceScores, int offset, int length, IReadOnlyList<SentenceAspect> aspects, IReadOnlyList<SentenceOpinion> opinions)
        {
            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Aspects = aspects;
            Opinions = opinions;
        }
    }
}
