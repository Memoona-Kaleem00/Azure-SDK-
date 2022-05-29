// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ManagedDiskPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(EncryptionSettingGroup))
            {
                writer.WritePropertyName("encryptionSettingsCollection");
                writer.WriteObjectValue(EncryptionSettingGroup);
            }
            if (Optional.IsDefined(DiskIopsReadWrite))
            {
                writer.WritePropertyName("diskIOPSReadWrite");
                writer.WriteNumberValue(DiskIopsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadWrite))
            {
                writer.WritePropertyName("diskMBpsReadWrite");
                writer.WriteNumberValue(DiskMBpsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskIopsReadOnly))
            {
                writer.WritePropertyName("diskIOPSReadOnly");
                writer.WriteNumberValue(DiskIopsReadOnly.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadOnly))
            {
                writer.WritePropertyName("diskMBpsReadOnly");
                writer.WriteNumberValue(DiskMBpsReadOnly.Value);
            }
            if (Optional.IsDefined(MaxShares))
            {
                writer.WritePropertyName("maxShares");
                writer.WriteNumberValue(MaxShares.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(NetworkAccessPolicy))
            {
                writer.WritePropertyName("networkAccessPolicy");
                writer.WriteStringValue(NetworkAccessPolicy.Value.ToString());
            }
            if (Optional.IsDefined(DiskAccessId))
            {
                writer.WritePropertyName("diskAccessId");
                writer.WriteStringValue(DiskAccessId);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(BurstingEnabled))
            {
                writer.WritePropertyName("burstingEnabled");
                writer.WriteBooleanValue(BurstingEnabled.Value);
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan");
                writer.WriteObjectValue(PurchasePlan);
            }
            if (Optional.IsDefined(SupportedCapabilities))
            {
                writer.WritePropertyName("supportedCapabilities");
                writer.WriteObjectValue(SupportedCapabilities);
            }
            if (Optional.IsDefined(SupportsHibernation))
            {
                writer.WritePropertyName("supportsHibernation");
                writer.WriteBooleanValue(SupportsHibernation.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
