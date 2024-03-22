// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointSyncStatus : IUtf8JsonSerializable, IJsonModel<ServerEndpointSyncStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerEndpointSyncStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerEndpointSyncStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DownloadHealth))
            {
                writer.WritePropertyName("downloadHealth"u8);
                writer.WriteStringValue(DownloadHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(UploadHealth))
            {
                writer.WritePropertyName("uploadHealth"u8);
                writer.WriteStringValue(UploadHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CombinedHealth))
            {
                writer.WritePropertyName("combinedHealth"u8);
                writer.WriteStringValue(CombinedHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SyncActivity))
            {
                writer.WritePropertyName("syncActivity"u8);
                writer.WriteStringValue(SyncActivity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TotalPersistentFilesNotSyncingCount))
            {
                writer.WritePropertyName("totalPersistentFilesNotSyncingCount"u8);
                writer.WriteNumberValue(TotalPersistentFilesNotSyncingCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UploadStatus))
            {
                writer.WritePropertyName("uploadStatus"u8);
                writer.WriteObjectValue<ServerEndpointSyncSessionStatus>(UploadStatus, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DownloadStatus))
            {
                writer.WritePropertyName("downloadStatus"u8);
                writer.WriteObjectValue<ServerEndpointSyncSessionStatus>(DownloadStatus, options);
            }
            if (options.Format != "W" && Optional.IsDefined(UploadActivity))
            {
                writer.WritePropertyName("uploadActivity"u8);
                writer.WriteObjectValue<ServerEndpointSyncActivityStatus>(UploadActivity, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DownloadActivity))
            {
                writer.WritePropertyName("downloadActivity"u8);
                writer.WriteObjectValue<ServerEndpointSyncActivityStatus>(DownloadActivity, options);
            }
            if (options.Format != "W" && Optional.IsDefined(OfflineDataTransferStatus))
            {
                writer.WritePropertyName("offlineDataTransferStatus"u8);
                writer.WriteStringValue(OfflineDataTransferStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BackgroundDataDownloadActivity))
            {
                writer.WritePropertyName("backgroundDataDownloadActivity"u8);
                writer.WriteObjectValue<ServerEndpointBackgroundDataDownloadActivity>(BackgroundDataDownloadActivity, options);
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

        ServerEndpointSyncStatus IJsonModel<ServerEndpointSyncStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointSyncStatus(document.RootElement, options);
        }

        internal static ServerEndpointSyncStatus DeserializeServerEndpointSyncStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServerEndpointHealthState? downloadHealth = default;
            ServerEndpointHealthState? uploadHealth = default;
            ServerEndpointHealthState? combinedHealth = default;
            ServerEndpointSyncActivityState? syncActivity = default;
            long? totalPersistentFilesNotSyncingCount = default;
            DateTimeOffset? lastUpdatedTimestamp = default;
            ServerEndpointSyncSessionStatus uploadStatus = default;
            ServerEndpointSyncSessionStatus downloadStatus = default;
            ServerEndpointSyncActivityStatus uploadActivity = default;
            ServerEndpointSyncActivityStatus downloadActivity = default;
            ServerEndpointOfflineDataTransferState? offlineDataTransferStatus = default;
            ServerEndpointBackgroundDataDownloadActivity backgroundDataDownloadActivity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("downloadHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadHealth = new ServerEndpointHealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uploadHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadHealth = new ServerEndpointHealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("combinedHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    combinedHealth = new ServerEndpointHealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncActivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncActivity = new ServerEndpointSyncActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalPersistentFilesNotSyncingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalPersistentFilesNotSyncingCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("uploadStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadStatus = ServerEndpointSyncSessionStatus.DeserializeServerEndpointSyncSessionStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("downloadStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadStatus = ServerEndpointSyncSessionStatus.DeserializeServerEndpointSyncSessionStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("uploadActivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadActivity = ServerEndpointSyncActivityStatus.DeserializeServerEndpointSyncActivityStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("downloadActivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadActivity = ServerEndpointSyncActivityStatus.DeserializeServerEndpointSyncActivityStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offlineDataTransferStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offlineDataTransferStatus = new ServerEndpointOfflineDataTransferState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backgroundDataDownloadActivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backgroundDataDownloadActivity = ServerEndpointBackgroundDataDownloadActivity.DeserializeServerEndpointBackgroundDataDownloadActivity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerEndpointSyncStatus(
                downloadHealth,
                uploadHealth,
                combinedHealth,
                syncActivity,
                totalPersistentFilesNotSyncingCount,
                lastUpdatedTimestamp,
                uploadStatus,
                downloadStatus,
                uploadActivity,
                downloadActivity,
                offlineDataTransferStatus,
                backgroundDataDownloadActivity,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerEndpointSyncStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support writing '{options.Format}' format.");
            }
        }

        ServerEndpointSyncStatus IPersistableModel<ServerEndpointSyncStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerEndpointSyncStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEndpointSyncStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
