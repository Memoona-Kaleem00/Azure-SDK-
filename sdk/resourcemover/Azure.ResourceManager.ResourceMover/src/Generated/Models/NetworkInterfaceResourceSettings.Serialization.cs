// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class NetworkInterfaceResourceSettings : IUtf8JsonSerializable
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
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                if (EnableAcceleratedNetworking != null)
                {
                    writer.WritePropertyName("enableAcceleratedNetworking");
                    writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
                }
                else
                {
                    writer.WriteNull("enableAcceleratedNetworking");
                }
            }
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("targetResourceName");
            writer.WriteStringValue(TargetResourceName);
            writer.WriteEndObject();
        }

        internal static NetworkInterfaceResourceSettings DeserializeNetworkInterfaceResourceSettings(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<NicIPConfigurationResourceSettings>> ipConfigurations = default;
            Optional<bool?> enableAcceleratedNetworking = default;
            string resourceType = default;
            string targetResourceName = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("ipConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NicIPConfigurationResourceSettings> array = new List<NicIPConfigurationResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicIPConfigurationResourceSettings.DeserializeNicIPConfigurationResourceSettings(item));
                    }
                    ipConfigurations = array;
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworking"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableAcceleratedNetworking = null;
                        continue;
                    }
                    enableAcceleratedNetworking = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkInterfaceResourceSettings(resourceType, targetResourceName, Optional.ToDictionary(tags), Optional.ToList(ipConfigurations), Optional.ToNullable(enableAcceleratedNetworking));
        }
    }
}
