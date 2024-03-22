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
    public partial class SiteAuthSettingsV2 : IUtf8JsonSerializable, IJsonModel<SiteAuthSettingsV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteAuthSettingsV2>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteAuthSettingsV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteAuthSettingsV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteAuthSettingsV2)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteObjectValue<AuthPlatform>(Platform, options);
            }
            if (Optional.IsDefined(GlobalValidation))
            {
                writer.WritePropertyName("globalValidation"u8);
                writer.WriteObjectValue<GlobalValidation>(GlobalValidation, options);
            }
            if (Optional.IsDefined(IdentityProviders))
            {
                writer.WritePropertyName("identityProviders"u8);
                writer.WriteObjectValue<AppServiceIdentityProviders>(IdentityProviders, options);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue<WebAppLoginInfo>(Login, options);
            }
            if (Optional.IsDefined(HttpSettings))
            {
                writer.WritePropertyName("httpSettings"u8);
                writer.WriteObjectValue<AppServiceHttpSettings>(HttpSettings, options);
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

        SiteAuthSettingsV2 IJsonModel<SiteAuthSettingsV2>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteAuthSettingsV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteAuthSettingsV2)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteAuthSettingsV2(document.RootElement, options);
        }

        internal static SiteAuthSettingsV2 DeserializeSiteAuthSettingsV2(JsonElement element, ModelReaderWriterOptions options = null)
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
            AuthPlatform platform = default;
            GlobalValidation globalValidation = default;
            AppServiceIdentityProviders identityProviders = default;
            WebAppLoginInfo login = default;
            AppServiceHttpSettings httpSettings = default;
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
                        if (property0.NameEquals("platform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platform = AuthPlatform.DeserializeAuthPlatform(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("globalValidation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            globalValidation = GlobalValidation.DeserializeGlobalValidation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("identityProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identityProviders = AppServiceIdentityProviders.DeserializeAppServiceIdentityProviders(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("login"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            login = WebAppLoginInfo.DeserializeWebAppLoginInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("httpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpSettings = AppServiceHttpSettings.DeserializeAppServiceHttpSettings(property0.Value, options);
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
            return new SiteAuthSettingsV2(
                id,
                name,
                type,
                systemData,
                platform,
                globalValidation,
                identityProviders,
                login,
                httpSettings,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteAuthSettingsV2>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteAuthSettingsV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteAuthSettingsV2)} does not support writing '{options.Format}' format.");
            }
        }

        SiteAuthSettingsV2 IPersistableModel<SiteAuthSettingsV2>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteAuthSettingsV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteAuthSettingsV2(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteAuthSettingsV2)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteAuthSettingsV2>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
