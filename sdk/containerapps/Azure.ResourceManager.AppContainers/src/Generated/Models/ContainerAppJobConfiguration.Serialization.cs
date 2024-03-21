// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppJobConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJobConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("triggerType"u8);
            writer.WriteStringValue(TriggerType.ToString());
            writer.WritePropertyName("replicaTimeout"u8);
            writer.WriteNumberValue(ReplicaTimeout);
            if (Optional.IsDefined(ReplicaRetryLimit))
            {
                writer.WritePropertyName("replicaRetryLimit"u8);
                writer.WriteNumberValue(ReplicaRetryLimit.Value);
            }
            if (Optional.IsDefined(ManualTriggerConfig))
            {
                writer.WritePropertyName("manualTriggerConfig"u8);
                writer.WriteObjectValue(ManualTriggerConfig);
            }
            if (Optional.IsDefined(ScheduleTriggerConfig))
            {
                writer.WritePropertyName("scheduleTriggerConfig"u8);
                writer.WriteObjectValue(ScheduleTriggerConfig);
            }
            if (Optional.IsDefined(EventTriggerConfig))
            {
                writer.WritePropertyName("eventTriggerConfig"u8);
                writer.WriteObjectValue(EventTriggerConfig);
            }
            if (Optional.IsCollectionDefined(Registries))
            {
                writer.WritePropertyName("registries"u8);
                writer.WriteStartArray();
                foreach (var item in Registries)
                {
                    writer.WriteObjectValue(item);
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

        ContainerAppJobConfiguration IJsonModel<ContainerAppJobConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobConfiguration(document.RootElement, options);
        }

        internal static ContainerAppJobConfiguration DeserializeContainerAppJobConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerAppWritableSecret> secrets = default;
            ContainerAppJobTriggerType triggerType = default;
            int replicaTimeout = default;
            int? replicaRetryLimit = default;
            JobConfigurationManualTriggerConfig manualTriggerConfig = default;
            JobConfigurationScheduleTriggerConfig scheduleTriggerConfig = default;
            EventTriggerConfiguration eventTriggerConfig = default;
            IList<ContainerAppRegistryCredentials> registries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppWritableSecret> array = new List<ContainerAppWritableSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppWritableSecret.DeserializeContainerAppWritableSecret(item, options));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = new ContainerAppJobTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicaTimeout"u8))
                {
                    replicaTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicaRetryLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaRetryLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("manualTriggerConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manualTriggerConfig = JobConfigurationManualTriggerConfig.DeserializeJobConfigurationManualTriggerConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scheduleTriggerConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleTriggerConfig = JobConfigurationScheduleTriggerConfig.DeserializeJobConfigurationScheduleTriggerConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("eventTriggerConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTriggerConfig = EventTriggerConfiguration.DeserializeEventTriggerConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("registries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppRegistryCredentials> array = new List<ContainerAppRegistryCredentials>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppRegistryCredentials.DeserializeContainerAppRegistryCredentials(item, options));
                    }
                    registries = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppJobConfiguration(
                secrets ?? new ChangeTrackingList<ContainerAppWritableSecret>(),
                triggerType,
                replicaTimeout,
                replicaRetryLimit,
                manualTriggerConfig,
                scheduleTriggerConfig,
                eventTriggerConfig,
                registries ?? new ChangeTrackingList<ContainerAppRegistryCredentials>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppJobConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJobConfiguration IPersistableModel<ContainerAppJobConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
