// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningKubernetesProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningKubernetesProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningKubernetesProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningKubernetesProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningKubernetesProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RelayConnectionString != null)
            {
                if (RelayConnectionString != null)
                {
                    writer.WritePropertyName("relayConnectionString"u8);
                    writer.WriteStringValue(RelayConnectionString);
                }
                else
                {
                    writer.WriteNull("relayConnectionString");
                }
            }
            if (ServiceBusConnectionString != null)
            {
                if (ServiceBusConnectionString != null)
                {
                    writer.WritePropertyName("serviceBusConnectionString"u8);
                    writer.WriteStringValue(ServiceBusConnectionString);
                }
                else
                {
                    writer.WriteNull("serviceBusConnectionString");
                }
            }
            if (ExtensionPrincipalId != null)
            {
                if (ExtensionPrincipalId != null)
                {
                    writer.WritePropertyName("extensionPrincipalId"u8);
                    writer.WriteStringValue(ExtensionPrincipalId);
                }
                else
                {
                    writer.WriteNull("extensionPrincipalId");
                }
            }
            if (ExtensionInstanceReleaseTrain != null)
            {
                writer.WritePropertyName("extensionInstanceReleaseTrain"u8);
                writer.WriteStringValue(ExtensionInstanceReleaseTrain);
            }
            if (VcName != null)
            {
                writer.WritePropertyName("vcName"u8);
                writer.WriteStringValue(VcName);
            }
            if (Namespace != null)
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (DefaultInstanceType != null)
            {
                writer.WritePropertyName("defaultInstanceType"u8);
                writer.WriteStringValue(DefaultInstanceType);
            }
            if (!(InstanceTypes is ChangeTrackingDictionary<string, MachineLearningInstanceTypeSchema> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("instanceTypes"u8);
                writer.WriteStartObject();
                foreach (var item in InstanceTypes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        MachineLearningKubernetesProperties IJsonModel<MachineLearningKubernetesProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningKubernetesProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningKubernetesProperties(document.RootElement, options);
        }

        internal static MachineLearningKubernetesProperties DeserializeMachineLearningKubernetesProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> relayConnectionString = default;
            Optional<string> serviceBusConnectionString = default;
            Optional<string> extensionPrincipalId = default;
            Optional<string> extensionInstanceReleaseTrain = default;
            Optional<string> vcName = default;
            Optional<string> @namespace = default;
            Optional<string> defaultInstanceType = default;
            Optional<IDictionary<string, MachineLearningInstanceTypeSchema>> instanceTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relayConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        relayConnectionString = null;
                        continue;
                    }
                    relayConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        serviceBusConnectionString = null;
                        continue;
                    }
                    serviceBusConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionPrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        extensionPrincipalId = null;
                        continue;
                    }
                    extensionPrincipalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionInstanceReleaseTrain"u8))
                {
                    extensionInstanceReleaseTrain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vcName"u8))
                {
                    vcName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultInstanceType"u8))
                {
                    defaultInstanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MachineLearningInstanceTypeSchema> dictionary = new Dictionary<string, MachineLearningInstanceTypeSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningInstanceTypeSchema.DeserializeMachineLearningInstanceTypeSchema(property0.Value, options));
                    }
                    instanceTypes = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningKubernetesProperties(relayConnectionString.Value, serviceBusConnectionString.Value, extensionPrincipalId.Value, extensionInstanceReleaseTrain.Value, vcName.Value, @namespace.Value, defaultInstanceType.Value, Optional.ToDictionary(instanceTypes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningKubernetesProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningKubernetesProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningKubernetesProperties IPersistableModel<MachineLearningKubernetesProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningKubernetesProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningKubernetesProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningKubernetesProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningKubernetesProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
