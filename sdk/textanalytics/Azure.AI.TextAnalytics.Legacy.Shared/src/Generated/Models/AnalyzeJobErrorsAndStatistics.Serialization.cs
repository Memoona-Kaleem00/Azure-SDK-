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

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class AnalyzeJobErrorsAndStatistics : IUtf8JsonSerializable, IModelJsonSerializable<AnalyzeJobErrorsAndStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnalyzeJobErrorsAndStatistics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnalyzeJobErrorsAndStatistics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeJobErrorsAndStatistics>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TextAnalyticsError>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                if (Statistics is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RequestStatistics>)Statistics).Serialize(writer, options);
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

        internal static AnalyzeJobErrorsAndStatistics DeserializeAnalyzeJobErrorsAndStatistics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<TextAnalyticsError>> errors = default;
            Optional<RequestStatistics> statistics = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAnalyticsError> array = new List<TextAnalyticsError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsError.DeserializeTextAnalyticsError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = RequestStatistics.DeserializeRequestStatistics(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnalyzeJobErrorsAndStatistics(Optional.ToList(errors), statistics.Value, rawData);
        }

        AnalyzeJobErrorsAndStatistics IModelJsonSerializable<AnalyzeJobErrorsAndStatistics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeJobErrorsAndStatistics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeJobErrorsAndStatistics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnalyzeJobErrorsAndStatistics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeJobErrorsAndStatistics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnalyzeJobErrorsAndStatistics IModelSerializable<AnalyzeJobErrorsAndStatistics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeJobErrorsAndStatistics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnalyzeJobErrorsAndStatistics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnalyzeJobErrorsAndStatistics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnalyzeJobErrorsAndStatistics"/> to convert. </param>
        public static implicit operator RequestContent(AnalyzeJobErrorsAndStatistics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnalyzeJobErrorsAndStatistics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnalyzeJobErrorsAndStatistics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnalyzeJobErrorsAndStatistics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
