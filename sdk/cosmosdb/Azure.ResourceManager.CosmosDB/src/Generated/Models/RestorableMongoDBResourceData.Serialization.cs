// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RestorableMongoDBResourceData : IUtf8JsonSerializable, IJsonModel<RestorableMongoDBResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorableMongoDBResourceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestorableMongoDBResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableMongoDBResourceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsCollectionDefined(CollectionNames))
            {
                writer.WritePropertyName("collectionNames"u8);
                writer.WriteStartArray();
                foreach (var item in CollectionNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
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

        RestorableMongoDBResourceData IJsonModel<RestorableMongoDBResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableMongoDBResourceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableMongoDBResourceData(document.RootElement, options);
        }

        internal static RestorableMongoDBResourceData DeserializeRestorableMongoDBResourceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databaseName = default;
            Optional<IReadOnlyList<string>> collectionNames = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    collectionNames = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorableMongoDBResourceData(id, name, type, systemData.Value, databaseName.Value, Optional.ToList(collectionNames), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (Optional.IsDefined(Name) || hasPropertyOverride)
            {
                builder.Append("  name: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (Optional.IsDefined(DatabaseName) || hasPropertyOverride)
            {
                builder.Append("  databaseName: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CollectionNames), out propertyOverride);
            if (Optional.IsCollectionDefined(CollectionNames) || hasPropertyOverride)
            {
                if (CollectionNames.Any() || hasPropertyOverride)
                {
                    builder.Append("  collectionNames: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in CollectionNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (Optional.IsDefined(Id) || hasPropertyOverride)
            {
                builder.Append("  id: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (Optional.IsDefined(SystemData) || hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{SystemData.ToString()}'");
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

        BinaryData IPersistableModel<RestorableMongoDBResourceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RestorableMongoDBResourceData)} does not support '{options.Format}' format.");
            }
        }

        RestorableMongoDBResourceData IPersistableModel<RestorableMongoDBResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestorableMongoDBResourceData(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RestorableMongoDBResourceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestorableMongoDBResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
