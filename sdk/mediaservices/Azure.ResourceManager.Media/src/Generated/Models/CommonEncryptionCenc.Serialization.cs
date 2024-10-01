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
    public partial class CommonEncryptionCenc : IUtf8JsonSerializable, IJsonModel<CommonEncryptionCenc>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommonEncryptionCenc>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CommonEncryptionCenc>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EnabledProtocols))
            {
                writer.WritePropertyName("enabledProtocols"u8);
                writer.WriteObjectValue(EnabledProtocols, options);
            }
            if (Optional.IsCollectionDefined(ClearTracks))
            {
                writer.WritePropertyName("clearTracks"u8);
                writer.WriteStartArray();
                foreach (var item in ClearTracks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteObjectValue(ContentKeys, options);
            }
            if (Optional.IsDefined(Drm))
            {
                writer.WritePropertyName("drm"u8);
                writer.WriteObjectValue(Drm, options);
            }
            if (Optional.IsDefined(ClearKeyEncryptionConfiguration))
            {
                writer.WritePropertyName("clearKeyEncryptionConfiguration"u8);
                writer.WriteObjectValue(ClearKeyEncryptionConfiguration, options);
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
        }

        CommonEncryptionCenc IJsonModel<CommonEncryptionCenc>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonEncryptionCenc(document.RootElement, options);
        }

        internal static CommonEncryptionCenc DeserializeCommonEncryptionCenc(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MediaEnabledProtocols enabledProtocols = default;
            IList<MediaTrackSelection> clearTracks = default;
            StreamingPolicyContentKeys contentKeys = default;
            CencDrmConfiguration drm = default;
            ClearKeyEncryptionConfiguration clearKeyEncryptionConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledProtocols = MediaEnabledProtocols.DeserializeMediaEnabledProtocols(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clearTracks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaTrackSelection> array = new List<MediaTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTrackSelection.DeserializeMediaTrackSelection(item, options));
                    }
                    clearTracks = array;
                    continue;
                }
                if (property.NameEquals("contentKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentKeys = StreamingPolicyContentKeys.DeserializeStreamingPolicyContentKeys(property.Value, options);
                    continue;
                }
                if (property.NameEquals("drm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    drm = CencDrmConfiguration.DeserializeCencDrmConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clearKeyEncryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clearKeyEncryptionConfiguration = ClearKeyEncryptionConfiguration.DeserializeClearKeyEncryptionConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CommonEncryptionCenc(
                enabledProtocols,
                clearTracks ?? new ChangeTrackingList<MediaTrackSelection>(),
                contentKeys,
                drm,
                clearKeyEncryptionConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommonEncryptionCenc>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support writing '{options.Format}' format.");
            }
        }

        CommonEncryptionCenc IPersistableModel<CommonEncryptionCenc>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommonEncryptionCenc(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommonEncryptionCenc>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
