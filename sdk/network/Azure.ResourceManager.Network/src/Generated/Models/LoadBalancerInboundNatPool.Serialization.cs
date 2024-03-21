// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancerInboundNatPool : IUtf8JsonSerializable, IJsonModel<LoadBalancerInboundNatPool>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerInboundNatPool>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadBalancerInboundNatPool>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerInboundNatPool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerInboundNatPool)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(FrontendIPConfiguration))
            {
                writer.WritePropertyName("frontendIPConfiguration"u8);
                JsonSerializer.Serialize(writer, FrontendIPConfiguration);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(FrontendPortRangeStart))
            {
                writer.WritePropertyName("frontendPortRangeStart"u8);
                writer.WriteNumberValue(FrontendPortRangeStart.Value);
            }
            if (Optional.IsDefined(FrontendPortRangeEnd))
            {
                writer.WritePropertyName("frontendPortRangeEnd"u8);
                writer.WriteNumberValue(FrontendPortRangeEnd.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort"u8);
                writer.WriteNumberValue(BackendPort.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableFloatingIP))
            {
                writer.WritePropertyName("enableFloatingIP"u8);
                writer.WriteBooleanValue(EnableFloatingIP.Value);
            }
            if (Optional.IsDefined(EnableTcpReset))
            {
                writer.WritePropertyName("enableTcpReset"u8);
                writer.WriteBooleanValue(EnableTcpReset.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        LoadBalancerInboundNatPool IJsonModel<LoadBalancerInboundNatPool>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerInboundNatPool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerInboundNatPool)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerInboundNatPool(document.RootElement, options);
        }

        internal static LoadBalancerInboundNatPool DeserializeLoadBalancerInboundNatPool(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            WritableSubResource frontendIPConfiguration = default;
            LoadBalancingTransportProtocol? protocol = default;
            int? frontendPortRangeStart = default;
            int? frontendPortRangeEnd = default;
            int? backendPort = default;
            int? idleTimeoutInMinutes = default;
            bool? enableFloatingIP = default;
            bool? enableTcpReset = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("frontendIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontendIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new LoadBalancingTransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frontendPortRangeStart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontendPortRangeStart = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("frontendPortRangeEnd"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontendPortRangeEnd = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableFloatingIP"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableFloatingIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableTcpReset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableTcpReset = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadBalancerInboundNatPool(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                frontendIPConfiguration,
                protocol,
                frontendPortRangeStart,
                frontendPortRangeEnd,
                backendPort,
                idleTimeoutInMinutes,
                enableFloatingIP,
                enableTcpReset,
                provisioningState);
        }

        BinaryData IPersistableModel<LoadBalancerInboundNatPool>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerInboundNatPool>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerInboundNatPool)} does not support '{options.Format}' format.");
            }
        }

        LoadBalancerInboundNatPool IPersistableModel<LoadBalancerInboundNatPool>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerInboundNatPool>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBalancerInboundNatPool(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerInboundNatPool)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBalancerInboundNatPool>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
