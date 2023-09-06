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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapsePrivateEndpointConnectionForPrivateLinkHubData : IUtf8JsonSerializable, IModelJsonSerializable<SynapsePrivateEndpointConnectionForPrivateLinkHubData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapsePrivateEndpointConnectionForPrivateLinkHubData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionForPrivateLinkHubData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SynapsePrivateEndpointConnectionProperties>)Properties).Serialize(writer, options);
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

        internal static SynapsePrivateEndpointConnectionForPrivateLinkHubData DeserializeSynapsePrivateEndpointConnectionForPrivateLinkHubData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SynapsePrivateEndpointConnectionProperties> properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SynapsePrivateEndpointConnectionProperties.DeserializeSynapsePrivateEndpointConnectionProperties(property.Value);
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapsePrivateEndpointConnectionForPrivateLinkHubData(id, name, type, systemData.Value, properties.Value, rawData);
        }

        SynapsePrivateEndpointConnectionForPrivateLinkHubData IModelJsonSerializable<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionForPrivateLinkHubData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapsePrivateEndpointConnectionForPrivateLinkHubData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionForPrivateLinkHubData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapsePrivateEndpointConnectionForPrivateLinkHubData IModelSerializable<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapsePrivateEndpointConnectionForPrivateLinkHubData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapsePrivateEndpointConnectionForPrivateLinkHubData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubData"/> to convert. </param>
        public static implicit operator RequestContent(SynapsePrivateEndpointConnectionForPrivateLinkHubData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapsePrivateEndpointConnectionForPrivateLinkHubData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapsePrivateEndpointConnectionForPrivateLinkHubData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
