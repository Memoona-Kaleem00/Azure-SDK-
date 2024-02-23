// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesAccountProperties : IUtf8JsonSerializable, IJsonModel<CognitiveServicesAccountProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CognitiveServicesAccountProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CognitiveServicesAccountProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesAccountProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Endpoint != null)
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (options.Format != "W" && !(Capabilities is ChangeTrackingList<CognitiveServicesSkuCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && IsMigrated.HasValue)
            {
                writer.WritePropertyName("isMigrated"u8);
                writer.WriteBooleanValue(IsMigrated.Value);
            }
            if (MigrationToken != null)
            {
                writer.WritePropertyName("migrationToken"u8);
                writer.WriteStringValue(MigrationToken);
            }
            if (options.Format != "W" && SkuChangeInfo != null)
            {
                writer.WritePropertyName("skuChangeInfo"u8);
                writer.WriteObjectValue(SkuChangeInfo);
            }
            if (CustomSubDomainName != null)
            {
                writer.WritePropertyName("customSubDomainName"u8);
                writer.WriteStringValue(CustomSubDomainName);
            }
            if (NetworkAcls != null)
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkAcls);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (!(UserOwnedStorage is ChangeTrackingList<ServiceAccountUserOwnedStorage> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("userOwnedStorage"u8);
                writer.WriteStartArray();
                foreach (var item in UserOwnedStorage)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<CognitiveServicesPrivateEndpointConnectionData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (ApiProperties != null)
            {
                writer.WritePropertyName("apiProperties"u8);
                writer.WriteObjectValue(ApiProperties);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("dateCreated"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && CallRateLimit != null)
            {
                writer.WritePropertyName("callRateLimit"u8);
                writer.WriteObjectValue(CallRateLimit);
            }
            if (EnableDynamicThrottling.HasValue)
            {
                writer.WritePropertyName("dynamicThrottlingEnabled"u8);
                writer.WriteBooleanValue(EnableDynamicThrottling.Value);
            }
            if (options.Format != "W" && QuotaLimit != null)
            {
                writer.WritePropertyName("quotaLimit"u8);
                writer.WriteObjectValue(QuotaLimit);
            }
            if (RestrictOutboundNetworkAccess.HasValue)
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteBooleanValue(RestrictOutboundNetworkAccess.Value);
            }
            if (!(AllowedFqdnList is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("allowedFqdnList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedFqdnList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (DisableLocalAuth.HasValue)
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (options.Format != "W" && !(Endpoints is ChangeTrackingDictionary<string, string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartObject();
                foreach (var item in Endpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Restore.HasValue)
            {
                writer.WritePropertyName("restore"u8);
                writer.WriteBooleanValue(Restore.Value);
            }
            if (options.Format != "W" && DeletedOn.HasValue)
            {
                writer.WritePropertyName("deletionDate"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
            }
            if (options.Format != "W" && ScheduledPurgeDate != null)
            {
                writer.WritePropertyName("scheduledPurgeDate"u8);
                writer.WriteStringValue(ScheduledPurgeDate);
            }
            if (Locations != null)
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteObjectValue(Locations);
            }
            if (options.Format != "W" && !(CommitmentPlanAssociations is ChangeTrackingList<CommitmentPlanAssociation> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("commitmentPlanAssociations"u8);
                writer.WriteStartArray();
                foreach (var item in CommitmentPlanAssociations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && AbusePenalty != null)
            {
                writer.WritePropertyName("abusePenalty"u8);
                writer.WriteObjectValue(AbusePenalty);
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

        CognitiveServicesAccountProperties IJsonModel<CognitiveServicesAccountProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesAccountProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesAccountProperties(document.RootElement, options);
        }

        internal static CognitiveServicesAccountProperties DeserializeCognitiveServicesAccountProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceAccountProvisioningState> provisioningState = default;
            Optional<string> endpoint = default;
            Optional<IReadOnlyList<CognitiveServicesSkuCapability>> capabilities = default;
            Optional<bool> isMigrated = default;
            Optional<string> migrationToken = default;
            Optional<CognitiveServicesSkuChangeInfo> skuChangeInfo = default;
            Optional<string> customSubDomainName = default;
            Optional<CognitiveServicesNetworkRuleSet> networkAcls = default;
            Optional<ServiceAccountEncryptionProperties> encryption = default;
            Optional<IList<ServiceAccountUserOwnedStorage>> userOwnedStorage = default;
            Optional<IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<ServiceAccountPublicNetworkAccess> publicNetworkAccess = default;
            Optional<ServiceAccountApiProperties> apiProperties = default;
            Optional<DateTimeOffset> dateCreated = default;
            Optional<ServiceAccountCallRateLimit> callRateLimit = default;
            Optional<bool> dynamicThrottlingEnabled = default;
            Optional<ServiceAccountQuotaLimit> quotaLimit = default;
            Optional<bool> restrictOutboundNetworkAccess = default;
            Optional<IList<string>> allowedFqdnList = default;
            Optional<bool> disableLocalAuth = default;
            Optional<IReadOnlyDictionary<string, string>> endpoints = default;
            Optional<bool> restore = default;
            Optional<DateTimeOffset> deletionDate = default;
            Optional<string> scheduledPurgeDate = default;
            Optional<CognitiveServicesMultiRegionSettings> locations = default;
            Optional<IReadOnlyList<CommitmentPlanAssociation>> commitmentPlanAssociations = default;
            Optional<AbusePenalty> abusePenalty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ServiceAccountProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CognitiveServicesSkuCapability> array = new List<CognitiveServicesSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesSkuCapability.DeserializeCognitiveServicesSkuCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("isMigrated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMigrated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("migrationToken"u8))
                {
                    migrationToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuChangeInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skuChangeInfo = CognitiveServicesSkuChangeInfo.DeserializeCognitiveServicesSkuChangeInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customSubDomainName"u8))
                {
                    customSubDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkAcls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkAcls = CognitiveServicesNetworkRuleSet.DeserializeCognitiveServicesNetworkRuleSet(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = ServiceAccountEncryptionProperties.DeserializeServiceAccountEncryptionProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userOwnedStorage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountUserOwnedStorage> array = new List<ServiceAccountUserOwnedStorage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountUserOwnedStorage.DeserializeServiceAccountUserOwnedStorage(item, options));
                    }
                    userOwnedStorage = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CognitiveServicesPrivateEndpointConnectionData> array = new List<CognitiveServicesPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesPrivateEndpointConnectionData.DeserializeCognitiveServicesPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new ServiceAccountPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiProperties = ServiceAccountApiProperties.DeserializeServiceAccountApiProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dateCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("callRateLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callRateLimit = ServiceAccountCallRateLimit.DeserializeServiceAccountCallRateLimit(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dynamicThrottlingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicThrottlingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("quotaLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaLimit = ServiceAccountQuotaLimit.DeserializeServiceAccountQuotaLimit(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restrictOutboundNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictOutboundNetworkAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedFqdnList"u8))
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
                    allowedFqdnList = array;
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
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
                    endpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("restore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restore = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deletionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"u8))
                {
                    scheduledPurgeDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locations = CognitiveServicesMultiRegionSettings.DeserializeCognitiveServicesMultiRegionSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("commitmentPlanAssociations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommitmentPlanAssociation> array = new List<CommitmentPlanAssociation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommitmentPlanAssociation.DeserializeCommitmentPlanAssociation(item, options));
                    }
                    commitmentPlanAssociations = array;
                    continue;
                }
                if (property.NameEquals("abusePenalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    abusePenalty = AbusePenalty.DeserializeAbusePenalty(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CognitiveServicesAccountProperties(Optional.ToNullable(provisioningState), endpoint.Value, Optional.ToList(capabilities), Optional.ToNullable(isMigrated), migrationToken.Value, skuChangeInfo.Value, customSubDomainName.Value, networkAcls.Value, encryption.Value, Optional.ToList(userOwnedStorage), Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess), apiProperties.Value, Optional.ToNullable(dateCreated), callRateLimit.Value, Optional.ToNullable(dynamicThrottlingEnabled), quotaLimit.Value, Optional.ToNullable(restrictOutboundNetworkAccess), Optional.ToList(allowedFqdnList), Optional.ToNullable(disableLocalAuth), Optional.ToDictionary(endpoints), Optional.ToNullable(restore), Optional.ToNullable(deletionDate), scheduledPurgeDate.Value, locations.Value, Optional.ToList(commitmentPlanAssociations), abusePenalty.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CognitiveServicesAccountProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesAccountProperties)} does not support '{options.Format}' format.");
            }
        }

        CognitiveServicesAccountProperties IPersistableModel<CognitiveServicesAccountProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCognitiveServicesAccountProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesAccountProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CognitiveServicesAccountProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
