// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class DiskRestorePointData : IUtf8JsonSerializable, IJsonModel<DiskRestorePointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskRestorePointData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiskRestorePointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskRestorePointData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration"u8);
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan"u8);
                writer.WriteObjectValue<DiskPurchasePlan>(PurchasePlan, options);
            }
            if (Optional.IsDefined(SupportedCapabilities))
            {
                writer.WritePropertyName("supportedCapabilities"u8);
                writer.WriteObjectValue<SupportedCapabilities>(SupportedCapabilities, options);
            }
            if (options.Format != "W" && Optional.IsDefined(FamilyId))
            {
                writer.WritePropertyName("familyId"u8);
                writer.WriteStringValue(FamilyId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceUniqueId))
            {
                writer.WritePropertyName("sourceUniqueId"u8);
                writer.WriteStringValue(SourceUniqueId);
            }
            if (options.Format != "W" && Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue<DiskEncryption>(Encryption, options);
            }
            if (Optional.IsDefined(SupportsHibernation))
            {
                writer.WritePropertyName("supportsHibernation"u8);
                writer.WriteBooleanValue(SupportsHibernation.Value);
            }
            if (Optional.IsDefined(NetworkAccessPolicy))
            {
                writer.WritePropertyName("networkAccessPolicy"u8);
                writer.WriteStringValue(NetworkAccessPolicy.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(DiskAccessId))
            {
                writer.WritePropertyName("diskAccessId"u8);
                writer.WriteStringValue(DiskAccessId);
            }
            if (Optional.IsDefined(CompletionPercent))
            {
                writer.WritePropertyName("completionPercent"u8);
                writer.WriteNumberValue(CompletionPercent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationState))
            {
                writer.WritePropertyName("replicationState"u8);
                writer.WriteStringValue(ReplicationState);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceResourceLocation))
            {
                writer.WritePropertyName("sourceResourceLocation"u8);
                writer.WriteStringValue(SourceResourceLocation.Value);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue<DiskSecurityProfile>(SecurityProfile, options);
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

        DiskRestorePointData IJsonModel<DiskRestorePointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskRestorePointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskRestorePointData(document.RootElement, options);
        }

        internal static DiskRestorePointData DeserializeDiskRestorePointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DateTimeOffset? timeCreated = default;
            ResourceIdentifier sourceResourceId = default;
            SupportedOperatingSystemType? osType = default;
            HyperVGeneration? hyperVGeneration = default;
            DiskPurchasePlan purchasePlan = default;
            SupportedCapabilities supportedCapabilities = default;
            string familyId = default;
            string sourceUniqueId = default;
            DiskEncryption encryption = default;
            bool? supportsHibernation = default;
            NetworkAccessPolicy? networkAccessPolicy = default;
            DiskPublicNetworkAccess? publicNetworkAccess = default;
            ResourceIdentifier diskAccessId = default;
            float? completionPercent = default;
            string replicationState = default;
            AzureLocation? sourceResourceLocation = default;
            DiskSecurityProfile securityProfile = default;
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
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = property0.Value.GetString().ToSupportedOperatingSystemType();
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasePlan = DiskPurchasePlan.DeserializeDiskPurchasePlan(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("supportedCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportedCapabilities = SupportedCapabilities.DeserializeSupportedCapabilities(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("familyId"u8))
                        {
                            familyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceUniqueId"u8))
                        {
                            sourceUniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = DiskEncryption.DeserializeDiskEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("supportsHibernation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsHibernation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkAccessPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAccessPolicy = new NetworkAccessPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new DiskPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskAccessId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskAccessId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("completionPercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            completionPercent = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            replicationState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = DiskSecurityProfile.DeserializeDiskSecurityProfile(property0.Value, options);
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
            return new DiskRestorePointData(
                id,
                name,
                type,
                systemData,
                timeCreated,
                sourceResourceId,
                osType,
                hyperVGeneration,
                purchasePlan,
                supportedCapabilities,
                familyId,
                sourceUniqueId,
                encryption,
                supportsHibernation,
                networkAccessPolicy,
                publicNetworkAccess,
                diskAccessId,
                completionPercent,
                replicationState,
                sourceResourceLocation,
                securityProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiskRestorePointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiskRestorePointData)} does not support writing '{options.Format}' format.");
            }
        }

        DiskRestorePointData IPersistableModel<DiskRestorePointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskRestorePointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiskRestorePointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskRestorePointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
