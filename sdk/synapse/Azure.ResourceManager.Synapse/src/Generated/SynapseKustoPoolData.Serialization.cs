// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseKustoPoolData : IUtf8JsonSerializable, IJsonModel<SynapseKustoPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseKustoPoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseKustoPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseKustoPoolData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue<SynapseDataSourceSku>(Sku, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(DataIngestionUri))
            {
                writer.WritePropertyName("dataIngestionUri"u8);
                writer.WriteStringValue(DataIngestionUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(StateReason))
            {
                writer.WritePropertyName("stateReason"u8);
                writer.WriteStringValue(StateReason);
            }
            if (Optional.IsDefined(OptimizedAutoscale))
            {
                writer.WritePropertyName("optimizedAutoscale"u8);
                writer.WriteObjectValue<SynapseOptimizedAutoscale>(OptimizedAutoscale, options);
            }
            if (Optional.IsDefined(EnableStreamingIngest))
            {
                writer.WritePropertyName("enableStreamingIngest"u8);
                writer.WriteBooleanValue(EnableStreamingIngest.Value);
            }
            if (Optional.IsDefined(EnablePurge))
            {
                writer.WritePropertyName("enablePurge"u8);
                writer.WriteBooleanValue(EnablePurge.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LanguageExtensions))
            {
                writer.WritePropertyName("languageExtensions"u8);
                writer.WriteObjectValue<SynapseLanguageExtensionsList>(LanguageExtensions, options);
            }
            if (Optional.IsDefined(WorkspaceUid))
            {
                writer.WritePropertyName("workspaceUID"u8);
                writer.WriteStringValue(WorkspaceUid.Value);
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

        SynapseKustoPoolData IJsonModel<SynapseKustoPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseKustoPoolData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseKustoPoolData(document.RootElement, options);
        }

        internal static SynapseKustoPoolData DeserializeSynapseKustoPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseDataSourceSku sku = default;
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            KustoPoolState? state = default;
            ResourceProvisioningState? provisioningState = default;
            Uri uri = default;
            Uri dataIngestionUri = default;
            string stateReason = default;
            SynapseOptimizedAutoscale optimizedAutoscale = default;
            bool? enableStreamingIngest = default;
            bool? enablePurge = default;
            SynapseLanguageExtensionsList languageExtensions = default;
            Guid? workspaceUID = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = SynapseDataSourceSku.DeserializeSynapseDataSourceSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new KustoPoolState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataIngestionUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataIngestionUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"u8))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("optimizedAutoscale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizedAutoscale = SynapseOptimizedAutoscale.DeserializeSynapseOptimizedAutoscale(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableStreamingIngest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableStreamingIngest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePurge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePurge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("languageExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            languageExtensions = SynapseLanguageExtensionsList.DeserializeSynapseLanguageExtensionsList(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("workspaceUID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceUID = property0.Value.GetGuid();
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
            return new SynapseKustoPoolData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                etag,
                state,
                provisioningState,
                uri,
                dataIngestionUri,
                stateReason,
                optimizedAutoscale,
                enableStreamingIngest,
                enablePurge,
                languageExtensions,
                workspaceUID,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseKustoPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseKustoPoolData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseKustoPoolData IPersistableModel<SynapseKustoPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseKustoPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseKustoPoolData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseKustoPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
