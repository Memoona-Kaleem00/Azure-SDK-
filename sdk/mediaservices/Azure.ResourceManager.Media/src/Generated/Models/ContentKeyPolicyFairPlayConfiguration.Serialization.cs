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
    public partial class ContentKeyPolicyFairPlayConfiguration : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyFairPlayConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyFairPlayConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyFairPlayConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ApplicationSecretKey != null)
            {
                writer.WritePropertyName("ask"u8);
                writer.WriteBase64StringValue(ApplicationSecretKey, "D");
            }
            else
            {
                writer.WriteNull("ask");
            }
            if (FairPlayPfxPassword != null)
            {
                writer.WritePropertyName("fairPlayPfxPassword"u8);
                writer.WriteStringValue(FairPlayPfxPassword);
            }
            else
            {
                writer.WriteNull("fairPlayPfxPassword");
            }
            if (FairPlayPfx != null)
            {
                writer.WritePropertyName("fairPlayPfx"u8);
                writer.WriteStringValue(FairPlayPfx);
            }
            else
            {
                writer.WriteNull("fairPlayPfx");
            }
            writer.WritePropertyName("rentalAndLeaseKeyType"u8);
            writer.WriteStringValue(RentalAndLeaseKeyType.ToString());
            writer.WritePropertyName("rentalDuration"u8);
            writer.WriteNumberValue(RentalDuration);
            if (OfflineRentalConfiguration != null)
            {
                writer.WritePropertyName("offlineRentalConfiguration"u8);
                writer.WriteObjectValue(OfflineRentalConfiguration);
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
            writer.WriteEndObject();
        }

        ContentKeyPolicyFairPlayConfiguration IJsonModel<ContentKeyPolicyFairPlayConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyFairPlayConfiguration(document.RootElement, options);
        }

        internal static ContentKeyPolicyFairPlayConfiguration DeserializeContentKeyPolicyFairPlayConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            byte[] ask = default;
            string fairPlayPfxPassword = default;
            string fairPlayPfx = default;
            ContentKeyPolicyFairPlayRentalAndLeaseKeyType rentalAndLeaseKeyType = default;
            long rentalDuration = default;
            Optional<ContentKeyPolicyFairPlayOfflineRentalConfiguration> offlineRentalConfiguration = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ask = null;
                        continue;
                    }
                    ask = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("fairPlayPfxPassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fairPlayPfxPassword = null;
                        continue;
                    }
                    fairPlayPfxPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fairPlayPfx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fairPlayPfx = null;
                        continue;
                    }
                    fairPlayPfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rentalAndLeaseKeyType"u8))
                {
                    rentalAndLeaseKeyType = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rentalDuration"u8))
                {
                    rentalDuration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("offlineRentalConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offlineRentalConfiguration = ContentKeyPolicyFairPlayOfflineRentalConfiguration.DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyFairPlayConfiguration(odataType, serializedAdditionalRawData, ask, fairPlayPfxPassword, fairPlayPfx, rentalAndLeaseKeyType, rentalDuration, offlineRentalConfiguration.Value);
        }

        BinaryData IPersistableModel<ContentKeyPolicyFairPlayConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContentKeyPolicyFairPlayConfiguration IPersistableModel<ContentKeyPolicyFairPlayConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyFairPlayConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyFairPlayConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
