// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterControlPlaneProfile : IUtf8JsonSerializable, IJsonModel<ProvisionedClusterControlPlaneProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClusterControlPlaneProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProvisionedClusterControlPlaneProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterControlPlaneProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterControlPlaneProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (VmSize != null)
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (ControlPlaneEndpoint != null)
            {
                writer.WritePropertyName("controlPlaneEndpoint"u8);
                writer.WriteObjectValue(ControlPlaneEndpoint);
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

        ProvisionedClusterControlPlaneProfile IJsonModel<ProvisionedClusterControlPlaneProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterControlPlaneProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterControlPlaneProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClusterControlPlaneProfile(document.RootElement, options);
        }

        internal static ProvisionedClusterControlPlaneProfile DeserializeProvisionedClusterControlPlaneProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> count = default;
            Optional<string> vmSize = default;
            Optional<ControlPlaneProfileControlPlaneEndpoint> controlPlaneEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlPlaneEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlPlaneEndpoint = ControlPlaneProfileControlPlaneEndpoint.DeserializeControlPlaneProfileControlPlaneEndpoint(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClusterControlPlaneProfile(Optional.ToNullable(count), vmSize.Value, controlPlaneEndpoint.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClusterControlPlaneProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterControlPlaneProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterControlPlaneProfile)} does not support '{options.Format}' format.");
            }
        }

        ProvisionedClusterControlPlaneProfile IPersistableModel<ProvisionedClusterControlPlaneProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterControlPlaneProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProvisionedClusterControlPlaneProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterControlPlaneProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProvisionedClusterControlPlaneProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
