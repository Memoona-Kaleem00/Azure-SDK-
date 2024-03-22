// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmNicContentDetails : IUtf8JsonSerializable, IJsonModel<VmNicContentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmNicContentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmNicContentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicContentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmNicContentDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
            }
            if (Optional.IsCollectionDefined(IPConfigs))
            {
                writer.WritePropertyName("ipConfigs"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigs)
                {
                    writer.WriteObjectValue<HyperVFailoverIPConfigDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SelectionType))
            {
                writer.WritePropertyName("selectionType"u8);
                writer.WriteStringValue(SelectionType);
            }
            if (Optional.IsDefined(RecoveryNetworkSecurityGroupId))
            {
                writer.WritePropertyName("recoveryNetworkSecurityGroupId"u8);
                writer.WriteStringValue(RecoveryNetworkSecurityGroupId);
            }
            if (Optional.IsDefined(IsAcceleratedNetworkingOnRecoveryEnabled))
            {
                writer.WritePropertyName("enableAcceleratedNetworkingOnRecovery"u8);
                writer.WriteBooleanValue(IsAcceleratedNetworkingOnRecoveryEnabled.Value);
            }
            if (Optional.IsDefined(TfoNetworkSecurityGroupId))
            {
                writer.WritePropertyName("tfoNetworkSecurityGroupId"u8);
                writer.WriteStringValue(TfoNetworkSecurityGroupId);
            }
            if (Optional.IsDefined(IsAcceleratedNetworkingOnTfoEnabled))
            {
                writer.WritePropertyName("enableAcceleratedNetworkingOnTfo"u8);
                writer.WriteBooleanValue(IsAcceleratedNetworkingOnTfoEnabled.Value);
            }
            if (Optional.IsDefined(RecoveryNicName))
            {
                writer.WritePropertyName("recoveryNicName"u8);
                writer.WriteStringValue(RecoveryNicName);
            }
            if (Optional.IsDefined(RecoveryNicResourceGroupName))
            {
                writer.WritePropertyName("recoveryNicResourceGroupName"u8);
                writer.WriteStringValue(RecoveryNicResourceGroupName);
            }
            if (Optional.IsDefined(IsReuseExistingNicAllowed))
            {
                writer.WritePropertyName("reuseExistingNic"u8);
                writer.WriteBooleanValue(IsReuseExistingNicAllowed.Value);
            }
            if (Optional.IsDefined(TfoNicName))
            {
                writer.WritePropertyName("tfoNicName"u8);
                writer.WriteStringValue(TfoNicName);
            }
            if (Optional.IsDefined(TfoNicResourceGroupName))
            {
                writer.WritePropertyName("tfoNicResourceGroupName"u8);
                writer.WriteStringValue(TfoNicResourceGroupName);
            }
            if (Optional.IsDefined(IsTfoReuseExistingNicAllowed))
            {
                writer.WritePropertyName("tfoReuseExistingNic"u8);
                writer.WriteBooleanValue(IsTfoReuseExistingNicAllowed.Value);
            }
            if (Optional.IsDefined(TargetNicName))
            {
                writer.WritePropertyName("targetNicName"u8);
                writer.WriteStringValue(TargetNicName);
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

        VmNicContentDetails IJsonModel<VmNicContentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicContentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmNicContentDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmNicContentDetails(document.RootElement, options);
        }

        internal static VmNicContentDetails DeserializeVmNicContentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            IList<HyperVFailoverIPConfigDetails> ipConfigs = default;
            string selectionType = default;
            string recoveryNetworkSecurityGroupId = default;
            bool? enableAcceleratedNetworkingOnRecovery = default;
            string tfoNetworkSecurityGroupId = default;
            bool? enableAcceleratedNetworkingOnTfo = default;
            string recoveryNicName = default;
            string recoveryNicResourceGroupName = default;
            bool? reuseExistingNic = default;
            string tfoNicName = default;
            string tfoNicResourceGroupName = default;
            bool? tfoReuseExistingNic = default;
            string targetNicName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipConfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVFailoverIPConfigDetails> array = new List<HyperVFailoverIPConfigDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVFailoverIPConfigDetails.DeserializeHyperVFailoverIPConfigDetails(item, options));
                    }
                    ipConfigs = array;
                    continue;
                }
                if (property.NameEquals("selectionType"u8))
                {
                    selectionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkSecurityGroupId"u8))
                {
                    recoveryNetworkSecurityGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworkingOnRecovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAcceleratedNetworkingOnRecovery = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tfoNetworkSecurityGroupId"u8))
                {
                    tfoNetworkSecurityGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworkingOnTfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAcceleratedNetworkingOnTfo = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoveryNicName"u8))
                {
                    recoveryNicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNicResourceGroupName"u8))
                {
                    recoveryNicResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reuseExistingNic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reuseExistingNic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tfoNicName"u8))
                {
                    tfoNicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoNicResourceGroupName"u8))
                {
                    tfoNicResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoReuseExistingNic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoReuseExistingNic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetNicName"u8))
                {
                    targetNicName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmNicContentDetails(
                nicId,
                ipConfigs ?? new ChangeTrackingList<HyperVFailoverIPConfigDetails>(),
                selectionType,
                recoveryNetworkSecurityGroupId,
                enableAcceleratedNetworkingOnRecovery,
                tfoNetworkSecurityGroupId,
                enableAcceleratedNetworkingOnTfo,
                recoveryNicName,
                recoveryNicResourceGroupName,
                reuseExistingNic,
                tfoNicName,
                tfoNicResourceGroupName,
                tfoReuseExistingNic,
                targetNicName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmNicContentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicContentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmNicContentDetails)} does not support writing '{options.Format}' format.");
            }
        }

        VmNicContentDetails IPersistableModel<VmNicContentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicContentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmNicContentDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmNicContentDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmNicContentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
