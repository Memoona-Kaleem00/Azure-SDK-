// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class AvsPrivateCloudData : IUtf8JsonSerializable, IJsonModel<AvsPrivateCloudData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsPrivateCloudData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvsPrivateCloudData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ManagementCluster != null)
            {
                writer.WritePropertyName("managementCluster"u8);
                writer.WriteObjectValue(ManagementCluster);
            }
            if (Internet.HasValue)
            {
                writer.WritePropertyName("internet"u8);
                writer.WriteStringValue(Internet.Value.ToString());
            }
            if (!(IdentitySources is ChangeTrackingList<SingleSignOnIdentitySource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("identitySources"u8);
                writer.WriteStartArray();
                foreach (var item in IdentitySources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Availability != null)
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteObjectValue(Availability);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (!(ExtendedNetworkBlocks is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("extendedNetworkBlocks"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedNetworkBlocks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Circuit != null)
            {
                writer.WritePropertyName("circuit"u8);
                writer.WriteObjectValue(Circuit);
            }
            if (options.Format != "W" && Endpoints != null)
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteObjectValue(Endpoints);
            }
            if (NetworkBlock != null)
            {
                writer.WritePropertyName("networkBlock"u8);
                writer.WriteStringValue(NetworkBlock);
            }
            if (options.Format != "W" && ManagementNetwork != null)
            {
                writer.WritePropertyName("managementNetwork"u8);
                writer.WriteStringValue(ManagementNetwork);
            }
            if (options.Format != "W" && ProvisioningNetwork != null)
            {
                writer.WritePropertyName("provisioningNetwork"u8);
                writer.WriteStringValue(ProvisioningNetwork);
            }
            if (options.Format != "W" && VMotionNetwork != null)
            {
                writer.WritePropertyName("vmotionNetwork"u8);
                writer.WriteStringValue(VMotionNetwork);
            }
            if (VCenterPassword != null)
            {
                writer.WritePropertyName("vcenterPassword"u8);
                writer.WriteStringValue(VCenterPassword);
            }
            if (NsxtPassword != null)
            {
                writer.WritePropertyName("nsxtPassword"u8);
                writer.WriteStringValue(NsxtPassword);
            }
            if (options.Format != "W" && VCenterCertificateThumbprint != null)
            {
                writer.WritePropertyName("vcenterCertificateThumbprint"u8);
                writer.WriteStringValue(VCenterCertificateThumbprint);
            }
            if (options.Format != "W" && NsxtCertificateThumbprint != null)
            {
                writer.WritePropertyName("nsxtCertificateThumbprint"u8);
                writer.WriteStringValue(NsxtCertificateThumbprint);
            }
            if (options.Format != "W" && !(ExternalCloudLinks is ChangeTrackingList<ResourceIdentifier> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("externalCloudLinks"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalCloudLinks)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SecondaryCircuit != null)
            {
                writer.WritePropertyName("secondaryCircuit"u8);
                writer.WriteObjectValue(SecondaryCircuit);
            }
            if (options.Format != "W" && NsxPublicIPQuotaRaised.HasValue)
            {
                writer.WritePropertyName("nsxPublicIpQuotaRaised"u8);
                writer.WriteStringValue(NsxPublicIPQuotaRaised.Value.ToString());
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

        AvsPrivateCloudData IJsonModel<AvsPrivateCloudData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsPrivateCloudData(document.RootElement, options);
        }

        internal static AvsPrivateCloudData DeserializeAvsPrivateCloudData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvsSku sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AvsManagementCluster> managementCluster = default;
            Optional<InternetConnectivityState> internet = default;
            IList<SingleSignOnIdentitySource> identitySources = default;
            Optional<PrivateCloudAvailabilityProperties> availability = default;
            Optional<CustomerManagedEncryption> encryption = default;
            IList<string> extendedNetworkBlocks = default;
            Optional<AvsPrivateCloudProvisioningState> provisioningState = default;
            Optional<ExpressRouteCircuit> circuit = default;
            Optional<AvsPrivateCloudEndpoints> endpoints = default;
            Optional<string> networkBlock = default;
            Optional<string> managementNetwork = default;
            Optional<string> provisioningNetwork = default;
            Optional<string> vmotionNetwork = default;
            Optional<string> vcenterPassword = default;
            Optional<string> nsxtPassword = default;
            Optional<string> vcenterCertificateThumbprint = default;
            Optional<string> nsxtCertificateThumbprint = default;
            IReadOnlyList<ResourceIdentifier> externalCloudLinks = default;
            Optional<ExpressRouteCircuit> secondaryCircuit = default;
            Optional<NsxPublicIPQuotaRaisedEnum> nsxPublicIPQuotaRaised = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AvsSku.DeserializeAvsSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("managementCluster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementCluster = AvsManagementCluster.DeserializeAvsManagementCluster(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("internet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internet = new InternetConnectivityState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("identitySources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SingleSignOnIdentitySource> array = new List<SingleSignOnIdentitySource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SingleSignOnIdentitySource.DeserializeSingleSignOnIdentitySource(item, options));
                            }
                            identitySources = array;
                            continue;
                        }
                        if (property0.NameEquals("availability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availability = PrivateCloudAvailabilityProperties.DeserializePrivateCloudAvailabilityProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = CustomerManagedEncryption.DeserializeCustomerManagedEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("extendedNetworkBlocks"u8))
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
                            extendedNetworkBlocks = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AvsPrivateCloudProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("circuit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuit = ExpressRouteCircuit.DeserializeExpressRouteCircuit(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("endpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpoints = AvsPrivateCloudEndpoints.DeserializeAvsPrivateCloudEndpoints(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkBlock"u8))
                        {
                            networkBlock = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managementNetwork"u8))
                        {
                            managementNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningNetwork"u8))
                        {
                            provisioningNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmotionNetwork"u8))
                        {
                            vmotionNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vcenterPassword"u8))
                        {
                            vcenterPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nsxtPassword"u8))
                        {
                            nsxtPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vcenterCertificateThumbprint"u8))
                        {
                            vcenterCertificateThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nsxtCertificateThumbprint"u8))
                        {
                            nsxtCertificateThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("externalCloudLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            externalCloudLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("secondaryCircuit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryCircuit = ExpressRouteCircuit.DeserializeExpressRouteCircuit(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("nsxPublicIpQuotaRaised"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nsxPublicIPQuotaRaised = new NsxPublicIPQuotaRaisedEnum(property0.Value.GetString());
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
            return new AvsPrivateCloudData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, identity, managementCluster.Value, Optional.ToNullable(internet), identitySources ?? new ChangeTrackingList<SingleSignOnIdentitySource>(), availability.Value, encryption.Value, extendedNetworkBlocks ?? new ChangeTrackingList<string>(), Optional.ToNullable(provisioningState), circuit.Value, endpoints.Value, networkBlock.Value, managementNetwork.Value, provisioningNetwork.Value, vmotionNetwork.Value, vcenterPassword.Value, nsxtPassword.Value, vcenterCertificateThumbprint.Value, nsxtCertificateThumbprint.Value, externalCloudLinks ?? new ChangeTrackingList<ResourceIdentifier>(), secondaryCircuit.Value, Optional.ToNullable(nsxPublicIPQuotaRaised), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsPrivateCloudData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudData)} does not support '{options.Format}' format.");
            }
        }

        AvsPrivateCloudData IPersistableModel<AvsPrivateCloudData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsPrivateCloudData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsPrivateCloudData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
