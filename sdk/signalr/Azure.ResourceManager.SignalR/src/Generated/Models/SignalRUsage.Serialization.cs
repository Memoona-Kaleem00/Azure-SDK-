// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRUsage : IUtf8JsonSerializable, IJsonModel<SignalRUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SignalRUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRUsage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (CurrentValue.HasValue)
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteNumberValue(CurrentValue.Value);
            }
            if (Limit.HasValue)
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
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

        SignalRUsage IJsonModel<SignalRUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRUsage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRUsage(document.RootElement, options);
        }

        internal static SignalRUsage DeserializeSignalRUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<long> currentValue = default;
            Optional<long> limit = default;
            Optional<SignalRUsageName> name = default;
            Optional<string> unit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = SignalRUsageName.DeserializeSignalRUsageName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SignalRUsage(
                id.Value,
                Optional.ToNullable(currentValue),
                Optional.ToNullable(limit),
                name.Value,
                unit.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignalRUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SignalRUsage)} does not support '{options.Format}' format.");
            }
        }

        SignalRUsage IPersistableModel<SignalRUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignalRUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignalRUsage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignalRUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
