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
    public partial class InMageRcmFailbackMobilityAgentDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFailbackMobilityAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFailbackMobilityAgentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmFailbackMobilityAgentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackMobilityAgentDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestVersion))
            {
                writer.WritePropertyName("latestVersion"u8);
                writer.WriteStringValue(LatestVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(DriverVersion))
            {
                writer.WritePropertyName("driverVersion"u8);
                writer.WriteStringValue(DriverVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestUpgradableVersionWithoutReboot))
            {
                writer.WritePropertyName("latestUpgradableVersionWithoutReboot"u8);
                writer.WriteStringValue(LatestUpgradableVersionWithoutReboot);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentVersionExpireOn))
            {
                writer.WritePropertyName("agentVersionExpiryDate"u8);
                writer.WriteStringValue(AgentVersionExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DriverVersionExpireOn))
            {
                writer.WritePropertyName("driverVersionExpiryDate"u8);
                writer.WriteStringValue(DriverVersionExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartbeatUtc"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReasonsBlockingUpgrade))
            {
                writer.WritePropertyName("reasonsBlockingUpgrade"u8);
                writer.WriteStartArray();
                foreach (var item in ReasonsBlockingUpgrade)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsUpgradeable))
            {
                writer.WritePropertyName("isUpgradeable"u8);
                writer.WriteStringValue(IsUpgradeable);
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

        InMageRcmFailbackMobilityAgentDetails IJsonModel<InMageRcmFailbackMobilityAgentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackMobilityAgentDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackMobilityAgentDetails(document.RootElement, options);
        }

        internal static InMageRcmFailbackMobilityAgentDetails DeserializeInMageRcmFailbackMobilityAgentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> version = default;
            Optional<string> latestVersion = default;
            Optional<string> driverVersion = default;
            Optional<string> latestUpgradableVersionWithoutReboot = default;
            Optional<DateTimeOffset> agentVersionExpireOn = default;
            Optional<DateTimeOffset> driverVersionExpireOn = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<IReadOnlyList<AgentUpgradeBlockedReason>> reasonsBlockingUpgrade = default;
            Optional<string> isUpgradeable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestVersion"u8))
                {
                    latestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverVersion"u8))
                {
                    driverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestUpgradableVersionWithoutReboot"u8))
                {
                    latestUpgradableVersionWithoutReboot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("driverVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driverVersionExpireOn = property.Value.GetDateTimeOffset("O");
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
                if (property.NameEquals("reasonsBlockingUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgentUpgradeBlockedReason> array = new List<AgentUpgradeBlockedReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AgentUpgradeBlockedReason(item.GetString()));
                    }
                    reasonsBlockingUpgrade = array;
                    continue;
                }
                if (property.NameEquals("isUpgradeable"u8))
                {
                    isUpgradeable = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFailbackMobilityAgentDetails(version.Value, latestVersion.Value, driverVersion.Value, latestUpgradableVersionWithoutReboot.Value, Optional.ToNullable(agentVersionExpireOn), Optional.ToNullable(driverVersionExpireOn), Optional.ToNullable(lastHeartbeatUtc), Optional.ToList(reasonsBlockingUpgrade), isUpgradeable.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

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

            if (Optional.IsDefined(LatestVersion))
            {
                builder.Append("  latestVersion:");
                if (LatestVersion.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{LatestVersion}'''");
                }
                else
                {
                    builder.AppendLine($" '{LatestVersion}'");
                }
            }

            if (Optional.IsDefined(DriverVersion))
            {
                builder.Append("  driverVersion:");
                if (DriverVersion.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DriverVersion}'''");
                }
                else
                {
                    builder.AppendLine($" '{DriverVersion}'");
                }
            }

            if (Optional.IsDefined(LatestUpgradableVersionWithoutReboot))
            {
                builder.Append("  latestUpgradableVersionWithoutReboot:");
                if (LatestUpgradableVersionWithoutReboot.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{LatestUpgradableVersionWithoutReboot}'''");
                }
                else
                {
                    builder.AppendLine($" '{LatestUpgradableVersionWithoutReboot}'");
                }
            }

            if (Optional.IsDefined(AgentVersionExpireOn))
            {
                builder.Append("  agentVersionExpiryDate:");
                var formattedDateTimeString = TypeFormatters.ToString(AgentVersionExpireOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(DriverVersionExpireOn))
            {
                builder.Append("  driverVersionExpiryDate:");
                var formattedDateTimeString = TypeFormatters.ToString(DriverVersionExpireOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                builder.Append("  lastHeartbeatUtc:");
                var formattedDateTimeString = TypeFormatters.ToString(LastHeartbeatReceivedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsCollectionDefined(ReasonsBlockingUpgrade))
            {
                if (ReasonsBlockingUpgrade.Any())
                {
                    builder.Append("  reasonsBlockingUpgrade:");
                    builder.AppendLine(" [");
                    foreach (var item in ReasonsBlockingUpgrade)
                    {
                        builder.AppendLine($"    '{item.ToString()}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(IsUpgradeable))
            {
                builder.Append("  isUpgradeable:");
                if (IsUpgradeable.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{IsUpgradeable}'''");
                }
                else
                {
                    builder.AppendLine($" '{IsUpgradeable}'");
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

        BinaryData IPersistableModel<InMageRcmFailbackMobilityAgentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackMobilityAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmFailbackMobilityAgentDetails IPersistableModel<InMageRcmFailbackMobilityAgentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmFailbackMobilityAgentDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackMobilityAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmFailbackMobilityAgentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
