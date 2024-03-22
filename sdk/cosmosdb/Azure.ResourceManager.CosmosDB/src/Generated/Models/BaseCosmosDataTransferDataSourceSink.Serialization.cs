// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class BaseCosmosDataTransferDataSourceSink : IUtf8JsonSerializable, IJsonModel<BaseCosmosDataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BaseCosmosDataTransferDataSourceSink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BaseCosmosDataTransferDataSourceSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseCosmosDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseCosmosDataTransferDataSourceSink)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RemoteAccountName))
            {
                writer.WritePropertyName("remoteAccountName"u8);
                writer.WriteStringValue(RemoteAccountName);
            }
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
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

        BaseCosmosDataTransferDataSourceSink IJsonModel<BaseCosmosDataTransferDataSourceSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseCosmosDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseCosmosDataTransferDataSourceSink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBaseCosmosDataTransferDataSourceSink(document.RootElement, options);
        }

        internal static BaseCosmosDataTransferDataSourceSink DeserializeBaseCosmosDataTransferDataSourceSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("component", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CosmosDBCassandra": return CosmosCassandraDataTransferDataSourceSink.DeserializeCosmosCassandraDataTransferDataSourceSink(element, options);
                    case "CosmosDBMongo": return CosmosMongoDataTransferDataSourceSink.DeserializeCosmosMongoDataTransferDataSourceSink(element, options);
                    case "CosmosDBSql": return CosmosSqlDataTransferDataSourceSink.DeserializeCosmosSqlDataTransferDataSourceSink(element, options);
                }
            }
            string remoteAccountName = default;
            DataTransferComponent component = "BaseCosmosDataTransferDataSourceSink";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("remoteAccountName"u8))
                {
                    remoteAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BaseCosmosDataTransferDataSourceSink(component, serializedAdditionalRawData, remoteAccountName);
        }

        BinaryData IPersistableModel<BaseCosmosDataTransferDataSourceSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseCosmosDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BaseCosmosDataTransferDataSourceSink)} does not support writing '{options.Format}' format.");
            }
        }

        BaseCosmosDataTransferDataSourceSink IPersistableModel<BaseCosmosDataTransferDataSourceSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseCosmosDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBaseCosmosDataTransferDataSourceSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BaseCosmosDataTransferDataSourceSink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BaseCosmosDataTransferDataSourceSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
