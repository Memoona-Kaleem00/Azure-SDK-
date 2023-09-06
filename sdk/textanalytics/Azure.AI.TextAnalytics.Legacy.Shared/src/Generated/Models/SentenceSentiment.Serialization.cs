// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class SentenceSentiment : IUtf8JsonSerializable, IModelJsonSerializable<SentenceSentiment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SentenceSentiment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SentenceSentiment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentenceSentiment>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("sentiment"u8);
            writer.WriteStringValue(Sentiment.ToSerialString());
            writer.WritePropertyName("confidenceScores"u8);
            if (ConfidenceScores is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SentimentConfidenceScorePerLabel>)ConfidenceScores).Serialize(writer, options);
            }
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            if (Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SentenceTarget>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Assessments))
            {
                writer.WritePropertyName("assessments"u8);
                writer.WriteStartArray();
                foreach (var item in Assessments)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SentenceAssessment>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SentenceSentiment DeserializeSentenceSentiment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            SentenceSentimentValue sentiment = default;
            SentimentConfidenceScorePerLabel confidenceScores = default;
            int offset = default;
            int length = default;
            Optional<IReadOnlyList<SentenceTarget>> targets = default;
            Optional<IReadOnlyList<SentenceAssessment>> assessments = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"u8))
                {
                    sentiment = property.Value.GetString().ToSentenceSentimentValue();
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    confidenceScores = SentimentConfidenceScorePerLabel.DeserializeSentimentConfidenceScorePerLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SentenceTarget> array = new List<SentenceTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceTarget.DeserializeSentenceTarget(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("assessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SentenceAssessment> array = new List<SentenceAssessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceAssessment.DeserializeSentenceAssessment(item));
                    }
                    assessments = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SentenceSentiment(text, sentiment, confidenceScores, offset, length, Optional.ToList(targets), Optional.ToList(assessments), rawData);
        }

        SentenceSentiment IModelJsonSerializable<SentenceSentiment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentenceSentiment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSentenceSentiment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SentenceSentiment>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentenceSentiment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SentenceSentiment IModelSerializable<SentenceSentiment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentenceSentiment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSentenceSentiment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SentenceSentiment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SentenceSentiment"/> to convert. </param>
        public static implicit operator RequestContent(SentenceSentiment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SentenceSentiment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SentenceSentiment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSentenceSentiment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
