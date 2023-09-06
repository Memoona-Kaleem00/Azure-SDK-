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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsError : IUtf8JsonSerializable, IModelJsonSerializable<StreamAnalyticsError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamAnalyticsError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamAnalyticsError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsError>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("error"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StreamAnalyticsErrorDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static StreamAnalyticsError DeserializeStreamAnalyticsError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<StreamAnalyticsErrorDetails>> details = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamAnalyticsErrorDetails> array = new List<StreamAnalyticsErrorDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsErrorDetails.DeserializeStreamAnalyticsErrorDetails(item));
                            }
                            details = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StreamAnalyticsError(code.Value, message.Value, target.Value, Optional.ToList(details), rawData);
        }

        StreamAnalyticsError IModelJsonSerializable<StreamAnalyticsError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamAnalyticsError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamAnalyticsError IModelSerializable<StreamAnalyticsError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamAnalyticsError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamAnalyticsError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamAnalyticsError"/> to convert. </param>
        public static implicit operator RequestContent(StreamAnalyticsError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamAnalyticsError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamAnalyticsError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamAnalyticsError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
