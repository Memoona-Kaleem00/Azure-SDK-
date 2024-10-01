// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class VhdImageMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<VhdImageMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VhdImageMappingRuleProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VhdImageMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UserConfiguration))
            {
                writer.WritePropertyName("userConfiguration"u8);
                writer.WriteStringValue(UserConfiguration);
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

        VhdImageMappingRuleProfile IJsonModel<VhdImageMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVhdImageMappingRuleProfile(document.RootElement, options);
        }

        internal static VhdImageMappingRuleProfile DeserializeVhdImageMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userConfiguration"u8))
                {
                    userConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VhdImageMappingRuleProfile(userConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VhdImageMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support writing '{options.Format}' format.");
            }
        }

        VhdImageMappingRuleProfile IPersistableModel<VhdImageMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVhdImageMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VhdImageMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
