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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningScriptReference : IUtf8JsonSerializable, IJsonModel<MachineLearningScriptReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningScriptReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningScriptReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ScriptSource))
            {
                writer.WritePropertyName("scriptSource"u8);
                writer.WriteStringValue(ScriptSource);
            }
            if (Optional.IsDefined(ScriptData))
            {
                writer.WritePropertyName("scriptData"u8);
                writer.WriteStringValue(ScriptData);
            }
            if (Optional.IsDefined(ScriptArguments))
            {
                writer.WritePropertyName("scriptArguments"u8);
                writer.WriteStringValue(ScriptArguments);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout);
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

        MachineLearningScriptReference IJsonModel<MachineLearningScriptReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningScriptReference(document.RootElement, options);
        }

        internal static MachineLearningScriptReference DeserializeMachineLearningScriptReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scriptSource = default;
            string scriptData = default;
            string scriptArguments = default;
            string timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptSource"u8))
                {
                    scriptSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptData"u8))
                {
                    scriptData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptArguments"u8))
                {
                    scriptArguments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    timeout = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningScriptReference(scriptSource, scriptData, scriptArguments, timeout, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScriptSource), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scriptSource: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScriptSource))
                {
                    builder.Append("  scriptSource: ");
                    if (ScriptSource.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ScriptSource}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ScriptSource}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScriptData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scriptData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScriptData))
                {
                    builder.Append("  scriptData: ");
                    if (ScriptData.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ScriptData}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ScriptData}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScriptArguments), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scriptArguments: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScriptArguments))
                {
                    builder.Append("  scriptArguments: ");
                    if (ScriptArguments.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ScriptArguments}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ScriptArguments}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timeout))
                {
                    builder.Append("  timeout: ");
                    if (Timeout.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Timeout}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Timeout}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningScriptReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningScriptReference IPersistableModel<MachineLearningScriptReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningScriptReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningScriptReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
