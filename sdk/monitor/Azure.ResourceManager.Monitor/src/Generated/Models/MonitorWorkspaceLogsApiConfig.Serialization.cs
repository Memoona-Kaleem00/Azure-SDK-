// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWorkspaceLogsApiConfig : IUtf8JsonSerializable, IJsonModel<MonitorWorkspaceLogsApiConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorWorkspaceLogsApiConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorWorkspaceLogsApiConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsApiConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceLogsApiConfig)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("dataCollectionEndpointUrl"u8);
            writer.WriteStringValue(DataCollectionEndpointUri.AbsoluteUri);
            writer.WritePropertyName("stream"u8);
            writer.WriteStringValue(Stream);
            writer.WritePropertyName("dataCollectionRule"u8);
            writer.WriteStringValue(DataCollectionRule);
            writer.WritePropertyName("schema"u8);
            writer.WriteObjectValue(Schema, options);
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

        MonitorWorkspaceLogsApiConfig IJsonModel<MonitorWorkspaceLogsApiConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsApiConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceLogsApiConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWorkspaceLogsApiConfig(document.RootElement, options);
        }

        internal static MonitorWorkspaceLogsApiConfig DeserializeMonitorWorkspaceLogsApiConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri dataCollectionEndpointUrl = default;
            string stream = default;
            string dataCollectionRule = default;
            MonitorWorkspaceLogsSchemaMap schema = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataCollectionEndpointUrl"u8))
                {
                    dataCollectionEndpointUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    stream = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataCollectionRule"u8))
                {
                    dataCollectionRule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    schema = MonitorWorkspaceLogsSchemaMap.DeserializeMonitorWorkspaceLogsSchemaMap(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitorWorkspaceLogsApiConfig(dataCollectionEndpointUrl, stream, dataCollectionRule, schema, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorWorkspaceLogsApiConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsApiConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceLogsApiConfig)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorWorkspaceLogsApiConfig IPersistableModel<MonitorWorkspaceLogsApiConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsApiConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorWorkspaceLogsApiConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceLogsApiConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorWorkspaceLogsApiConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
