// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayBackendHttpSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(CookieBasedAffinity))
            {
                writer.WritePropertyName("cookieBasedAffinity");
                writer.WriteStringValue(CookieBasedAffinity.Value.ToString());
            }
            if (Optional.IsDefined(RequestTimeout))
            {
                writer.WritePropertyName("requestTimeout");
                writer.WriteNumberValue(RequestTimeout.Value);
            }
            if (Optional.IsDefined(Probe))
            {
                writer.WritePropertyName("probe");
                writer.WriteObjectValue(Probe);
            }
            if (Optional.IsCollectionDefined(AuthenticationCertificates))
            {
                writer.WritePropertyName("authenticationCertificates");
                writer.WriteStartArray();
                foreach (var item in AuthenticationCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrustedRootCertificates))
            {
                writer.WritePropertyName("trustedRootCertificates");
                writer.WriteStartArray();
                foreach (var item in TrustedRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConnectionDraining))
            {
                writer.WritePropertyName("connectionDraining");
                writer.WriteObjectValue(ConnectionDraining);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(PickHostNameFromBackendAddress))
            {
                writer.WritePropertyName("pickHostNameFromBackendAddress");
                writer.WriteBooleanValue(PickHostNameFromBackendAddress.Value);
            }
            if (Optional.IsDefined(AffinityCookieName))
            {
                writer.WritePropertyName("affinityCookieName");
                writer.WriteStringValue(AffinityCookieName);
            }
            if (Optional.IsDefined(ProbeEnabled))
            {
                writer.WritePropertyName("probeEnabled");
                writer.WriteBooleanValue(ProbeEnabled.Value);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayBackendHttpSettings DeserializeApplicationGatewayBackendHttpSettings(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<int> port = default;
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<ApplicationGatewayCookieBasedAffinity> cookieBasedAffinity = default;
            Optional<int> requestTimeout = default;
            Optional<SubResource> probe = default;
            Optional<IList<SubResource>> authenticationCertificates = default;
            Optional<IList<SubResource>> trustedRootCertificates = default;
            Optional<ApplicationGatewayConnectionDraining> connectionDraining = default;
            Optional<string> hostName = default;
            Optional<bool> pickHostNameFromBackendAddress = default;
            Optional<string> affinityCookieName = default;
            Optional<bool> probeEnabled = default;
            Optional<string> path = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cookieBasedAffinity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cookieBasedAffinity = new ApplicationGatewayCookieBasedAffinity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestTimeout"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requestTimeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("probe"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            probe = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authenticationCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            authenticationCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("trustedRootCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            trustedRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("connectionDraining"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionDraining = ApplicationGatewayConnectionDraining.DeserializeApplicationGatewayConnectionDraining(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            pickHostNameFromBackendAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("affinityCookieName"))
                        {
                            affinityCookieName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("probeEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            probeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("path"))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayBackendHttpSettings(id.Value, name.Value, etag.Value, type.Value, Optional.ToNullable(port), Optional.ToNullable(protocol), Optional.ToNullable(cookieBasedAffinity), Optional.ToNullable(requestTimeout), probe.Value, Optional.ToList(authenticationCertificates), Optional.ToList(trustedRootCertificates), connectionDraining.Value, hostName.Value, Optional.ToNullable(pickHostNameFromBackendAddress), affinityCookieName.Value, Optional.ToNullable(probeEnabled), path.Value, Optional.ToNullable(provisioningState));
        }
    }
}
