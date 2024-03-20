// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ReissueCertificateOrderContent : IUtf8JsonSerializable, IJsonModel<ReissueCertificateOrderContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReissueCertificateOrderContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReissueCertificateOrderContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReissueCertificateOrderContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReissueCertificateOrderContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(KeySize))
            {
                writer.WritePropertyName("keySize"u8);
                writer.WriteNumberValue(KeySize.Value);
            }
            if (Optional.IsDefined(DelayExistingRevokeInHours))
            {
                writer.WritePropertyName("delayExistingRevokeInHours"u8);
                writer.WriteNumberValue(DelayExistingRevokeInHours.Value);
            }
            if (Optional.IsDefined(Csr))
            {
                writer.WritePropertyName("csr"u8);
                writer.WriteStringValue(Csr);
            }
            if (Optional.IsDefined(IsPrivateKeyExternal))
            {
                writer.WritePropertyName("isPrivateKeyExternal"u8);
                writer.WriteBooleanValue(IsPrivateKeyExternal.Value);
            }
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
            writer.WriteEndObject();
        }

        ReissueCertificateOrderContent IJsonModel<ReissueCertificateOrderContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReissueCertificateOrderContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReissueCertificateOrderContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReissueCertificateOrderContent(document.RootElement, options);
        }

        internal static ReissueCertificateOrderContent DeserializeReissueCertificateOrderContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? keySize = default;
            int? delayExistingRevokeInHours = default;
            string csr = default;
            bool? isPrivateKeyExternal = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("keySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("delayExistingRevokeInHours"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delayExistingRevokeInHours = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("csr"u8))
                        {
                            csr = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isPrivateKeyExternal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrivateKeyExternal = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReissueCertificateOrderContent(
                id,
                name,
                type,
                systemData,
                keySize,
                delayExistingRevokeInHours,
                csr,
                isPrivateKeyExternal,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReissueCertificateOrderContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReissueCertificateOrderContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReissueCertificateOrderContent)} does not support '{options.Format}' format.");
            }
        }

        ReissueCertificateOrderContent IPersistableModel<ReissueCertificateOrderContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReissueCertificateOrderContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReissueCertificateOrderContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReissueCertificateOrderContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReissueCertificateOrderContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
