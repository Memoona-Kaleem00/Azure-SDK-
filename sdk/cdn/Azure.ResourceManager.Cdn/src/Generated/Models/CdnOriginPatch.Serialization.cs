// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnOriginPatch : IUtf8JsonSerializable, IJsonModel<CdnOriginPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnOriginPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CdnOriginPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (HostName != null)
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (HttpPort.HasValue)
            {
                if (HttpPort != null)
                {
                    writer.WritePropertyName("httpPort"u8);
                    writer.WriteNumberValue(HttpPort.Value);
                }
                else
                {
                    writer.WriteNull("httpPort");
                }
            }
            if (HttpsPort.HasValue)
            {
                if (HttpsPort != null)
                {
                    writer.WritePropertyName("httpsPort"u8);
                    writer.WriteNumberValue(HttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("httpsPort");
                }
            }
            if (OriginHostHeader != null)
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Priority.HasValue)
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority"u8);
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Weight.HasValue)
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight"u8);
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Enabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (PrivateLinkAlias != null)
            {
                writer.WritePropertyName("privateLinkAlias"u8);
                writer.WriteStringValue(PrivateLinkAlias);
            }
            if (PrivateLinkResourceId != null)
            {
                if (PrivateLinkResourceId != null)
                {
                    writer.WritePropertyName("privateLinkResourceId"u8);
                    writer.WriteStringValue(PrivateLinkResourceId);
                }
                else
                {
                    writer.WriteNull("privateLinkResourceId");
                }
            }
            if (PrivateLinkLocation != null)
            {
                writer.WritePropertyName("privateLinkLocation"u8);
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (PrivateLinkApprovalMessage != null)
            {
                writer.WritePropertyName("privateLinkApprovalMessage"u8);
                writer.WriteStringValue(PrivateLinkApprovalMessage);
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

        CdnOriginPatch IJsonModel<CdnOriginPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnOriginPatch(document.RootElement, options);
        }

        internal static CdnOriginPatch DeserializeCdnOriginPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hostName = default;
            Optional<int?> httpPort = default;
            Optional<int?> httpsPort = default;
            Optional<string> originHostHeader = default;
            Optional<int?> priority = default;
            Optional<int?> weight = default;
            Optional<bool> enabled = default;
            Optional<string> privateLinkAlias = default;
            Optional<ResourceIdentifier> privateLinkResourceId = default;
            Optional<string> privateLinkLocation = default;
            Optional<string> privateLinkApprovalMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpPort = null;
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpsPort = null;
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkAlias"u8))
                        {
                            privateLinkAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateLinkResourceId = null;
                                continue;
                            }
                            privateLinkResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkLocation"u8))
                        {
                            privateLinkLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkApprovalMessage"u8))
                        {
                            privateLinkApprovalMessage = property0.Value.GetString();
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
            return new CdnOriginPatch(hostName.Value, Optional.ToNullable(httpPort), Optional.ToNullable(httpsPort), originHostHeader.Value, Optional.ToNullable(priority), Optional.ToNullable(weight), Optional.ToNullable(enabled), privateLinkAlias.Value, privateLinkResourceId.Value, privateLinkLocation.Value, privateLinkApprovalMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnOriginPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CdnOriginPatch)} does not support '{options.Format}' format.");
            }
        }

        CdnOriginPatch IPersistableModel<CdnOriginPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCdnOriginPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnOriginPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnOriginPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
