// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class VideoLayer : IUtf8JsonSerializable, IJsonModel<VideoLayer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VideoLayer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VideoLayer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VideoLayer)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("bitrate"u8);
            writer.WriteNumberValue(Bitrate);
            if (Optional.IsDefined(MaxBitrate))
            {
                writer.WritePropertyName("maxBitrate"u8);
                writer.WriteNumberValue(MaxBitrate.Value);
            }
            if (Optional.IsDefined(BFrames))
            {
                writer.WritePropertyName("bFrames"u8);
                writer.WriteNumberValue(BFrames.Value);
            }
            if (Optional.IsDefined(FrameRate))
            {
                writer.WritePropertyName("frameRate"u8);
                writer.WriteStringValue(FrameRate);
            }
            if (Optional.IsDefined(Slices))
            {
                writer.WritePropertyName("slices"u8);
                writer.WriteNumberValue(Slices.Value);
            }
            if (Optional.IsDefined(UseAdaptiveBFrame))
            {
                writer.WritePropertyName("adaptiveBFrame"u8);
                writer.WriteBooleanValue(UseAdaptiveBFrame.Value);
            }
        }

        VideoLayer IJsonModel<VideoLayer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VideoLayer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVideoLayer(document.RootElement, options);
        }

        internal static VideoLayer DeserializeVideoLayer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int bitrate = default;
            int? maxBitrate = default;
            int? bFrames = default;
            string frameRate = default;
            int? slices = default;
            bool? adaptiveBFrame = default;
            string width = default;
            string height = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bitrate"u8))
                {
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxBitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frameRate"u8))
                {
                    frameRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adaptiveBFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adaptiveBFrame = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VideoLayer(
                width,
                height,
                label,
                serializedAdditionalRawData,
                bitrate,
                maxBitrate,
                bFrames,
                frameRate,
                slices,
                adaptiveBFrame);
        }

        BinaryData IPersistableModel<VideoLayer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VideoLayer)} does not support writing '{options.Format}' format.");
            }
        }

        VideoLayer IPersistableModel<VideoLayer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVideoLayer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VideoLayer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VideoLayer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
