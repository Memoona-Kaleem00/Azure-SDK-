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
    public partial class MachineLearningTritonModelJobOutput : IUtf8JsonSerializable, IJsonModel<MachineLearningTritonModelJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningTritonModelJobOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningTritonModelJobOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTritonModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("uri"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("uri");
                }
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
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

        MachineLearningTritonModelJobOutput IJsonModel<MachineLearningTritonModelJobOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTritonModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningTritonModelJobOutput(document.RootElement, options);
        }

        internal static MachineLearningTritonModelJobOutput DeserializeMachineLearningTritonModelJobOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri uri = default;
            MachineLearningOutputDeliveryMode? mode = default;
            JobOutputType jobOutputType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MachineLearningOutputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobOutputType"u8))
                {
                    jobOutputType = new JobOutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningTritonModelJobOutput(jobOutputType, description, serializedAdditionalRawData, uri, mode);
        }

        BinaryData IPersistableModel<MachineLearningTritonModelJobOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTritonModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningTritonModelJobOutput IPersistableModel<MachineLearningTritonModelJobOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTritonModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningTritonModelJobOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningTritonModelJobOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
