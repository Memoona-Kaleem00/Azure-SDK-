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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class CodelessUiConnectorConfigPropertiesDataTypesItem : IUtf8JsonSerializable, IJsonModel<CodelessUiConnectorConfigPropertiesDataTypesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CodelessUiConnectorConfigPropertiesDataTypesItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CodelessUiConnectorConfigPropertiesDataTypesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodelessUiConnectorConfigPropertiesDataTypesItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(LastDataReceivedQuery))
            {
                writer.WritePropertyName("lastDataReceivedQuery"u8);
                writer.WriteStringValue(LastDataReceivedQuery);
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

        CodelessUiConnectorConfigPropertiesDataTypesItem IJsonModel<CodelessUiConnectorConfigPropertiesDataTypesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodelessUiConnectorConfigPropertiesDataTypesItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCodelessUiConnectorConfigPropertiesDataTypesItem(document.RootElement, options);
        }

        internal static CodelessUiConnectorConfigPropertiesDataTypesItem DeserializeCodelessUiConnectorConfigPropertiesDataTypesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string lastDataReceivedQuery = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastDataReceivedQuery"u8))
                {
                    lastDataReceivedQuery = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CodelessUiConnectorConfigPropertiesDataTypesItem(name, lastDataReceivedQuery, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastDataReceivedQuery), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastDataReceivedQuery: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastDataReceivedQuery))
                {
                    builder.Append("  lastDataReceivedQuery: ");
                    if (LastDataReceivedQuery.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastDataReceivedQuery}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastDataReceivedQuery}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CodelessUiConnectorConfigPropertiesDataTypesItem)} does not support writing '{options.Format}' format.");
            }
        }

        CodelessUiConnectorConfigPropertiesDataTypesItem IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCodelessUiConnectorConfigPropertiesDataTypesItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CodelessUiConnectorConfigPropertiesDataTypesItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CodelessUiConnectorConfigPropertiesDataTypesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
