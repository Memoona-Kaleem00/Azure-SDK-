// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(KeyVaultPropertiesConverter))]
    public partial class KeyVaultProperties : IUtf8JsonSerializable, IJsonModel<KeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteStringValue(Identity);
            }
            writer.WriteEndObject();
        }

        KeyVaultProperties IJsonModel<KeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultProperties(document.RootElement, options);
        }

        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyIdentifier = default;
            string identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultProperties(keyIdentifier, identity);
        }

        BinaryData IPersistableModel<KeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultProperties)} does not support writing '{options.Format}' format.");
            }
        }

        KeyVaultProperties IPersistableModel<KeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class KeyVaultPropertiesConverter : JsonConverter<KeyVaultProperties>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<KeyVaultProperties>(model);
            }
            public override KeyVaultProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultProperties(document.RootElement);
            }
        }
    }
}
