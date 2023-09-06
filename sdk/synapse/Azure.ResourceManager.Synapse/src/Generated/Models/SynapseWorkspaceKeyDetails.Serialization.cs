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
    public partial class SynapseWorkspaceKeyDetails : IUtf8JsonSerializable, IModelJsonSerializable<SynapseWorkspaceKeyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseWorkspaceKeyDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseWorkspaceKeyDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceKeyDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUrl"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
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

        internal static SynapseWorkspaceKeyDetails DeserializeSynapseWorkspaceKeyDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<Uri> keyVaultUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseWorkspaceKeyDetails(name.Value, keyVaultUrl.Value, rawData);
        }

        SynapseWorkspaceKeyDetails IModelJsonSerializable<SynapseWorkspaceKeyDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceKeyDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseWorkspaceKeyDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseWorkspaceKeyDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceKeyDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseWorkspaceKeyDetails IModelSerializable<SynapseWorkspaceKeyDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceKeyDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseWorkspaceKeyDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseWorkspaceKeyDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseWorkspaceKeyDetails"/> to convert. </param>
        public static implicit operator RequestContent(SynapseWorkspaceKeyDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseWorkspaceKeyDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseWorkspaceKeyDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseWorkspaceKeyDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
