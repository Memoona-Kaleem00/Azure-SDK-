// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class PiiEntitiesDocumentResult : IUtf8JsonSerializable, IModelJsonSerializable<PiiEntitiesDocumentResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PiiEntitiesDocumentResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PiiEntitiesDocumentResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiEntitiesDocumentResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("redactedText"u8);
            writer.WriteStringValue(RedactedText);
            writer.WritePropertyName("entities"u8);
            writer.WriteStartArray();
            foreach (var item in Entities)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<Entity>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings"u8);
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DocumentWarning>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                if (Statistics.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TextDocumentStatistics>)Statistics.Value).Serialize(writer, options);
                }
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

        internal static PiiEntitiesDocumentResult DeserializePiiEntitiesDocumentResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string redactedText = default;
            IList<Entity> entities = default;
            string id = default;
            IList<DocumentWarning> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redactedText"u8))
                {
                    redactedText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"u8))
                {
                    List<Entity> array = new List<Entity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Entity.DeserializeEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PiiEntitiesDocumentResult(id, warnings, Optional.ToNullable(statistics), redactedText, entities, rawData);
        }

        PiiEntitiesDocumentResult IModelJsonSerializable<PiiEntitiesDocumentResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiEntitiesDocumentResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePiiEntitiesDocumentResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PiiEntitiesDocumentResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiEntitiesDocumentResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PiiEntitiesDocumentResult IModelSerializable<PiiEntitiesDocumentResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiEntitiesDocumentResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePiiEntitiesDocumentResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PiiEntitiesDocumentResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PiiEntitiesDocumentResult"/> to convert. </param>
        public static implicit operator RequestContent(PiiEntitiesDocumentResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PiiEntitiesDocumentResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PiiEntitiesDocumentResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePiiEntitiesDocumentResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
