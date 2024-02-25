// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServerPatch : IUtf8JsonSerializable, IJsonModel<SqlServerPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (AdministratorLogin != null)
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (AdministratorLoginPassword != null)
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && State != null)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && FullyQualifiedDomainName != null)
            {
                writer.WritePropertyName("fullyQualifiedDomainName"u8);
                writer.WriteStringValue(FullyQualifiedDomainName);
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<SqlServerPrivateEndpointConnection> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (MinTlsVersion.HasValue)
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinTlsVersion.Value.ToString());
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (options.Format != "W" && WorkspaceFeature.HasValue)
            {
                writer.WritePropertyName("workspaceFeature"u8);
                writer.WriteStringValue(WorkspaceFeature.Value.ToString());
            }
            if (PrimaryUserAssignedIdentityId != null)
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (FederatedClientId.HasValue)
            {
                writer.WritePropertyName("federatedClientId"u8);
                writer.WriteStringValue(FederatedClientId.Value);
            }
            if (KeyId != null)
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            if (Administrators != null)
            {
                writer.WritePropertyName("administrators"u8);
                writer.WriteObjectValue(Administrators);
            }
            if (RestrictOutboundNetworkAccess.HasValue)
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteStringValue(RestrictOutboundNetworkAccess.Value.ToString());
            }
            if (IsIPv6Enabled.HasValue)
            {
                writer.WritePropertyName("isIPv6Enabled"u8);
                writer.WriteStringValue(IsIPv6Enabled.Value.ToString());
            }
            if (options.Format != "W" && ExternalGovernanceStatus.HasValue)
            {
                writer.WritePropertyName("externalGovernanceStatus"u8);
                writer.WriteStringValue(ExternalGovernanceStatus.Value.ToString());
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

        SqlServerPatch IJsonModel<SqlServerPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerPatch(document.RootElement, options);
        }

        internal static SqlServerPatch DeserializeSqlServerPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            Optional<string> administratorLogin = default;
            Optional<string> administratorLoginPassword = default;
            Optional<string> version = default;
            Optional<string> state = default;
            Optional<string> fullyQualifiedDomainName = default;
            IReadOnlyList<SqlServerPrivateEndpointConnection> privateEndpointConnections = default;
            Optional<SqlMinimalTlsVersion> minimalTlsVersion = default;
            Optional<ServerNetworkAccessFlag> publicNetworkAccess = default;
            Optional<ServerWorkspaceFeature> workspaceFeature = default;
            Optional<ResourceIdentifier> primaryUserAssignedIdentityId = default;
            Optional<Guid> federatedClientId = default;
            Optional<Uri> keyId = default;
            Optional<ServerExternalAdministrator> administrators = default;
            Optional<ServerNetworkAccessFlag> restrictOutboundNetworkAccess = default;
            Optional<ServerNetworkAccessFlag> isIPv6Enabled = default;
            Optional<ExternalGovernanceStatus> externalGovernanceStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
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
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"u8))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SqlServerPrivateEndpointConnection> array = new List<SqlServerPrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SqlServerPrivateEndpointConnection.DeserializeSqlServerPrivateEndpointConnection(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimalTlsVersion = new SqlMinimalTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new ServerNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("workspaceFeature"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceFeature = new ServerWorkspaceFeature(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentityId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryUserAssignedIdentityId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("federatedClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            federatedClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("keyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyId = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrators"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrators = ServerExternalAdministrator.DeserializeServerExternalAdministrator(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("restrictOutboundNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restrictOutboundNetworkAccess = new ServerNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isIPv6Enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isIPv6Enabled = new ServerNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externalGovernanceStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            externalGovernanceStatus = new ExternalGovernanceStatus(property0.Value.GetString());
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
            return new SqlServerPatch(identity, tags ?? new ChangeTrackingDictionary<string, string>(), administratorLogin.Value, administratorLoginPassword.Value, version.Value, state.Value, fullyQualifiedDomainName.Value, privateEndpointConnections ?? new ChangeTrackingList<SqlServerPrivateEndpointConnection>(), Optional.ToNullable(minimalTlsVersion), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(workspaceFeature), primaryUserAssignedIdentityId.Value, Optional.ToNullable(federatedClientId), keyId.Value, administrators.Value, Optional.ToNullable(restrictOutboundNetworkAccess), Optional.ToNullable(isIPv6Enabled), Optional.ToNullable(externalGovernanceStatus), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerPatch)} does not support '{options.Format}' format.");
            }
        }

        SqlServerPatch IPersistableModel<SqlServerPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
