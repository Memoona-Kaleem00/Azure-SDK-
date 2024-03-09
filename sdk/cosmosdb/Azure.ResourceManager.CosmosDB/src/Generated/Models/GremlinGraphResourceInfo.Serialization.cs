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
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GremlinGraphResourceInfo : IUtf8JsonSerializable, IJsonModel<GremlinGraphResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GremlinGraphResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GremlinGraphResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GremlinGraphResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(GraphName);
            if (Optional.IsDefined(IndexingPolicy))
            {
                writer.WritePropertyName("indexingPolicy"u8);
                writer.WriteObjectValue(IndexingPolicy);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteObjectValue(PartitionKey);
            }
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl"u8);
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(UniqueKeyPolicy))
            {
                writer.WritePropertyName("uniqueKeyPolicy"u8);
                writer.WriteObjectValue(UniqueKeyPolicy);
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy"u8);
                writer.WriteObjectValue(ConflictResolutionPolicy);
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
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

        GremlinGraphResourceInfo IJsonModel<GremlinGraphResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GremlinGraphResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGremlinGraphResourceInfo(document.RootElement, options);
        }

        internal static GremlinGraphResourceInfo DeserializeGremlinGraphResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            CosmosDBIndexingPolicy indexingPolicy = default;
            CosmosDBContainerPartitionKey partitionKey = default;
            int? defaultTtl = default;
            CosmosDBUniqueKeyPolicy uniqueKeyPolicy = default;
            ConflictResolutionPolicy conflictResolutionPolicy = default;
            long? analyticalStorageTtl = default;
            ResourceRestoreParameters restoreParameters = default;
            CosmosDBAccountCreateMode? createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexingPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexingPolicy = CosmosDBIndexingPolicy.DeserializeCosmosDBIndexingPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionKey = CosmosDBContainerPartitionKey.DeserializeCosmosDBContainerPartitionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uniqueKeyPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uniqueKeyPolicy = CosmosDBUniqueKeyPolicy.DeserializeCosmosDBUniqueKeyPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("conflictResolutionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictResolutionPolicy = ConflictResolutionPolicy.DeserializeConflictResolutionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GremlinGraphResourceInfo(
                id,
                indexingPolicy,
                partitionKey,
                defaultTtl,
                uniqueKeyPolicy,
                conflictResolutionPolicy,
                analyticalStorageTtl,
                restoreParameters,
                createMode,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GraphName), out propertyOverride);
            if (Optional.IsDefined(GraphName) || hasPropertyOverride)
            {
                builder.Append("  id: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (GraphName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GraphName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GraphName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IndexingPolicy), out propertyOverride);
            if (Optional.IsDefined(IndexingPolicy) || hasPropertyOverride)
            {
                builder.Append("  indexingPolicy: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, IndexingPolicy, options, 2, false, "  indexingPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartitionKey), out propertyOverride);
            if (Optional.IsDefined(PartitionKey) || hasPropertyOverride)
            {
                builder.Append("  partitionKey: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, PartitionKey, options, 2, false, "  partitionKey: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultTtl), out propertyOverride);
            if (Optional.IsDefined(DefaultTtl) || hasPropertyOverride)
            {
                builder.Append("  defaultTtl: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{DefaultTtl.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UniqueKeyPolicy), out propertyOverride);
            if (Optional.IsDefined(UniqueKeyPolicy) || hasPropertyOverride)
            {
                builder.Append("  uniqueKeyPolicy: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, UniqueKeyPolicy, options, 2, false, "  uniqueKeyPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictResolutionPolicy), out propertyOverride);
            if (Optional.IsDefined(ConflictResolutionPolicy) || hasPropertyOverride)
            {
                builder.Append("  conflictResolutionPolicy: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, ConflictResolutionPolicy, options, 2, false, "  conflictResolutionPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AnalyticalStorageTtl), out propertyOverride);
            if (Optional.IsDefined(AnalyticalStorageTtl) || hasPropertyOverride)
            {
                builder.Append("  analyticalStorageTtl: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{AnalyticalStorageTtl.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestoreParameters), out propertyOverride);
            if (Optional.IsDefined(RestoreParameters) || hasPropertyOverride)
            {
                builder.Append("  restoreParameters: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, RestoreParameters, options, 2, false, "  restoreParameters: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreateMode), out propertyOverride);
            if (Optional.IsDefined(CreateMode) || hasPropertyOverride)
            {
                builder.Append("  createMode: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{CreateMode.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<GremlinGraphResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GremlinGraphResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        GremlinGraphResourceInfo IPersistableModel<GremlinGraphResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGremlinGraphResourceInfo(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GremlinGraphResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GremlinGraphResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
