// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningEndpointAuthToken : IUtf8JsonSerializable, IJsonModel<MachineLearningEndpointAuthToken>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEndpointAuthToken>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningEndpointAuthToken>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointAuthToken>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointAuthToken)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AccessToken))
            {
                if (AccessToken != null)
                {
                    writer.WritePropertyName("accessToken"u8);
                    writer.WriteStringValue(AccessToken);
                }
                else
                {
                    writer.WriteNull("accessToken");
                }
            }
            if (Optional.IsDefined(TokenType))
            {
                if (TokenType != null)
                {
                    writer.WritePropertyName("tokenType"u8);
                    writer.WriteStringValue(TokenType);
                }
                else
                {
                    writer.WriteNull("tokenType");
                }
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTimeUtc"u8);
                writer.WriteNumberValue(ExpireOn.Value, "U");
            }
            if (Optional.IsDefined(RefreshOn))
            {
                writer.WritePropertyName("refreshAfterTimeUtc"u8);
                writer.WriteNumberValue(RefreshOn.Value, "U");
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

        MachineLearningEndpointAuthToken IJsonModel<MachineLearningEndpointAuthToken>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointAuthToken>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointAuthToken)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEndpointAuthToken(document.RootElement, options);
        }

        internal static MachineLearningEndpointAuthToken DeserializeMachineLearningEndpointAuthToken(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accessToken = default;
            string tokenType = default;
            DateTimeOffset? expiryTimeUtc = default;
            DateTimeOffset? refreshAfterTimeUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessToken = null;
                        continue;
                    }
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tokenType = null;
                        continue;
                    }
                    tokenType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTimeUtc = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("refreshAfterTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshAfterTimeUtc = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningEndpointAuthToken(accessToken, tokenType, expiryTimeUtc, refreshAfterTimeUtc, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningEndpointAuthToken>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointAuthToken>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEndpointAuthToken)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningEndpointAuthToken IPersistableModel<MachineLearningEndpointAuthToken>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointAuthToken>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningEndpointAuthToken(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEndpointAuthToken)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningEndpointAuthToken>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
