// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class CustomIPPrefixData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Core.Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Asn))
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteStringValue(Asn);
            }
            if (Core.Optional.IsDefined(Cidr))
            {
                writer.WritePropertyName("cidr"u8);
                writer.WriteStringValue(Cidr);
            }
            if (Core.Optional.IsDefined(SignedMessage))
            {
                writer.WritePropertyName("signedMessage"u8);
                writer.WriteStringValue(SignedMessage);
            }
            if (Core.Optional.IsDefined(AuthorizationMessage))
            {
                writer.WritePropertyName("authorizationMessage"u8);
                writer.WriteStringValue(AuthorizationMessage);
            }
            if (Core.Optional.IsDefined(ParentCustomIPPrefix))
            {
                writer.WritePropertyName("customIpPrefixParent"u8);
                JsonSerializer.Serialize(writer, ParentCustomIPPrefix);
            }
            if (Core.Optional.IsDefined(CommissionedState))
            {
                writer.WritePropertyName("commissionedState"u8);
                writer.WriteStringValue(CommissionedState.Value.ToString());
            }
            if (Core.Optional.IsDefined(ExpressRouteAdvertise))
            {
                writer.WritePropertyName("expressRouteAdvertise"u8);
                writer.WriteBooleanValue(ExpressRouteAdvertise.Value);
            }
            if (Core.Optional.IsDefined(Geo))
            {
                writer.WritePropertyName("geo"u8);
                writer.WriteStringValue(Geo.Value.ToString());
            }
            if (Core.Optional.IsDefined(NoInternetAdvertise))
            {
                writer.WritePropertyName("noInternetAdvertise"u8);
                writer.WriteBooleanValue(NoInternetAdvertise.Value);
            }
            if (Core.Optional.IsDefined(PrefixType))
            {
                writer.WritePropertyName("prefixType"u8);
                writer.WriteStringValue(PrefixType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomIPPrefixData DeserializeCustomIPPrefixData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ExtendedLocation> extendedLocation = default;
            Core.Optional<ETag> etag = default;
            Core.Optional<IList<string>> zones = default;
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<ResourceType> type = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            Core.Optional<string> asn = default;
            Core.Optional<string> cidr = default;
            Core.Optional<string> signedMessage = default;
            Core.Optional<string> authorizationMessage = default;
            Core.Optional<WritableSubResource> customIPPrefixParent = default;
            Core.Optional<IReadOnlyList<WritableSubResource>> childCustomIPPrefixes = default;
            Core.Optional<CommissionedState> commissionedState = default;
            Core.Optional<bool> expressRouteAdvertise = default;
            Core.Optional<CidrAdvertisingGeoCode> geo = default;
            Core.Optional<bool> noInternetAdvertise = default;
            Core.Optional<CustomIPPrefixType> prefixType = default;
            Core.Optional<IReadOnlyList<WritableSubResource>> publicIPPrefixes = default;
            Core.Optional<Guid> resourceGuid = default;
            Core.Optional<string> failedReason = default;
            Core.Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("asn"u8))
                        {
                            asn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cidr"u8))
                        {
                            cidr = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signedMessage"u8))
                        {
                            signedMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationMessage"u8))
                        {
                            authorizationMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customIpPrefixParent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customIPPrefixParent = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("childCustomIpPrefixes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            childCustomIPPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("commissionedState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commissionedState = new CommissionedState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteAdvertise"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteAdvertise = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("geo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            geo = new CidrAdvertisingGeoCode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("noInternetAdvertise"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            noInternetAdvertise = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("prefixType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            prefixType = new CustomIPPrefixType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicIpPrefixes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            publicIPPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("failedReason"u8))
                        {
                            failedReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomIPPrefixData(id.Value, name.Value, Core.Optional.ToNullable(type), Core.Optional.ToNullable(location), Core.Optional.ToDictionary(tags), extendedLocation, Core.Optional.ToNullable(etag), Core.Optional.ToList(zones), asn.Value, cidr.Value, signedMessage.Value, authorizationMessage.Value, customIPPrefixParent, Core.Optional.ToList(childCustomIPPrefixes), Core.Optional.ToNullable(commissionedState), Core.Optional.ToNullable(expressRouteAdvertise), Core.Optional.ToNullable(geo), Core.Optional.ToNullable(noInternetAdvertise), Core.Optional.ToNullable(prefixType), Core.Optional.ToList(publicIPPrefixes), Core.Optional.ToNullable(resourceGuid), failedReason.Value, Core.Optional.ToNullable(provisioningState));
        }
    }
}
