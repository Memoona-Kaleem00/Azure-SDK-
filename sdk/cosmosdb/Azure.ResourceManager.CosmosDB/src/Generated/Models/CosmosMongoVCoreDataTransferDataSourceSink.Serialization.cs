// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosMongoVCoreDataTransferDataSourceSink : IUtf8JsonSerializable, IJsonModel<CosmosMongoVCoreDataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosMongoVCoreDataTransferDataSourceSink>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosMongoVCoreDataTransferDataSourceSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosMongoVCoreDataTransferDataSourceSink)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("collectionName"u8);
            writer.WriteStringValue(CollectionName);
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(ConnectionStringKeyVaultUri))
            {
                writer.WritePropertyName("connectionStringKeyVaultUri"u8);
                writer.WriteStringValue(ConnectionStringKeyVaultUri.AbsoluteUri);
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

        CosmosMongoVCoreDataTransferDataSourceSink IJsonModel<CosmosMongoVCoreDataTransferDataSourceSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosMongoVCoreDataTransferDataSourceSink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosMongoVCoreDataTransferDataSourceSink(document.RootElement, options);
        }

        internal static CosmosMongoVCoreDataTransferDataSourceSink DeserializeCosmosMongoVCoreDataTransferDataSourceSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string collectionName = default;
            string hostName = default;
            Uri connectionStringKeyVaultUri = default;
            DataTransferComponent component = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionName"u8))
                {
                    collectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStringKeyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStringKeyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosMongoVCoreDataTransferDataSourceSink(
                component,
                serializedAdditionalRawData,
                databaseName,
                collectionName,
                hostName,
                connectionStringKeyVaultUri);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  databaseName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    builder.Append("  databaseName: ");
                    if (DatabaseName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CollectionName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  collectionName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CollectionName))
                {
                    builder.Append("  collectionName: ");
                    if (CollectionName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CollectionName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CollectionName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hostName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostName))
                {
                    builder.Append("  hostName: ");
                    if (HostName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HostName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HostName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectionStringKeyVaultUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectionStringKeyVaultUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectionStringKeyVaultUri))
                {
                    builder.Append("  connectionStringKeyVaultUri: ");
                    builder.AppendLine($"'{ConnectionStringKeyVaultUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Component), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  component: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  component: ");
                builder.AppendLine($"'{Component.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosMongoVCoreDataTransferDataSourceSink)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosMongoVCoreDataTransferDataSourceSink IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosMongoVCoreDataTransferDataSourceSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosMongoVCoreDataTransferDataSourceSink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosMongoVCoreDataTransferDataSourceSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
