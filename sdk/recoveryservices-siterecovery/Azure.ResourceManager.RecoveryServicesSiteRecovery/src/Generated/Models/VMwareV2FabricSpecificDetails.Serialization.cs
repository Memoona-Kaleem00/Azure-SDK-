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
    public partial class VMwareV2FabricSpecificDetails : IUtf8JsonSerializable, IJsonModel<VMwareV2FabricSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareV2FabricSpecificDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareV2FabricSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareV2FabricSpecificDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(VMwareSiteId))
            {
                writer.WritePropertyName("vmwareSiteId"u8);
                writer.WriteStringValue(VMwareSiteId);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalSiteId))
            {
                writer.WritePropertyName("physicalSiteId"u8);
                writer.WriteStringValue(PhysicalSiteId);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationSolutionId))
            {
                writer.WritePropertyName("migrationSolutionId"u8);
                writer.WriteStringValue(MigrationSolutionId);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceEndpoint))
            {
                writer.WritePropertyName("serviceEndpoint"u8);
                writer.WriteStringValue(ServiceEndpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceResourceId))
            {
                writer.WritePropertyName("serviceResourceId"u8);
                writer.WriteStringValue(ServiceResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceContainerId))
            {
                writer.WritePropertyName("serviceContainerId"u8);
                writer.WriteStringValue(ServiceContainerId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProcessServers))
            {
                writer.WritePropertyName("processServers"u8);
                writer.WriteStartArray();
                foreach (var item in ProcessServers)
                {
                    writer.WriteObjectValue<SiteRecoveryProcessServerDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareV2FabricSpecificDetails IJsonModel<VMwareV2FabricSpecificDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareV2FabricSpecificDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareV2FabricSpecificDetails(document.RootElement, options);
        }

        internal static VMwareV2FabricSpecificDetails DeserializeVMwareV2FabricSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareSiteId = default;
            ResourceIdentifier physicalSiteId = default;
            ResourceIdentifier migrationSolutionId = default;
            string serviceEndpoint = default;
            ResourceIdentifier serviceResourceId = default;
            string serviceContainerId = default;
            IReadOnlyList<SiteRecoveryProcessServerDetails> processServers = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("physicalSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceEndpoint"u8))
                {
                    serviceEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceContainerId"u8))
                {
                    serviceContainerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryProcessServerDetails> array = new List<SiteRecoveryProcessServerDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryProcessServerDetails.DeserializeSiteRecoveryProcessServerDetails(item, options));
                    }
                    processServers = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareV2FabricSpecificDetails(
                instanceType,
                serializedAdditionalRawData,
                vmwareSiteId,
                physicalSiteId,
                migrationSolutionId,
                serviceEndpoint,
                serviceResourceId,
                serviceContainerId,
                processServers ?? new ChangeTrackingList<SiteRecoveryProcessServerDetails>());
        }

        BinaryData IPersistableModel<VMwareV2FabricSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareV2FabricSpecificDetails)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareV2FabricSpecificDetails IPersistableModel<VMwareV2FabricSpecificDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareV2FabricSpecificDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareV2FabricSpecificDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareV2FabricSpecificDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
