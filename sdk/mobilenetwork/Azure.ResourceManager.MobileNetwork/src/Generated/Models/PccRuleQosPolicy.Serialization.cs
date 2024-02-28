// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PccRuleQosPolicy : IUtf8JsonSerializable, IJsonModel<PccRuleQosPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PccRuleQosPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PccRuleQosPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleQosPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PccRuleQosPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (GuaranteedBitRate != null)
            {
                writer.WritePropertyName("guaranteedBitRate"u8);
                writer.WriteObjectValue(GuaranteedBitRate);
            }
            if (FiveQi.HasValue)
            {
                writer.WritePropertyName("5qi"u8);
                writer.WriteNumberValue(FiveQi.Value);
            }
            if (AllocationAndRetentionPriorityLevel.HasValue)
            {
                writer.WritePropertyName("allocationAndRetentionPriorityLevel"u8);
                writer.WriteNumberValue(AllocationAndRetentionPriorityLevel.Value);
            }
            if (PreemptionCapability.HasValue)
            {
                writer.WritePropertyName("preemptionCapability"u8);
                writer.WriteStringValue(PreemptionCapability.Value.ToString());
            }
            if (PreemptionVulnerability.HasValue)
            {
                writer.WritePropertyName("preemptionVulnerability"u8);
                writer.WriteStringValue(PreemptionVulnerability.Value.ToString());
            }
            writer.WritePropertyName("maximumBitRate"u8);
            writer.WriteObjectValue(MaximumBitRate);
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

        PccRuleQosPolicy IJsonModel<PccRuleQosPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleQosPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PccRuleQosPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePccRuleQosPolicy(document.RootElement, options);
        }

        internal static PccRuleQosPolicy DeserializePccRuleQosPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Ambr guaranteedBitRate = default;
            int? _5qi = default;
            int? allocationAndRetentionPriorityLevel = default;
            MobileNetworkPreemptionCapability? preemptionCapability = default;
            MobileNetworkPreemptionVulnerability? preemptionVulnerability = default;
            Ambr maximumBitRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("guaranteedBitRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    guaranteedBitRate = Ambr.DeserializeAmbr(property.Value, options);
                    continue;
                }
                if (property.NameEquals("5qi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    _5qi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocationAndRetentionPriorityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationAndRetentionPriorityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptionCapability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionCapability = new MobileNetworkPreemptionCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preemptionVulnerability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionVulnerability = new MobileNetworkPreemptionVulnerability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maximumBitRate"u8))
                {
                    maximumBitRate = Ambr.DeserializeAmbr(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PccRuleQosPolicy(
                _5qi,
                allocationAndRetentionPriorityLevel,
                preemptionCapability,
                preemptionVulnerability,
                maximumBitRate,
                serializedAdditionalRawData,
                guaranteedBitRate);
        }

        BinaryData IPersistableModel<PccRuleQosPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleQosPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PccRuleQosPolicy)} does not support '{options.Format}' format.");
            }
        }

        PccRuleQosPolicy IPersistableModel<PccRuleQosPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleQosPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePccRuleQosPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PccRuleQosPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PccRuleQosPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
