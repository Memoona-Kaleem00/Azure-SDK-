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
    public partial class FabricReplicationGroupTaskDetails : IUtf8JsonSerializable, IJsonModel<FabricReplicationGroupTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FabricReplicationGroupTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FabricReplicationGroupTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricReplicationGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricReplicationGroupTaskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SkippedReason))
            {
                writer.WritePropertyName("skippedReason"u8);
                writer.WriteStringValue(SkippedReason);
            }
            if (Optional.IsDefined(SkippedReasonString))
            {
                writer.WritePropertyName("skippedReasonString"u8);
                writer.WriteStringValue(SkippedReasonString);
            }
            if (Optional.IsDefined(JobTask))
            {
                writer.WritePropertyName("jobTask"u8);
                writer.WriteObjectValue(JobTask);
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

        FabricReplicationGroupTaskDetails IJsonModel<FabricReplicationGroupTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricReplicationGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricReplicationGroupTaskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFabricReplicationGroupTaskDetails(document.RootElement, options);
        }

        internal static FabricReplicationGroupTaskDetails DeserializeFabricReplicationGroupTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> skippedReason = default;
            Optional<string> skippedReasonString = default;
            Optional<SiteRecoveryJobEntity> jobTask = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skippedReason"u8))
                {
                    skippedReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skippedReasonString"u8))
                {
                    skippedReasonString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobTask = SiteRecoveryJobEntity.DeserializeSiteRecoveryJobEntity(property.Value);
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
            return new FabricReplicationGroupTaskDetails(instanceType, serializedAdditionalRawData, jobTask.Value, skippedReason.Value, skippedReasonString.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SkippedReason))
            {
                builder.Append("  skippedReason:");
                if (SkippedReason.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SkippedReason}'''");
                }
                else
                {
                    builder.AppendLine($" '{SkippedReason}'");
                }
            }

            if (Optional.IsDefined(SkippedReasonString))
            {
                builder.Append("  skippedReasonString:");
                if (SkippedReasonString.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SkippedReasonString}'''");
                }
                else
                {
                    builder.AppendLine($" '{SkippedReasonString}'");
                }
            }

            if (Optional.IsDefined(JobTask))
            {
                builder.Append("  jobTask:");
                AppendChildObject(builder, JobTask, options, 2, false);
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

        BinaryData IPersistableModel<FabricReplicationGroupTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricReplicationGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FabricReplicationGroupTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        FabricReplicationGroupTaskDetails IPersistableModel<FabricReplicationGroupTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricReplicationGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFabricReplicationGroupTaskDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(FabricReplicationGroupTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FabricReplicationGroupTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
