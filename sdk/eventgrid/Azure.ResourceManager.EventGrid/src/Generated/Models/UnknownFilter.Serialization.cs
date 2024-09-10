// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class UnknownFilter : IUtf8JsonSerializable, IJsonModel<EventGridFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridFilter)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        EventGridFilter IJsonModel<EventGridFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridFilter(document.RootElement, options);
        }

        internal static UnknownFilter DeserializeUnknownFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FilterOperatorType operatorType = "Unknown";
            string key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new FilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownFilter(operatorType, key, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperatorType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  operatorType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  operatorType: ");
                builder.AppendLine($"'{OperatorType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Key), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  key: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Key))
                {
                    builder.Append("  key: ");
                    if (Key.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Key}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Key}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventGridFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventGridFilter)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridFilter IPersistableModel<EventGridFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
