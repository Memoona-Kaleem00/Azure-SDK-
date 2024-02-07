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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryDataStore : IUtf8JsonSerializable, IJsonModel<SiteRecoveryDataStore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryDataStore>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryDataStore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDataStore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDataStore)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SymbolicName))
            {
                writer.WritePropertyName("symbolicName"u8);
                writer.WriteStringValue(SymbolicName);
            }
            if (Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid.Value);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteStringValue(Capacity);
            }
            if (Optional.IsDefined(FreeSpace))
            {
                writer.WritePropertyName("freeSpace"u8);
                writer.WriteStringValue(FreeSpace);
            }
            if (Optional.IsDefined(DataStoreType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(DataStoreType);
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

        SiteRecoveryDataStore IJsonModel<SiteRecoveryDataStore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDataStore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDataStore)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryDataStore(document.RootElement, options);
        }

        internal static SiteRecoveryDataStore DeserializeSiteRecoveryDataStore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> symbolicName = default;
            Optional<Guid> uuid = default;
            Optional<string> capacity = default;
            Optional<string> freeSpace = default;
            Optional<string> type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("symbolicName"u8))
                {
                    symbolicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("freeSpace"u8))
                {
                    freeSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryDataStore(symbolicName.Value, Optional.ToNullable(uuid), capacity.Value, freeSpace.Value, type.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SymbolicName))
            {
                builder.Append("  symbolicName:");
                if (SymbolicName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SymbolicName}'''");
                }
                else
                {
                    builder.AppendLine($" '{SymbolicName}'");
                }
            }

            if (Optional.IsDefined(Uuid))
            {
                builder.Append("  uuid:");
                builder.AppendLine($" '{Uuid.Value.ToString()}'");
            }

            if (Optional.IsDefined(Capacity))
            {
                builder.Append("  capacity:");
                if (Capacity.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Capacity}'''");
                }
                else
                {
                    builder.AppendLine($" '{Capacity}'");
                }
            }

            if (Optional.IsDefined(FreeSpace))
            {
                builder.Append("  freeSpace:");
                if (FreeSpace.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{FreeSpace}'''");
                }
                else
                {
                    builder.AppendLine($" '{FreeSpace}'");
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

        BinaryData IPersistableModel<SiteRecoveryDataStore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDataStore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDataStore)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryDataStore IPersistableModel<SiteRecoveryDataStore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDataStore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryDataStore(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDataStore)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryDataStore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
