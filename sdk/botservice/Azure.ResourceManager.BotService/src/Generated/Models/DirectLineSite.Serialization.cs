// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class DirectLineSite : IUtf8JsonSerializable, IJsonModel<DirectLineSite>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectLineSite>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DirectLineSite>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectLineSite)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && SiteId != null)
            {
                writer.WritePropertyName("siteId"u8);
                writer.WriteStringValue(SiteId);
            }
            writer.WritePropertyName("siteName"u8);
            writer.WriteStringValue(SiteName);
            if (options.Format != "W" && Key != null)
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (options.Format != "W" && Key2 != null)
            {
                writer.WritePropertyName("key2"u8);
                writer.WriteStringValue(Key2);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (options.Format != "W" && IsTokenEnabled.HasValue)
            {
                writer.WritePropertyName("isTokenEnabled"u8);
                writer.WriteBooleanValue(IsTokenEnabled.Value);
            }
            if (IsEndpointParametersEnabled.HasValue)
            {
                writer.WritePropertyName("isEndpointParametersEnabled"u8);
                writer.WriteBooleanValue(IsEndpointParametersEnabled.Value);
            }
            if (IsDetailedLoggingEnabled.HasValue)
            {
                writer.WritePropertyName("isDetailedLoggingEnabled"u8);
                writer.WriteBooleanValue(IsDetailedLoggingEnabled.Value);
            }
            if (IsBlockUserUploadEnabled.HasValue)
            {
                if (IsBlockUserUploadEnabled != null)
                {
                    writer.WritePropertyName("isBlockUserUploadEnabled"u8);
                    writer.WriteBooleanValue(IsBlockUserUploadEnabled.Value);
                }
                else
                {
                    writer.WriteNull("isBlockUserUploadEnabled");
                }
            }
            if (IsNoStorageEnabled.HasValue)
            {
                writer.WritePropertyName("isNoStorageEnabled"u8);
                writer.WriteBooleanValue(IsNoStorageEnabled.Value);
            }
            if (ETag.HasValue)
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (AppId != null)
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (IsV1Enabled.HasValue)
            {
                writer.WritePropertyName("isV1Enabled"u8);
                writer.WriteBooleanValue(IsV1Enabled.Value);
            }
            if (IsV3Enabled.HasValue)
            {
                writer.WritePropertyName("isV3Enabled"u8);
                writer.WriteBooleanValue(IsV3Enabled.Value);
            }
            if (IsSecureSiteEnabled.HasValue)
            {
                writer.WritePropertyName("isSecureSiteEnabled"u8);
                writer.WriteBooleanValue(IsSecureSiteEnabled.Value);
            }
            if (!(TrustedOrigins is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("trustedOrigins"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedOrigins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsWebChatSpeechEnabled.HasValue)
            {
                writer.WritePropertyName("isWebChatSpeechEnabled"u8);
                writer.WriteBooleanValue(IsWebChatSpeechEnabled.Value);
            }
            if (IsWebchatPreviewEnabled.HasValue)
            {
                writer.WritePropertyName("isWebchatPreviewEnabled"u8);
                writer.WriteBooleanValue(IsWebchatPreviewEnabled.Value);
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

        DirectLineSite IJsonModel<DirectLineSite>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectLineSite)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectLineSite(document.RootElement, options);
        }

        internal static DirectLineSite DeserializeDirectLineSite(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> tenantId = default;
            Optional<string> siteId = default;
            string siteName = default;
            Optional<string> key = default;
            Optional<string> key2 = default;
            bool isEnabled = default;
            Optional<bool> isTokenEnabled = default;
            Optional<bool> isEndpointParametersEnabled = default;
            Optional<bool> isDetailedLoggingEnabled = default;
            Optional<bool?> isBlockUserUploadEnabled = default;
            Optional<bool> isNoStorageEnabled = default;
            Optional<ETag> eTag = default;
            Optional<string> appId = default;
            Optional<bool> isV1Enabled = default;
            Optional<bool> isV3Enabled = default;
            Optional<bool> isSecureSiteEnabled = default;
            IList<string> trustedOrigins = default;
            Optional<bool> isWebChatSpeechEnabled = default;
            Optional<bool> isWebchatPreviewEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("siteId"u8))
                {
                    siteId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isTokenEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isTokenEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEndpointParametersEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEndpointParametersEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDetailedLoggingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDetailedLoggingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isBlockUserUploadEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isBlockUserUploadEnabled = null;
                        continue;
                    }
                    isBlockUserUploadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNoStorageEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNoStorageEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isV1Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV1Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isV3Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV3Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSecureSiteEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSecureSiteEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trustedOrigins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    trustedOrigins = array;
                    continue;
                }
                if (property.NameEquals("isWebChatSpeechEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebChatSpeechEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isWebchatPreviewEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebchatPreviewEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DirectLineSite(
                Optional.ToNullable(tenantId),
                siteId.Value,
                siteName,
                key.Value,
                key2.Value,
                isEnabled,
                Optional.ToNullable(isTokenEnabled),
                Optional.ToNullable(isEndpointParametersEnabled),
                Optional.ToNullable(isDetailedLoggingEnabled),
                Optional.ToNullable(isBlockUserUploadEnabled),
                Optional.ToNullable(isNoStorageEnabled),
                Optional.ToNullable(eTag),
                appId.Value,
                Optional.ToNullable(isV1Enabled),
                Optional.ToNullable(isV3Enabled),
                Optional.ToNullable(isSecureSiteEnabled),
                trustedOrigins ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(isWebChatSpeechEnabled),
                Optional.ToNullable(isWebchatPreviewEnabled),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DirectLineSite>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DirectLineSite)} does not support '{options.Format}' format.");
            }
        }

        DirectLineSite IPersistableModel<DirectLineSite>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDirectLineSite(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DirectLineSite)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DirectLineSite>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
