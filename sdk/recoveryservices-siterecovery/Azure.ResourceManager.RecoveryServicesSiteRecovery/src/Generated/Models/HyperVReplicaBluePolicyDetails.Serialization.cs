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
    public partial class HyperVReplicaBluePolicyDetails : IUtf8JsonSerializable, IJsonModel<HyperVReplicaBluePolicyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaBluePolicyDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVReplicaBluePolicyDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBluePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaBluePolicyDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicationFrequencyInSeconds))
            {
                writer.WritePropertyName("replicationFrequencyInSeconds"u8);
                writer.WriteNumberValue(ReplicationFrequencyInSeconds.Value);
            }
            if (Optional.IsDefined(RecoveryPoints))
            {
                writer.WritePropertyName("recoveryPoints"u8);
                writer.WriteNumberValue(RecoveryPoints.Value);
            }
            if (Optional.IsDefined(ApplicationConsistentSnapshotFrequencyInHours))
            {
                writer.WritePropertyName("applicationConsistentSnapshotFrequencyInHours"u8);
                writer.WriteNumberValue(ApplicationConsistentSnapshotFrequencyInHours.Value);
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteStringValue(Compression);
            }
            if (Optional.IsDefined(InitialReplicationMethod))
            {
                writer.WritePropertyName("initialReplicationMethod"u8);
                writer.WriteStringValue(InitialReplicationMethod);
            }
            if (Optional.IsDefined(OnlineReplicationStartTime))
            {
                writer.WritePropertyName("onlineReplicationStartTime"u8);
                writer.WriteStringValue(OnlineReplicationStartTime);
            }
            if (Optional.IsDefined(OfflineReplicationImportPath))
            {
                writer.WritePropertyName("offlineReplicationImportPath"u8);
                writer.WriteStringValue(OfflineReplicationImportPath);
            }
            if (Optional.IsDefined(OfflineReplicationExportPath))
            {
                writer.WritePropertyName("offlineReplicationExportPath"u8);
                writer.WriteStringValue(OfflineReplicationExportPath);
            }
            if (Optional.IsDefined(ReplicationPort))
            {
                writer.WritePropertyName("replicationPort"u8);
                writer.WriteNumberValue(ReplicationPort.Value);
            }
            if (Optional.IsDefined(AllowedAuthenticationType))
            {
                writer.WritePropertyName("allowedAuthenticationType"u8);
                writer.WriteNumberValue(AllowedAuthenticationType.Value);
            }
            if (Optional.IsDefined(ReplicaDeletionOption))
            {
                writer.WritePropertyName("replicaDeletionOption"u8);
                writer.WriteStringValue(ReplicaDeletionOption);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        HyperVReplicaBluePolicyDetails IJsonModel<HyperVReplicaBluePolicyDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBluePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaBluePolicyDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaBluePolicyDetails(document.RootElement, options);
        }

        internal static HyperVReplicaBluePolicyDetails DeserializeHyperVReplicaBluePolicyDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> replicationFrequencyInSeconds = default;
            Optional<int> recoveryPoints = default;
            Optional<int> applicationConsistentSnapshotFrequencyInHours = default;
            Optional<string> compression = default;
            Optional<string> initialReplicationMethod = default;
            Optional<string> onlineReplicationStartTime = default;
            Optional<string> offlineReplicationImportPath = default;
            Optional<string> offlineReplicationExportPath = default;
            Optional<int> replicationPort = default;
            Optional<int> allowedAuthenticationType = default;
            Optional<string> replicaDeletionOption = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicationFrequencyInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationFrequencyInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPoints = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("applicationConsistentSnapshotFrequencyInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationConsistentSnapshotFrequencyInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    compression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationMethod"u8))
                {
                    initialReplicationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onlineReplicationStartTime"u8))
                {
                    onlineReplicationStartTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationImportPath"u8))
                {
                    offlineReplicationImportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationExportPath"u8))
                {
                    offlineReplicationExportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedAuthenticationType = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicaDeletionOption"u8))
                {
                    replicaDeletionOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVReplicaBluePolicyDetails(instanceType, serializedAdditionalRawData, Optional.ToNullable(replicationFrequencyInSeconds), Optional.ToNullable(recoveryPoints), Optional.ToNullable(applicationConsistentSnapshotFrequencyInHours), compression.Value, initialReplicationMethod.Value, onlineReplicationStartTime.Value, offlineReplicationImportPath.Value, offlineReplicationExportPath.Value, Optional.ToNullable(replicationPort), Optional.ToNullable(allowedAuthenticationType), replicaDeletionOption.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ReplicationFrequencyInSeconds))
            {
                builder.Append("  replicationFrequencyInSeconds:");
                builder.AppendLine($" {ReplicationFrequencyInSeconds.Value}");
            }

            if (Optional.IsDefined(RecoveryPoints))
            {
                builder.Append("  recoveryPoints:");
                builder.AppendLine($" {RecoveryPoints.Value}");
            }

            if (Optional.IsDefined(ApplicationConsistentSnapshotFrequencyInHours))
            {
                builder.Append("  applicationConsistentSnapshotFrequencyInHours:");
                builder.AppendLine($" {ApplicationConsistentSnapshotFrequencyInHours.Value}");
            }

            if (Optional.IsDefined(Compression))
            {
                builder.Append("  compression:");
                if (Compression.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Compression}'''");
                }
                else
                {
                    builder.AppendLine($" '{Compression}'");
                }
            }

            if (Optional.IsDefined(InitialReplicationMethod))
            {
                builder.Append("  initialReplicationMethod:");
                if (InitialReplicationMethod.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{InitialReplicationMethod}'''");
                }
                else
                {
                    builder.AppendLine($" '{InitialReplicationMethod}'");
                }
            }

            if (Optional.IsDefined(OnlineReplicationStartTime))
            {
                builder.Append("  onlineReplicationStartTime:");
                if (OnlineReplicationStartTime.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{OnlineReplicationStartTime}'''");
                }
                else
                {
                    builder.AppendLine($" '{OnlineReplicationStartTime}'");
                }
            }

            if (Optional.IsDefined(OfflineReplicationImportPath))
            {
                builder.Append("  offlineReplicationImportPath:");
                if (OfflineReplicationImportPath.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{OfflineReplicationImportPath}'''");
                }
                else
                {
                    builder.AppendLine($" '{OfflineReplicationImportPath}'");
                }
            }

            if (Optional.IsDefined(OfflineReplicationExportPath))
            {
                builder.Append("  offlineReplicationExportPath:");
                if (OfflineReplicationExportPath.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{OfflineReplicationExportPath}'''");
                }
                else
                {
                    builder.AppendLine($" '{OfflineReplicationExportPath}'");
                }
            }

            if (Optional.IsDefined(ReplicationPort))
            {
                builder.Append("  replicationPort:");
                builder.AppendLine($" {ReplicationPort.Value}");
            }

            if (Optional.IsDefined(AllowedAuthenticationType))
            {
                builder.Append("  allowedAuthenticationType:");
                builder.AppendLine($" {AllowedAuthenticationType.Value}");
            }

            if (Optional.IsDefined(ReplicaDeletionOption))
            {
                builder.Append("  replicaDeletionOption:");
                if (ReplicaDeletionOption.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ReplicaDeletionOption}'''");
                }
                else
                {
                    builder.AppendLine($" '{ReplicaDeletionOption}'");
                }
            }

            if (Optional.IsDefined(InstanceType))
            {
                builder.Append("  instanceType:");
                if (InstanceType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{InstanceType}'''");
                }
                else
                {
                    builder.AppendLine($" '{InstanceType}'");
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

        BinaryData IPersistableModel<HyperVReplicaBluePolicyDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBluePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaBluePolicyDetails)} does not support '{options.Format}' format.");
            }
        }

        HyperVReplicaBluePolicyDetails IPersistableModel<HyperVReplicaBluePolicyDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBluePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVReplicaBluePolicyDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaBluePolicyDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaBluePolicyDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
