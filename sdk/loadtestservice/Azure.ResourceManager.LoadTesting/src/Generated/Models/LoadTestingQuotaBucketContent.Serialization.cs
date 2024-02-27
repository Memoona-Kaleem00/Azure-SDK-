// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingQuotaBucketContent : IUtf8JsonSerializable, IJsonModel<LoadTestingQuotaBucketContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadTestingQuotaBucketContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadTestingQuotaBucketContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingQuotaBucketContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestingQuotaBucketContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (CurrentUsage.HasValue)
            {
                writer.WritePropertyName("currentUsage"u8);
                writer.WriteNumberValue(CurrentUsage.Value);
            }
            if (CurrentQuota.HasValue)
            {
                writer.WritePropertyName("currentQuota"u8);
                writer.WriteNumberValue(CurrentQuota.Value);
            }
            if (NewQuota.HasValue)
            {
                writer.WritePropertyName("newQuota"u8);
                writer.WriteNumberValue(NewQuota.Value);
            }
            if (Dimensions != null)
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteObjectValue(Dimensions);
            }
            writer.WriteEndObject();
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

        LoadTestingQuotaBucketContent IJsonModel<LoadTestingQuotaBucketContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingQuotaBucketContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestingQuotaBucketContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestingQuotaBucketContent(document.RootElement, options);
        }

        internal static LoadTestingQuotaBucketContent DeserializeLoadTestingQuotaBucketContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> currentUsage = default;
            Optional<int> currentQuota = default;
            Optional<int> newQuota = default;
            Optional<LoadTestingQuotaBucketDimensions> dimensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("currentUsage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentUsage = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("newQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dimensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dimensions = LoadTestingQuotaBucketDimensions.DeserializeLoadTestingQuotaBucketDimensions(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadTestingQuotaBucketContent(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(currentUsage),
                Optional.ToNullable(currentQuota),
                Optional.ToNullable(newQuota),
                dimensions.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadTestingQuotaBucketContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingQuotaBucketContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadTestingQuotaBucketContent)} does not support '{options.Format}' format.");
            }
        }

        LoadTestingQuotaBucketContent IPersistableModel<LoadTestingQuotaBucketContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingQuotaBucketContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadTestingQuotaBucketContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadTestingQuotaBucketContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadTestingQuotaBucketContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
