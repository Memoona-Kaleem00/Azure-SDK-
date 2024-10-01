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
    public partial class UpdateReplicationProtectedItemProperties : IUtf8JsonSerializable, IJsonModel<UpdateReplicationProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateReplicationProtectedItemProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateReplicationProtectedItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RecoveryAzureVmName))
            {
                writer.WritePropertyName("recoveryAzureVMName"u8);
                writer.WriteStringValue(RecoveryAzureVmName);
            }
            if (Optional.IsDefined(RecoveryAzureVmSize))
            {
                writer.WritePropertyName("recoveryAzureVMSize"u8);
                writer.WriteStringValue(RecoveryAzureVmSize);
            }
            if (Optional.IsDefined(SelectedRecoveryAzureNetworkId))
            {
                writer.WritePropertyName("selectedRecoveryAzureNetworkId"u8);
                writer.WriteStringValue(SelectedRecoveryAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedTfoAzureNetworkId))
            {
                writer.WritePropertyName("selectedTfoAzureNetworkId"u8);
                writer.WriteStringValue(SelectedTfoAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedSourceNicId))
            {
                writer.WritePropertyName("selectedSourceNicId"u8);
                writer.WriteStringValue(SelectedSourceNicId);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails, options);
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
        }

        UpdateReplicationProtectedItemProperties IJsonModel<UpdateReplicationProtectedItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateReplicationProtectedItemProperties(document.RootElement, options);
        }

        internal static UpdateReplicationProtectedItemProperties DeserializeUpdateReplicationProtectedItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryAzureVmName = default;
            string recoveryAzureVmSize = default;
            ResourceIdentifier selectedRecoveryAzureNetworkId = default;
            ResourceIdentifier selectedTfoAzureNetworkId = default;
            string selectedSourceNicId = default;
            string enableRdpOnTargetOption = default;
            IList<VmNicContentDetails> vmNics = default;
            SiteRecoveryLicenseType? licenseType = default;
            ResourceIdentifier recoveryAvailabilitySetId = default;
            UpdateReplicationProtectedItemProviderContent providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryAzureVMName"u8))
                {
                    recoveryAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureVMSize"u8))
                {
                    recoveryAzureVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedRecoveryAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedRecoveryAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectedTfoAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedTfoAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectedSourceNicId"u8))
                {
                    selectedSourceNicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmNicContentDetails> array = new List<VmNicContentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicContentDetails.DeserializeVmNicContentDetails(item, options));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = UpdateReplicationProtectedItemProviderContent.DeserializeUpdateReplicationProtectedItemProviderContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateReplicationProtectedItemProperties(
                recoveryAzureVmName,
                recoveryAzureVmSize,
                selectedRecoveryAzureNetworkId,
                selectedTfoAzureNetworkId,
                selectedSourceNicId,
                enableRdpOnTargetOption,
                vmNics ?? new ChangeTrackingList<VmNicContentDetails>(),
                licenseType,
                recoveryAvailabilitySetId,
                providerSpecificDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateReplicationProtectedItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateReplicationProtectedItemProperties IPersistableModel<UpdateReplicationProtectedItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateReplicationProtectedItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateReplicationProtectedItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
