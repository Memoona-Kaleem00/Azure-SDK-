// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ReportListInUseStorageAccountsResult : IUtf8JsonSerializable, IJsonModel<ReportListInUseStorageAccountsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportListInUseStorageAccountsResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReportListInUseStorageAccountsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportListInUseStorageAccountsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportListInUseStorageAccountsResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageAccountList))
            {
                writer.WritePropertyName("storageAccountList"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccountList)
                {
                    writer.WriteObjectValue(item, options);
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

        ReportListInUseStorageAccountsResult IJsonModel<ReportListInUseStorageAccountsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportListInUseStorageAccountsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportListInUseStorageAccountsResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportListInUseStorageAccountsResult(document.RootElement, options);
        }

        internal static ReportListInUseStorageAccountsResult DeserializeReportListInUseStorageAccountsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ReportStorageInfo> storageAccountList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportStorageInfo> array = new List<ReportStorageInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportStorageInfo.DeserializeReportStorageInfo(item, options));
                    }
                    storageAccountList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReportListInUseStorageAccountsResult(storageAccountList ?? new ChangeTrackingList<ReportStorageInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportListInUseStorageAccountsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportListInUseStorageAccountsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportListInUseStorageAccountsResult)} does not support writing '{options.Format}' format.");
            }
        }

        ReportListInUseStorageAccountsResult IPersistableModel<ReportListInUseStorageAccountsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportListInUseStorageAccountsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportListInUseStorageAccountsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportListInUseStorageAccountsResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportListInUseStorageAccountsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
