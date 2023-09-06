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
    public partial class DictionaryLookupItem : IUtf8JsonSerializable, IModelJsonSerializable<DictionaryLookupItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DictionaryLookupItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DictionaryLookupItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("normalizedSource"u8);
            writer.WriteStringValue(NormalizedSource);
            writer.WritePropertyName("displaySource"u8);
            writer.WriteStringValue(DisplaySource);
            writer.WritePropertyName("translations"u8);
            writer.WriteStartArray();
            foreach (var item in Translations)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DictionaryTranslation>)item).Serialize(writer, options);
                }
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

        internal static DictionaryLookupItem DeserializeDictionaryLookupItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string normalizedSource = default;
            string displaySource = default;
            IReadOnlyList<DictionaryTranslation> translations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("normalizedSource"u8))
                {
                    normalizedSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displaySource"u8))
                {
                    displaySource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translations"u8))
                {
                    List<DictionaryTranslation> array = new List<DictionaryTranslation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DictionaryTranslation.DeserializeDictionaryTranslation(item));
                    }
                    translations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DictionaryLookupItem(normalizedSource, displaySource, translations, rawData);
        }

        DictionaryLookupItem IModelJsonSerializable<DictionaryLookupItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDictionaryLookupItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DictionaryLookupItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DictionaryLookupItem IModelSerializable<DictionaryLookupItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDictionaryLookupItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DictionaryLookupItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DictionaryLookupItem"/> to convert. </param>
        public static implicit operator RequestContent(DictionaryLookupItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DictionaryLookupItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DictionaryLookupItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDictionaryLookupItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
