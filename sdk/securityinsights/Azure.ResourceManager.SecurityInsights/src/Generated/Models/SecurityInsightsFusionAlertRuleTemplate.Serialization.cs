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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsFusionAlertRuleTemplate : IUtf8JsonSerializable, IJsonModel<SecurityInsightsFusionAlertRuleTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsFusionAlertRuleTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsFusionAlertRuleTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsFusionAlertRuleTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (AlertRulesCreatedByTemplateCount.HasValue)
            {
                writer.WritePropertyName("alertRulesCreatedByTemplateCount"u8);
                writer.WriteNumberValue(AlertRulesCreatedByTemplateCount.Value);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdDateUTC"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedDateUTC"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (!(RequiredDataConnectors is ChangeTrackingList<AlertRuleTemplateDataSource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("requiredDataConnectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Severity.HasValue)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (!(Tactics is ChangeTrackingList<SecurityInsightsAttackTactic> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(Techniques is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
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

        SecurityInsightsFusionAlertRuleTemplate IJsonModel<SecurityInsightsFusionAlertRuleTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsFusionAlertRuleTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsFusionAlertRuleTemplate(document.RootElement, options);
        }

        internal static SecurityInsightsFusionAlertRuleTemplate DeserializeSecurityInsightsFusionAlertRuleTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> alertRulesCreatedByTemplateCount = default;
            Optional<DateTimeOffset> createdDateUTC = default;
            Optional<DateTimeOffset> lastUpdatedDateUTC = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            IList<AlertRuleTemplateDataSource> requiredDataConnectors = default;
            Optional<SecurityInsightsAlertRuleTemplateStatus> status = default;
            Optional<SecurityInsightsAlertSeverity> severity = default;
            IList<SecurityInsightsAttackTactic> tactics = default;
            IList<string> techniques = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
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
                        if (property0.NameEquals("alertRulesCreatedByTemplateCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertRulesCreatedByTemplateCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("createdDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AlertRuleTemplateDataSource> array = new List<AlertRuleTemplateDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AlertRuleTemplateDataSource.DeserializeAlertRuleTemplateDataSource(item, options));
                            }
                            requiredDataConnectors = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertRuleTemplateStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            techniques = array;
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
            return new SecurityInsightsFusionAlertRuleTemplate(
                id,
                name,
                type,
                systemData.Value,
                kind,
                serializedAdditionalRawData,
                Optional.ToNullable(alertRulesCreatedByTemplateCount),
                Optional.ToNullable(createdDateUTC),
                Optional.ToNullable(lastUpdatedDateUTC),
                description.Value,
                displayName.Value,
                requiredDataConnectors ?? new ChangeTrackingList<AlertRuleTemplateDataSource>(),
                Optional.ToNullable(status),
                Optional.ToNullable(severity),
                tactics ?? new ChangeTrackingList<SecurityInsightsAttackTactic>(),
                techniques ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsFusionAlertRuleTemplate)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsFusionAlertRuleTemplate IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsFusionAlertRuleTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsFusionAlertRuleTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsFusionAlertRuleTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
