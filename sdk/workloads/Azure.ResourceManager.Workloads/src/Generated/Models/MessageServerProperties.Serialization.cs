// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class MessageServerProperties : IUtf8JsonSerializable, IJsonModel<MessageServerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageServerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MessageServerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageServerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && MsPort.HasValue)
            {
                if (MsPort != null)
                {
                    writer.WritePropertyName("msPort"u8);
                    writer.WriteNumberValue(MsPort.Value);
                }
                else
                {
                    writer.WriteNull("msPort");
                }
            }
            if (options.Format != "W" && InternalMsPort.HasValue)
            {
                if (InternalMsPort != null)
                {
                    writer.WritePropertyName("internalMsPort"u8);
                    writer.WriteNumberValue(InternalMsPort.Value);
                }
                else
                {
                    writer.WriteNull("internalMsPort");
                }
            }
            if (options.Format != "W" && HttpPort.HasValue)
            {
                if (HttpPort != null)
                {
                    writer.WritePropertyName("httpPort"u8);
                    writer.WriteNumberValue(HttpPort.Value);
                }
                else
                {
                    writer.WriteNull("httpPort");
                }
            }
            if (options.Format != "W" && HttpsPort.HasValue)
            {
                if (HttpsPort != null)
                {
                    writer.WritePropertyName("httpsPort"u8);
                    writer.WriteNumberValue(HttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("httpsPort");
                }
            }
            if (options.Format != "W" && Hostname != null)
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (options.Format != "W" && IPAddress != null)
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (options.Format != "W" && Health.HasValue)
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
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

        MessageServerProperties IJsonModel<MessageServerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageServerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageServerProperties(document.RootElement, options);
        }

        internal static MessageServerProperties DeserializeMessageServerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long?> msPort = default;
            Optional<long?> internalMsPort = default;
            Optional<long?> httpPort = default;
            Optional<long?> httpsPort = default;
            Optional<string> hostname = default;
            Optional<string> ipAddress = default;
            Optional<SapHealthState> health = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("msPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        msPort = null;
                        continue;
                    }
                    msPort = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("internalMsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        internalMsPort = null;
                        continue;
                    }
                    internalMsPort = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("httpPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpPort = null;
                        continue;
                    }
                    httpPort = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("httpsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsPort = null;
                        continue;
                    }
                    httpsPort = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SapHealthState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MessageServerProperties(
                Optional.ToNullable(msPort),
                Optional.ToNullable(internalMsPort),
                Optional.ToNullable(httpPort),
                Optional.ToNullable(httpsPort),
                hostname.Value,
                ipAddress.Value,
                Optional.ToNullable(health),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MessageServerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageServerProperties)} does not support '{options.Format}' format.");
            }
        }

        MessageServerProperties IPersistableModel<MessageServerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageServerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageServerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageServerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
