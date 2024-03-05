// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadPointInTimeRecoveryPoint : IUtf8JsonSerializable, IJsonModel<WorkloadPointInTimeRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadPointInTimeRecoveryPoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadPointInTimeRecoveryPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadPointInTimeRecoveryPoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TimeRanges))
            {
                writer.WritePropertyName("timeRanges"u8);
                writer.WriteStartArray();
                foreach (var item in TimeRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryPointCreatedOn))
            {
                writer.WritePropertyName("recoveryPointTimeInUTC"u8);
                writer.WriteStringValue(RecoveryPointCreatedOn.Value, "O");
            }
            if (Optional.IsDefined(RestorePointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestorePointType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                writer.WritePropertyName("recoveryPointTierDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryPointTierDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                writer.WritePropertyName("recoveryPointMoveReadinessInfo"u8);
                writer.WriteStartObject();
                foreach (var item in RecoveryPointMoveReadinessInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RecoveryPointProperties))
            {
                writer.WritePropertyName("recoveryPointProperties"u8);
                writer.WriteObjectValue(RecoveryPointProperties);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        WorkloadPointInTimeRecoveryPoint IJsonModel<WorkloadPointInTimeRecoveryPoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadPointInTimeRecoveryPoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadPointInTimeRecoveryPoint(document.RootElement, options);
        }

        internal static WorkloadPointInTimeRecoveryPoint DeserializeWorkloadPointInTimeRecoveryPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadSAPHanaPointInTimeRecoveryPoint": return WorkloadSapHanaPointInTimeRecoveryPoint.DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(element, options);
                }
            }
            IList<PointInTimeRange> timeRanges = default;
            DateTimeOffset? recoveryPointTimeInUTC = default;
            RestorePointType? type = default;
            IList<RecoveryPointTierInformationV2> recoveryPointTierDetails = default;
            IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo = default;
            RecoveryPointProperties recoveryPointProperties = default;
            string objectType = "AzureWorkloadPointInTimeRecoveryPoint";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointInTimeRange> array = new List<PointInTimeRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointInTimeRange.DeserializePointInTimeRange(item, options));
                    }
                    timeRanges = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RestorePointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPointTierDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointTierInformationV2> array = new List<RecoveryPointTierInformationV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item, options));
                    }
                    recoveryPointTierDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointMoveReadinessInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RecoveryPointMoveReadinessInfo> dictionary = new Dictionary<string, RecoveryPointMoveReadinessInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value, options));
                    }
                    recoveryPointMoveReadinessInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("recoveryPointProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadPointInTimeRecoveryPoint(
                objectType,
                serializedAdditionalRawData,
                recoveryPointTimeInUTC,
                type,
                recoveryPointTierDetails ?? new ChangeTrackingList<RecoveryPointTierInformationV2>(),
                recoveryPointMoveReadinessInfo ?? new ChangeTrackingDictionary<string, RecoveryPointMoveReadinessInfo>(),
                recoveryPointProperties,
                timeRanges ?? new ChangeTrackingList<PointInTimeRange>());
        }

        BinaryData IPersistableModel<WorkloadPointInTimeRecoveryPoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadPointInTimeRecoveryPoint)} does not support '{options.Format}' format.");
            }
        }

        WorkloadPointInTimeRecoveryPoint IPersistableModel<WorkloadPointInTimeRecoveryPoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadPointInTimeRecoveryPoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadPointInTimeRecoveryPoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadPointInTimeRecoveryPoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
