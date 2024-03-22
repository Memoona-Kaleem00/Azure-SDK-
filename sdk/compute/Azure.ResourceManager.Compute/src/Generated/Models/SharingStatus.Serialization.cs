// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SharingStatus : IUtf8JsonSerializable, IJsonModel<SharingStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharingStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharingStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharingStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AggregatedState))
            {
                writer.WritePropertyName("aggregatedState"u8);
                writer.WriteStringValue(AggregatedState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStartArray();
                foreach (var item in Summary)
                {
                    writer.WriteObjectValue<RegionalSharingStatus>(item, options);
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

        SharingStatus IJsonModel<SharingStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharingStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharingStatus(document.RootElement, options);
        }

        internal static SharingStatus DeserializeSharingStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SharingState? aggregatedState = default;
            IReadOnlyList<RegionalSharingStatus> summary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregatedState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aggregatedState = new SharingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RegionalSharingStatus> array = new List<RegionalSharingStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionalSharingStatus.DeserializeRegionalSharingStatus(item, options));
                    }
                    summary = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharingStatus(aggregatedState, summary ?? new ChangeTrackingList<RegionalSharingStatus>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SharingStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SharingStatus)} does not support writing '{options.Format}' format.");
            }
        }

        SharingStatus IPersistableModel<SharingStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharingStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SharingStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharingStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
