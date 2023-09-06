// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownProviderSpecificProperties : IUtf8JsonSerializable, IModelJsonSerializable<ProviderSpecificProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderSpecificProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProviderSpecificProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
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

        internal static ProviderSpecificProperties DeserializeUnknownProviderSpecificProperties(JsonElement element, ModelSerializerOptions options = default) => DeserializeProviderSpecificProperties(element, options);

        ProviderSpecificProperties IModelJsonSerializable<ProviderSpecificProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownProviderSpecificProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderSpecificProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProviderSpecificProperties IModelSerializable<ProviderSpecificProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderSpecificProperties(doc.RootElement, options);
        }
    }
}
