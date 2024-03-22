// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataImportDetails : IUtf8JsonSerializable, IJsonModel<DataImportDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataImportDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataImportDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataImportDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("accountDetails"u8);
            writer.WriteObjectValue<DataAccountDetails>(AccountDetails, options);
            if (Optional.IsDefined(LogCollectionLevel))
            {
                writer.WritePropertyName("logCollectionLevel"u8);
                writer.WriteStringValue(LogCollectionLevel.Value.ToSerialString());
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

        DataImportDetails IJsonModel<DataImportDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataImportDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataImportDetails(document.RootElement, options);
        }

        internal static DataImportDetails DeserializeDataImportDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataAccountDetails accountDetails = default;
            LogCollectionLevel? logCollectionLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountDetails"u8))
                {
                    accountDetails = DataAccountDetails.DeserializeDataAccountDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logCollectionLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logCollectionLevel = property.Value.GetString().ToLogCollectionLevel();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataImportDetails(accountDetails, logCollectionLevel, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataImportDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataImportDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DataImportDetails IPersistableModel<DataImportDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataImportDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataImportDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataImportDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
