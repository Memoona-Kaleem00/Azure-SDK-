// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SharingProfile : IUtf8JsonSerializable, IJsonModel<SharingProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharingProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharingProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharingProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Permission))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permission.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CommunityGalleryInfo))
            {
                writer.WritePropertyName("communityGalleryInfo"u8);
                writer.WriteObjectValue(CommunityGalleryInfo);
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

        SharingProfile IJsonModel<SharingProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharingProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharingProfile(document.RootElement, options);
        }

        internal static SharingProfile DeserializeSharingProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GallerySharingPermissionType? permissions = default;
            IReadOnlyList<SharingProfileGroup> groups = default;
            CommunityGalleryInfo communityGalleryInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    permissions = new GallerySharingPermissionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SharingProfileGroup> array = new List<SharingProfileGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharingProfileGroup.DeserializeSharingProfileGroup(item, options));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("communityGalleryInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communityGalleryInfo = CommunityGalleryInfo.DeserializeCommunityGalleryInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharingProfile(permissions, groups ?? new ChangeTrackingList<SharingProfileGroup>(), communityGalleryInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SharingProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SharingProfile)} does not support '{options.Format}' format.");
            }
        }

        SharingProfile IPersistableModel<SharingProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharingProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SharingProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharingProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
