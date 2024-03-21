// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkPacketCaptureData : IUtf8JsonSerializable, IJsonModel<MobileNetworkPacketCaptureData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkPacketCaptureData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkPacketCaptureData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPacketCaptureData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (options.Format != "W" && Optional.IsDefined(CaptureStartOn))
            {
                writer.WritePropertyName("captureStartTime"u8);
                writer.WriteStringValue(CaptureStartOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BytesToCapturePerPacket))
            {
                writer.WritePropertyName("bytesToCapturePerPacket"u8);
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (Optional.IsDefined(TotalBytesPerSession))
            {
                writer.WritePropertyName("totalBytesPerSession"u8);
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (Optional.IsDefined(TimeLimitInSeconds))
            {
                writer.WritePropertyName("timeLimitInSeconds"u8);
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(OutputFiles))
            {
                writer.WritePropertyName("outputFiles"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        MobileNetworkPacketCaptureData IJsonModel<MobileNetworkPacketCaptureData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPacketCaptureData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPacketCaptureData(document.RootElement, options);
        }

        internal static MobileNetworkPacketCaptureData DeserializeMobileNetworkPacketCaptureData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            MobileNetworkProvisioningState? provisioningState = default;
            MobileNetworkPacketCaptureStatus? status = default;
            string reason = default;
            DateTimeOffset? captureStartTime = default;
            IList<string> networkInterfaces = default;
            long? bytesToCapturePerPacket = default;
            long? totalBytesPerSession = default;
            int? timeLimitInSeconds = default;
            IReadOnlyList<string> outputFiles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new MobileNetworkPacketCaptureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reason"u8))
                        {
                            reason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("captureStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            captureStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("bytesToCapturePerPacket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesToCapturePerPacket = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalBytesPerSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalBytesPerSession = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("timeLimitInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeLimitInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("outputFiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            outputFiles = array;
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
            return new MobileNetworkPacketCaptureData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                status,
                reason,
                captureStartTime,
                networkInterfaces ?? new ChangeTrackingList<string>(),
                bytesToCapturePerPacket,
                totalBytesPerSession,
                timeLimitInSeconds,
                outputFiles ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkPacketCaptureData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPacketCaptureData)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkPacketCaptureData IPersistableModel<MobileNetworkPacketCaptureData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkPacketCaptureData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPacketCaptureData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkPacketCaptureData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
