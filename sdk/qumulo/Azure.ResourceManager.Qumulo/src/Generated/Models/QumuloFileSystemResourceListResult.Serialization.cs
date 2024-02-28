// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Qumulo;

namespace Azure.ResourceManager.Qumulo.Models
{
    internal partial class QumuloFileSystemResourceListResult : IUtf8JsonSerializable, IJsonModel<QumuloFileSystemResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QumuloFileSystemResourceListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QumuloFileSystemResourceListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QumuloFileSystemResourceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QumuloFileSystemResourceListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        QumuloFileSystemResourceListResult IJsonModel<QumuloFileSystemResourceListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QumuloFileSystemResourceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QumuloFileSystemResourceListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQumuloFileSystemResourceListResult(document.RootElement, options);
        }

        internal static QumuloFileSystemResourceListResult DeserializeQumuloFileSystemResourceListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<QumuloFileSystemResourceData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<QumuloFileSystemResourceData> array = new List<QumuloFileSystemResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QumuloFileSystemResourceListResult(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QumuloFileSystemResourceListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QumuloFileSystemResourceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QumuloFileSystemResourceListResult)} does not support '{options.Format}' format.");
            }
        }

        QumuloFileSystemResourceListResult IPersistableModel<QumuloFileSystemResourceListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QumuloFileSystemResourceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQumuloFileSystemResourceListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QumuloFileSystemResourceListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QumuloFileSystemResourceListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
