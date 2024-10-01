// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryOSDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryOSDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryOSDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryOSDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryOSDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryOSDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType);
            }
            if (Optional.IsDefined(OSEdition))
            {
                writer.WritePropertyName("osEdition"u8);
                writer.WriteStringValue(OSEdition);
            }
            if (Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("oSVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (Optional.IsDefined(OSMajorVersion))
            {
                writer.WritePropertyName("oSMajorVersion"u8);
                writer.WriteStringValue(OSMajorVersion);
            }
            if (Optional.IsDefined(OSMinorVersion))
            {
                writer.WritePropertyName("oSMinorVersion"u8);
                writer.WriteStringValue(OSMinorVersion);
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

        SiteRecoveryOSDetails IJsonModel<SiteRecoveryOSDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryOSDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryOSDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryOSDetails(document.RootElement, options);
        }

        internal static SiteRecoveryOSDetails DeserializeSiteRecoveryOSDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string osType = default;
            string productType = default;
            string osEdition = default;
            string osVersion = default;
            string osMajorVersion = default;
            string osMinorVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productType"u8))
                {
                    productType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osEdition"u8))
                {
                    osEdition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oSVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oSMajorVersion"u8))
                {
                    osMajorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oSMinorVersion"u8))
                {
                    osMinorVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryOSDetails(
                osType,
                productType,
                osEdition,
                osVersion,
                osMajorVersion,
                osMinorVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryOSDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryOSDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryOSDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryOSDetails IPersistableModel<SiteRecoveryOSDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryOSDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryOSDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryOSDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryOSDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
