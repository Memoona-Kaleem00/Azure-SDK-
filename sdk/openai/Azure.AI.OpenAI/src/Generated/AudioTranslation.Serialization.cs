// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AudioTranslation : IUtf8JsonSerializable, IJsonModel<AudioTranslation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AudioTranslation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AudioTranslation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (InternalAudioTaskLabel.HasValue)
            {
                writer.WritePropertyName("task"u8);
                writer.WriteStringValue(InternalAudioTaskLabel.Value.ToString());
            }
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Duration.HasValue)
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(Convert.ToDouble(Duration.Value.ToString("s\\.fff")));
            }
            if (!(Segments is ChangeTrackingList<AudioTranslationSegment> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteStartArray();
                foreach (var item in Segments)
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

        AudioTranslation IJsonModel<AudioTranslation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranslation(document.RootElement, options);
        }

        internal static AudioTranslation DeserializeAudioTranslation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            Optional<AudioTaskLabel> task = default;
            Optional<string> language = default;
            Optional<TimeSpan> duration = default;
            IReadOnlyList<AudioTranslationSegment> segments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("task"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    task = new AudioTaskLabel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("segments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AudioTranslationSegment> array = new List<AudioTranslationSegment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AudioTranslationSegment.DeserializeAudioTranslationSegment(item, options));
                    }
                    segments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AudioTranslation(
                text,
                Optional.ToNullable(task),
                language.Value,
                Optional.ToNullable(duration),
                segments ?? new ChangeTrackingList<AudioTranslationSegment>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AudioTranslation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AudioTranslation)} does not support '{options.Format}' format.");
            }
        }

        AudioTranslation IPersistableModel<AudioTranslation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAudioTranslation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranslation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranslation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
