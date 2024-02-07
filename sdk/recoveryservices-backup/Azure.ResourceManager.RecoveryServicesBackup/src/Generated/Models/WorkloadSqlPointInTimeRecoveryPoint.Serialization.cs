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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadSqlPointInTimeRecoveryPoint : IUtf8JsonSerializable, IJsonModel<WorkloadSqlPointInTimeRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadSqlPointInTimeRecoveryPoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadSqlPointInTimeRecoveryPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlPointInTimeRecoveryPoint)} does not support '{format}' format.");
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
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
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

        WorkloadSqlPointInTimeRecoveryPoint IJsonModel<WorkloadSqlPointInTimeRecoveryPoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlPointInTimeRecoveryPoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSqlPointInTimeRecoveryPoint(document.RootElement, options);
        }

        internal static WorkloadSqlPointInTimeRecoveryPoint DeserializeWorkloadSqlPointInTimeRecoveryPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PointInTimeRange>> timeRanges = default;
            Optional<WorkloadSqlRecoveryPointExtendedInfo> extendedInfo = default;
            Optional<DateTimeOffset> recoveryPointTimeInUTC = default;
            Optional<RestorePointType> type = default;
            Optional<IList<RecoveryPointTierInformationV2>> recoveryPointTierDetails = default;
            Optional<IDictionary<string, RecoveryPointMoveReadinessInfo>> recoveryPointMoveReadinessInfo = default;
            Optional<RecoveryPointProperties> recoveryPointProperties = default;
            string objectType = default;
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
                        array.Add(PointInTimeRange.DeserializePointInTimeRange(item));
                    }
                    timeRanges = array;
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = WorkloadSqlRecoveryPointExtendedInfo.DeserializeWorkloadSqlRecoveryPointExtendedInfo(property.Value);
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
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item));
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
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value));
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
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value);
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
            return new WorkloadSqlPointInTimeRecoveryPoint(objectType, serializedAdditionalRawData, Optional.ToNullable(recoveryPointTimeInUTC), Optional.ToNullable(type), Optional.ToList(recoveryPointTierDetails), Optional.ToDictionary(recoveryPointMoveReadinessInfo), recoveryPointProperties.Value, extendedInfo.Value, Optional.ToList(timeRanges));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(TimeRanges))
            {
                if (TimeRanges.Any())
                {
                    builder.Append("  timeRanges:");
                    builder.AppendLine(" [");
                    foreach (var item in TimeRanges)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(ExtendedInfo))
            {
                builder.Append("  extendedInfo:");
                AppendChildObject(builder, ExtendedInfo, options, 2, false);
            }

            if (Optional.IsDefined(RecoveryPointCreatedOn))
            {
                builder.Append("  recoveryPointTimeInUTC:");
                var formattedDateTimeString = TypeFormatters.ToString(RecoveryPointCreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                if (RecoveryPointTierDetails.Any())
                {
                    builder.Append("  recoveryPointTierDetails:");
                    builder.AppendLine(" [");
                    foreach (var item in RecoveryPointTierDetails)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                if (RecoveryPointMoveReadinessInfo.Any())
                {
                    builder.Append("  recoveryPointMoveReadinessInfo:");
                    builder.AppendLine(" {");
                    foreach (var item in RecoveryPointMoveReadinessInfo)
                    {
                        builder.Append($"    {item.Key}:");
                        AppendChildObject(builder, item.Value, options, 4, false);
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(RecoveryPointProperties))
            {
                builder.Append("  recoveryPointProperties:");
                AppendChildObject(builder, RecoveryPointProperties, options, 2, false);
            }

            if (Optional.IsDefined(ObjectType))
            {
                builder.Append("  objectType:");
                if (ObjectType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ObjectType}'''");
                }
                else
                {
                    builder.AppendLine($" '{ObjectType}'");
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

        BinaryData IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlPointInTimeRecoveryPoint)} does not support '{options.Format}' format.");
            }
        }

        WorkloadSqlPointInTimeRecoveryPoint IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadSqlPointInTimeRecoveryPoint(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlPointInTimeRecoveryPoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadSqlPointInTimeRecoveryPoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
