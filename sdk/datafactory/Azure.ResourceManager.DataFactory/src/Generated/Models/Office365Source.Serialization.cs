// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class Office365Source : IUtf8JsonSerializable, IJsonModel<Office365Source>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Office365Source>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Office365Source>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365Source>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Office365Source)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AllowedGroups != null)
            {
                writer.WritePropertyName("allowedGroups"u8);
                JsonSerializer.Serialize(writer, AllowedGroups);
            }
            if (UserScopeFilterUri != null)
            {
                writer.WritePropertyName("userScopeFilterUri"u8);
                JsonSerializer.Serialize(writer, UserScopeFilterUri);
            }
            if (DateFilterColumn != null)
            {
                writer.WritePropertyName("dateFilterColumn"u8);
                JsonSerializer.Serialize(writer, DateFilterColumn);
            }
            if (StartOn != null)
            {
                writer.WritePropertyName("startTime"u8);
                JsonSerializer.Serialize(writer, StartOn);
            }
            if (EndOn != null)
            {
                writer.WritePropertyName("endTime"u8);
                JsonSerializer.Serialize(writer, EndOn);
            }
            if (OutputColumns != null)
            {
                writer.WritePropertyName("outputColumns"u8);
                JsonSerializer.Serialize(writer, OutputColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (SourceRetryCount != null)
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (SourceRetryWait != null)
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        Office365Source IJsonModel<Office365Source>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365Source>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Office365Source)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOffice365Source(document.RootElement, options);
        }

        internal static Office365Source DeserializeOffice365Source(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<IList<string>>> allowedGroups = default;
            Optional<DataFactoryElement<string>> userScopeFilterUri = default;
            Optional<DataFactoryElement<string>> dateFilterColumn = default;
            Optional<DataFactoryElement<string>> startTime = default;
            Optional<DataFactoryElement<string>> endTime = default;
            Optional<DataFactoryElement<IList<Office365TableOutputColumn>>> outputColumns = default;
            string type = default;
            Optional<DataFactoryElement<int>> sourceRetryCount = default;
            Optional<DataFactoryElement<string>> sourceRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedGroups = JsonSerializer.Deserialize<DataFactoryElement<IList<string>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("userScopeFilterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userScopeFilterUri = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("dateFilterColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFilterColumn = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("outputColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputColumns = JsonSerializer.Deserialize<DataFactoryElement<IList<Office365TableOutputColumn>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Office365Source(
                type,
                sourceRetryCount.Value,
                sourceRetryWait.Value,
                maxConcurrentConnections.Value,
                disableMetricsCollection.Value,
                additionalProperties,
                allowedGroups.Value,
                userScopeFilterUri.Value,
                dateFilterColumn.Value,
                startTime.Value,
                endTime.Value,
                outputColumns.Value);
        }

        BinaryData IPersistableModel<Office365Source>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365Source>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Office365Source)} does not support '{options.Format}' format.");
            }
        }

        Office365Source IPersistableModel<Office365Source>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365Source>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOffice365Source(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Office365Source)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Office365Source>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
