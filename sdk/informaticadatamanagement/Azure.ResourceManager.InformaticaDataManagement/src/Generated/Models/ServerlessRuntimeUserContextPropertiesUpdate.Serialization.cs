// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    internal partial class ServerlessRuntimeUserContextPropertiesUpdate : IUtf8JsonSerializable, IJsonModel<ServerlessRuntimeUserContextPropertiesUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerlessRuntimeUserContextPropertiesUpdate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServerlessRuntimeUserContextPropertiesUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessRuntimeUserContextPropertiesUpdate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserContextToken))
            {
                writer.WritePropertyName("userContextToken"u8);
                writer.WriteStringValue(UserContextToken);
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

        ServerlessRuntimeUserContextPropertiesUpdate IJsonModel<ServerlessRuntimeUserContextPropertiesUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessRuntimeUserContextPropertiesUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerlessRuntimeUserContextPropertiesUpdate(document.RootElement, options);
        }

        internal static ServerlessRuntimeUserContextPropertiesUpdate DeserializeServerlessRuntimeUserContextPropertiesUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userContextToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userContextToken"u8))
                {
                    userContextToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServerlessRuntimeUserContextPropertiesUpdate(userContextToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerlessRuntimeUserContextPropertiesUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ServerlessRuntimeUserContextPropertiesUpdate IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerlessRuntimeUserContextPropertiesUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerlessRuntimeUserContextPropertiesUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerlessRuntimeUserContextPropertiesUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
