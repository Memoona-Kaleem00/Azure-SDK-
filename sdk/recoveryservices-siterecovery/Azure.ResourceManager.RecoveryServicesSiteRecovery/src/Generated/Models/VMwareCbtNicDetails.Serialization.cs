// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtNicDetails : IUtf8JsonSerializable, IJsonModel<VMwareCbtNicDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtNicDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtNicDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtNicDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
            }
            if (Optional.IsDefined(IsPrimaryNic))
            {
                writer.WritePropertyName("isPrimaryNic"u8);
                writer.WriteStringValue(IsPrimaryNic);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceIPAddress))
            {
                writer.WritePropertyName("sourceIPAddress"u8);
                writer.WriteStringValue(SourceIPAddress.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SourceIPAddressType))
            {
                writer.WritePropertyName("sourceIPAddressType"u8);
                writer.WriteStringValue(SourceIPAddressType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SourceNetworkId))
            {
                writer.WritePropertyName("sourceNetworkId"u8);
                writer.WriteStringValue(SourceNetworkId);
            }
            if (Optional.IsDefined(TargetIPAddress))
            {
                writer.WritePropertyName("targetIPAddress"u8);
                writer.WriteStringValue(TargetIPAddress.ToString());
            }
            if (Optional.IsDefined(TargetIPAddressType))
            {
                writer.WritePropertyName("targetIPAddressType"u8);
                writer.WriteStringValue(TargetIPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(TargetSubnetName))
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsDefined(TestSubnetName))
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (Optional.IsDefined(TestIPAddress))
            {
                writer.WritePropertyName("testIPAddress"u8);
                writer.WriteStringValue(TestIPAddress.ToString());
            }
            if (Optional.IsDefined(TestIPAddressType))
            {
                writer.WritePropertyName("testIPAddressType"u8);
                writer.WriteStringValue(TestIPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(TargetNicName))
            {
                writer.WritePropertyName("targetNicName"u8);
                writer.WriteStringValue(TargetNicName);
            }
            if (Optional.IsDefined(IsSelectedForMigration))
            {
                writer.WritePropertyName("isSelectedForMigration"u8);
                writer.WriteStringValue(IsSelectedForMigration);
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

        VMwareCbtNicDetails IJsonModel<VMwareCbtNicDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtNicDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtNicDetails(document.RootElement, options);
        }

        internal static VMwareCbtNicDetails DeserializeVMwareCbtNicDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string isPrimaryNic = default;
            IPAddress sourceIPAddress = default;
            SiteRecoveryEthernetAddressType? sourceIPAddressType = default;
            ResourceIdentifier sourceNetworkId = default;
            IPAddress targetIPAddress = default;
            SiteRecoveryEthernetAddressType? targetIPAddressType = default;
            string targetSubnetName = default;
            ResourceIdentifier testNetworkId = default;
            string testSubnetName = default;
            IPAddress testIPAddress = default;
            SiteRecoveryEthernetAddressType? testIPAddressType = default;
            string targetNicName = default;
            string isSelectedForMigration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimaryNic"u8))
                {
                    isPrimaryNic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetNicName"u8))
                {
                    targetNicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSelectedForMigration"u8))
                {
                    isSelectedForMigration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtNicDetails(
                nicId,
                isPrimaryNic,
                sourceIPAddress,
                sourceIPAddressType,
                sourceNetworkId,
                targetIPAddress,
                targetIPAddressType,
                targetSubnetName,
                testNetworkId,
                testSubnetName,
                testIPAddress,
                testIPAddressType,
                targetNicName,
                isSelectedForMigration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareCbtNicDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtNicDetails)} does not support '{options.Format}' format.");
            }
        }

        VMwareCbtNicDetails IPersistableModel<VMwareCbtNicDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtNicDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtNicDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtNicDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
