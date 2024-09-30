// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradePolicy : IUtf8JsonSerializable, IJsonModel<RollingUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RollingUpgradePolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RollingUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MaxBatchInstancePercent))
            {
                writer.WritePropertyName("maxBatchInstancePercent"u8);
                writer.WriteNumberValue(MaxBatchInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyUpgradedInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyUpgradedInstancePercent.Value);
            }
            if (Optional.IsDefined(PauseTimeBetweenBatches))
            {
                writer.WritePropertyName("pauseTimeBetweenBatches"u8);
                writer.WriteStringValue(PauseTimeBetweenBatches);
            }
            if (Optional.IsDefined(EnableCrossZoneUpgrade))
            {
                writer.WritePropertyName("enableCrossZoneUpgrade"u8);
                writer.WriteBooleanValue(EnableCrossZoneUpgrade.Value);
            }
            if (Optional.IsDefined(PrioritizeUnhealthyInstances))
            {
                writer.WritePropertyName("prioritizeUnhealthyInstances"u8);
                writer.WriteBooleanValue(PrioritizeUnhealthyInstances.Value);
            }
            if (Optional.IsDefined(RollbackFailedInstancesOnPolicyBreach))
            {
                writer.WritePropertyName("rollbackFailedInstancesOnPolicyBreach"u8);
                writer.WriteBooleanValue(RollbackFailedInstancesOnPolicyBreach.Value);
            }
            if (Optional.IsDefined(IsMaxSurgeEnabled))
            {
                writer.WritePropertyName("maxSurge"u8);
                writer.WriteBooleanValue(IsMaxSurgeEnabled.Value);
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
        }

        RollingUpgradePolicy IJsonModel<RollingUpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRollingUpgradePolicy(document.RootElement, options);
        }

        internal static RollingUpgradePolicy DeserializeRollingUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxBatchInstancePercent = default;
            int? maxUnhealthyInstancePercent = default;
            int? maxUnhealthyUpgradedInstancePercent = default;
            string pauseTimeBetweenBatches = default;
            bool? enableCrossZoneUpgrade = default;
            bool? prioritizeUnhealthyInstances = default;
            bool? rollbackFailedInstancesOnPolicyBreach = default;
            bool? maxSurge = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxBatchInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBatchInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyUpgradedInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyUpgradedInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pauseTimeBetweenBatches"u8))
                {
                    pauseTimeBetweenBatches = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableCrossZoneUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCrossZoneUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prioritizeUnhealthyInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prioritizeUnhealthyInstances = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rollbackFailedInstancesOnPolicyBreach"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollbackFailedInstancesOnPolicyBreach = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxSurge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSurge = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RollingUpgradePolicy(
                maxBatchInstancePercent,
                maxUnhealthyInstancePercent,
                maxUnhealthyUpgradedInstancePercent,
                pauseTimeBetweenBatches,
                enableCrossZoneUpgrade,
                prioritizeUnhealthyInstances,
                rollbackFailedInstancesOnPolicyBreach,
                maxSurge,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RollingUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support writing '{options.Format}' format.");
            }
        }

        RollingUpgradePolicy IPersistableModel<RollingUpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRollingUpgradePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RollingUpgradePolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RollingUpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
