// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DWCopyCommandDefaultValueConverter))]
    public partial class DWCopyCommandDefaultValue : IUtf8JsonSerializable, IJsonModel<DWCopyCommandDefaultValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DWCopyCommandDefaultValue>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DWCopyCommandDefaultValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DWCopyCommandDefaultValue>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DWCopyCommandDefaultValue>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
                writer.WriteObjectValue(ColumnName);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteObjectValue(DefaultValue);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        DWCopyCommandDefaultValue IJsonModel<DWCopyCommandDefaultValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDWCopyCommandDefaultValue(document.RootElement, options);
        }

        internal static DWCopyCommandDefaultValue DeserializeDWCopyCommandDefaultValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> columnName = default;
            Optional<object> defaultValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = property.Value.GetObject();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DWCopyCommandDefaultValue(columnName.Value, defaultValue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DWCopyCommandDefaultValue>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DWCopyCommandDefaultValue IPersistableModel<DWCopyCommandDefaultValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDWCopyCommandDefaultValue(document.RootElement, options);
        }

        string IPersistableModel<DWCopyCommandDefaultValue>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class DWCopyCommandDefaultValueConverter : JsonConverter<DWCopyCommandDefaultValue>
        {
            public override void Write(Utf8JsonWriter writer, DWCopyCommandDefaultValue model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DWCopyCommandDefaultValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDWCopyCommandDefaultValue(document.RootElement);
            }
        }
    }
}
