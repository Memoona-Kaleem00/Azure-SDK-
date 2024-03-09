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
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyVersion : IUtf8JsonSerializable, IJsonModel<ManagementPolicyVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementPolicyVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementPolicyVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TierToCool))
            {
                writer.WritePropertyName("tierToCool"u8);
                writer.WriteObjectValue(TierToCool);
            }
            if (Optional.IsDefined(TierToArchive))
            {
                writer.WritePropertyName("tierToArchive"u8);
                writer.WriteObjectValue(TierToArchive);
            }
            if (Optional.IsDefined(TierToCold))
            {
                writer.WritePropertyName("tierToCold"u8);
                writer.WriteObjectValue(TierToCold);
            }
            if (Optional.IsDefined(TierToHot))
            {
                writer.WritePropertyName("tierToHot"u8);
                writer.WriteObjectValue(TierToHot);
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete);
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

        ManagementPolicyVersion IJsonModel<ManagementPolicyVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementPolicyVersion(document.RootElement, options);
        }

        internal static ManagementPolicyVersion DeserializeManagementPolicyVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateAfterCreation tierToCool = default;
            DateAfterCreation tierToArchive = default;
            DateAfterCreation tierToCold = default;
            DateAfterCreation tierToHot = default;
            DateAfterCreation delete = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tierToCool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCool = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tierToArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToArchive = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tierToCold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCold = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tierToHot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToHot = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementPolicyVersion(
                tierToCool,
                tierToArchive,
                tierToCold,
                tierToHot,
                delete,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToCool), out propertyOverride);
            if (Optional.IsDefined(TierToCool) || hasPropertyOverride)
            {
                builder.Append("  tierToCool: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, TierToCool, options, 2, false, "  tierToCool: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToArchive), out propertyOverride);
            if (Optional.IsDefined(TierToArchive) || hasPropertyOverride)
            {
                builder.Append("  tierToArchive: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, TierToArchive, options, 2, false, "  tierToArchive: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToCold), out propertyOverride);
            if (Optional.IsDefined(TierToCold) || hasPropertyOverride)
            {
                builder.Append("  tierToCold: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, TierToCold, options, 2, false, "  tierToCold: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToHot), out propertyOverride);
            if (Optional.IsDefined(TierToHot) || hasPropertyOverride)
            {
                builder.Append("  tierToHot: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, TierToHot, options, 2, false, "  tierToHot: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Delete), out propertyOverride);
            if (Optional.IsDefined(Delete) || hasPropertyOverride)
            {
                builder.Append("  delete: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, Delete, options, 2, false, "  delete: ");
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

        BinaryData IPersistableModel<ManagementPolicyVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{options.Format}' format.");
            }
        }

        ManagementPolicyVersion IPersistableModel<ManagementPolicyVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementPolicyVersion(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementPolicyVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
