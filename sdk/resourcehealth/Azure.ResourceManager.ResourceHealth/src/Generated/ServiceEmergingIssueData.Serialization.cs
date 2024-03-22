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
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    public partial class ServiceEmergingIssueData : IUtf8JsonSerializable, IJsonModel<ServiceEmergingIssueData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceEmergingIssueData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceEmergingIssueData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEmergingIssueData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceEmergingIssueData)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(RefreshedOn))
            {
                writer.WritePropertyName("refreshTimestamp"u8);
                writer.WriteStringValue(RefreshedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(StatusBanners))
            {
                writer.WritePropertyName("statusBanners"u8);
                writer.WriteStartArray();
                foreach (var item in StatusBanners)
                {
                    writer.WriteObjectValue<EmergingIssueBannerType>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StatusActiveEvents))
            {
                writer.WritePropertyName("statusActiveEvents"u8);
                writer.WriteStartArray();
                foreach (var item in StatusActiveEvents)
                {
                    writer.WriteObjectValue<EmergingIssueActiveEventType>(item, options);
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

        ServiceEmergingIssueData IJsonModel<ServiceEmergingIssueData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEmergingIssueData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceEmergingIssueData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceEmergingIssueData(document.RootElement, options);
        }

        internal static ServiceEmergingIssueData DeserializeServiceEmergingIssueData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DateTimeOffset? refreshTimestamp = default;
            IReadOnlyList<EmergingIssueBannerType> statusBanners = default;
            IReadOnlyList<EmergingIssueActiveEventType> statusActiveEvents = default;
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
                        if (property0.NameEquals("refreshTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("statusBanners"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EmergingIssueBannerType> array = new List<EmergingIssueBannerType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EmergingIssueBannerType.DeserializeEmergingIssueBannerType(item, options));
                            }
                            statusBanners = array;
                            continue;
                        }
                        if (property0.NameEquals("statusActiveEvents"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EmergingIssueActiveEventType> array = new List<EmergingIssueActiveEventType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EmergingIssueActiveEventType.DeserializeEmergingIssueActiveEventType(item, options));
                            }
                            statusActiveEvents = array;
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
            return new ServiceEmergingIssueData(
                id,
                name,
                type,
                systemData,
                refreshTimestamp,
                statusBanners ?? new ChangeTrackingList<EmergingIssueBannerType>(),
                statusActiveEvents ?? new ChangeTrackingList<EmergingIssueActiveEventType>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceEmergingIssueData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEmergingIssueData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceEmergingIssueData)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceEmergingIssueData IPersistableModel<ServiceEmergingIssueData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceEmergingIssueData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceEmergingIssueData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceEmergingIssueData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceEmergingIssueData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
