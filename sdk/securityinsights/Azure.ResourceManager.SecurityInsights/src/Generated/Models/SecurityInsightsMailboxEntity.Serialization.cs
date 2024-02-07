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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsMailboxEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsMailboxEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsMailboxEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsMailboxEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsMailboxEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsMailboxEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(MailboxPrimaryAddress))
            {
                writer.WritePropertyName("mailboxPrimaryAddress"u8);
                writer.WriteStringValue(MailboxPrimaryAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Upn))
            {
                writer.WritePropertyName("upn"u8);
                writer.WriteStringValue(Upn);
            }
            if (options.Format != "W" && Optional.IsDefined(ExternalDirectoryObjectId))
            {
                writer.WritePropertyName("externalDirectoryObjectId"u8);
                writer.WriteStringValue(ExternalDirectoryObjectId.Value);
            }
            writer.WriteEndObject();
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

        SecurityInsightsMailboxEntity IJsonModel<SecurityInsightsMailboxEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsMailboxEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsMailboxEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsMailboxEntity(document.RootElement, options);
        }

        internal static SecurityInsightsMailboxEntity DeserializeSecurityInsightsMailboxEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> mailboxPrimaryAddress = default;
            Optional<string> displayName = default;
            Optional<string> upn = default;
            Optional<Guid> externalDirectoryObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mailboxPrimaryAddress"u8))
                        {
                            mailboxPrimaryAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("upn"u8))
                        {
                            upn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("externalDirectoryObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            externalDirectoryObjectId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsMailboxEntity(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, mailboxPrimaryAddress.Value, displayName.Value, upn.Value, Optional.ToNullable(externalDirectoryObjectId));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsCollectionDefined(AdditionalData))
            {
                if (AdditionalData.Any())
                {
                    builder.Append("    additionalData:");
                    builder.AppendLine(" {");
                    foreach (var item in AdditionalData)
                    {
                        builder.Append($"        {item.Key}:");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value.ToString()}'");
                    }
                    builder.AppendLine("    }");
                }
            }

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("    friendlyName:");
                if (FriendlyName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{FriendlyName}'''");
                }
                else
                {
                    builder.AppendLine($" '{FriendlyName}'");
                }
            }

            if (Optional.IsDefined(MailboxPrimaryAddress))
            {
                builder.Append("    mailboxPrimaryAddress:");
                if (MailboxPrimaryAddress.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{MailboxPrimaryAddress}'''");
                }
                else
                {
                    builder.AppendLine($" '{MailboxPrimaryAddress}'");
                }
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("    displayName:");
                if (DisplayName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DisplayName}'''");
                }
                else
                {
                    builder.AppendLine($" '{DisplayName}'");
                }
            }

            if (Optional.IsDefined(Upn))
            {
                builder.Append("    upn:");
                if (Upn.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Upn}'''");
                }
                else
                {
                    builder.AppendLine($" '{Upn}'");
                }
            }

            if (Optional.IsDefined(ExternalDirectoryObjectId))
            {
                builder.Append("    externalDirectoryObjectId:");
                builder.AppendLine($" '{ExternalDirectoryObjectId.Value.ToString()}'");
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SecurityInsightsMailboxEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsMailboxEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsMailboxEntity)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsMailboxEntity IPersistableModel<SecurityInsightsMailboxEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsMailboxEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsMailboxEntity(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsMailboxEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsMailboxEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
