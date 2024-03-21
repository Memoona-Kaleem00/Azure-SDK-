// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentMetadataPartner : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentMetadataPartner>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentMetadataPartner>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityAssessmentMetadataPartner>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataPartner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataPartner)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("partnerName"u8);
            writer.WriteStringValue(PartnerName);
            if (Optional.IsDefined(ProductName))
            {
                writer.WritePropertyName("productName"u8);
                writer.WriteStringValue(ProductName);
            }
            writer.WritePropertyName("secret"u8);
            writer.WriteStringValue(Secret);
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

        SecurityAssessmentMetadataPartner IJsonModel<SecurityAssessmentMetadataPartner>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataPartner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataPartner)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentMetadataPartner(document.RootElement, options);
        }

        internal static SecurityAssessmentMetadataPartner DeserializeSecurityAssessmentMetadataPartner(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partnerName = default;
            string productName = default;
            string secret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partnerName"u8))
                {
                    partnerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productName"u8))
                {
                    productName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secret"u8))
                {
                    secret = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityAssessmentMetadataPartner(partnerName, productName, secret, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAssessmentMetadataPartner>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataPartner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataPartner)} does not support '{options.Format}' format.");
            }
        }

        SecurityAssessmentMetadataPartner IPersistableModel<SecurityAssessmentMetadataPartner>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataPartner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAssessmentMetadataPartner(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataPartner)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentMetadataPartner>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
