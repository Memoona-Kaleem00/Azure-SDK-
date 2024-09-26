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
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DiagnosticSettingData : IUtf8JsonSerializable, IJsonModel<DiagnosticSettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticSettingData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiagnosticSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ServiceBusRuleId))
            {
                writer.WritePropertyName("serviceBusRuleId"u8);
                writer.WriteStringValue(ServiceBusRuleId);
            }
            if (Optional.IsDefined(EventHubAuthorizationRuleId))
            {
                writer.WritePropertyName("eventHubAuthorizationRuleId"u8);
                writer.WriteStringValue(EventHubAuthorizationRuleId);
            }
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Logs))
            {
                writer.WritePropertyName("logs"u8);
                writer.WriteStartArray();
                foreach (var item in Logs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(MarketplacePartnerId))
            {
                writer.WritePropertyName("marketplacePartnerId"u8);
                writer.WriteStringValue(MarketplacePartnerId);
            }
            if (Optional.IsDefined(LogAnalyticsDestinationType))
            {
                writer.WritePropertyName("logAnalyticsDestinationType"u8);
                writer.WriteStringValue(LogAnalyticsDestinationType);
            }
            writer.WriteEndObject();
        }

        DiagnosticSettingData IJsonModel<DiagnosticSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticSettingData(document.RootElement, options);
        }

        internal static DiagnosticSettingData DeserializeDiagnosticSettingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier storageAccountId = default;
            ResourceIdentifier serviceBusRuleId = default;
            ResourceIdentifier eventHubAuthorizationRuleId = default;
            string eventHubName = default;
            IList<MetricSettings> metrics = default;
            IList<LogSettings> logs = default;
            ResourceIdentifier workspaceId = default;
            ResourceIdentifier marketplacePartnerId = default;
            string logAnalyticsDestinationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("storageAccountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceBusRuleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceBusRuleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubAuthorizationRuleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventHubAuthorizationRuleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"u8))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MetricSettings> array = new List<MetricSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetricSettings.DeserializeMetricSettings(item, options));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("logs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LogSettings> array = new List<LogSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogSettings.DeserializeLogSettings(item, options));
                            }
                            logs = array;
                            continue;
                        }
                        if (property0.NameEquals("workspaceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplacePartnerId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplacePartnerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsDestinationType"u8))
                        {
                            logAnalyticsDestinationType = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiagnosticSettingData(
                id,
                name,
                type,
                systemData,
                storageAccountId,
                serviceBusRuleId,
                eventHubAuthorizationRuleId,
                eventHubName,
                metrics ?? new ChangeTrackingList<MetricSettings>(),
                logs ?? new ChangeTrackingList<LogSettings>(),
                workspaceId,
                marketplacePartnerId,
                logAnalyticsDestinationType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnosticSettingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support writing '{options.Format}' format.");
            }
        }

        DiagnosticSettingData IPersistableModel<DiagnosticSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiagnosticSettingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnosticSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
