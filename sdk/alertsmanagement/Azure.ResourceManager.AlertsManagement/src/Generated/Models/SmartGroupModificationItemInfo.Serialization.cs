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
    public partial class SmartGroupModificationItemInfo : IUtf8JsonSerializable, IJsonModel<SmartGroupModificationItemInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SmartGroupModificationItemInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SmartGroupModificationItemInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmartGroupModificationItemInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ModificationEvent))
            {
                writer.WritePropertyName("modificationEvent"u8);
                writer.WriteStringValue(ModificationEvent.Value.ToSerialString());
            }
            if (Optional.IsDefined(OldValue))
            {
                writer.WritePropertyName("oldValue"u8);
                writer.WriteStringValue(OldValue);
            }
            if (Optional.IsDefined(NewValue))
            {
                writer.WritePropertyName("newValue"u8);
                writer.WriteStringValue(NewValue);
            }
            if (Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedAt"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(ModifiedBy))
            {
                writer.WritePropertyName("modifiedBy"u8);
                writer.WriteStringValue(ModifiedBy);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(Description))
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
        }

        SmartGroupModificationItemInfo IJsonModel<SmartGroupModificationItemInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmartGroupModificationItemInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSmartGroupModificationItemInfo(document.RootElement, options);
        }

        internal static SmartGroupModificationItemInfo DeserializeSmartGroupModificationItemInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SmartGroupModificationEvent? modificationEvent = default;
            string oldValue = default;
            string newValue = default;
            DateTimeOffset? modifiedAt = default;
            string modifiedBy = default;
            string comments = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modificationEvent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modificationEvent = property.Value.GetString().ToSmartGroupModificationEvent();
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedAt = property.Value.GetDateTimeOffset("O");
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
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SmartGroupModificationItemInfo(
                modificationEvent,
                oldValue,
                newValue,
                modifiedAt,
                modifiedBy,
                comments,
                description,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SmartGroupModificationItemInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SmartGroupModificationItemInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SmartGroupModificationItemInfo IPersistableModel<SmartGroupModificationItemInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationItemInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSmartGroupModificationItemInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SmartGroupModificationItemInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SmartGroupModificationItemInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
