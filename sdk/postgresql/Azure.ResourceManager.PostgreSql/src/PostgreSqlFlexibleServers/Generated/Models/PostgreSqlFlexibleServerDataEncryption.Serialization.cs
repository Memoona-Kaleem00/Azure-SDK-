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
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerDataEncryption : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerDataEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerDataEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerDataEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKeyUri))
            {
                writer.WritePropertyName("primaryKeyURI"u8);
                writer.WriteStringValue(PrimaryKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(GeoBackupKeyUri))
            {
                writer.WritePropertyName("geoBackupKeyURI"u8);
                writer.WriteStringValue(GeoBackupKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(GeoBackupUserAssignedIdentityId))
            {
                writer.WritePropertyName("geoBackupUserAssignedIdentityId"u8);
                writer.WriteStringValue(GeoBackupUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryEncryptionKeyStatus))
            {
                writer.WritePropertyName("primaryEncryptionKeyStatus"u8);
                writer.WriteStringValue(PrimaryEncryptionKeyStatus.Value.ToString());
            }
            if (Optional.IsDefined(GeoBackupEncryptionKeyStatus))
            {
                writer.WritePropertyName("geoBackupEncryptionKeyStatus"u8);
                writer.WriteStringValue(GeoBackupEncryptionKeyStatus.Value.ToString());
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

        PostgreSqlFlexibleServerDataEncryption IJsonModel<PostgreSqlFlexibleServerDataEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerDataEncryption(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerDataEncryption DeserializePostgreSqlFlexibleServerDataEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri primaryKeyUri = default;
            ResourceIdentifier primaryUserAssignedIdentityId = default;
            Uri geoBackupKeyUri = default;
            string geoBackupUserAssignedIdentityId = default;
            PostgreSqlFlexibleServerKeyType? type = default;
            PostgreSqlKeyStatus? primaryEncryptionKeyStatus = default;
            PostgreSqlKeyStatus? geoBackupEncryptionKeyStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryUserAssignedIdentityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryUserAssignedIdentityId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupUserAssignedIdentityId"u8))
                {
                    geoBackupUserAssignedIdentityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new PostgreSqlFlexibleServerKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerDataEncryption(
                primaryKeyUri,
                primaryUserAssignedIdentityId,
                geoBackupKeyUri,
                geoBackupUserAssignedIdentityId,
                type,
                primaryEncryptionKeyStatus,
                geoBackupEncryptionKeyStatus,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryKeyUri), out propertyOverride);
            if (Optional.IsDefined(PrimaryKeyUri) || hasPropertyOverride)
            {
                builder.Append("  primaryKeyURI: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{PrimaryKeyUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryUserAssignedIdentityId), out propertyOverride);
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId) || hasPropertyOverride)
            {
                builder.Append("  primaryUserAssignedIdentityId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{PrimaryUserAssignedIdentityId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeoBackupKeyUri), out propertyOverride);
            if (Optional.IsDefined(GeoBackupKeyUri) || hasPropertyOverride)
            {
                builder.Append("  geoBackupKeyURI: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{GeoBackupKeyUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeoBackupUserAssignedIdentityId), out propertyOverride);
            if (Optional.IsDefined(GeoBackupUserAssignedIdentityId) || hasPropertyOverride)
            {
                builder.Append("  geoBackupUserAssignedIdentityId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (GeoBackupUserAssignedIdentityId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GeoBackupUserAssignedIdentityId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GeoBackupUserAssignedIdentityId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryEncryptionKeyStatus), out propertyOverride);
            if (Optional.IsDefined(PrimaryEncryptionKeyStatus) || hasPropertyOverride)
            {
                builder.Append("  primaryEncryptionKeyStatus: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{PrimaryEncryptionKeyStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeoBackupEncryptionKeyStatus), out propertyOverride);
            if (Optional.IsDefined(GeoBackupEncryptionKeyStatus) || hasPropertyOverride)
            {
                builder.Append("  geoBackupEncryptionKeyStatus: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{GeoBackupEncryptionKeyStatus.Value.ToString()}'");
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

        BinaryData IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerDataEncryption IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerDataEncryption(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
