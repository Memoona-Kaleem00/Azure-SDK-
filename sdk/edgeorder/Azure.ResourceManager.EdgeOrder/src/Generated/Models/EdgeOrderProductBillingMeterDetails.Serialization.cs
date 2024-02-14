// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProductBillingMeterDetails : IUtf8JsonSerializable, IJsonModel<EdgeOrderProductBillingMeterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderProductBillingMeterDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderProductBillingMeterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductBillingMeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductBillingMeterDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterDetails))
            {
                writer.WritePropertyName("meterDetails"u8);
                writer.WriteObjectValue(MeterDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(MeteringType))
            {
                writer.WritePropertyName("meteringType"u8);
                writer.WriteStringValue(MeteringType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency);
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

        EdgeOrderProductBillingMeterDetails IJsonModel<EdgeOrderProductBillingMeterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductBillingMeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductBillingMeterDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderProductBillingMeterDetails(document.RootElement, options);
        }

        internal static EdgeOrderProductBillingMeterDetails DeserializeEdgeOrderProductBillingMeterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<EdgeOrderProductMeterDetails> meterDetails = default;
            Optional<EdgeOrderProductMeteringType> meteringType = default;
            Optional<string> frequency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meterDetails = EdgeOrderProductMeterDetails.DeserializeEdgeOrderProductMeterDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("meteringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meteringType = new EdgeOrderProductMeteringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    frequency = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderProductBillingMeterDetails(name.Value, meterDetails.Value, Optional.ToNullable(meteringType), frequency.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderProductBillingMeterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductBillingMeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductBillingMeterDetails)} does not support '{options.Format}' format.");
            }
        }

        EdgeOrderProductBillingMeterDetails IPersistableModel<EdgeOrderProductBillingMeterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductBillingMeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderProductBillingMeterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductBillingMeterDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderProductBillingMeterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
