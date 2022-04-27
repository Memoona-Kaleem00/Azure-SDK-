// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class FailoverGroupData : IUtf8JsonSerializable
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ReadWriteEndpoint))
            {
                writer.WritePropertyName("readWriteEndpoint");
                writer.WriteObjectValue(ReadWriteEndpoint);
            }
            if (Optional.IsDefined(ReadOnlyEndpoint))
            {
                writer.WritePropertyName("readOnlyEndpoint");
                writer.WriteObjectValue(ReadOnlyEndpoint);
            }
            if (Optional.IsCollectionDefined(PartnerServers))
            {
                writer.WritePropertyName("partnerServers");
                writer.WriteStartArray();
                foreach (var item in PartnerServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases");
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FailoverGroupData DeserializeFailoverGroupData(JsonElement element)
        {
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<FailoverGroupReadWriteEndpoint> readWriteEndpoint = default;
            Optional<FailoverGroupReadOnlyEndpoint> readOnlyEndpoint = default;
            Optional<FailoverGroupReplicationRole> replicationRole = default;
            Optional<string> replicationState = default;
            Optional<IList<PartnerInfo>> partnerServers = default;
            Optional<IList<string>> databases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("readWriteEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            readWriteEndpoint = FailoverGroupReadWriteEndpoint.DeserializeFailoverGroupReadWriteEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("readOnlyEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            readOnlyEndpoint = FailoverGroupReadOnlyEndpoint.DeserializeFailoverGroupReadOnlyEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicationRole = new FailoverGroupReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicationState"))
                        {
                            replicationState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerServers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PartnerInfo> array = new List<PartnerInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PartnerInfo.DeserializePartnerInfo(item));
                            }
                            partnerServers = array;
                            continue;
                        }
                        if (property0.NameEquals("databases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            databases = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FailoverGroupData(id, name, type, systemData, location.Value, Optional.ToDictionary(tags), readWriteEndpoint.Value, readOnlyEndpoint.Value, Optional.ToNullable(replicationRole), replicationState.Value, Optional.ToList(partnerServers), Optional.ToList(databases));
        }
    }
}
