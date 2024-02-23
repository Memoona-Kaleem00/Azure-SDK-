// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertModificationItemInfo : IUtf8JsonSerializable, IJsonModel<ServiceAlertModificationItemInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertModificationItemInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAlertModificationItemInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertModificationItemInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ModificationEvent.HasValue)
            {
                writer.WritePropertyName("modificationEvent"u8);
                writer.WriteStringValue(ModificationEvent.Value.ToSerialString());
            }
            if (OldValue != null)
            {
                writer.WritePropertyName("oldValue"u8);
                writer.WriteStringValue(OldValue);
            }
            if (NewValue != null)
            {
                writer.WritePropertyName("newValue"u8);
                writer.WriteStringValue(NewValue);
            }
            if (ModifiedAt != null)
            {
                writer.WritePropertyName("modifiedAt"u8);
                writer.WriteStringValue(ModifiedAt);
            }
            if (ModifiedBy != null)
            {
                writer.WritePropertyName("modifiedBy"u8);
                writer.WriteStringValue(ModifiedBy);
            }
            if (Comments != null)
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ServiceAlertModificationItemInfo IJsonModel<ServiceAlertModificationItemInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertModificationItemInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertModificationItemInfo(document.RootElement, options);
        }

        internal static ServiceAlertModificationItemInfo DeserializeServiceAlertModificationItemInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceAlertModificationEvent> modificationEvent = default;
            Optional<string> oldValue = default;
            Optional<string> newValue = default;
            Optional<string> modifiedAt = default;
            Optional<string> modifiedBy = default;
            Optional<string> comments = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modificationEvent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modificationEvent = property.Value.GetString().ToServiceAlertModificationEvent();
                    continue;
                }
                if (property.NameEquals("oldValue"u8))
                {
                    oldValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newValue"u8))
                {
                    newValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedAt"u8))
                {
                    modifiedAt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedBy"u8))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAlertModificationItemInfo(Optional.ToNullable(modificationEvent), oldValue.Value, newValue.Value, modifiedAt.Value, modifiedBy.Value, comments.Value, description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAlertModificationItemInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertModificationItemInfo)} does not support '{options.Format}' format.");
            }
        }

        ServiceAlertModificationItemInfo IPersistableModel<ServiceAlertModificationItemInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAlertModificationItemInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertModificationItemInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAlertModificationItemInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
