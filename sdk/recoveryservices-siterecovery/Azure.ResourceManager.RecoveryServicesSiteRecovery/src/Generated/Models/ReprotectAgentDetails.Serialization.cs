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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReprotectAgentDetails : IUtf8JsonSerializable, IJsonModel<ReprotectAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReprotectAgentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReprotectAgentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReprotectAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReprotectAgentDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartbeatUtc"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectedItemCount))
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AccessibleDatastores))
            {
                writer.WritePropertyName("accessibleDatastores"u8);
                writer.WriteStartArray();
                foreach (var item in AccessibleDatastores)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vcenterId"u8);
                writer.WriteStringValue(VCenterId);
            }
            if (options.Format != "W" && Optional.IsDefined(Last))
            {
                writer.WritePropertyName("lastDiscoveryInUtc"u8);
                writer.WriteStringValue(Last.Value, "O");
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

        ReprotectAgentDetails IJsonModel<ReprotectAgentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReprotectAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReprotectAgentDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReprotectAgentDetails(document.RootElement, options);
        }

        internal static ReprotectAgentDetails DeserializeReprotectAgentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> biosId = default;
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<string> fqdn = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<SiteRecoveryProtectionHealth> health = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            Optional<int> protectedItemCount = default;
            Optional<IReadOnlyList<string>> accessibleDatastores = default;
            Optional<string> vCenterId = default;
            Optional<DateTimeOffset> lastDiscoveryInUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("accessibleDatastores"u8))
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
                    accessibleDatastores = array;
                    continue;
                }
                if (property.NameEquals("vcenterId"u8))
                {
                    vCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastDiscoveryInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastDiscoveryInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReprotectAgentDetails(id.Value, name.Value, biosId.Value, fabricObjectId.Value, fqdn.Value, version.Value, Optional.ToNullable(lastHeartbeatUtc), Optional.ToNullable(health), Optional.ToList(healthErrors), Optional.ToNullable(protectedItemCount), Optional.ToList(accessibleDatastores), vCenterId.Value, Optional.ToNullable(lastDiscoveryInUtc), serializedAdditionalRawData);
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

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                if (Id.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Id}'''");
                }
                else
                {
                    builder.AppendLine($" '{Id}'");
                }
            }

            if (Optional.IsDefined(BiosId))
            {
                builder.Append("  biosId:");
                if (BiosId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{BiosId}'''");
                }
                else
                {
                    builder.AppendLine($" '{BiosId}'");
                }
            }

            if (Optional.IsDefined(FabricObjectId))
            {
                builder.Append("  fabricObjectId:");
                builder.AppendLine($" '{FabricObjectId.ToString()}'");
            }

            if (Optional.IsDefined(Fqdn))
            {
                builder.Append("  fqdn:");
                if (Fqdn.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Fqdn}'''");
                }
                else
                {
                    builder.AppendLine($" '{Fqdn}'");
                }
            }

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                if (Version.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Version}'''");
                }
                else
                {
                    builder.AppendLine($" '{Version}'");
                }
            }

            if (Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                builder.Append("  lastHeartbeatUtc:");
                var formattedDateTimeString = TypeFormatters.ToString(LastHeartbeatReceivedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(Health))
            {
                builder.Append("  health:");
                builder.AppendLine($" '{Health.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(HealthErrors))
            {
                if (HealthErrors.Any())
                {
                    builder.Append("  healthErrors:");
                    builder.AppendLine(" [");
                    foreach (var item in HealthErrors)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(ProtectedItemCount))
            {
                builder.Append("  protectedItemCount:");
                builder.AppendLine($" {ProtectedItemCount.Value}");
            }

            if (Optional.IsCollectionDefined(AccessibleDatastores))
            {
                if (AccessibleDatastores.Any())
                {
                    builder.Append("  accessibleDatastores:");
                    builder.AppendLine(" [");
                    foreach (var item in AccessibleDatastores)
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

            if (Optional.IsDefined(VCenterId))
            {
                builder.Append("  vcenterId:");
                if (VCenterId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{VCenterId}'''");
                }
                else
                {
                    builder.AppendLine($" '{VCenterId}'");
                }
            }

            if (Optional.IsDefined(Last))
            {
                builder.Append("  lastDiscoveryInUtc:");
                var formattedDateTimeString = TypeFormatters.ToString(Last.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
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

        BinaryData IPersistableModel<ReprotectAgentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReprotectAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ReprotectAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        ReprotectAgentDetails IPersistableModel<ReprotectAgentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReprotectAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReprotectAgentDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ReprotectAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReprotectAgentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
