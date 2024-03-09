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
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerStorageCapability : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerStorageCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerStorageCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerStorageCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SupportedIops))
            {
                writer.WritePropertyName("supportedIops"u8);
                writer.WriteNumberValue(SupportedIops.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageSizeInMB))
            {
                writer.WritePropertyName("storageSizeMb"u8);
                writer.WriteNumberValue(StorageSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultIopsTier))
            {
                writer.WritePropertyName("defaultIopsTier"u8);
                writer.WriteStringValue(DefaultIopsTier);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedIopsTiers))
            {
                writer.WritePropertyName("supportedIopsTiers"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedIopsTiers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CapabilityStatus))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(CapabilityStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        PostgreSqlFlexibleServerStorageCapability IJsonModel<PostgreSqlFlexibleServerStorageCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerStorageCapability(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerStorageCapability DeserializePostgreSqlFlexibleServerStorageCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? supportedIops = default;
            long? storageSizeMb = default;
            string defaultIopsTier = default;
            IReadOnlyList<PostgreSqlFlexibleServerStorageTierCapability> supportedIopsTiers = default;
            PostgreSqlFlexbileServerCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedIops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSizeMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageSizeMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultIopsTier"u8))
                {
                    defaultIopsTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedIopsTiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerStorageTierCapability> array = new List<PostgreSqlFlexibleServerStorageTierCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerStorageTierCapability.DeserializePostgreSqlFlexibleServerStorageTierCapability(item, options));
                    }
                    supportedIopsTiers = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerStorageCapability(
                status,
                reason,
                serializedAdditionalRawData,
                supportedIops,
                storageSizeMb,
                defaultIopsTier,
                supportedIopsTiers ?? new ChangeTrackingList<PostgreSqlFlexibleServerStorageTierCapability>());
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedIops), out propertyOverride);
            if (Optional.IsDefined(SupportedIops) || hasPropertyOverride)
            {
                builder.Append("  supportedIops: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{SupportedIops.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageSizeInMB), out propertyOverride);
            if (Optional.IsDefined(StorageSizeInMB) || hasPropertyOverride)
            {
                builder.Append("  storageSizeMb: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{StorageSizeInMB.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultIopsTier), out propertyOverride);
            if (Optional.IsDefined(DefaultIopsTier) || hasPropertyOverride)
            {
                builder.Append("  defaultIopsTier: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (DefaultIopsTier.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DefaultIopsTier}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DefaultIopsTier}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedIopsTiers), out propertyOverride);
            if (Optional.IsCollectionDefined(SupportedIopsTiers) || hasPropertyOverride)
            {
                if (SupportedIopsTiers.Any() || hasPropertyOverride)
                {
                    builder.Append("  supportedIopsTiers: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in SupportedIopsTiers)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  supportedIopsTiers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CapabilityStatus), out propertyOverride);
            if (Optional.IsDefined(CapabilityStatus) || hasPropertyOverride)
            {
                builder.Append("  status: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{CapabilityStatus.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reason), out propertyOverride);
            if (Optional.IsDefined(Reason) || hasPropertyOverride)
            {
                builder.Append("  reason: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Reason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Reason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Reason}'");
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

        BinaryData IPersistableModel<PostgreSqlFlexibleServerStorageCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerStorageCapability IPersistableModel<PostgreSqlFlexibleServerStorageCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerStorageCapability(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerStorageCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
