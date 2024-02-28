// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupStatus : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBackupStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBackupStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumeBackupStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && IsHealthy.HasValue)
            {
                writer.WritePropertyName("healthy"u8);
                writer.WriteBooleanValue(IsHealthy.Value);
            }
            if (options.Format != "W" && RelationshipStatus.HasValue)
            {
                writer.WritePropertyName("relationshipStatus"u8);
                writer.WriteStringValue(RelationshipStatus.Value.ToString());
            }
            if (options.Format != "W" && MirrorState.HasValue)
            {
                writer.WritePropertyName("mirrorState"u8);
                writer.WriteStringValue(MirrorState.Value.ToString());
            }
            if (options.Format != "W" && UnhealthyReason != null)
            {
                writer.WritePropertyName("unhealthyReason"u8);
                writer.WriteStringValue(UnhealthyReason);
            }
            if (options.Format != "W" && ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && LastTransferSize.HasValue)
            {
                writer.WritePropertyName("lastTransferSize"u8);
                writer.WriteNumberValue(LastTransferSize.Value);
            }
            if (options.Format != "W" && LastTransferType != null)
            {
                writer.WritePropertyName("lastTransferType"u8);
                writer.WriteStringValue(LastTransferType);
            }
            if (options.Format != "W" && TotalTransferBytes.HasValue)
            {
                writer.WritePropertyName("totalTransferBytes"u8);
                writer.WriteNumberValue(TotalTransferBytes.Value);
            }
            if (options.Format != "W" && TransferProgressBytes.HasValue)
            {
                writer.WritePropertyName("transferProgressBytes"u8);
                writer.WriteNumberValue(TransferProgressBytes.Value);
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

        NetAppVolumeBackupStatus IJsonModel<NetAppVolumeBackupStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupStatus(document.RootElement, options);
        }

        internal static NetAppVolumeBackupStatus DeserializeNetAppVolumeBackupStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? healthy = default;
            NetAppRelationshipStatus? relationshipStatus = default;
            NetAppMirrorState? mirrorState = default;
            string unhealthyReason = default;
            string errorMessage = default;
            long? lastTransferSize = default;
            string lastTransferType = default;
            long? totalTransferBytes = default;
            long? transferProgressBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("relationshipStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relationshipStatus = new NetAppRelationshipStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mirrorState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mirrorState = new NetAppMirrorState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unhealthyReason"u8))
                {
                    unhealthyReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastTransferSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTransferSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastTransferType"u8))
                {
                    lastTransferType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalTransferBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalTransferBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transferProgressBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferProgressBytes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeBackupStatus(
                healthy,
                relationshipStatus,
                mirrorState,
                unhealthyReason,
                errorMessage,
                lastTransferSize,
                lastTransferType,
                totalTransferBytes,
                transferProgressBytes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeBackupStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupStatus)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumeBackupStatus IPersistableModel<NetAppVolumeBackupStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeBackupStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeBackupStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
