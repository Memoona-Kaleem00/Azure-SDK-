// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsTableSearchResults : IUtf8JsonSerializable, IJsonModel<OperationalInsightsTableSearchResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsTableSearchResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsTableSearchResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableSearchResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Limit.HasValue)
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (StartSearchOn.HasValue)
            {
                writer.WritePropertyName("startSearchTime"u8);
                writer.WriteStringValue(StartSearchOn.Value, "O");
            }
            if (EndSearchOn.HasValue)
            {
                writer.WritePropertyName("endSearchTime"u8);
                writer.WriteStringValue(EndSearchOn.Value, "O");
            }
            if (options.Format != "W" && SourceTable != null)
            {
                writer.WritePropertyName("sourceTable"u8);
                writer.WriteStringValue(SourceTable);
            }
            if (options.Format != "W" && AzureAsyncOperationId.HasValue)
            {
                writer.WritePropertyName("azureAsyncOperationId"u8);
                writer.WriteStringValue(AzureAsyncOperationId.Value);
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

        OperationalInsightsTableSearchResults IJsonModel<OperationalInsightsTableSearchResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableSearchResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableSearchResults(document.RootElement, options);
        }

        internal static OperationalInsightsTableSearchResults DeserializeOperationalInsightsTableSearchResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string query = default;
            string description = default;
            int? limit = default;
            DateTimeOffset? startSearchTime = default;
            DateTimeOffset? endSearchTime = default;
            string sourceTable = default;
            Guid? azureAsyncOperationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
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
                if (property.NameEquals("startSearchTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startSearchTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endSearchTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endSearchTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceTable"u8))
                {
                    sourceTable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureAsyncOperationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureAsyncOperationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsTableSearchResults(
                query,
                description,
                limit,
                startSearchTime,
                endSearchTime,
                sourceTable,
                azureAsyncOperationId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsTableSearchResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableSearchResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsTableSearchResults IPersistableModel<OperationalInsightsTableSearchResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableSearchResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsTableSearchResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsTableSearchResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
