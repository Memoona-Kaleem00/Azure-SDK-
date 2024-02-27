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
                throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DownloadHealth.HasValue)
            {
                writer.WritePropertyName("downloadHealth"u8);
                writer.WriteStringValue(DownloadHealth.Value.ToString());
            }
            if (options.Format != "W" && UploadHealth.HasValue)
            {
                writer.WritePropertyName("uploadHealth"u8);
                writer.WriteStringValue(UploadHealth.Value.ToString());
            }
            if (options.Format != "W" && CombinedHealth.HasValue)
            {
                writer.WritePropertyName("combinedHealth"u8);
                writer.WriteStringValue(CombinedHealth.Value.ToString());
            }
            if (options.Format != "W" && SyncActivity.HasValue)
            {
                writer.WritePropertyName("syncActivity"u8);
                writer.WriteStringValue(SyncActivity.Value.ToString());
            }
            if (options.Format != "W" && TotalPersistentFilesNotSyncingCount.HasValue)
            {
                writer.WritePropertyName("totalPersistentFilesNotSyncingCount"u8);
                writer.WriteNumberValue(TotalPersistentFilesNotSyncingCount.Value);
            }
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && UploadStatus != null)
            {
                writer.WritePropertyName("uploadStatus"u8);
                writer.WriteObjectValue(UploadStatus);
            }
            if (options.Format != "W" && DownloadStatus != null)
            {
                writer.WritePropertyName("downloadStatus"u8);
                writer.WriteObjectValue(DownloadStatus);
            }
            if (options.Format != "W" && UploadActivity != null)
            {
                writer.WritePropertyName("uploadActivity"u8);
                writer.WriteObjectValue(UploadActivity);
            }
            if (options.Format != "W" && DownloadActivity != null)
            {
                writer.WritePropertyName("downloadActivity"u8);
                writer.WriteObjectValue(DownloadActivity);
            }
            if (options.Format != "W" && OfflineDataTransferStatus.HasValue)
            {
                writer.WritePropertyName("offlineDataTransferStatus"u8);
                writer.WriteStringValue(OfflineDataTransferStatus.Value.ToString());
            }
            if (options.Format != "W" && BackgroundDataDownloadActivity != null)
            {
                writer.WritePropertyName("backgroundDataDownloadActivity"u8);
                writer.WriteObjectValue(BackgroundDataDownloadActivity);
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
                throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support '{format}' format.");
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
            Optional<ServerEndpointHealthState> downloadHealth = default;
            Optional<ServerEndpointHealthState> uploadHealth = default;
            Optional<ServerEndpointHealthState> combinedHealth = default;
            Optional<ServerEndpointSyncActivityState> syncActivity = default;
            Optional<long> totalPersistentFilesNotSyncingCount = default;
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<ServerEndpointSyncSessionStatus> uploadStatus = default;
            Optional<ServerEndpointSyncSessionStatus> downloadStatus = default;
            Optional<ServerEndpointSyncActivityStatus> uploadActivity = default;
            Optional<ServerEndpointSyncActivityStatus> downloadActivity = default;
            Optional<ServerEndpointOfflineDataTransferState> offlineDataTransferStatus = default;
            Optional<ServerEndpointBackgroundDataDownloadActivity> backgroundDataDownloadActivity = default;
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
                Optional.ToNullable(downloadHealth),
                Optional.ToNullable(uploadHealth),
                Optional.ToNullable(combinedHealth),
                Optional.ToNullable(syncActivity),
                Optional.ToNullable(totalPersistentFilesNotSyncingCount),
                Optional.ToNullable(lastUpdatedTimestamp),
                uploadStatus.Value,
                downloadStatus.Value,
                uploadActivity.Value,
                downloadActivity.Value,
                Optional.ToNullable(offlineDataTransferStatus),
                backgroundDataDownloadActivity.Value,
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
                    throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support '{options.Format}' format.");
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
                    throw new FormatException($"The model {nameof(ServerEndpointSyncStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEndpointSyncStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
