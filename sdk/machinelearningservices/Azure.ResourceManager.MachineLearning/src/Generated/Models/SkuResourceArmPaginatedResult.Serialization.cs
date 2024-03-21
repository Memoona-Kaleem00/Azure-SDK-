// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class SkuResourceArmPaginatedResult : IUtf8JsonSerializable, IJsonModel<SkuResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SkuResourceArmPaginatedResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SkuResourceArmPaginatedResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SkuResourceArmPaginatedResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        SkuResourceArmPaginatedResult IJsonModel<SkuResourceArmPaginatedResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SkuResourceArmPaginatedResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSkuResourceArmPaginatedResult(document.RootElement, options);
        }

        internal static SkuResourceArmPaginatedResult DeserializeSkuResourceArmPaginatedResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nextLink = default;
            IReadOnlyList<MachineLearningSkuDetail> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningSkuDetail> array = new List<MachineLearningSkuDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningSkuDetail.DeserializeMachineLearningSkuDetail(item, options));
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
            return new SkuResourceArmPaginatedResult(nextLink, value ?? new ChangeTrackingList<MachineLearningSkuDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SkuResourceArmPaginatedResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SkuResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }
        }

        SkuResourceArmPaginatedResult IPersistableModel<SkuResourceArmPaginatedResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSkuResourceArmPaginatedResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SkuResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SkuResourceArmPaginatedResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
