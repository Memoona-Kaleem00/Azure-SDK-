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
    public partial class SynapseEntityReference : IUtf8JsonSerializable, IModelJsonSerializable<SynapseEntityReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseEntityReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseEntityReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseEntityReference>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IntegrationRuntimeEntityReferenceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IntegrationRuntimeEntityReferenceType.Value.ToString());
            }
            if (Optional.IsDefined(ReferenceName))
            {
                writer.WritePropertyName("referenceName"u8);
                writer.WriteStringValue(ReferenceName);
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

        internal static SynapseEntityReference DeserializeSynapseEntityReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SynapseIntegrationRuntimeEntityReferenceType> type = default;
            Optional<string> referenceName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SynapseIntegrationRuntimeEntityReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseEntityReference(Optional.ToNullable(type), referenceName.Value, rawData);
        }

        SynapseEntityReference IModelJsonSerializable<SynapseEntityReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseEntityReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseEntityReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseEntityReference>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseEntityReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseEntityReference IModelSerializable<SynapseEntityReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseEntityReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseEntityReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseEntityReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseEntityReference"/> to convert. </param>
        public static implicit operator RequestContent(SynapseEntityReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseEntityReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseEntityReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseEntityReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
