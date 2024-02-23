// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabUserInviteRequestContent : IUtf8JsonSerializable, IJsonModel<LabUserInviteRequestContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabUserInviteRequestContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabUserInviteRequestContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserInviteRequestContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabUserInviteRequestContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Text != null)
            {
                writer.WritePropertyName("text"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Text);
#else
                using (JsonDocument document = JsonDocument.Parse(Text))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        LabUserInviteRequestContent IJsonModel<LabUserInviteRequestContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserInviteRequestContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabUserInviteRequestContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabUserInviteRequestContent(document.RootElement, options);
        }

        internal static LabUserInviteRequestContent DeserializeLabUserInviteRequestContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> text = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LabUserInviteRequestContent(text.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LabUserInviteRequestContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserInviteRequestContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabUserInviteRequestContent)} does not support '{options.Format}' format.");
            }
        }

        LabUserInviteRequestContent IPersistableModel<LabUserInviteRequestContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserInviteRequestContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabUserInviteRequestContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabUserInviteRequestContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabUserInviteRequestContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
