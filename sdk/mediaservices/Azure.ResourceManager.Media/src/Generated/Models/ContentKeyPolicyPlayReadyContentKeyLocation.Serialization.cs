// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownContentKeyPolicyPlayReadyContentKeyLocation))]
    public partial class ContentKeyPolicyPlayReadyContentKeyLocation : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyPlayReadyContentKeyLocation IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyContentKeyLocation(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyContentKeyLocation DeserializeContentKeyPolicyPlayReadyContentKeyLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader": return ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader.DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(element, options);
                    case "#Microsoft.Media.ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier": return ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier.DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(element, options);
                }
            }
            return UnknownContentKeyPolicyPlayReadyContentKeyLocation.DeserializeUnknownContentKeyPolicyPlayReadyContentKeyLocation(element, options);
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyPlayReadyContentKeyLocation IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyPlayReadyContentKeyLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
