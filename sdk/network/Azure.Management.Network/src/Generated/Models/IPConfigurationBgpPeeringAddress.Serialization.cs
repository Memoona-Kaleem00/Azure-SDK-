// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class IPConfigurationBgpPeeringAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (IpconfigurationId != null)
            {
                writer.WritePropertyName("ipconfigurationId");
                writer.WriteStringValue(IpconfigurationId);
            }
            if (DefaultBgpIpAddresses != null)
            {
                writer.WritePropertyName("defaultBgpIpAddresses");
                writer.WriteStartArray();
                foreach (var item in DefaultBgpIpAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (CustomBgpIpAddresses != null)
            {
                writer.WritePropertyName("customBgpIpAddresses");
                writer.WriteStartArray();
                foreach (var item in CustomBgpIpAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (TunnelIpAddresses != null)
            {
                writer.WritePropertyName("tunnelIpAddresses");
                writer.WriteStartArray();
                foreach (var item in TunnelIpAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IPConfigurationBgpPeeringAddress DeserializeIPConfigurationBgpPeeringAddress(JsonElement element)
        {
            string ipconfigurationId = default;
            IList<string> defaultBgpIpAddresses = default;
            IList<string> customBgpIpAddresses = default;
            IList<string> tunnelIpAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipconfigurationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipconfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultBgpIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    defaultBgpIpAddresses = array;
                    continue;
                }
                if (property.NameEquals("customBgpIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    customBgpIpAddresses = array;
                    continue;
                }
                if (property.NameEquals("tunnelIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    tunnelIpAddresses = array;
                    continue;
                }
            }
            return new IPConfigurationBgpPeeringAddress(ipconfigurationId, defaultBgpIpAddresses, customBgpIpAddresses, tunnelIpAddresses);
        }
    }
}
