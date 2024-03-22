// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryAgentDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryAgentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryAgentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryAgentDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AgentId))
            {
                writer.WritePropertyName("agentId"u8);
                writer.WriteStringValue(AgentId);
            }
            if (options.Format != "W" && Optional.IsDefined(MachineId))
            {
                writer.WritePropertyName("machineId"u8);
                writer.WriteStringValue(MachineId);
            }
            if (options.Format != "W" && Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks"u8);
                writer.WriteStartArray();
                foreach (var item in Disks)
                {
                    writer.WriteObjectValue<SiteRecoveryAgentDiskDetails>(item, options);
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

        SiteRecoveryAgentDetails IJsonModel<SiteRecoveryAgentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryAgentDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryAgentDetails(document.RootElement, options);
        }

        internal static SiteRecoveryAgentDetails DeserializeSiteRecoveryAgentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string agentId = default;
            string machineId = default;
            string biosId = default;
            string fqdn = default;
            IReadOnlyList<SiteRecoveryAgentDiskDetails> disks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentId"u8))
                {
                    agentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryAgentDiskDetails> array = new List<SiteRecoveryAgentDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryAgentDiskDetails.DeserializeSiteRecoveryAgentDiskDetails(item, options));
                    }
                    disks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryAgentDetails(
                agentId,
                machineId,
                biosId,
                fqdn,
                disks ?? new ChangeTrackingList<SiteRecoveryAgentDiskDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryAgentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryAgentDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryAgentDetails IPersistableModel<SiteRecoveryAgentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryAgentDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryAgentDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryAgentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
