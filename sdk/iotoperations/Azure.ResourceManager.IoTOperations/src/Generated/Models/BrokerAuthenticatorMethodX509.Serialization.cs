// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations.Models
{
    public partial class BrokerAuthenticatorMethodX509 : IUtf8JsonSerializable, IJsonModel<BrokerAuthenticatorMethodX509>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BrokerAuthenticatorMethodX509>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BrokerAuthenticatorMethodX509>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodX509>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodX509)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AuthorizationAttributes))
            {
                writer.WritePropertyName("authorizationAttributes"u8);
                writer.WriteStartObject();
                foreach (var item in AuthorizationAttributes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TrustedClientCaCert))
            {
                writer.WritePropertyName("trustedClientCaCert"u8);
                writer.WriteStringValue(TrustedClientCaCert);
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

        BrokerAuthenticatorMethodX509 IJsonModel<BrokerAuthenticatorMethodX509>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodX509>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodX509)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBrokerAuthenticatorMethodX509(document.RootElement, options);
        }

        internal static BrokerAuthenticatorMethodX509 DeserializeBrokerAuthenticatorMethodX509(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, BrokerAuthenticatorMethodX509Attributes> authorizationAttributes = default;
            string trustedClientCaCert = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationAttributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BrokerAuthenticatorMethodX509Attributes> dictionary = new Dictionary<string, BrokerAuthenticatorMethodX509Attributes>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BrokerAuthenticatorMethodX509Attributes.DeserializeBrokerAuthenticatorMethodX509Attributes(property0.Value, options));
                    }
                    authorizationAttributes = dictionary;
                    continue;
                }
                if (property.NameEquals("trustedClientCaCert"u8))
                {
                    trustedClientCaCert = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BrokerAuthenticatorMethodX509(authorizationAttributes ?? new ChangeTrackingDictionary<string, BrokerAuthenticatorMethodX509Attributes>(), trustedClientCaCert, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BrokerAuthenticatorMethodX509>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodX509>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodX509)} does not support writing '{options.Format}' format.");
            }
        }

        BrokerAuthenticatorMethodX509 IPersistableModel<BrokerAuthenticatorMethodX509>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodX509>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBrokerAuthenticatorMethodX509(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodX509)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BrokerAuthenticatorMethodX509>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
