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
    internal partial class ComputePrivateLinkResourceListResult : IUtf8JsonSerializable, IJsonModel<ComputePrivateLinkResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputePrivateLinkResourceListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputePrivateLinkResourceListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePrivateLinkResourceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputePrivateLinkResourceListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue<ComputePrivateLinkResourceData>(item, options);
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

        ComputePrivateLinkResourceListResult IJsonModel<ComputePrivateLinkResourceListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePrivateLinkResourceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputePrivateLinkResourceListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputePrivateLinkResourceListResult(document.RootElement, options);
        }

        internal static ComputePrivateLinkResourceListResult DeserializeComputePrivateLinkResourceListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ComputePrivateLinkResourceData> value = default;
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
                    List<ComputePrivateLinkResourceData> array = new List<ComputePrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputePrivateLinkResourceData.DeserializeComputePrivateLinkResourceData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputePrivateLinkResourceListResult(value ?? new ChangeTrackingList<ComputePrivateLinkResourceData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputePrivateLinkResourceListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePrivateLinkResourceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputePrivateLinkResourceListResult)} does not support writing '{options.Format}' format.");
            }
        }

        ComputePrivateLinkResourceListResult IPersistableModel<ComputePrivateLinkResourceListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePrivateLinkResourceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputePrivateLinkResourceListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputePrivateLinkResourceListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputePrivateLinkResourceListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
