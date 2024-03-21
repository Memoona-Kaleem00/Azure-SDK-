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
    public partial class MachineLearningStackEnsembleSettings : IUtf8JsonSerializable, IJsonModel<MachineLearningStackEnsembleSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningStackEnsembleSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningStackEnsembleSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStackEnsembleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningStackEnsembleSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StackMetaLearnerKWargs))
            {
                if (StackMetaLearnerKWargs != null)
                {
                    writer.WritePropertyName("stackMetaLearnerKWargs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StackMetaLearnerKWargs);
#else
                    using (JsonDocument document = JsonDocument.Parse(StackMetaLearnerKWargs))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                else
                {
                    writer.WriteNull("stackMetaLearnerKWargs");
                }
            }
            if (Optional.IsDefined(StackMetaLearnerTrainPercentage))
            {
                writer.WritePropertyName("stackMetaLearnerTrainPercentage"u8);
                writer.WriteNumberValue(StackMetaLearnerTrainPercentage.Value);
            }
            if (Optional.IsDefined(StackMetaLearnerType))
            {
                writer.WritePropertyName("stackMetaLearnerType"u8);
                writer.WriteStringValue(StackMetaLearnerType.Value.ToString());
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

        MachineLearningStackEnsembleSettings IJsonModel<MachineLearningStackEnsembleSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStackEnsembleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningStackEnsembleSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningStackEnsembleSettings(document.RootElement, options);
        }

        internal static MachineLearningStackEnsembleSettings DeserializeMachineLearningStackEnsembleSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData stackMetaLearnerKWargs = default;
            double? stackMetaLearnerTrainPercentage = default;
            MachineLearningStackMetaLearnerType? stackMetaLearnerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stackMetaLearnerKWargs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackMetaLearnerKWargs = null;
                        continue;
                    }
                    stackMetaLearnerKWargs = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("stackMetaLearnerTrainPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stackMetaLearnerTrainPercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("stackMetaLearnerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stackMetaLearnerType = new MachineLearningStackMetaLearnerType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningStackEnsembleSettings(stackMetaLearnerKWargs, stackMetaLearnerTrainPercentage, stackMetaLearnerType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningStackEnsembleSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStackEnsembleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningStackEnsembleSettings)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningStackEnsembleSettings IPersistableModel<MachineLearningStackEnsembleSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStackEnsembleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningStackEnsembleSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningStackEnsembleSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningStackEnsembleSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
