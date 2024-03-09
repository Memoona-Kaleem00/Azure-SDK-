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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedActionImpactRecord : IUtf8JsonSerializable, IJsonModel<RecommendedActionImpactRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecommendedActionImpactRecord>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecommendedActionImpactRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImpactRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedActionImpactRecord)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DimensionName))
            {
                writer.WritePropertyName("dimensionName"u8);
                writer.WriteStringValue(DimensionName);
            }
            if (options.Format != "W" && Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (options.Format != "W" && Optional.IsDefined(AbsoluteValue))
            {
                writer.WritePropertyName("absoluteValue"u8);
                writer.WriteNumberValue(AbsoluteValue.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ChangeValueAbsolute))
            {
                writer.WritePropertyName("changeValueAbsolute"u8);
                writer.WriteNumberValue(ChangeValueAbsolute.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ChangeValueRelative))
            {
                writer.WritePropertyName("changeValueRelative"u8);
                writer.WriteNumberValue(ChangeValueRelative.Value);
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

        RecommendedActionImpactRecord IJsonModel<RecommendedActionImpactRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImpactRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedActionImpactRecord)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedActionImpactRecord(document.RootElement, options);
        }

        internal static RecommendedActionImpactRecord DeserializeRecommendedActionImpactRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimensionName = default;
            string unit = default;
            double? absoluteValue = default;
            double? changeValueAbsolute = default;
            double? changeValueRelative = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("absoluteValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    absoluteValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeValueAbsolute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeValueAbsolute = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeValueRelative"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeValueRelative = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecommendedActionImpactRecord(
                dimensionName,
                unit,
                absoluteValue,
                changeValueAbsolute,
                changeValueRelative,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DimensionName), out propertyOverride);
            if (Optional.IsDefined(DimensionName) || hasPropertyOverride)
            {
                builder.Append("  dimensionName: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (DimensionName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DimensionName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DimensionName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Unit), out propertyOverride);
            if (Optional.IsDefined(Unit) || hasPropertyOverride)
            {
                builder.Append("  unit: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Unit.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Unit}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Unit}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AbsoluteValue), out propertyOverride);
            if (Optional.IsDefined(AbsoluteValue) || hasPropertyOverride)
            {
                builder.Append("  absoluteValue: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{AbsoluteValue.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ChangeValueAbsolute), out propertyOverride);
            if (Optional.IsDefined(ChangeValueAbsolute) || hasPropertyOverride)
            {
                builder.Append("  changeValueAbsolute: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{ChangeValueAbsolute.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ChangeValueRelative), out propertyOverride);
            if (Optional.IsDefined(ChangeValueRelative) || hasPropertyOverride)
            {
                builder.Append("  changeValueRelative: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{ChangeValueRelative.Value.ToString()}'");
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

        BinaryData IPersistableModel<RecommendedActionImpactRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImpactRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RecommendedActionImpactRecord)} does not support '{options.Format}' format.");
            }
        }

        RecommendedActionImpactRecord IPersistableModel<RecommendedActionImpactRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImpactRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecommendedActionImpactRecord(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RecommendedActionImpactRecord)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecommendedActionImpactRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
