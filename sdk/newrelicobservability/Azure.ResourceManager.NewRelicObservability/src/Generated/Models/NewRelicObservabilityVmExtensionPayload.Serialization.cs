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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityVmExtensionPayload : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityVmExtensionPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityVmExtensionPayload>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicObservabilityVmExtensionPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityVmExtensionPayload)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IngestionKey))
            {
                writer.WritePropertyName("ingestionKey"u8);
                writer.WriteStringValue(IngestionKey);
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

        NewRelicObservabilityVmExtensionPayload IJsonModel<NewRelicObservabilityVmExtensionPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityVmExtensionPayload)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityVmExtensionPayload(document.RootElement, options);
        }

        internal static NewRelicObservabilityVmExtensionPayload DeserializeNewRelicObservabilityVmExtensionPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ingestionKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestionKey"u8))
                {
                    ingestionKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicObservabilityVmExtensionPayload(ingestionKey, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IngestionKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ingestionKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IngestionKey))
                {
                    builder.Append("  ingestionKey: ");
                    if (IngestionKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{IngestionKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{IngestionKey}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NewRelicObservabilityVmExtensionPayload>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityVmExtensionPayload)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicObservabilityVmExtensionPayload IPersistableModel<NewRelicObservabilityVmExtensionPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicObservabilityVmExtensionPayload(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityVmExtensionPayload)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicObservabilityVmExtensionPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
