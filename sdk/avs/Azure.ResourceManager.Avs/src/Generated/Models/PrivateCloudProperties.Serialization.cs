// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class PrivateCloudProperties : IUtf8JsonSerializable, IJsonModel<PrivateCloudProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateCloudProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateCloudProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateCloudProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateCloudProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("managementCluster"u8);
            writer.WriteObjectValue(ManagementCluster, options);
            if (Optional.IsDefined(Internet))
            {
                writer.WritePropertyName("internet"u8);
                writer.WriteStringValue(Internet.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IdentitySources))
            {
                writer.WritePropertyName("identitySources"u8);
                writer.WriteStartArray();
                foreach (var item in IdentitySources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteObjectValue(Availability, options);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (Optional.IsCollectionDefined(ExtendedNetworkBlocks))
            {
                writer.WritePropertyName("extendedNetworkBlocks"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedNetworkBlocks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Circuit))
            {
                writer.WritePropertyName("circuit"u8);
                writer.WriteObjectValue(Circuit, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteObjectValue(Endpoints, options);
            }
            writer.WritePropertyName("networkBlock"u8);
            writer.WriteStringValue(NetworkBlock);
            if (options.Format != "W" && Optional.IsDefined(ManagementNetwork))
            {
                writer.WritePropertyName("managementNetwork"u8);
                writer.WriteStringValue(ManagementNetwork);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningNetwork))
            {
                writer.WritePropertyName("provisioningNetwork"u8);
                writer.WriteStringValue(ProvisioningNetwork);
            }
            if (options.Format != "W" && Optional.IsDefined(VmotionNetwork))
            {
                writer.WritePropertyName("vmotionNetwork"u8);
                writer.WriteStringValue(VmotionNetwork);
            }
            if (Optional.IsDefined(VcenterPassword))
            {
                writer.WritePropertyName("vcenterPassword"u8);
                writer.WriteStringValue(VcenterPassword);
            }
            if (Optional.IsDefined(NsxtPassword))
            {
                writer.WritePropertyName("nsxtPassword"u8);
                writer.WriteStringValue(NsxtPassword);
            }
            if (options.Format != "W" && Optional.IsDefined(VcenterCertificateThumbprint))
            {
                writer.WritePropertyName("vcenterCertificateThumbprint"u8);
                writer.WriteStringValue(VcenterCertificateThumbprint);
            }
            if (options.Format != "W" && Optional.IsDefined(NsxtCertificateThumbprint))
            {
                writer.WritePropertyName("nsxtCertificateThumbprint"u8);
                writer.WriteStringValue(NsxtCertificateThumbprint);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExternalCloudLinks))
            {
                writer.WritePropertyName("externalCloudLinks"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalCloudLinks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SecondaryCircuit))
            {
                writer.WritePropertyName("secondaryCircuit"u8);
                writer.WriteObjectValue(SecondaryCircuit, options);
            }
            if (options.Format != "W" && Optional.IsDefined(NsxPublicIPQuotaRaised))
            {
                writer.WritePropertyName("nsxPublicIpQuotaRaised"u8);
                writer.WriteStringValue(NsxPublicIPQuotaRaised.Value.ToString());
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(DnsZoneType))
            {
                writer.WritePropertyName("dnsZoneType"u8);
                writer.WriteStringValue(DnsZoneType.Value.ToString());
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

        PrivateCloudProperties IJsonModel<PrivateCloudProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateCloudProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateCloudProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateCloudProperties(document.RootElement, options);
        }

        internal static PrivateCloudProperties DeserializePrivateCloudProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvsManagementCluster managementCluster = default;
            InternetConnectivityState? internet = default;
            IList<SingleSignOnIdentitySource> identitySources = default;
            PrivateCloudAvailabilityProperties availability = default;
            CustomerManagedEncryption encryption = default;
            IList<string> extendedNetworkBlocks = default;
            AvsPrivateCloudProvisioningState? provisioningState = default;
            ExpressRouteCircuit circuit = default;
            AvsPrivateCloudEndpoints endpoints = default;
            string networkBlock = default;
            string managementNetwork = default;
            string provisioningNetwork = default;
            string vmotionNetwork = default;
            string vcenterPassword = default;
            string nsxtPassword = default;
            string vcenterCertificateThumbprint = default;
            string nsxtCertificateThumbprint = default;
            IReadOnlyList<string> externalCloudLinks = default;
            ExpressRouteCircuit secondaryCircuit = default;
            NsxPublicIPQuotaRaisedEnum? nsxPublicIPQuotaRaised = default;
            ResourceIdentifier virtualNetworkId = default;
            DnsZoneType? dnsZoneType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managementCluster"u8))
                {
                    managementCluster = AvsManagementCluster.DeserializeAvsManagementCluster(property.Value, options);
                    continue;
                }
                if (property.NameEquals("internet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internet = new InternetConnectivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identitySources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SingleSignOnIdentitySource> array = new List<SingleSignOnIdentitySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SingleSignOnIdentitySource.DeserializeSingleSignOnIdentitySource(item, options));
                    }
                    identitySources = array;
                    continue;
                }
                if (property.NameEquals("availability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availability = PrivateCloudAvailabilityProperties.DeserializePrivateCloudAvailabilityProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = CustomerManagedEncryption.DeserializeCustomerManagedEncryption(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedNetworkBlocks"u8))
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
                    extendedNetworkBlocks = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AvsPrivateCloudProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("circuit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    circuit = ExpressRouteCircuit.DeserializeExpressRouteCircuit(property.Value, options);
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpoints = AvsPrivateCloudEndpoints.DeserializeAvsPrivateCloudEndpoints(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkBlock"u8))
                {
                    networkBlock = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementNetwork"u8))
                {
                    managementNetwork = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningNetwork"u8))
                {
                    provisioningNetwork = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmotionNetwork"u8))
                {
                    vmotionNetwork = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vcenterPassword"u8))
                {
                    vcenterPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nsxtPassword"u8))
                {
                    nsxtPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vcenterCertificateThumbprint"u8))
                {
                    vcenterCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nsxtCertificateThumbprint"u8))
                {
                    nsxtCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalCloudLinks"u8))
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
                    externalCloudLinks = array;
                    continue;
                }
                if (property.NameEquals("secondaryCircuit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryCircuit = ExpressRouteCircuit.DeserializeExpressRouteCircuit(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nsxPublicIpQuotaRaised"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nsxPublicIPQuotaRaised = new NsxPublicIPQuotaRaisedEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsZoneType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsZoneType = new DnsZoneType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateCloudProperties(
                managementCluster,
                internet,
                identitySources ?? new ChangeTrackingList<SingleSignOnIdentitySource>(),
                availability,
                encryption,
                extendedNetworkBlocks ?? new ChangeTrackingList<string>(),
                provisioningState,
                circuit,
                endpoints,
                networkBlock,
                managementNetwork,
                provisioningNetwork,
                vmotionNetwork,
                vcenterPassword,
                nsxtPassword,
                vcenterCertificateThumbprint,
                nsxtCertificateThumbprint,
                externalCloudLinks ?? new ChangeTrackingList<string>(),
                secondaryCircuit,
                nsxPublicIPQuotaRaised,
                virtualNetworkId,
                dnsZoneType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateCloudProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateCloudProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateCloudProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateCloudProperties IPersistableModel<PrivateCloudProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateCloudProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateCloudProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateCloudProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateCloudProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
