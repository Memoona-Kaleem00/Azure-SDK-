// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    internal partial class UnknownNamedLineBase : IUtf8JsonSerializable, IModelJsonSerializable<NamedLineBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NamedLineBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NamedLineBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineBase>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static NamedLineBase DeserializeUnknownNamedLineBase(JsonElement element, ModelSerializerOptions options = default) => DeserializeNamedLineBase(element, options);

        NamedLineBase IModelJsonSerializable<NamedLineBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownNamedLineBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NamedLineBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NamedLineBase IModelSerializable<NamedLineBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNamedLineBase(doc.RootElement, options);
        }
    }
}
