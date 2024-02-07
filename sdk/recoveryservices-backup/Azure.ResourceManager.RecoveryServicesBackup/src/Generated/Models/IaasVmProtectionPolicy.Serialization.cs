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
    public partial class IaasVmProtectionPolicy : IUtf8JsonSerializable, IJsonModel<IaasVmProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmProtectionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IaasVmProtectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstantRPDetails))
            {
                writer.WritePropertyName("instantRPDetails"u8);
                writer.WriteObjectValue(InstantRPDetails);
            }
            if (Optional.IsDefined(SchedulePolicy))
            {
                writer.WritePropertyName("schedulePolicy"u8);
                writer.WriteObjectValue(SchedulePolicy);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsCollectionDefined(TieringPolicy))
            {
                writer.WritePropertyName("tieringPolicy"u8);
                writer.WriteStartObject();
                foreach (var item in TieringPolicy)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(InstantRPRetentionRangeInDays))
            {
                writer.WritePropertyName("instantRpRetentionRangeInDays"u8);
                writer.WriteNumberValue(InstantRPRetentionRangeInDays.Value);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("policyType"u8);
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            writer.WritePropertyName("backupManagementType"u8);
            writer.WriteStringValue(BackupManagementType);
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        IaasVmProtectionPolicy IJsonModel<IaasVmProtectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmProtectionPolicy(document.RootElement, options);
        }

        internal static IaasVmProtectionPolicy DeserializeIaasVmProtectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<InstantRPAdditionalDetails> instantRPDetails = default;
            Optional<BackupSchedulePolicy> schedulePolicy = default;
            Optional<BackupRetentionPolicy> retentionPolicy = default;
            Optional<IDictionary<string, BackupTieringPolicy>> tieringPolicy = default;
            Optional<int> instantRpRetentionRangeInDays = default;
            Optional<string> timeZone = default;
            Optional<IaasVmPolicyType> policyType = default;
            Optional<int> protectedItemsCount = default;
            string backupManagementType = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instantRPDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instantRPDetails = InstantRPAdditionalDetails.DeserializeInstantRPAdditionalDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("schedulePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulePolicy = BackupSchedulePolicy.DeserializeBackupSchedulePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = BackupRetentionPolicy.DeserializeBackupRetentionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("tieringPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BackupTieringPolicy> dictionary = new Dictionary<string, BackupTieringPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BackupTieringPolicy.DeserializeBackupTieringPolicy(property0.Value));
                    }
                    tieringPolicy = dictionary;
                    continue;
                }
                if (property.NameEquals("instantRpRetentionRangeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instantRpRetentionRangeInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyType = new IaasVmPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmProtectionPolicy(Optional.ToNullable(protectedItemsCount), backupManagementType, Optional.ToList(resourceGuardOperationRequests), serializedAdditionalRawData, instantRPDetails.Value, schedulePolicy.Value, retentionPolicy.Value, Optional.ToDictionary(tieringPolicy), Optional.ToNullable(instantRpRetentionRangeInDays), timeZone.Value, Optional.ToNullable(policyType));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(InstantRPDetails))
            {
                builder.Append("  instantRPDetails:");
                AppendChildObject(builder, InstantRPDetails, options, 2, false);
            }

            if (Optional.IsDefined(SchedulePolicy))
            {
                builder.Append("  schedulePolicy:");
                AppendChildObject(builder, SchedulePolicy, options, 2, false);
            }

            if (Optional.IsDefined(RetentionPolicy))
            {
                builder.Append("  retentionPolicy:");
                AppendChildObject(builder, RetentionPolicy, options, 2, false);
            }

            if (Optional.IsCollectionDefined(TieringPolicy))
            {
                if (TieringPolicy.Any())
                {
                    builder.Append("  tieringPolicy:");
                    builder.AppendLine(" {");
                    foreach (var item in TieringPolicy)
                    {
                        builder.Append($"    {item.Key}:");
                        AppendChildObject(builder, item.Value, options, 4, false);
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(InstantRPRetentionRangeInDays))
            {
                builder.Append("  instantRpRetentionRangeInDays:");
                builder.AppendLine($" {InstantRPRetentionRangeInDays.Value}");
            }

            if (Optional.IsDefined(TimeZone))
            {
                builder.Append("  timeZone:");
                if (TimeZone.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{TimeZone}'''");
                }
                else
                {
                    builder.AppendLine($" '{TimeZone}'");
                }
            }

            if (Optional.IsDefined(PolicyType))
            {
                builder.Append("  policyType:");
                builder.AppendLine($" '{PolicyType.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProtectedItemsCount))
            {
                builder.Append("  protectedItemsCount:");
                builder.AppendLine($" {ProtectedItemsCount.Value}");
            }

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                if (BackupManagementType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{BackupManagementType}'''");
                }
                else
                {
                    builder.AppendLine($" '{BackupManagementType}'");
                }
            }

            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                if (ResourceGuardOperationRequests.Any())
                {
                    builder.Append("  resourceGuardOperationRequests:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceGuardOperationRequests)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("    '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"    '{item}'");
                        }
                    }
                    builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<IaasVmProtectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        IaasVmProtectionPolicy IPersistableModel<IaasVmProtectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmProtectionPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmProtectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
