// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class UserAuthenticationUpdate : IUtf8JsonSerializable, IJsonModel<UserAuthenticationUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserAuthenticationUpdate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserAuthenticationUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthenticationUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAuthenticationUpdate)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(UsernamePasswordCredentials))
            {
                writer.WritePropertyName("usernamePasswordCredentials"u8);
                writer.WriteObjectValue(UsernamePasswordCredentials, options);
            }
            if (Optional.IsDefined(X509Credentials))
            {
                writer.WritePropertyName("x509Credentials"u8);
                writer.WriteObjectValue(X509Credentials, options);
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

        UserAuthenticationUpdate IJsonModel<UserAuthenticationUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthenticationUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAuthenticationUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserAuthenticationUpdate(document.RootElement, options);
        }

        internal static UserAuthenticationUpdate DeserializeUserAuthenticationUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UserAuthenticationMode? mode = default;
            UsernamePasswordCredentialsUpdate usernamePasswordCredentials = default;
            X509CredentialsUpdate x509Credentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new UserAuthenticationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usernamePasswordCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usernamePasswordCredentials = UsernamePasswordCredentialsUpdate.DeserializeUsernamePasswordCredentialsUpdate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("x509Credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Credentials = X509CredentialsUpdate.DeserializeX509CredentialsUpdate(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserAuthenticationUpdate(mode, usernamePasswordCredentials, x509Credentials, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserAuthenticationUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthenticationUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserAuthenticationUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        UserAuthenticationUpdate IPersistableModel<UserAuthenticationUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthenticationUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserAuthenticationUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserAuthenticationUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserAuthenticationUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
