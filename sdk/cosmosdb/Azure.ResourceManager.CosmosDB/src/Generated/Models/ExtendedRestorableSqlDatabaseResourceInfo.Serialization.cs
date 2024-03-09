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
    public partial class ExtendedRestorableSqlDatabaseResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EventTimestamp))
            {
                writer.WritePropertyName("eventTimestamp"u8);
                writer.WriteStringValue(EventTimestamp);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("ownerId"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseId))
            {
                writer.WritePropertyName("ownerResourceId"u8);
                writer.WriteStringValue(DatabaseId);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteObjectValue(Database);
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

        ExtendedRestorableSqlDatabaseResourceInfo IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedRestorableSqlDatabaseResourceInfo(document.RootElement, options);
        }

        internal static ExtendedRestorableSqlDatabaseResourceInfo DeserializeExtendedRestorableSqlDatabaseResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rid = default;
            CosmosDBOperationType? operationType = default;
            string eventTimestamp = default;
            string ownerId = default;
            string ownerResourceId = default;
            RestorableSqlDatabasePropertiesResourceDatabase database = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    database = RestorableSqlDatabasePropertiesResourceDatabase.DeserializeRestorableSqlDatabasePropertiesResourceDatabase(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtendedRestorableSqlDatabaseResourceInfo(
                rid,
                operationType,
                eventTimestamp,
                ownerId,
                ownerResourceId,
                database,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rid), out propertyOverride);
            if (Optional.IsDefined(Rid) || hasPropertyOverride)
            {
                builder.Append("  _rid: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Rid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Rid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Rid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperationType), out propertyOverride);
            if (Optional.IsDefined(OperationType) || hasPropertyOverride)
            {
                builder.Append("  operationType: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{OperationType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventTimestamp), out propertyOverride);
            if (Optional.IsDefined(EventTimestamp) || hasPropertyOverride)
            {
                builder.Append("  eventTimestamp: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (EventTimestamp.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EventTimestamp}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EventTimestamp}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (Optional.IsDefined(DatabaseName) || hasPropertyOverride)
            {
                builder.Append("  ownerId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseId), out propertyOverride);
            if (Optional.IsDefined(DatabaseId) || hasPropertyOverride)
            {
                builder.Append("  ownerResourceId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (DatabaseId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Database), out propertyOverride);
            if (Optional.IsDefined(Database) || hasPropertyOverride)
            {
                builder.Append("  database: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, Database, options, 2, false, "  database: ");
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

        BinaryData IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ExtendedRestorableSqlDatabaseResourceInfo IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedRestorableSqlDatabaseResourceInfo(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
