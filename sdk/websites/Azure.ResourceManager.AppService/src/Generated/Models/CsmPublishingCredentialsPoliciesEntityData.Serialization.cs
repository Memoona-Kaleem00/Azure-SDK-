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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class CsmPublishingCredentialsPoliciesEntityData : IUtf8JsonSerializable, IModelJsonSerializable<CsmPublishingCredentialsPoliciesEntityData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CsmPublishingCredentialsPoliciesEntityData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CsmPublishingCredentialsPoliciesEntityData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmPublishingCredentialsPoliciesEntityData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Allow))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteBooleanValue(Allow.Value);
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

        internal static CsmPublishingCredentialsPoliciesEntityData DeserializeCsmPublishingCredentialsPoliciesEntityData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> allow = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allow = property0.Value.GetBoolean();
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
            return new CsmPublishingCredentialsPoliciesEntityData(id, name, type, systemData.Value, Optional.ToNullable(allow), kind.Value, rawData);
        }

        CsmPublishingCredentialsPoliciesEntityData IModelJsonSerializable<CsmPublishingCredentialsPoliciesEntityData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmPublishingCredentialsPoliciesEntityData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCsmPublishingCredentialsPoliciesEntityData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CsmPublishingCredentialsPoliciesEntityData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmPublishingCredentialsPoliciesEntityData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CsmPublishingCredentialsPoliciesEntityData IModelSerializable<CsmPublishingCredentialsPoliciesEntityData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmPublishingCredentialsPoliciesEntityData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCsmPublishingCredentialsPoliciesEntityData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CsmPublishingCredentialsPoliciesEntityData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CsmPublishingCredentialsPoliciesEntityData"/> to convert. </param>
        public static implicit operator RequestContent(CsmPublishingCredentialsPoliciesEntityData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CsmPublishingCredentialsPoliciesEntityData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CsmPublishingCredentialsPoliciesEntityData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCsmPublishingCredentialsPoliciesEntityData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
