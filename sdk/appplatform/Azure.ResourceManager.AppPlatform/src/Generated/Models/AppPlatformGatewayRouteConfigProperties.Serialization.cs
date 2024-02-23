// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayRouteConfigProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformGatewayRouteConfigProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformGatewayRouteConfigProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformGatewayRouteConfigProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayRouteConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (AppResourceId != null)
            {
                writer.WritePropertyName("appResourceId"u8);
                writer.WriteStringValue(AppResourceId);
            }
            if (OpenApi != null)
            {
                writer.WritePropertyName("openApi"u8);
                writer.WriteObjectValue(OpenApi);
            }
            if (Protocol.HasValue)
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (!(Routes is ChangeTrackingList<AppPlatformGatewayApiRoute> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AppPlatformGatewayRouteConfigProperties IJsonModel<AppPlatformGatewayRouteConfigProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayRouteConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformGatewayRouteConfigProperties(document.RootElement, options);
        }

        internal static AppPlatformGatewayRouteConfigProperties DeserializeAppPlatformGatewayRouteConfigProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformGatewayProvisioningState> provisioningState = default;
            Optional<ResourceIdentifier> appResourceId = default;
            Optional<GatewayRouteConfigOpenApiProperties> openApi = default;
            Optional<AppPlatformGatewayRouteConfigProtocol> protocol = default;
            IList<AppPlatformGatewayApiRoute> routes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformGatewayProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("openApi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openApi = GatewayRouteConfigOpenApiProperties.DeserializeGatewayRouteConfigOpenApiProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new AppPlatformGatewayRouteConfigProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformGatewayApiRoute> array = new List<AppPlatformGatewayApiRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformGatewayApiRoute.DeserializeAppPlatformGatewayApiRoute(item, options));
                    }
                    routes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformGatewayRouteConfigProperties(Optional.ToNullable(provisioningState), appResourceId.Value, openApi.Value, Optional.ToNullable(protocol), routes ?? new ChangeTrackingList<AppPlatformGatewayApiRoute>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformGatewayRouteConfigProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayRouteConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformGatewayRouteConfigProperties IPersistableModel<AppPlatformGatewayRouteConfigProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayRouteConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformGatewayRouteConfigProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformGatewayRouteConfigProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
