// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownSsisObjectMetadata))]
    public partial class SsisObjectMetadata : IUtf8JsonSerializable, IJsonModel<SsisObjectMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisObjectMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SsisObjectMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisObjectMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(MetadataType.ToString());
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        SsisObjectMetadata IJsonModel<SsisObjectMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisObjectMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisObjectMetadata(document.RootElement, options);
        }

        internal static SsisObjectMetadata DeserializeSsisObjectMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Environment": return SsisEnvironment.DeserializeSsisEnvironment(element, options);
                    case "Folder": return SsisFolder.DeserializeSsisFolder(element, options);
                    case "Package": return SsisPackage.DeserializeSsisPackage(element, options);
                    case "Project": return SsisProject.DeserializeSsisProject(element, options);
                }
            }
            return UnknownSsisObjectMetadata.DeserializeUnknownSsisObjectMetadata(element, options);
        }

        BinaryData IPersistableModel<SsisObjectMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SsisObjectMetadata)} does not support '{options.Format}' format.");
            }
        }

        SsisObjectMetadata IPersistableModel<SsisObjectMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSsisObjectMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SsisObjectMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SsisObjectMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
