// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseLinkedIntegrationRuntimeKeyAuthorization : IUtf8JsonSerializable, IJsonModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntimeKeyAuthorization)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteObjectValue<SynapseSecureString>(Key, options);
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
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

        SynapseLinkedIntegrationRuntimeKeyAuthorization IJsonModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntimeKeyAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseLinkedIntegrationRuntimeKeyAuthorization(document.RootElement, options);
        }

        internal static SynapseLinkedIntegrationRuntimeKeyAuthorization DeserializeSynapseLinkedIntegrationRuntimeKeyAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseSecureString key = default;
            string authorizationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = SynapseSecureString.DeserializeSynapseSecureString(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseLinkedIntegrationRuntimeKeyAuthorization(authorizationType, serializedAdditionalRawData, key);
        }

        BinaryData IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntimeKeyAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseLinkedIntegrationRuntimeKeyAuthorization IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseLinkedIntegrationRuntimeKeyAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntimeKeyAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseLinkedIntegrationRuntimeKeyAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
