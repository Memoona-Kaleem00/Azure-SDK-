// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationPropertiesUtilization : IUtf8JsonSerializable, IJsonModel<ReservationPropertiesUtilization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationPropertiesUtilization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationPropertiesUtilization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPropertiesUtilization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationPropertiesUtilization)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Trend))
            {
                writer.WritePropertyName("trend"u8);
                writer.WriteStringValue(Trend);
            }
            if (Optional.IsCollectionDefined(Aggregates))
            {
                writer.WritePropertyName("aggregates"u8);
                writer.WriteStartArray();
                foreach (var item in Aggregates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ReservationPropertiesUtilization IJsonModel<ReservationPropertiesUtilization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPropertiesUtilization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationPropertiesUtilization)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationPropertiesUtilization(document.RootElement, options);
        }

        internal static ReservationPropertiesUtilization DeserializeReservationPropertiesUtilization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> trend = default;
            Optional<IReadOnlyList<ReservationUtilizationAggregates>> aggregates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trend"u8))
                {
                    trend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationUtilizationAggregates> array = new List<ReservationUtilizationAggregates>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationUtilizationAggregates.DeserializeReservationUtilizationAggregates(item, options));
                    }
                    aggregates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationPropertiesUtilization(trend.Value, Optional.ToList(aggregates), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationPropertiesUtilization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPropertiesUtilization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationPropertiesUtilization)} does not support '{options.Format}' format.");
            }
        }

        ReservationPropertiesUtilization IPersistableModel<ReservationPropertiesUtilization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPropertiesUtilization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationPropertiesUtilization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationPropertiesUtilization)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationPropertiesUtilization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
