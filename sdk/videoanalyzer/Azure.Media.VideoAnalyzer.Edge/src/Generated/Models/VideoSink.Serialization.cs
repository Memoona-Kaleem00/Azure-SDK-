// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoSink : IUtf8JsonSerializable, IModelJsonSerializable<VideoSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VideoSink>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VideoSink>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoSink>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("videoName"u8);
            writer.WriteStringValue(VideoName);
            if (Optional.IsDefined(VideoCreationProperties))
            {
                writer.WritePropertyName("videoCreationProperties"u8);
                if (VideoCreationProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VideoCreationProperties>)VideoCreationProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VideoPublishingOptions))
            {
                writer.WritePropertyName("videoPublishingOptions"u8);
                if (VideoPublishingOptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VideoPublishingOptions>)VideoPublishingOptions).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("localMediaCachePath"u8);
            writer.WriteStringValue(LocalMediaCachePath);
            writer.WritePropertyName("localMediaCacheMaximumSizeMiB"u8);
            writer.WriteStringValue(LocalMediaCacheMaximumSizeMiB);
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NodeInput>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static VideoSink DeserializeVideoSink(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string videoName = default;
            Optional<VideoCreationProperties> videoCreationProperties = default;
            Optional<VideoPublishingOptions> videoPublishingOptions = default;
            string localMediaCachePath = default;
            string localMediaCacheMaximumSizeMiB = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("videoName"u8))
                {
                    videoName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("videoCreationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    videoCreationProperties = VideoCreationProperties.DeserializeVideoCreationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("videoPublishingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    videoPublishingOptions = VideoPublishingOptions.DeserializeVideoPublishingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("localMediaCachePath"u8))
                {
                    localMediaCachePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localMediaCacheMaximumSizeMiB"u8))
                {
                    localMediaCacheMaximumSizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VideoSink(type, name, inputs, videoName, videoCreationProperties.Value, videoPublishingOptions.Value, localMediaCachePath, localMediaCacheMaximumSizeMiB, rawData);
        }

        VideoSink IModelJsonSerializable<VideoSink>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoSink>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVideoSink(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VideoSink>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoSink>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VideoSink IModelSerializable<VideoSink>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoSink>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVideoSink(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VideoSink"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VideoSink"/> to convert. </param>
        public static implicit operator RequestContent(VideoSink model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VideoSink"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VideoSink(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVideoSink(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
