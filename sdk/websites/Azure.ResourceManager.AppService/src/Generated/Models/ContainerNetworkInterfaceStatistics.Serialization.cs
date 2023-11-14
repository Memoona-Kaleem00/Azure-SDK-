// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerNetworkInterfaceStatistics : IUtf8JsonSerializable, IJsonModel<ContainerNetworkInterfaceStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerNetworkInterfaceStatistics>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ContainerNetworkInterfaceStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContainerNetworkInterfaceStatistics>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContainerNetworkInterfaceStatistics>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RxBytes))
            {
                writer.WritePropertyName("rxBytes"u8);
                writer.WriteNumberValue(RxBytes.Value);
            }
            if (Optional.IsDefined(RxPackets))
            {
                writer.WritePropertyName("rxPackets"u8);
                writer.WriteNumberValue(RxPackets.Value);
            }
            if (Optional.IsDefined(RxErrors))
            {
                writer.WritePropertyName("rxErrors"u8);
                writer.WriteNumberValue(RxErrors.Value);
            }
            if (Optional.IsDefined(RxDropped))
            {
                writer.WritePropertyName("rxDropped"u8);
                writer.WriteNumberValue(RxDropped.Value);
            }
            if (Optional.IsDefined(TxBytes))
            {
                writer.WritePropertyName("txBytes"u8);
                writer.WriteNumberValue(TxBytes.Value);
            }
            if (Optional.IsDefined(TxPackets))
            {
                writer.WritePropertyName("txPackets"u8);
                writer.WriteNumberValue(TxPackets.Value);
            }
            if (Optional.IsDefined(TxErrors))
            {
                writer.WritePropertyName("txErrors"u8);
                writer.WriteNumberValue(TxErrors.Value);
            }
            if (Optional.IsDefined(TxDropped))
            {
                writer.WritePropertyName("txDropped"u8);
                writer.WriteNumberValue(TxDropped.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        ContainerNetworkInterfaceStatistics IJsonModel<ContainerNetworkInterfaceStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerNetworkInterfaceStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerNetworkInterfaceStatistics(document.RootElement, options);
        }

        internal static ContainerNetworkInterfaceStatistics DeserializeContainerNetworkInterfaceStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> rxBytes = default;
            Optional<long> rxPackets = default;
            Optional<long> rxErrors = default;
            Optional<long> rxDropped = default;
            Optional<long> txBytes = default;
            Optional<long> txPackets = default;
            Optional<long> txErrors = default;
            Optional<long> txDropped = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rxBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rxPackets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxPackets = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rxErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxErrors = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rxDropped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxDropped = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txPackets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txPackets = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txErrors = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txDropped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txDropped = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerNetworkInterfaceStatistics(Optional.ToNullable(rxBytes), Optional.ToNullable(rxPackets), Optional.ToNullable(rxErrors), Optional.ToNullable(rxDropped), Optional.ToNullable(txBytes), Optional.ToNullable(txPackets), Optional.ToNullable(txErrors), Optional.ToNullable(txDropped), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerNetworkInterfaceStatistics>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerNetworkInterfaceStatistics)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerNetworkInterfaceStatistics IPersistableModel<ContainerNetworkInterfaceStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerNetworkInterfaceStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerNetworkInterfaceStatistics(document.RootElement, options);
        }

        string IPersistableModel<ContainerNetworkInterfaceStatistics>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
