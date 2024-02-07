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

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationEmailConfigurationProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationEmailConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationEmailConfigurationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataReplicationEmailConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEmailConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationEmailConfigurationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sendToOwners"u8);
            writer.WriteBooleanValue(SendToOwners);
            if (Optional.IsCollectionDefined(CustomEmailAddresses))
            {
                writer.WritePropertyName("customEmailAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in CustomEmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Locale))
            {
                writer.WritePropertyName("locale"u8);
                writer.WriteStringValue(Locale);
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

        DataReplicationEmailConfigurationProperties IJsonModel<DataReplicationEmailConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEmailConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationEmailConfigurationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationEmailConfigurationProperties(document.RootElement, options);
        }

        internal static DataReplicationEmailConfigurationProperties DeserializeDataReplicationEmailConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool sendToOwners = default;
            Optional<IList<string>> customEmailAddresses = default;
            Optional<string> locale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendToOwners"u8))
                {
                    sendToOwners = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customEmailAddresses"u8))
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
                    customEmailAddresses = array;
                    continue;
                }
                if (property.NameEquals("locale"u8))
                {
                    locale = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationEmailConfigurationProperties(sendToOwners, Optional.ToList(customEmailAddresses), locale.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SendToOwners))
            {
                builder.Append("  sendToOwners:");
                var boolValue = SendToOwners == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(CustomEmailAddresses))
            {
                if (CustomEmailAddresses.Any())
                {
                    builder.Append("  customEmailAddresses:");
                    builder.AppendLine(" [");
                    foreach (var item in CustomEmailAddresses)
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

            if (Optional.IsDefined(Locale))
            {
                builder.Append("  locale:");
                if (Locale.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Locale}'''");
                }
                else
                {
                    builder.AppendLine($" '{Locale}'");
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

        BinaryData IPersistableModel<DataReplicationEmailConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEmailConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataReplicationEmailConfigurationProperties)} does not support '{options.Format}' format.");
            }
        }

        DataReplicationEmailConfigurationProperties IPersistableModel<DataReplicationEmailConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEmailConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataReplicationEmailConfigurationProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataReplicationEmailConfigurationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataReplicationEmailConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
