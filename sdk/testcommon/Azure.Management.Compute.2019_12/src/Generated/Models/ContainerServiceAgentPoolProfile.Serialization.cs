// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ContainerServiceAgentPoolProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("count");
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("vmSize");
            writer.WriteStringValue(VmSize.ToString());
            writer.WritePropertyName("dnsPrefix");
            writer.WriteStringValue(DnsPrefix);
            if (Fqdn != null)
            {
                writer.WritePropertyName("fqdn");
                writer.WriteStringValue(Fqdn);
            }
            writer.WriteEndObject();
        }

        internal static ContainerServiceAgentPoolProfile DeserializeContainerServiceAgentPoolProfile(JsonElement element)
        {
            string name = default;
            int count = default;
            ContainerServiceVMSizeTypes vmSize = default;
            string dnsPrefix = default;
            string fqdn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    vmSize = new ContainerServiceVMSizeTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsPrefix"))
                {
                    dnsPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fqdn = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceAgentPoolProfile(name, count, vmSize, dnsPrefix, fqdn);
        }
    }
}
