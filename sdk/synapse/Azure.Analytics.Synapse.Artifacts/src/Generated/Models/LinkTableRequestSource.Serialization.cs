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
    [JsonConverter(typeof(LinkTableRequestSourceConverter))]
    public partial class LinkTableRequestSource : IUtf8JsonSerializable, IJsonModel<LinkTableRequestSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkTableRequestSource>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LinkTableRequestSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LinkTableRequestSource>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LinkTableRequestSource>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
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

        LinkTableRequestSource IJsonModel<LinkTableRequestSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableRequestSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkTableRequestSource(document.RootElement, options);
        }

        internal static LinkTableRequestSource DeserializeLinkTableRequestSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tableName = default;
            Optional<string> schemaName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkTableRequestSource(tableName.Value, schemaName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkTableRequestSource>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableRequestSource)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LinkTableRequestSource IPersistableModel<LinkTableRequestSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableRequestSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLinkTableRequestSource(document.RootElement, options);
        }

        string IPersistableModel<LinkTableRequestSource>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class LinkTableRequestSourceConverter : JsonConverter<LinkTableRequestSource>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableRequestSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkTableRequestSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableRequestSource(document.RootElement);
            }
        }
    }
}
