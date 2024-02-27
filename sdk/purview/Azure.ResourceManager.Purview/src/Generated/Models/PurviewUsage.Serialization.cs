// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewUsage : IUtf8JsonSerializable, IJsonModel<PurviewUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurviewUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PurviewUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewUsage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && CurrentValue.HasValue)
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteNumberValue(CurrentValue.Value);
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Limit.HasValue)
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (options.Format != "W" && Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
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

        PurviewUsage IJsonModel<PurviewUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewUsage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewUsage(document.RootElement, options);
        }

        internal static PurviewUsage DeserializePurviewUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> currentValue = default;
            Optional<string> id = default;
            Optional<int> limit = default;
            Optional<PurviewUsageName> name = default;
            Optional<string> unit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = PurviewUsageName.DeserializePurviewUsageName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PurviewUsage(
                Optional.ToNullable(currentValue),
                id.Value,
                Optional.ToNullable(limit),
                name.Value,
                unit.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurviewUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PurviewUsage)} does not support '{options.Format}' format.");
            }
        }

        PurviewUsage IPersistableModel<PurviewUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePurviewUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurviewUsage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurviewUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
