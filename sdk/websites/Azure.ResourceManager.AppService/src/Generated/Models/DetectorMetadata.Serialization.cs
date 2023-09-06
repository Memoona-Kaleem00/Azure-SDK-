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

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class DetectorMetadata : IUtf8JsonSerializable, IModelJsonSerializable<DetectorMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DetectorMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DetectorMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorMetadata>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource"u8);
                if (DataSource is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DetectorDataSource>)DataSource).Serialize(writer, options);
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

        internal static DetectorMetadata DeserializeDetectorMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DetectorDataSource> dataSource = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSource = DetectorDataSource.DeserializeDetectorDataSource(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DetectorMetadata(dataSource.Value, rawData);
        }

        DetectorMetadata IModelJsonSerializable<DetectorMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorMetadata>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectorMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DetectorMetadata>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorMetadata>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DetectorMetadata IModelSerializable<DetectorMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorMetadata>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDetectorMetadata(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DetectorMetadata"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DetectorMetadata"/> to convert. </param>
        public static implicit operator RequestContent(DetectorMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DetectorMetadata"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DetectorMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDetectorMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
