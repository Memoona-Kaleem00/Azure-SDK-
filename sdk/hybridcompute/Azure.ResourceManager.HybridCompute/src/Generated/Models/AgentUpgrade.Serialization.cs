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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class AgentUpgrade : IUtf8JsonSerializable, IJsonModel<AgentUpgrade>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentUpgrade>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AgentUpgrade>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentUpgrade)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredVersion))
            {
                writer.WritePropertyName("desiredVersion"u8);
                writer.WriteStringValue(DesiredVersion);
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId.Value);
            }
            if (Optional.IsDefined(IsAutomaticUpgradeEnabled))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(IsAutomaticUpgradeEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastAttemptDesiredVersion))
            {
                writer.WritePropertyName("lastAttemptDesiredVersion"u8);
                writer.WriteStringValue(LastAttemptDesiredVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(LastAttemptedOn))
            {
                writer.WritePropertyName("lastAttemptTimestamp"u8);
                writer.WriteStringValue(LastAttemptedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastAttemptStatus))
            {
                writer.WritePropertyName("lastAttemptStatus"u8);
                writer.WriteStringValue(LastAttemptStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastAttemptMessage))
            {
                writer.WritePropertyName("lastAttemptMessage"u8);
                writer.WriteStringValue(LastAttemptMessage);
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

        AgentUpgrade IJsonModel<AgentUpgrade>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentUpgrade)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentUpgrade(document.RootElement, options);
        }

        internal static AgentUpgrade DeserializeAgentUpgrade(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string desiredVersion = default;
            Guid? correlationId = default;
            bool? enableAutomaticUpgrade = default;
            string lastAttemptDesiredVersion = default;
            DateTimeOffset? lastAttemptTimestamp = default;
            LastAttemptStatusEnum? lastAttemptStatus = default;
            string lastAttemptMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredVersion"u8))
                {
                    desiredVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    correlationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastAttemptDesiredVersion"u8))
                {
                    lastAttemptDesiredVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastAttemptTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastAttemptTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastAttemptStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastAttemptStatus = new LastAttemptStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastAttemptMessage"u8))
                {
                    lastAttemptMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AgentUpgrade(
                desiredVersion,
                correlationId,
                enableAutomaticUpgrade,
                lastAttemptDesiredVersion,
                lastAttemptTimestamp,
                lastAttemptStatus,
                lastAttemptMessage,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DesiredVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  desiredVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DesiredVersion))
                {
                    builder.Append("  desiredVersion: ");
                    if (DesiredVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DesiredVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DesiredVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CorrelationId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  correlationId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CorrelationId))
                {
                    builder.Append("  correlationId: ");
                    builder.AppendLine($"'{CorrelationId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAutomaticUpgradeEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableAutomaticUpgrade: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAutomaticUpgradeEnabled))
                {
                    builder.Append("  enableAutomaticUpgrade: ");
                    var boolValue = IsAutomaticUpgradeEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastAttemptDesiredVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastAttemptDesiredVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastAttemptDesiredVersion))
                {
                    builder.Append("  lastAttemptDesiredVersion: ");
                    if (LastAttemptDesiredVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastAttemptDesiredVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastAttemptDesiredVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastAttemptedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastAttemptTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastAttemptedOn))
                {
                    builder.Append("  lastAttemptTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastAttemptedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastAttemptStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastAttemptStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastAttemptStatus))
                {
                    builder.Append("  lastAttemptStatus: ");
                    builder.AppendLine($"'{LastAttemptStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastAttemptMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastAttemptMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastAttemptMessage))
                {
                    builder.Append("  lastAttemptMessage: ");
                    if (LastAttemptMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastAttemptMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastAttemptMessage}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AgentUpgrade>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AgentUpgrade)} does not support writing '{options.Format}' format.");
            }
        }

        AgentUpgrade IPersistableModel<AgentUpgrade>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentUpgrade(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentUpgrade)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentUpgrade>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
