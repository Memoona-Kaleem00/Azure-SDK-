// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SelfHelp;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpVideo : IUtf8JsonSerializable, IJsonModel<SelfHelpVideo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpVideo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpVideo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpVideo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpVideo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReplacementKey))
            {
                writer.WritePropertyName("replacementKey"u8);
                writer.WriteStringValue(ReplacementKey);
            }
            if (Optional.IsDefined(Src))
            {
                writer.WritePropertyName("src"u8);
                writer.WriteStringValue(Src);
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
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

        SelfHelpVideo IJsonModel<SelfHelpVideo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpVideo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpVideo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpVideo(document.RootElement, options);
        }

        internal static SelfHelpVideo DeserializeSelfHelpVideo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string replacementKey = default;
            string src = default;
            string title = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replacementKey"u8))
                {
                    replacementKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("src"u8))
                {
                    src = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpVideo(src, title, serializedAdditionalRawData, replacementKey);
        }

        BinaryData IPersistableModel<SelfHelpVideo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpVideo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpVideo)} does not support '{options.Format}' format.");
            }
        }

        SelfHelpVideo IPersistableModel<SelfHelpVideo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpVideo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHelpVideo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpVideo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpVideo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
