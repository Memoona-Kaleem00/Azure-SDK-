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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountKeyList : IUtf8JsonSerializable, IJsonModel<CosmosDBAccountKeyList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBAccountKeyList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBAccountKeyList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountKeyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountKeyList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PrimaryMasterKey))
            {
                writer.WritePropertyName("primaryMasterKey"u8);
                writer.WriteStringValue(PrimaryMasterKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryMasterKey))
            {
                writer.WritePropertyName("secondaryMasterKey"u8);
                writer.WriteStringValue(SecondaryMasterKey);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryReadonlyMasterKey))
            {
                writer.WritePropertyName("primaryReadonlyMasterKey"u8);
                writer.WriteStringValue(PrimaryReadonlyMasterKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryReadonlyMasterKey))
            {
                writer.WritePropertyName("secondaryReadonlyMasterKey"u8);
                writer.WriteStringValue(SecondaryReadonlyMasterKey);
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

        CosmosDBAccountKeyList IJsonModel<CosmosDBAccountKeyList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountKeyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountKeyList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountKeyList(document.RootElement, options);
        }

        internal static CosmosDBAccountKeyList DeserializeCosmosDBAccountKeyList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryMasterKey = default;
            Optional<string> secondaryMasterKey = default;
            Optional<string> primaryReadonlyMasterKey = default;
            Optional<string> secondaryReadonlyMasterKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMasterKey"u8))
                {
                    primaryMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryMasterKey"u8))
                {
                    secondaryMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryReadonlyMasterKey"u8))
                {
                    primaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryReadonlyMasterKey"u8))
                {
                    secondaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBAccountKeyList(primaryReadonlyMasterKey.Value, secondaryReadonlyMasterKey.Value, serializedAdditionalRawData, primaryMasterKey.Value, secondaryMasterKey.Value);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryMasterKey), out propertyOverride);
            if (Optional.IsDefined(PrimaryMasterKey) || hasPropertyOverride)
            {
                builder.Append("  primaryMasterKey: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (PrimaryMasterKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrimaryMasterKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrimaryMasterKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecondaryMasterKey), out propertyOverride);
            if (Optional.IsDefined(SecondaryMasterKey) || hasPropertyOverride)
            {
                builder.Append("  secondaryMasterKey: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (SecondaryMasterKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecondaryMasterKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecondaryMasterKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryReadonlyMasterKey), out propertyOverride);
            if (Optional.IsDefined(PrimaryReadonlyMasterKey) || hasPropertyOverride)
            {
                builder.Append("  primaryReadonlyMasterKey: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (PrimaryReadonlyMasterKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrimaryReadonlyMasterKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrimaryReadonlyMasterKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecondaryReadonlyMasterKey), out propertyOverride);
            if (Optional.IsDefined(SecondaryReadonlyMasterKey) || hasPropertyOverride)
            {
                builder.Append("  secondaryReadonlyMasterKey: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (SecondaryReadonlyMasterKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecondaryReadonlyMasterKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecondaryReadonlyMasterKey}'");
                    }
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

        BinaryData IPersistableModel<CosmosDBAccountKeyList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountKeyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountKeyList)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBAccountKeyList IPersistableModel<CosmosDBAccountKeyList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountKeyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBAccountKeyList(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountKeyList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBAccountKeyList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
