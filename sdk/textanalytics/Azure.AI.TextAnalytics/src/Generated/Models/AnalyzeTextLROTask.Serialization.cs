// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextLROTask : IUtf8JsonSerializable, IModelJsonSerializable<AnalyzeTextLROTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnalyzeTextLROTask>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnalyzeTextLROTask>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLROTask>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
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

        internal static AnalyzeTextLROTask DeserializeAnalyzeTextLROTask(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AbstractiveSummarization": return AbstractiveSummarizationLROTask.DeserializeAbstractiveSummarizationLROTask(element);
                    case "CustomEntityRecognition": return CustomEntitiesLROTask.DeserializeCustomEntitiesLROTask(element);
                    case "CustomMultiLabelClassification": return CustomMultiLabelClassificationLROTask.DeserializeCustomMultiLabelClassificationLROTask(element);
                    case "CustomSingleLabelClassification": return CustomSingleLabelClassificationLROTask.DeserializeCustomSingleLabelClassificationLROTask(element);
                    case "EntityLinking": return EntityLinkingLROTask.DeserializeEntityLinkingLROTask(element);
                    case "EntityRecognition": return EntitiesLROTask.DeserializeEntitiesLROTask(element);
                    case "ExtractiveSummarization": return ExtractiveSummarizationLROTask.DeserializeExtractiveSummarizationLROTask(element);
                    case "Healthcare": return HealthcareLROTask.DeserializeHealthcareLROTask(element);
                    case "KeyPhraseExtraction": return KeyPhraseLROTask.DeserializeKeyPhraseLROTask(element);
                    case "PiiEntityRecognition": return PiiLROTask.DeserializePiiLROTask(element);
                    case "SentimentAnalysis": return SentimentAnalysisLROTask.DeserializeSentimentAnalysisLROTask(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            AnalyzeTextLROTaskKind kind = default;
            Optional<string> taskName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROTaskKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownAnalyzeTextLROTask(taskName.Value, kind, rawData);
        }

        AnalyzeTextLROTask IModelJsonSerializable<AnalyzeTextLROTask>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLROTask>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextLROTask(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnalyzeTextLROTask>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLROTask>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnalyzeTextLROTask IModelSerializable<AnalyzeTextLROTask>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeTextLROTask>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnalyzeTextLROTask(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnalyzeTextLROTask"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnalyzeTextLROTask"/> to convert. </param>
        public static implicit operator RequestContent(AnalyzeTextLROTask model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnalyzeTextLROTask"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnalyzeTextLROTask(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnalyzeTextLROTask(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
