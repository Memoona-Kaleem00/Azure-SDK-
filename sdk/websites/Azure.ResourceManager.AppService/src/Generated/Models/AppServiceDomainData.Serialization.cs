// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceDomainData : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceDomainData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceDomainData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceDomainData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDomainData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ContactAdmin))
            {
                writer.WritePropertyName("contactAdmin"u8);
                if (ContactAdmin is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RegistrationContactInfo>)ContactAdmin).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ContactBilling))
            {
                writer.WritePropertyName("contactBilling"u8);
                if (ContactBilling is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RegistrationContactInfo>)ContactBilling).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ContactRegistrant))
            {
                writer.WritePropertyName("contactRegistrant"u8);
                if (ContactRegistrant is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RegistrationContactInfo>)ContactRegistrant).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ContactTech))
            {
                writer.WritePropertyName("contactTech"u8);
                if (ContactTech is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RegistrationContactInfo>)ContactTech).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsDomainPrivacyEnabled))
            {
                writer.WritePropertyName("privacy"u8);
                writer.WriteBooleanValue(IsDomainPrivacyEnabled.Value);
            }
            if (Optional.IsDefined(IsAutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteBooleanValue(IsAutoRenew.Value);
            }
            if (Optional.IsDefined(Consent))
            {
                writer.WritePropertyName("consent"u8);
                if (Consent is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DomainPurchaseConsent>)Consent).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DnsType))
            {
                writer.WritePropertyName("dnsType"u8);
                writer.WriteStringValue(DnsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DnsZoneId))
            {
                writer.WritePropertyName("dnsZoneId"u8);
                writer.WriteStringValue(DnsZoneId);
            }
            if (Optional.IsDefined(TargetDnsType))
            {
                writer.WritePropertyName("targetDnsType"u8);
                writer.WriteStringValue(TargetDnsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(AuthCode))
            {
                writer.WritePropertyName("authCode"u8);
                writer.WriteStringValue(AuthCode);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AppServiceDomainData DeserializeAppServiceDomainData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<RegistrationContactInfo> contactAdmin = default;
            Optional<RegistrationContactInfo> contactBilling = default;
            Optional<RegistrationContactInfo> contactRegistrant = default;
            Optional<RegistrationContactInfo> contactTech = default;
            Optional<AppServiceDomainStatus> registrationStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<string>> nameServers = default;
            Optional<bool> privacy = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> expirationTime = default;
            Optional<DateTimeOffset> lastRenewedTime = default;
            Optional<bool> autoRenew = default;
            Optional<bool> readyForDnsRecordManagement = default;
            Optional<IReadOnlyList<AppServiceHostName>> managedHostNames = default;
            Optional<DomainPurchaseConsent> consent = default;
            Optional<IReadOnlyList<DomainNotRenewableReason>> domainNotRenewableReasons = default;
            Optional<AppServiceDnsType> dnsType = default;
            Optional<string> dnsZoneId = default;
            Optional<AppServiceDnsType> targetDnsType = default;
            Optional<string> authCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("contactAdmin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactAdmin = RegistrationContactInfo.DeserializeRegistrationContactInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contactBilling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactBilling = RegistrationContactInfo.DeserializeRegistrationContactInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contactRegistrant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactRegistrant = RegistrationContactInfo.DeserializeRegistrationContactInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contactTech"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactTech = RegistrationContactInfo.DeserializeRegistrationContactInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("registrationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationStatus = property0.Value.GetString().ToAppServiceDomainStatus();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("nameServers"u8))
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
                            nameServers = array;
                            continue;
                        }
                        if (property0.NameEquals("privacy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacy = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastRenewedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastRenewedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoRenew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoRenew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("readyForDnsRecordManagement"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readyForDnsRecordManagement = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("managedHostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceHostName> array = new List<AppServiceHostName>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceHostName.DeserializeAppServiceHostName(item));
                            }
                            managedHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("consent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            consent = DomainPurchaseConsent.DeserializeDomainPurchaseConsent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("domainNotRenewableReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DomainNotRenewableReason> array = new List<DomainNotRenewableReason>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DomainNotRenewableReason(item.GetString()));
                            }
                            domainNotRenewableReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsType = property0.Value.GetString().ToAppServiceDnsType();
                            continue;
                        }
                        if (property0.NameEquals("dnsZoneId"u8))
                        {
                            dnsZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDnsType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetDnsType = property0.Value.GetString().ToAppServiceDnsType();
                            continue;
                        }
                        if (property0.NameEquals("authCode"u8))
                        {
                            authCode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceDomainData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, contactAdmin.Value, contactBilling.Value, contactRegistrant.Value, contactTech.Value, Optional.ToNullable(registrationStatus), Optional.ToNullable(provisioningState), Optional.ToList(nameServers), Optional.ToNullable(privacy), Optional.ToNullable(createdTime), Optional.ToNullable(expirationTime), Optional.ToNullable(lastRenewedTime), Optional.ToNullable(autoRenew), Optional.ToNullable(readyForDnsRecordManagement), Optional.ToList(managedHostNames), consent.Value, Optional.ToList(domainNotRenewableReasons), Optional.ToNullable(dnsType), dnsZoneId.Value, Optional.ToNullable(targetDnsType), authCode.Value, kind.Value, rawData);
        }

        AppServiceDomainData IModelJsonSerializable<AppServiceDomainData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDomainData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceDomainData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceDomainData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDomainData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceDomainData IModelSerializable<AppServiceDomainData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDomainData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceDomainData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceDomainData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceDomainData"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceDomainData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceDomainData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceDomainData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceDomainData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
