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
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommonEncryptionCenc>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommonEncryptionCenc>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EnabledProtocols != null)
            {
                writer.WritePropertyName("enabledProtocols"u8);
                writer.WriteObjectValue(EnabledProtocols);
            }
            if (!(ClearTracks is ChangeTrackingList<MediaTrackSelection> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("clearTracks"u8);
                writer.WriteStartArray();
                foreach (var item in ClearTracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ContentKeys != null)
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteObjectValue(ContentKeys);
            }
            if (Drm != null)
            {
                writer.WritePropertyName("drm"u8);
                writer.WriteObjectValue(Drm);
            }
            if (ClearKeyEncryptionConfiguration != null)
            {
                writer.WritePropertyName("clearKeyEncryptionConfiguration"u8);
                writer.WriteObjectValue(ClearKeyEncryptionConfiguration);
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

        CommonEncryptionCenc IJsonModel<CommonEncryptionCenc>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonEncryptionCenc(document.RootElement, options);
        }

        internal static CommonEncryptionCenc DeserializeCommonEncryptionCenc(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaEnabledProtocols> enabledProtocols = default;
            Optional<IList<MediaTrackSelection>> clearTracks = default;
            Optional<StreamingPolicyContentKeys> contentKeys = default;
            Optional<CencDrmConfiguration> drm = default;
            Optional<ClearKeyEncryptionConfiguration> clearKeyEncryptionConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommonEncryptionCenc(enabledProtocols.Value, Optional.ToList(clearTracks), contentKeys.Value, drm.Value, clearKeyEncryptionConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommonEncryptionCenc>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonEncryptionCenc>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support '{options.Format}' format.");
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
                    throw new FormatException($"The model {nameof(CommonEncryptionCenc)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommonEncryptionCenc>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
