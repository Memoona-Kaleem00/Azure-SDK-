// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSensitivityLabelUpdateListResult : IUtf8JsonSerializable, IJsonModel<SynapseSensitivityLabelUpdateListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSensitivityLabelUpdateListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseSensitivityLabelUpdateListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdateListResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Operations))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
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
        }

        SynapseSensitivityLabelUpdateListResult IJsonModel<SynapseSensitivityLabelUpdateListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdateListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSensitivityLabelUpdateListResult(document.RootElement, options);
        }

        internal static SynapseSensitivityLabelUpdateListResult DeserializeSynapseSensitivityLabelUpdateListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SynapseSensitivityLabelUpdate> operations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSensitivityLabelUpdate> array = new List<SynapseSensitivityLabelUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSensitivityLabelUpdate.DeserializeSynapseSensitivityLabelUpdate(item, options));
                    }
                    operations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseSensitivityLabelUpdateListResult(operations ?? new ChangeTrackingList<SynapseSensitivityLabelUpdate>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseSensitivityLabelUpdateListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdateListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseSensitivityLabelUpdateListResult IPersistableModel<SynapseSensitivityLabelUpdateListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSensitivityLabelUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSensitivityLabelUpdateListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSensitivityLabelUpdateListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSensitivityLabelUpdateListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
