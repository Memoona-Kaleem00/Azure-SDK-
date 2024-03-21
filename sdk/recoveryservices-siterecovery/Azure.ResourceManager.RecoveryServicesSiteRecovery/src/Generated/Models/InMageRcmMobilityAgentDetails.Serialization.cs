// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmMobilityAgentDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmMobilityAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmMobilityAgentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmMobilityAgentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmMobilityAgentDetails)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(LatestAgentReleaseDate))
            {
                writer.WritePropertyName("latestAgentReleaseDate"u8);
                writer.WriteStringValue(LatestAgentReleaseDate);
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

        InMageRcmMobilityAgentDetails IJsonModel<InMageRcmMobilityAgentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmMobilityAgentDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmMobilityAgentDetails(document.RootElement, options);
        }

        internal static InMageRcmMobilityAgentDetails DeserializeInMageRcmMobilityAgentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string version = default;
            string latestVersion = default;
            string latestAgentReleaseDate = default;
            string driverVersion = default;
            string latestUpgradableVersionWithoutReboot = default;
            DateTimeOffset? agentVersionExpireOn = default;
            DateTimeOffset? driverVersionExpireOn = default;
            DateTimeOffset? lastHeartbeatUtc = default;
            IReadOnlyList<AgentUpgradeBlockedReason> reasonsBlockingUpgrade = default;
            string isUpgradeable = default;
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
                if (property.NameEquals("latestAgentReleaseDate"u8))
                {
                    latestAgentReleaseDate = property.Value.GetString();
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
            return new InMageRcmMobilityAgentDetails(
                version,
                latestVersion,
                latestAgentReleaseDate,
                driverVersion,
                latestUpgradableVersionWithoutReboot,
                agentVersionExpireOn,
                driverVersionExpireOn,
                lastHeartbeatUtc,
                reasonsBlockingUpgrade ?? new ChangeTrackingList<AgentUpgradeBlockedReason>(),
                isUpgradeable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmMobilityAgentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmMobilityAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmMobilityAgentDetails IPersistableModel<InMageRcmMobilityAgentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmMobilityAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmMobilityAgentDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmMobilityAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmMobilityAgentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
