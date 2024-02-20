// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownReplicationProviderSpecificContainerMappingContent))]
    public partial class ReplicationProviderSpecificContainerMappingContent : IUtf8JsonSerializable, IJsonModel<ReplicationProviderSpecificContainerMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProviderSpecificContainerMappingContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProviderSpecificContainerMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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

        ReplicationProviderSpecificContainerMappingContent IJsonModel<ReplicationProviderSpecificContainerMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProviderSpecificContainerMappingContent(document.RootElement, options);
        }

        internal static ReplicationProviderSpecificContainerMappingContent DeserializeReplicationProviderSpecificContainerMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AContainerMappingContent.DeserializeA2AContainerMappingContent(element, options);
                    case "VMwareCbt": return VMwareCbtContainerMappingContent.DeserializeVMwareCbtContainerMappingContent(element, options);
                }
            }
            return UnknownReplicationProviderSpecificContainerMappingContent.DeserializeUnknownReplicationProviderSpecificContainerMappingContent(element, options);
        }

        BinaryData IPersistableModel<ReplicationProviderSpecificContainerMappingContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{options.Format}' format.");
            }
        }

        ReplicationProviderSpecificContainerMappingContent IPersistableModel<ReplicationProviderSpecificContainerMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProviderSpecificContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationProviderSpecificContainerMappingContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationProviderSpecificContainerMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
