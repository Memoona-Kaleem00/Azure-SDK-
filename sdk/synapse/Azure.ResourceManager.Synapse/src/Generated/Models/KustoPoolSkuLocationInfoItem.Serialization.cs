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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class KustoPoolSkuLocationInfoItem : IUtf8JsonSerializable, IModelJsonSerializable<KustoPoolSkuLocationInfoItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KustoPoolSkuLocationInfoItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KustoPoolSkuLocationInfoItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoPoolSkuLocationInfoItem>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
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

        internal static KustoPoolSkuLocationInfoItem DeserializeKustoPoolSkuLocationInfoItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation location = default;
            Optional<IReadOnlyList<string>> zones = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KustoPoolSkuLocationInfoItem(location, Optional.ToList(zones), rawData);
        }

        KustoPoolSkuLocationInfoItem IModelJsonSerializable<KustoPoolSkuLocationInfoItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoPoolSkuLocationInfoItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoPoolSkuLocationInfoItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KustoPoolSkuLocationInfoItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoPoolSkuLocationInfoItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KustoPoolSkuLocationInfoItem IModelSerializable<KustoPoolSkuLocationInfoItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoPoolSkuLocationInfoItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKustoPoolSkuLocationInfoItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KustoPoolSkuLocationInfoItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KustoPoolSkuLocationInfoItem"/> to convert. </param>
        public static implicit operator RequestContent(KustoPoolSkuLocationInfoItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KustoPoolSkuLocationInfoItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KustoPoolSkuLocationInfoItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKustoPoolSkuLocationInfoItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
