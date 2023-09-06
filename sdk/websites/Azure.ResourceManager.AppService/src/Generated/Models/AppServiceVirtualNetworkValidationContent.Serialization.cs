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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceVirtualNetworkValidationContent : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceVirtualNetworkValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceVirtualNetworkValidationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceVirtualNetworkValidationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkValidationContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetResourceGroup))
            {
                writer.WritePropertyName("vnetResourceGroup"u8);
                writer.WriteStringValue(VnetResourceGroup);
            }
            if (Optional.IsDefined(VnetName))
            {
                writer.WritePropertyName("vnetName"u8);
                writer.WriteStringValue(VnetName);
            }
            if (Optional.IsDefined(VnetSubnetName))
            {
                writer.WritePropertyName("vnetSubnetName"u8);
                writer.WriteStringValue(VnetSubnetName);
            }
            if (Optional.IsDefined(SubnetResourceId))
            {
                writer.WritePropertyName("subnetResourceId"u8);
                writer.WriteStringValue(SubnetResourceId);
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

        internal static AppServiceVirtualNetworkValidationContent DeserializeAppServiceVirtualNetworkValidationContent(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> vnetResourceGroup = default;
            Optional<string> vnetName = default;
            Optional<string> vnetSubnetName = default;
            Optional<ResourceIdentifier> subnetResourceId = default;
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
                        if (property0.NameEquals("vnetResourceGroup"u8))
                        {
                            vnetResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetName"u8))
                        {
                            vnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetSubnetName"u8))
                        {
                            vnetSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetResourceId = new ResourceIdentifier(property0.Value.GetString());
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
            return new AppServiceVirtualNetworkValidationContent(id, name, type, systemData.Value, vnetResourceGroup.Value, vnetName.Value, vnetSubnetName.Value, subnetResourceId.Value, kind.Value, rawData);
        }

        AppServiceVirtualNetworkValidationContent IModelJsonSerializable<AppServiceVirtualNetworkValidationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkValidationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceVirtualNetworkValidationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceVirtualNetworkValidationContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkValidationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceVirtualNetworkValidationContent IModelSerializable<AppServiceVirtualNetworkValidationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceVirtualNetworkValidationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceVirtualNetworkValidationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceVirtualNetworkValidationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceVirtualNetworkValidationContent"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceVirtualNetworkValidationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceVirtualNetworkValidationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceVirtualNetworkValidationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceVirtualNetworkValidationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
