// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupRestoreWithRehydrationContent : IUtf8JsonSerializable, IJsonModel<BackupRestoreWithRehydrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRestoreWithRehydrationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupRestoreWithRehydrationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRestoreWithRehydrationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rehydrationPriority"u8);
            writer.WriteStringValue(RehydrationPriority.ToString());
            writer.WritePropertyName("rehydrationRetentionDuration"u8);
            writer.WriteStringValue(RehydrationRetentionDuration, "P");
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("restoreTargetInfo"u8);
            writer.WriteObjectValue(RestoreTargetInfo);
            writer.WritePropertyName("sourceDataStoreType"u8);
            writer.WriteStringValue(SourceDataStoreType.ToString());
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (IdentityDetails != null)
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails);
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

        BackupRestoreWithRehydrationContent IJsonModel<BackupRestoreWithRehydrationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRestoreWithRehydrationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRestoreWithRehydrationContent(document.RootElement, options);
        }

        internal static BackupRestoreWithRehydrationContent DeserializeBackupRestoreWithRehydrationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupRehydrationPriority rehydrationPriority = default;
            TimeSpan rehydrationRetentionDuration = default;
            string recoveryPointId = default;
            string objectType = default;
            RestoreTargetInfoBase restoreTargetInfo = default;
            SourceDataStoreType sourceDataStoreType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<DataProtectionIdentityDetails> identityDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    rehydrationPriority = new BackupRehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTargetInfo"u8))
                {
                    restoreTargetInfo = RestoreTargetInfoBase.DeserializeRestoreTargetInfoBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDataStoreType"u8))
                {
                    sourceDataStoreType = new SourceDataStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityDetails = DataProtectionIdentityDetails.DeserializeDataProtectionIdentityDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupRestoreWithRehydrationContent(
                objectType,
                restoreTargetInfo,
                sourceDataStoreType,
                sourceResourceId.Value,
                identityDetails.Value,
                serializedAdditionalRawData,
                recoveryPointId,
                rehydrationPriority,
                rehydrationRetentionDuration);
        }

        BinaryData IPersistableModel<BackupRestoreWithRehydrationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupRestoreWithRehydrationContent)} does not support '{options.Format}' format.");
            }
        }

        BackupRestoreWithRehydrationContent IPersistableModel<BackupRestoreWithRehydrationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreWithRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupRestoreWithRehydrationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupRestoreWithRehydrationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupRestoreWithRehydrationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
