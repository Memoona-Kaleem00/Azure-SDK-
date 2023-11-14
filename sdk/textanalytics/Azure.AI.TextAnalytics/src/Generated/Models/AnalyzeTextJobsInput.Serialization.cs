// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextJobsInput : IUtf8JsonSerializable, IJsonModel<AnalyzeTextJobsInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextJobsInput>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AnalyzeTextJobsInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AnalyzeTextJobsInput>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AnalyzeTextJobsInput>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("analysisInput"u8);
            writer.WriteObjectValue(AnalysisInput);
            writer.WritePropertyName("tasks"u8);
            writer.WriteStartArray();
            foreach (var item in Tasks)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        AnalyzeTextJobsInput IJsonModel<AnalyzeTextJobsInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AnalyzeTextJobsInput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextJobsInput(document.RootElement, options);
        }

        internal static AnalyzeTextJobsInput DeserializeAnalyzeTextJobsInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            MultiLanguageAnalysisInput analysisInput = default;
            IList<AnalyzeTextLROTask> tasks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("analysisInput"u8))
                {
                    analysisInput = MultiLanguageAnalysisInput.DeserializeMultiLanguageAnalysisInput(property.Value);
                    continue;
                }
                if (property.NameEquals("tasks"u8))
                {
                    List<AnalyzeTextLROTask> array = new List<AnalyzeTextLROTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzeTextLROTask.DeserializeAnalyzeTextLROTask(item));
                    }
                    tasks = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalyzeTextJobsInput(displayName.Value, analysisInput, tasks, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeTextJobsInput>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AnalyzeTextJobsInput)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AnalyzeTextJobsInput IPersistableModel<AnalyzeTextJobsInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AnalyzeTextJobsInput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAnalyzeTextJobsInput(document.RootElement, options);
        }

        string IPersistableModel<AnalyzeTextJobsInput>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
