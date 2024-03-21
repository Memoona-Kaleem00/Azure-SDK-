// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownJobInput))]
    public partial class MachineLearningJobInput : IUtf8JsonSerializable, IJsonModel<MachineLearningJobInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningJobInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            writer.WritePropertyName("jobInputType"u8);
            writer.WriteStringValue(JobInputType.ToString());
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

        MachineLearningJobInput IJsonModel<MachineLearningJobInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobInput(document.RootElement, options);
        }

        internal static MachineLearningJobInput DeserializeMachineLearningJobInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobInputType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "custom_model": return MachineLearningCustomModelJobInput.DeserializeMachineLearningCustomModelJobInput(element, options);
                    case "literal": return MachineLearningLiteralJobInput.DeserializeMachineLearningLiteralJobInput(element, options);
                    case "mlflow_model": return MachineLearningFlowModelJobInput.DeserializeMachineLearningFlowModelJobInput(element, options);
                    case "mltable": return MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(element, options);
                    case "triton_model": return MachineLearningTritonModelJobInput.DeserializeMachineLearningTritonModelJobInput(element, options);
                    case "uri_file": return MachineLearningUriFileJobInput.DeserializeMachineLearningUriFileJobInput(element, options);
                    case "uri_folder": return MachineLearningUriFolderJobInput.DeserializeMachineLearningUriFolderJobInput(element, options);
                }
            }
            return UnknownJobInput.DeserializeUnknownJobInput(element, options);
        }

        BinaryData IPersistableModel<MachineLearningJobInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobInput)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningJobInput IPersistableModel<MachineLearningJobInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningJobInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
