// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeVnetProperties : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeVnetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeVnetProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeVnetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeVnetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeVnetProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (VnetId.HasValue)
            {
                writer.WritePropertyName("vNetId"u8);
                writer.WriteStringValue(VnetId.Value);
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(Subnet);
            }
            if (!(PublicIPs is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("publicIPs"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SubnetId != null)
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseIntegrationRuntimeVnetProperties IJsonModel<SynapseIntegrationRuntimeVnetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeVnetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeVnetProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeVnetProperties(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeVnetProperties DeserializeSynapseIntegrationRuntimeVnetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? vNetId = default;
            string subnet = default;
            IList<string> publicIPs = default;
            ResourceIdentifier subnetId = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vNetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vNetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    publicIPs = array;
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeVnetProperties(vNetId, subnet, publicIPs ?? new ChangeTrackingList<string>(), subnetId, additionalProperties);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeVnetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeVnetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeVnetProperties)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeVnetProperties IPersistableModel<SynapseIntegrationRuntimeVnetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeVnetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeVnetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeVnetProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeVnetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
