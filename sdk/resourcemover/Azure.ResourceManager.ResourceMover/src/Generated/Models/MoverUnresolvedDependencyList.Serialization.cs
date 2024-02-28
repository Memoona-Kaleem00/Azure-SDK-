// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoverUnresolvedDependencyList : IUtf8JsonSerializable, IJsonModel<MoverUnresolvedDependencyList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverUnresolvedDependencyList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverUnresolvedDependencyList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverUnresolvedDependencyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverUnresolvedDependencyList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<MoverUnresolvedDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (options.Format != "W" && SummaryCollection != null)
            {
                writer.WritePropertyName("summaryCollection"u8);
                writer.WriteObjectValue(SummaryCollection);
            }
            if (options.Format != "W" && TotalCount.HasValue)
            {
                writer.WritePropertyName("totalCount"u8);
                writer.WriteNumberValue(TotalCount.Value);
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

        MoverUnresolvedDependencyList IJsonModel<MoverUnresolvedDependencyList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverUnresolvedDependencyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverUnresolvedDependencyList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverUnresolvedDependencyList(document.RootElement, options);
        }

        internal static MoverUnresolvedDependencyList DeserializeMoverUnresolvedDependencyList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MoverUnresolvedDependency> value = default;
            string nextLink = default;
            MoverSummaryList summaryCollection = default;
            long? totalCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverUnresolvedDependency> array = new List<MoverUnresolvedDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverUnresolvedDependency.DeserializeMoverUnresolvedDependency(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summaryCollection = MoverSummaryList.DeserializeMoverSummaryList(property.Value, options);
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverUnresolvedDependencyList(value ?? new ChangeTrackingList<MoverUnresolvedDependency>(), nextLink, summaryCollection, totalCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverUnresolvedDependencyList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverUnresolvedDependencyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverUnresolvedDependencyList)} does not support '{options.Format}' format.");
            }
        }

        MoverUnresolvedDependencyList IPersistableModel<MoverUnresolvedDependencyList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverUnresolvedDependencyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverUnresolvedDependencyList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverUnresolvedDependencyList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverUnresolvedDependencyList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
