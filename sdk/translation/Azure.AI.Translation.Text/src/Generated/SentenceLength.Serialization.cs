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

namespace Azure.AI.Translation.Text
{
    public partial class SentenceLength : IUtf8JsonSerializable, IModelJsonSerializable<SentenceLength>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SentenceLength>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SentenceLength>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("srcSentLen"u8);
            writer.WriteStartArray();
            foreach (var item in SrcSentLen)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("transSentLen"u8);
            writer.WriteStartArray();
            foreach (var item in TransSentLen)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
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

        internal static SentenceLength DeserializeSentenceLength(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<int> srcSentLen = default;
            IReadOnlyList<int> transSentLen = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("srcSentLen"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    srcSentLen = array;
                    continue;
                }
                if (property.NameEquals("transSentLen"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    transSentLen = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SentenceLength(srcSentLen, transSentLen, rawData);
        }

        SentenceLength IModelJsonSerializable<SentenceLength>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSentenceLength(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SentenceLength>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SentenceLength IModelSerializable<SentenceLength>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSentenceLength(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SentenceLength"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SentenceLength"/> to convert. </param>
        public static implicit operator RequestContent(SentenceLength model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SentenceLength"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SentenceLength(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSentenceLength(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
