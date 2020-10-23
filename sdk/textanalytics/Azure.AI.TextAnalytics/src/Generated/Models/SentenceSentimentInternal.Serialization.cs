// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial struct SentenceSentimentInternal
    {
        internal static SentenceSentimentInternal DeserializeSentenceSentimentInternal(JsonElement element)
        {
            string text = default;
            string sentiment = default;
            SentimentConfidenceScores confidenceScores = default;
            int offset = default;
            int length = default;
            Optional<IReadOnlyList<SentenceAspect>> aspects = default;
            Optional<IReadOnlyList<SentenceOpinion>> opinions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    confidenceScores = SentimentConfidenceScores.DeserializeSentimentConfidenceScores(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("aspects"))
                {
                    List<SentenceAspect> array = new List<SentenceAspect>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceAspect.DeserializeSentenceAspect(item));
                    }
                    aspects = array;
                    continue;
                }
                if (property.NameEquals("opinions"))
                {
                    List<SentenceOpinion> array = new List<SentenceOpinion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceOpinion.DeserializeSentenceOpinion(item));
                    }
                    opinions = array;
                    continue;
                }
            }
            return new SentenceSentimentInternal(text, sentiment, confidenceScores, offset, length, Optional.ToList(aspects), Optional.ToList(opinions));
        }
    }
}
