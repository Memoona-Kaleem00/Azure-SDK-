// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SnapshotBackupAdditionalDetails : IUtf8JsonSerializable, IJsonModel<SnapshotBackupAdditionalDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotBackupAdditionalDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotBackupAdditionalDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotBackupAdditionalDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotBackupAdditionalDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstantRpRetentionRangeInDays))
            {
                writer.WritePropertyName("instantRpRetentionRangeInDays"u8);
                writer.WriteNumberValue(InstantRpRetentionRangeInDays.Value);
            }
            if (Optional.IsDefined(InstantRPDetails))
            {
                writer.WritePropertyName("instantRPDetails"u8);
                writer.WriteStringValue(InstantRPDetails);
            }
            if (Optional.IsDefined(UserAssignedManagedIdentityDetails))
            {
                writer.WritePropertyName("userAssignedManagedIdentityDetails"u8);
                writer.WriteObjectValue<UserAssignedManagedIdentityDetails>(UserAssignedManagedIdentityDetails, options);
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

        SnapshotBackupAdditionalDetails IJsonModel<SnapshotBackupAdditionalDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotBackupAdditionalDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotBackupAdditionalDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotBackupAdditionalDetails(document.RootElement, options);
        }

        internal static SnapshotBackupAdditionalDetails DeserializeSnapshotBackupAdditionalDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? instantRpRetentionRangeInDays = default;
            string instantRPDetails = default;
            UserAssignedManagedIdentityDetails userAssignedManagedIdentityDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instantRpRetentionRangeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instantRpRetentionRangeInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instantRPDetails"u8))
                {
                    instantRPDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedManagedIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedManagedIdentityDetails = UserAssignedManagedIdentityDetails.DeserializeUserAssignedManagedIdentityDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SnapshotBackupAdditionalDetails(instantRpRetentionRangeInDays, instantRPDetails, userAssignedManagedIdentityDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotBackupAdditionalDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotBackupAdditionalDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SnapshotBackupAdditionalDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SnapshotBackupAdditionalDetails IPersistableModel<SnapshotBackupAdditionalDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotBackupAdditionalDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotBackupAdditionalDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SnapshotBackupAdditionalDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotBackupAdditionalDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
