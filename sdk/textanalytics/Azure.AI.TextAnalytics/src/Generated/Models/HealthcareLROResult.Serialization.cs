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
    internal partial class HealthcareLROResult : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareLROResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareLROResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareLROResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareLROResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            if (Results is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<HealthcareResult>)Results).Serialize(writer, options);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
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

        internal static HealthcareLROResult DeserializeHealthcareLROResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareResult results = default;
            AnalyzeTextLROResultsKind kind = default;
            Optional<string> taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = HealthcareResult.DeserializeHealthcareResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareLROResult(lastUpdateDateTime, status, kind, taskName.Value, results, rawData);
        }

        HealthcareLROResult IModelJsonSerializable<HealthcareLROResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareLROResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareLROResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareLROResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareLROResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareLROResult IModelSerializable<HealthcareLROResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareLROResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareLROResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthcareLROResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthcareLROResult"/> to convert. </param>
        public static implicit operator RequestContent(HealthcareLROResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthcareLROResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthcareLROResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareLROResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
