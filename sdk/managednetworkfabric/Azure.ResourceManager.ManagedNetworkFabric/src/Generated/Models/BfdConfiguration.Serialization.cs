// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class BfdConfiguration : IUtf8JsonSerializable, IJsonModel<BfdConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BfdConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BfdConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BfdConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BfdConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AdministrativeState.HasValue)
            {
                writer.WritePropertyName("administrativeState"u8);
                writer.WriteStringValue(AdministrativeState.Value.ToString());
            }
            if (IntervalInMilliSeconds.HasValue)
            {
                writer.WritePropertyName("intervalInMilliSeconds"u8);
                writer.WriteNumberValue(IntervalInMilliSeconds.Value);
            }
            if (Multiplier.HasValue)
            {
                writer.WritePropertyName("multiplier"u8);
                writer.WriteNumberValue(Multiplier.Value);
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

        BfdConfiguration IJsonModel<BfdConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BfdConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BfdConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBfdConfiguration(document.RootElement, options);
        }

        internal static BfdConfiguration DeserializeBfdConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BfdAdministrativeState> administrativeState = default;
            Optional<int> intervalInMilliSeconds = default;
            Optional<int> multiplier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administrativeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administrativeState = new BfdAdministrativeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("intervalInMilliSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalInMilliSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiplier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiplier = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BfdConfiguration(Optional.ToNullable(administrativeState), Optional.ToNullable(intervalInMilliSeconds), Optional.ToNullable(multiplier), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BfdConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BfdConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BfdConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BfdConfiguration IPersistableModel<BfdConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BfdConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBfdConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BfdConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BfdConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
