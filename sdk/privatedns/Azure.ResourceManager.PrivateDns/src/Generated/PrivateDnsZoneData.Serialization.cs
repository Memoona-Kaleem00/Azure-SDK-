// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PrivateDns.Models;

namespace Azure.ResourceManager.PrivateDns
{
    public partial class PrivateDnsZoneData : IUtf8JsonSerializable, IJsonModel<PrivateDnsZoneData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateDnsZoneData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateDnsZoneData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
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
            if (options.Format != "W" && Optional.IsDefined(MaxNumberOfRecords))
            {
                writer.WritePropertyName("maxNumberOfRecordSets"u8);
                writer.WriteNumberValue(MaxNumberOfRecords.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfRecords))
            {
                writer.WritePropertyName("numberOfRecordSets"u8);
                writer.WriteNumberValue(NumberOfRecords.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxNumberOfVirtualNetworkLinks))
            {
                writer.WritePropertyName("maxNumberOfVirtualNetworkLinks"u8);
                writer.WriteNumberValue(MaxNumberOfVirtualNetworkLinks.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfVirtualNetworkLinks))
            {
                writer.WritePropertyName("numberOfVirtualNetworkLinks"u8);
                writer.WriteNumberValue(NumberOfVirtualNetworkLinks.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxNumberOfVirtualNetworkLinksWithRegistration))
            {
                writer.WritePropertyName("maxNumberOfVirtualNetworkLinksWithRegistration"u8);
                writer.WriteNumberValue(MaxNumberOfVirtualNetworkLinksWithRegistration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfVirtualNetworkLinksWithRegistration))
            {
                writer.WritePropertyName("numberOfVirtualNetworkLinksWithRegistration"u8);
                writer.WriteNumberValue(NumberOfVirtualNetworkLinksWithRegistration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateDnsProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(PrivateDnsProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InternalId))
            {
                writer.WritePropertyName("internalId"u8);
                writer.WriteStringValue(InternalId);
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

        PrivateDnsZoneData IJsonModel<PrivateDnsZoneData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateDnsZoneData(document.RootElement, options);
        }

        internal static PrivateDnsZoneData DeserializePrivateDnsZoneData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            long? maxNumberOfRecordSets = default;
            long? numberOfRecordSets = default;
            long? maxNumberOfVirtualNetworkLinks = default;
            long? numberOfVirtualNetworkLinks = default;
            long? maxNumberOfVirtualNetworkLinksWithRegistration = default;
            long? numberOfVirtualNetworkLinksWithRegistration = default;
            PrivateDnsProvisioningState? privateDnsProvisioningState = default;
            string internalId = default;
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
                        if (property0.NameEquals("maxNumberOfRecordSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfRecordSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfVirtualNetworkLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfVirtualNetworkLinks = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfVirtualNetworkLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfVirtualNetworkLinks = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfVirtualNetworkLinksWithRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfVirtualNetworkLinksWithRegistration = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfVirtualNetworkLinksWithRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfVirtualNetworkLinksWithRegistration = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateDnsProvisioningState = new PrivateDnsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalId"u8))
                        {
                            internalId = property0.Value.GetString();
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
            return new PrivateDnsZoneData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                etag,
                maxNumberOfRecordSets,
                numberOfRecordSets,
                maxNumberOfVirtualNetworkLinks,
                numberOfVirtualNetworkLinks,
                maxNumberOfVirtualNetworkLinksWithRegistration,
                numberOfVirtualNetworkLinksWithRegistration,
                privateDnsProvisioningState,
                internalId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateDnsZoneData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support '{options.Format}' format.");
            }
        }

        PrivateDnsZoneData IPersistableModel<PrivateDnsZoneData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateDnsZoneData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateDnsZoneData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
