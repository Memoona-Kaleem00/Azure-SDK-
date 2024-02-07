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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourceTypeAliasPattern : IUtf8JsonSerializable, IJsonModel<ResourceTypeAliasPattern>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeAliasPattern>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceTypeAliasPattern>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeAliasPattern>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Phrase))
            {
                writer.WritePropertyName("phrase"u8);
                writer.WriteStringValue(Phrase);
            }
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
            }
            if (Optional.IsDefined(PatternType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PatternType.Value.ToSerialString());
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

        ResourceTypeAliasPattern IJsonModel<ResourceTypeAliasPattern>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeAliasPattern>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPattern(document.RootElement, options);
        }

        internal static ResourceTypeAliasPattern DeserializeResourceTypeAliasPattern(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> phrase = default;
            Optional<string> variable = default;
            Optional<ResourceTypeAliasPatternType> type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phrase"u8))
                {
                    phrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasPatternType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceTypeAliasPattern(phrase.Value, variable.Value, Optional.ToNullable(type), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Phrase))
            {
                builder.Append("  phrase:");
                if (Phrase.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Phrase}'''");
                }
                else
                {
                    builder.AppendLine($" '{Phrase}'");
                }
            }

            if (Optional.IsDefined(Variable))
            {
                builder.Append("  variable:");
                if (Variable.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Variable}'''");
                }
                else
                {
                    builder.AppendLine($" '{Variable}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
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
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ResourceTypeAliasPattern>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeAliasPattern>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{options.Format}' format.");
            }
        }

        ResourceTypeAliasPattern IPersistableModel<ResourceTypeAliasPattern>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeAliasPattern>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceTypeAliasPattern(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceTypeAliasPattern>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
