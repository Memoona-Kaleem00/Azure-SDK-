// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationWebhookCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<AutomationWebhookCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationWebhookCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationWebhookCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWebhookCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationWebhookCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Uri != null)
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (!(Parameters is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Runbook != null)
            {
                writer.WritePropertyName("runbook"u8);
                writer.WriteObjectValue(Runbook);
            }
            if (RunOn != null)
            {
                writer.WritePropertyName("runOn"u8);
                writer.WriteStringValue(RunOn);
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

        AutomationWebhookCreateOrUpdateContent IJsonModel<AutomationWebhookCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWebhookCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationWebhookCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationWebhookCreateOrUpdateContent(document.RootElement, options);
        }

        internal static AutomationWebhookCreateOrUpdateContent DeserializeAutomationWebhookCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<bool> isEnabled = default;
            Optional<Uri> uri = default;
            Optional<DateTimeOffset> expiryTime = default;
            IDictionary<string, string> parameters = default;
            Optional<RunbookAssociationProperty> runbook = default;
            Optional<string> runOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
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
                        if (property0.NameEquals("expiryTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("runbook"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runbook = RunbookAssociationProperty.DeserializeRunbookAssociationProperty(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("runOn"u8))
                        {
                            runOn = property0.Value.GetString();
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
            return new AutomationWebhookCreateOrUpdateContent(name, Optional.ToNullable(isEnabled), uri.Value, Optional.ToNullable(expiryTime), parameters ?? new ChangeTrackingDictionary<string, string>(), runbook.Value, runOn.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationWebhookCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWebhookCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationWebhookCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        AutomationWebhookCreateOrUpdateContent IPersistableModel<AutomationWebhookCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWebhookCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationWebhookCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationWebhookCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationWebhookCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
