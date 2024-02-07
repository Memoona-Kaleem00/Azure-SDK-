// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceOperationSteps : IUtf8JsonSerializable, IJsonModel<ManagedInstanceOperationSteps>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceOperationSteps>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceOperationSteps>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TotalSteps))
            {
                writer.WritePropertyName("totalSteps"u8);
                writer.WriteStringValue(TotalSteps);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentStep))
            {
                writer.WritePropertyName("currentStep"u8);
                writer.WriteNumberValue(CurrentStep.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StepsList))
            {
                writer.WritePropertyName("stepsList"u8);
                writer.WriteStartArray();
                foreach (var item in StepsList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ManagedInstanceOperationSteps IJsonModel<ManagedInstanceOperationSteps>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceOperationSteps(document.RootElement, options);
        }

        internal static ManagedInstanceOperationSteps DeserializeManagedInstanceOperationSteps(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> totalSteps = default;
            Optional<int> currentStep = default;
            Optional<IReadOnlyList<UpsertManagedServerOperationStep>> stepsList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalSteps"u8))
                {
                    totalSteps = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentStep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepsList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UpsertManagedServerOperationStep> array = new List<UpsertManagedServerOperationStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UpsertManagedServerOperationStep.DeserializeUpsertManagedServerOperationStep(item));
                    }
                    stepsList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceOperationSteps(totalSteps.Value, Optional.ToNullable(currentStep), Optional.ToList(stepsList), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TotalSteps))
            {
                builder.Append("  totalSteps:");
                if (TotalSteps.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{TotalSteps}'''");
                }
                else
                {
                    builder.AppendLine($" '{TotalSteps}'");
                }
            }

            if (Optional.IsDefined(CurrentStep))
            {
                builder.Append("  currentStep:");
                builder.AppendLine($" {CurrentStep.Value}");
            }

            if (Optional.IsCollectionDefined(StepsList))
            {
                if (StepsList.Any())
                {
                    builder.Append("  stepsList:");
                    builder.AppendLine(" [");
                    foreach (var item in StepsList)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ManagedInstanceOperationSteps>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support '{options.Format}' format.");
            }
        }

        ManagedInstanceOperationSteps IPersistableModel<ManagedInstanceOperationSteps>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceOperationSteps(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceOperationSteps>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
