// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.Signing
{
    internal partial class SigningPayloadOptions : IUtf8JsonSerializable, IJsonModel<SigningPayloadOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SigningPayloadOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SigningPayloadOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SigningPayloadOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SigningPayloadOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("signatureAlgorithm"u8);
            writer.WriteStringValue(SignatureAlgorithm.ToSerialString());
            writer.WritePropertyName("digest"u8);
            writer.WriteBase64StringValue(Digest.ToArray(), "D");
            if (Optional.IsCollectionDefined(FileHashList))
            {
                writer.WritePropertyName("fileHashList"u8);
                writer.WriteStartArray();
                foreach (var item in FileHashList)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteBase64StringValue(item.ToArray(), "D");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AuthenticodeHashList))
            {
                writer.WritePropertyName("authenticodeHashList"u8);
                writer.WriteStartArray();
                foreach (var item in AuthenticodeHashList)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteBase64StringValue(item.ToArray(), "D");
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

        SigningPayloadOptions IJsonModel<SigningPayloadOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SigningPayloadOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SigningPayloadOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSigningPayloadOptions(document.RootElement, options);
        }

        internal static SigningPayloadOptions DeserializeSigningPayloadOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SignatureAlgorithm signatureAlgorithm = default;
            BinaryData digest = default;
            IList<BinaryData> fileHashList = default;
            IList<BinaryData> authenticodeHashList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureAlgorithm"u8))
                {
                    signatureAlgorithm = property.Value.GetString().ToSignatureAlgorithm();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = BinaryData.FromBytes(property.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (property.NameEquals("fileHashList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromBytes(item.GetBytesFromBase64("D")));
                        }
                    }
                    fileHashList = array;
                    continue;
                }
                if (property.NameEquals("authenticodeHashList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromBytes(item.GetBytesFromBase64("D")));
                        }
                    }
                    authenticodeHashList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SigningPayloadOptions(signatureAlgorithm, digest, fileHashList ?? new ChangeTrackingList<BinaryData>(), authenticodeHashList ?? new ChangeTrackingList<BinaryData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SigningPayloadOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SigningPayloadOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SigningPayloadOptions)} does not support writing '{options.Format}' format.");
            }
        }

        SigningPayloadOptions IPersistableModel<SigningPayloadOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SigningPayloadOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSigningPayloadOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SigningPayloadOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SigningPayloadOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SigningPayloadOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSigningPayloadOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
