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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ManagedNetworkSettings : IUtf8JsonSerializable, IJsonModel<ManagedNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedNetworkSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsolationMode))
            {
                writer.WritePropertyName("isolationMode"u8);
                writer.WriteStringValue(IsolationMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkId))
            {
                writer.WritePropertyName("networkId"u8);
                writer.WriteStringValue(NetworkId);
            }
            if (Optional.IsCollectionDefined(OutboundRules))
            {
                if (OutboundRules != null)
                {
                    writer.WritePropertyName("outboundRules"u8);
                    writer.WriteStartObject();
                    foreach (var item in OutboundRules)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value, options);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outboundRules");
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status, options);
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

        ManagedNetworkSettings IJsonModel<ManagedNetworkSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedNetworkSettings(document.RootElement, options);
        }

        internal static ManagedNetworkSettings DeserializeManagedNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IsolationMode? isolationMode = default;
            string networkId = default;
            IDictionary<string, MachineLearningOutboundRule> outboundRules = default;
            ManagedNetworkProvisionStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isolationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolationMode = new IsolationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outboundRules = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningOutboundRule> dictionary = new Dictionary<string, MachineLearningOutboundRule>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningOutboundRule.DeserializeMachineLearningOutboundRule(property0.Value, options));
                    }
                    outboundRules = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ManagedNetworkProvisionStatus.DeserializeManagedNetworkProvisionStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedNetworkSettings(isolationMode, networkId, outboundRules ?? new ChangeTrackingDictionary<string, MachineLearningOutboundRule>(), status, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsolationMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isolationMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsolationMode))
                {
                    builder.Append("  isolationMode: ");
                    builder.AppendLine($"'{IsolationMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  networkId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkId))
                {
                    builder.Append("  networkId: ");
                    if (NetworkId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NetworkId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NetworkId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutboundRules), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outboundRules: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(OutboundRules))
                {
                    if (OutboundRules.Any())
                    {
                        builder.Append("  outboundRules: ");
                        builder.AppendLine("{");
                        foreach (var item in OutboundRules)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  outboundRules: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Status, options, 2, false, "  status: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedNetworkSettings IPersistableModel<ManagedNetworkSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedNetworkSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedNetworkSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
