// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallPanoramaConfiguration : IUtf8JsonSerializable, IJsonModel<FirewallPanoramaConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPanoramaConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPanoramaConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPanoramaConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPanoramaConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("configString"u8);
            writer.WriteStringValue(ConfigString);
            if (options.Format != "W" && VmAuthKey != null)
            {
                writer.WritePropertyName("vmAuthKey"u8);
                writer.WriteStringValue(VmAuthKey);
            }
            if (options.Format != "W" && PanoramaServer != null)
            {
                writer.WritePropertyName("panoramaServer"u8);
                writer.WriteStringValue(PanoramaServer);
            }
            if (options.Format != "W" && PanoramaServer2 != null)
            {
                writer.WritePropertyName("panoramaServer2"u8);
                writer.WriteStringValue(PanoramaServer2);
            }
            if (options.Format != "W" && DgName != null)
            {
                writer.WritePropertyName("dgName"u8);
                writer.WriteStringValue(DgName);
            }
            if (options.Format != "W" && TplName != null)
            {
                writer.WritePropertyName("tplName"u8);
                writer.WriteStringValue(TplName);
            }
            if (options.Format != "W" && CgName != null)
            {
                writer.WritePropertyName("cgName"u8);
                writer.WriteStringValue(CgName);
            }
            if (options.Format != "W" && HostName != null)
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
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

        FirewallPanoramaConfiguration IJsonModel<FirewallPanoramaConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPanoramaConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPanoramaConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPanoramaConfiguration(document.RootElement, options);
        }

        internal static FirewallPanoramaConfiguration DeserializeFirewallPanoramaConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string configString = default;
            Optional<string> vmAuthKey = default;
            Optional<string> panoramaServer = default;
            Optional<string> panoramaServer2 = default;
            Optional<string> dgName = default;
            Optional<string> tplName = default;
            Optional<string> cgName = default;
            Optional<string> hostName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configString"u8))
                {
                    configString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmAuthKey"u8))
                {
                    vmAuthKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("panoramaServer"u8))
                {
                    panoramaServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("panoramaServer2"u8))
                {
                    panoramaServer2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dgName"u8))
                {
                    dgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tplName"u8))
                {
                    tplName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cgName"u8))
                {
                    cgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallPanoramaConfiguration(
                configString,
                vmAuthKey.Value,
                panoramaServer.Value,
                panoramaServer2.Value,
                dgName.Value,
                tplName.Value,
                cgName.Value,
                hostName.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPanoramaConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPanoramaConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPanoramaConfiguration)} does not support '{options.Format}' format.");
            }
        }

        FirewallPanoramaConfiguration IPersistableModel<FirewallPanoramaConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPanoramaConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPanoramaConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPanoramaConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPanoramaConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
