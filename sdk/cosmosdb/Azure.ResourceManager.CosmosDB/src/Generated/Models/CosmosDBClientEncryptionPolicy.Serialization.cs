// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBClientEncryptionPolicy : IUtf8JsonSerializable, IJsonModel<CosmosDBClientEncryptionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBClientEncryptionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBClientEncryptionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBClientEncryptionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("includedPaths"u8);
            writer.WriteStartArray();
            foreach (var item in IncludedPaths)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("policyFormatVersion"u8);
            writer.WriteNumberValue(PolicyFormatVersion);
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

        CosmosDBClientEncryptionPolicy IJsonModel<CosmosDBClientEncryptionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBClientEncryptionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBClientEncryptionPolicy(document.RootElement, options);
        }

        internal static CosmosDBClientEncryptionPolicy DeserializeCosmosDBClientEncryptionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CosmosDBClientEncryptionIncludedPath> includedPaths = default;
            int policyFormatVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includedPaths"u8))
                {
                    List<CosmosDBClientEncryptionIncludedPath> array = new List<CosmosDBClientEncryptionIncludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBClientEncryptionIncludedPath.DeserializeCosmosDBClientEncryptionIncludedPath(item, options));
                    }
                    includedPaths = array;
                    continue;
                }
                if (property.NameEquals("policyFormatVersion"u8))
                {
                    policyFormatVersion = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBClientEncryptionPolicy(includedPaths, policyFormatVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBClientEncryptionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBClientEncryptionPolicy)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBClientEncryptionPolicy IPersistableModel<CosmosDBClientEncryptionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBClientEncryptionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBClientEncryptionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBClientEncryptionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
