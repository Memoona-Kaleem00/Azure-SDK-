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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareCryptoCertificateResult : IUtf8JsonSerializable, IJsonModel<FirmwareCryptoCertificateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirmwareCryptoCertificateResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirmwareCryptoCertificateResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoCertificateResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (CryptoCertId != null)
            {
                if (CryptoCertId != null)
                {
                    writer.WritePropertyName("cryptoCertId"u8);
                    writer.WriteStringValue(CryptoCertId);
                }
                else
                {
                    writer.WriteNull("cryptoCertId");
                }
            }
            if (NamePropertiesName != null)
            {
                if (NamePropertiesName != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(NamePropertiesName);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Subject != null)
            {
                if (Subject != null)
                {
                    writer.WritePropertyName("subject"u8);
                    writer.WriteObjectValue(Subject);
                }
                else
                {
                    writer.WriteNull("subject");
                }
            }
            if (Issuer != null)
            {
                if (Issuer != null)
                {
                    writer.WritePropertyName("issuer"u8);
                    writer.WriteObjectValue(Issuer);
                }
                else
                {
                    writer.WriteNull("issuer");
                }
            }
            if (IssuedOn.HasValue)
            {
                if (IssuedOn != null)
                {
                    writer.WritePropertyName("issuedDate"u8);
                    writer.WriteStringValue(IssuedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("issuedDate");
                }
            }
            if (ExpireOn.HasValue)
            {
                if (ExpireOn != null)
                {
                    writer.WritePropertyName("expirationDate"u8);
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expirationDate");
                }
            }
            if (Role != null)
            {
                if (Role != null)
                {
                    writer.WritePropertyName("role"u8);
                    writer.WriteStringValue(Role);
                }
                else
                {
                    writer.WriteNull("role");
                }
            }
            if (SignatureAlgorithm != null)
            {
                if (SignatureAlgorithm != null)
                {
                    writer.WritePropertyName("signatureAlgorithm"u8);
                    writer.WriteStringValue(SignatureAlgorithm);
                }
                else
                {
                    writer.WriteNull("signatureAlgorithm");
                }
            }
            if (KeySize.HasValue)
            {
                if (KeySize != null)
                {
                    writer.WritePropertyName("keySize"u8);
                    writer.WriteNumberValue(KeySize.Value);
                }
                else
                {
                    writer.WriteNull("keySize");
                }
            }
            if (KeyAlgorithm != null)
            {
                if (KeyAlgorithm != null)
                {
                    writer.WritePropertyName("keyAlgorithm"u8);
                    writer.WriteStringValue(KeyAlgorithm);
                }
                else
                {
                    writer.WriteNull("keyAlgorithm");
                }
            }
            if (Encoding != null)
            {
                if (Encoding != null)
                {
                    writer.WritePropertyName("encoding"u8);
                    writer.WriteStringValue(Encoding);
                }
                else
                {
                    writer.WriteNull("encoding");
                }
            }
            if (SerialNumber != null)
            {
                if (SerialNumber != null)
                {
                    writer.WritePropertyName("serialNumber"u8);
                    writer.WriteStringValue(SerialNumber);
                }
                else
                {
                    writer.WriteNull("serialNumber");
                }
            }
            if (Fingerprint != null)
            {
                if (Fingerprint != null)
                {
                    writer.WritePropertyName("fingerprint"u8);
                    writer.WriteStringValue(Fingerprint);
                }
                else
                {
                    writer.WriteNull("fingerprint");
                }
            }
            if (!(Usage is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                if (Usage != null)
                {
                    writer.WritePropertyName("usage"u8);
                    writer.WriteStartArray();
                    foreach (var item in Usage)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("usage");
                }
            }
            if (options.Format != "W" && !(FilePaths is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                if (FilePaths != null)
                {
                    writer.WritePropertyName("filePaths"u8);
                    writer.WriteStartArray();
                    foreach (var item in FilePaths)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("filePaths");
                }
            }
            if (PairedKey != null)
            {
                if (PairedKey != null)
                {
                    writer.WritePropertyName("pairedKey"u8);
                    writer.WriteObjectValue(PairedKey);
                }
                else
                {
                    writer.WriteNull("pairedKey");
                }
            }
            if (IsExpired.HasValue)
            {
                if (IsExpired != null)
                {
                    writer.WritePropertyName("isExpired"u8);
                    writer.WriteBooleanValue(IsExpired.Value);
                }
                else
                {
                    writer.WriteNull("isExpired");
                }
            }
            if (IsSelfSigned.HasValue)
            {
                if (IsSelfSigned != null)
                {
                    writer.WritePropertyName("isSelfSigned"u8);
                    writer.WriteBooleanValue(IsSelfSigned.Value);
                }
                else
                {
                    writer.WriteNull("isSelfSigned");
                }
            }
            if (IsWeakSignature.HasValue)
            {
                if (IsWeakSignature != null)
                {
                    writer.WritePropertyName("isWeakSignature"u8);
                    writer.WriteBooleanValue(IsWeakSignature.Value);
                }
                else
                {
                    writer.WriteNull("isWeakSignature");
                }
            }
            if (IsShortKeySize.HasValue)
            {
                if (IsShortKeySize != null)
                {
                    writer.WritePropertyName("isShortKeySize"u8);
                    writer.WriteBooleanValue(IsShortKeySize.Value);
                }
                else
                {
                    writer.WriteNull("isShortKeySize");
                }
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

        FirmwareCryptoCertificateResult IJsonModel<FirmwareCryptoCertificateResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoCertificateResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCryptoCertificateResult(document.RootElement, options);
        }

        internal static FirmwareCryptoCertificateResult DeserializeFirmwareCryptoCertificateResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> cryptoCertId = default;
            Optional<string> name0 = default;
            Optional<FirmwareCryptoCertificateEntity> subject = default;
            Optional<FirmwareCryptoCertificateEntity> issuer = default;
            Optional<DateTimeOffset?> issuedDate = default;
            Optional<DateTimeOffset?> expirationDate = default;
            Optional<string> role = default;
            Optional<string> signatureAlgorithm = default;
            Optional<long?> keySize = default;
            Optional<string> keyAlgorithm = default;
            Optional<string> encoding = default;
            Optional<string> serialNumber = default;
            Optional<string> fingerprint = default;
            IList<string> usage = default;
            IReadOnlyList<string> filePaths = default;
            Optional<FirmwarePairedKey> pairedKey = default;
            Optional<bool?> isExpired = default;
            Optional<bool?> isSelfSigned = default;
            Optional<bool?> isWeakSignature = default;
            Optional<bool?> isShortKeySize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("cryptoCertId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cryptoCertId = null;
                                continue;
                            }
                            cryptoCertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                name0 = null;
                                continue;
                            }
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subject"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                subject = null;
                                continue;
                            }
                            subject = FirmwareCryptoCertificateEntity.DeserializeFirmwareCryptoCertificateEntity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("issuer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                issuer = null;
                                continue;
                            }
                            issuer = FirmwareCryptoCertificateEntity.DeserializeFirmwareCryptoCertificateEntity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("issuedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                issuedDate = null;
                                continue;
                            }
                            issuedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                expirationDate = null;
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                role = null;
                                continue;
                            }
                            role = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signatureAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                signatureAlgorithm = null;
                                continue;
                            }
                            signatureAlgorithm = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                keySize = null;
                                continue;
                            }
                            keySize = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("keyAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                keyAlgorithm = null;
                                continue;
                            }
                            keyAlgorithm = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encoding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                encoding = null;
                                continue;
                            }
                            encoding = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                serialNumber = null;
                                continue;
                            }
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fingerprint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                fingerprint = null;
                                continue;
                            }
                            fingerprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            usage = array;
                            continue;
                        }
                        if (property0.NameEquals("filePaths"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            filePaths = array;
                            continue;
                        }
                        if (property0.NameEquals("pairedKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                pairedKey = null;
                                continue;
                            }
                            pairedKey = FirmwarePairedKey.DeserializeFirmwarePairedKey(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isExpired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isExpired = null;
                                continue;
                            }
                            isExpired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isSelfSigned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isSelfSigned = null;
                                continue;
                            }
                            isSelfSigned = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isWeakSignature"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isWeakSignature = null;
                                continue;
                            }
                            isWeakSignature = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isShortKeySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isShortKeySize = null;
                                continue;
                            }
                            isShortKeySize = property0.Value.GetBoolean();
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
            return new FirmwareCryptoCertificateResult(
                id,
                name,
                type,
                systemData.Value,
                cryptoCertId.Value,
                name0.Value,
                subject.Value,
                issuer.Value,
                Optional.ToNullable(issuedDate),
                Optional.ToNullable(expirationDate),
                role.Value,
                signatureAlgorithm.Value,
                Optional.ToNullable(keySize),
                keyAlgorithm.Value,
                encoding.Value,
                serialNumber.Value,
                fingerprint.Value,
                usage ?? new ChangeTrackingList<string>(),
                filePaths ?? new ChangeTrackingList<string>(),
                pairedKey.Value,
                Optional.ToNullable(isExpired),
                Optional.ToNullable(isSelfSigned),
                Optional.ToNullable(isWeakSignature),
                Optional.ToNullable(isShortKeySize),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirmwareCryptoCertificateResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirmwareCryptoCertificateResult)} does not support '{options.Format}' format.");
            }
        }

        FirmwareCryptoCertificateResult IPersistableModel<FirmwareCryptoCertificateResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirmwareCryptoCertificateResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirmwareCryptoCertificateResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirmwareCryptoCertificateResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
