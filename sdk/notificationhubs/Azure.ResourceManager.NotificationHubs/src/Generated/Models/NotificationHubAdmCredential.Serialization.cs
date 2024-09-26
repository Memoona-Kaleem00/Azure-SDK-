// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubAdmCredential : IUtf8JsonSerializable, IJsonModel<NotificationHubAdmCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubAdmCredential>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NotificationHubAdmCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubAdmCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubAdmCredential)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            writer.WritePropertyName("clientSecret"u8);
            writer.WriteStringValue(ClientSecret);
            writer.WritePropertyName("authTokenUrl"u8);
            writer.WriteStringValue(AuthTokenUri.AbsoluteUri);
            writer.WriteEndObject();
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

        NotificationHubAdmCredential IJsonModel<NotificationHubAdmCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubAdmCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubAdmCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubAdmCredential(document.RootElement, options);
        }

        internal static NotificationHubAdmCredential DeserializeNotificationHubAdmCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientId = default;
            string clientSecret = default;
            Uri authTokenUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authTokenUrl"u8))
                        {
                            authTokenUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NotificationHubAdmCredential(clientId, clientSecret, authTokenUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubAdmCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubAdmCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubAdmCredential)} does not support writing '{options.Format}' format.");
            }
        }

        NotificationHubAdmCredential IPersistableModel<NotificationHubAdmCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubAdmCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationHubAdmCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubAdmCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubAdmCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
