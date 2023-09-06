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
    public partial class SynapseSsisObjectMetadataStatusResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapseSsisObjectMetadataStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseSsisObjectMetadataStatusResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseSsisObjectMetadataStatusResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisObjectMetadataStatusResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStringValue(Properties);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
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

        internal static SynapseSsisObjectMetadataStatusResult DeserializeSynapseSsisObjectMetadataStatusResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> name = default;
            Optional<string> properties = default;
            Optional<string> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseSsisObjectMetadataStatusResult(status.Value, name.Value, properties.Value, error.Value, rawData);
        }

        SynapseSsisObjectMetadataStatusResult IModelJsonSerializable<SynapseSsisObjectMetadataStatusResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisObjectMetadataStatusResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSsisObjectMetadataStatusResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseSsisObjectMetadataStatusResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisObjectMetadataStatusResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseSsisObjectMetadataStatusResult IModelSerializable<SynapseSsisObjectMetadataStatusResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisObjectMetadataStatusResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseSsisObjectMetadataStatusResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseSsisObjectMetadataStatusResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseSsisObjectMetadataStatusResult"/> to convert. </param>
        public static implicit operator RequestContent(SynapseSsisObjectMetadataStatusResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseSsisObjectMetadataStatusResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseSsisObjectMetadataStatusResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseSsisObjectMetadataStatusResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
